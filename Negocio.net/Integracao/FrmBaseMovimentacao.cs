using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraNavBar;
using Negocio.Net.Dominio;
using Negocio.Net.Dominio.Entidades;
using Negocio.Net.Edicao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Validation;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio.Net.Integracao
{
    partial class FrmBaseMovimentacao : FrmBase
    {
        public Modulo Modulo { get; set; }

        /// <summary>
        /// Fonte de Dados 
        /// </summary>
        protected BindingSource Dados = new BindingSource();

        /// <summary>
        /// Arquivo Xml contendo a configuração da Grid
        /// </summary>
        protected String XmlGrid;

        /// <summary>
        /// Campos [Properties] disponiveis no objeto da grid
        /// </summary>
        protected IEnumerable<Campo> Campos;

        /// <summary>
        /// Type responsável pelos dados
        /// </summary>
        protected Type TypeDados;

        /// <summary>
        /// Type responsável pelo formulário de edição
        /// </summary>
        protected Type TypeEdicao;

        /// <summary>
        /// Filtro para ser aplicado dentro do Type
        /// </summary>
        protected string FiltroParaAplicar;

        private string filtroPersonalizado;

        private int UltimaSelecao;
        /// <summary>
        /// Construtor da Classe
        /// </summary>
        public FrmBaseMovimentacao()
        {
            InitializeComponent();
            gridControl.EmbeddedNavigator.Buttons.First.Visible = true;

            grid.OptionsBehavior.Editable = false;
            grid.DoubleClick += grid_DoubleClick;

            labelFiltrosPersonalizados.Text = Properties.Resources.LabelFiltrosPersonalizados;
            atualizarDados.WorkerReportsProgress = true;
            atualizarDados.ProgressChanged += new ProgressChangedEventHandler(atualizarDados_ProgressChanged);
            atualizarDados.RunWorkerCompleted += new RunWorkerCompletedEventHandler(atualizarDados_RunWorkerCompleted);
            atualizarDados.DoWork += new DoWorkEventHandler(atualizarDados_DoWork);
        }

        /// <summary>
        /// Exibe a Barra de Progresso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void atualizarDados_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (1 == e.ProgressPercentage)
            {
                this.Dados = new BindingSource();
                this.UseWaitCursor = true;
                this.Enabled = false;
                this.progresso.Visible = true;
                PosicionaProgresso();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void atualizarDados_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                this.progresso.Visible = false;
                this.Enabled = true;
                this.UseWaitCursor = false;
                gridControl.DataSource = Dados;
                grid.FocusedRowHandle = UltimaSelecao;
                
                if (null == filtroControl1.Campos)
                {
                    if (!String.IsNullOrEmpty(XmlGrid))
                    {
                        var StreamXmlGrid = new System.IO.MemoryStream(System.Text.Encoding.UTF8.GetBytes(XmlGrid));
                        grid.RestoreLayoutFromStream(StreamXmlGrid);
                        StreamXmlGrid.Dispose();
                    }

                    Campos = Funcoes.AtributosDaClasse(TypeDados);
                    filtroControl1.Campos = Campos;

                    // Navegando entre as colunas da grid para popular suas configurações
                    foreach (DevExpress.XtraGrid.Columns.GridColumn coluna in grid.Columns)
                    {
                        Campo Campo = Campos.Where(x => x.FieldName == coluna.FieldName).FirstOrDefault();
                        if (null != Campo)
                        {
                            coluna.Caption = Campo.Caption;

                            // Carregando a Visibilidade do dominio caso não esteja definido no perfil salvo
                            if (String.IsNullOrEmpty(XmlGrid))
                                coluna.Visible = Campo.Visible;

                            coluna.OptionsColumn.ShowInCustomizationForm = (Campo.Visible == true ? Campo.Visible : Campo.ExibirNoCustomizador);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Funcoes.ExibirExcessao(ex);
            }
        }

        /// <summary>
        /// Consulta em Thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void atualizarDados_DoWork(object sender, DoWorkEventArgs e)
        {
            atualizarDados.ReportProgress(1);
            RecuperaXmlGrid();
            Consultar();
        }

        /// <summary>
        /// Execução Assincrona da Consulta com o Banco de Dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmBaseMovimentacao_Shown(object sender, EventArgs e)
        {
            atualizarDados.RunWorkerAsync();
            grid.OptionsBehavior.Editable = false;
            grid.OptionsSelection.EnableAppearanceFocusedCell = false;
            grid.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
        }

        /// <summary>
        /// Atualiza o posicionamento da barra de progresso ao redimensionar o programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmBaseMovimentacao_Resize(object sender, EventArgs e)
        {
            PosicionaProgresso();
        }

        /// <summary>
        /// Mapeamento de Teclas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmBaseMovimentacao_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2: { NavBar_LinkClicked(btnInserir, new DevExpress.XtraNavBar.NavBarLinkEventArgs(new NavBarItemLink(btnInserir))); break; }
                case Keys.F3: { NavBar_LinkClicked(btnEditar, new DevExpress.XtraNavBar.NavBarLinkEventArgs(new NavBarItemLink(btnEditar))); break; }
                case Keys.F4: { NavBar_LinkClicked(btnRemover, new DevExpress.XtraNavBar.NavBarLinkEventArgs(new NavBarItemLink(btnRemover))); break; }
                case Keys.F5: { NavBar_LinkClicked(btnVisualizar, new DevExpress.XtraNavBar.NavBarLinkEventArgs(new NavBarItemLink(btnVisualizar))); break; }
            }
        }

        /// <summary>
        /// Posiciona a Barra de Progresso no Centro do Monitor
        /// </summary>
        private void PosicionaProgresso()
        {
            var point = new Point(((this.Width / 2) - progresso.Width - (progresso.Width / 3)), (this.Height / 2) - progresso.Height);
            this.progresso.Location = point;
        }

        /// <summary>
        /// Recupera o Layout da Grid no Banco de Dados
        /// </summary>
        /// <param name="Contexto"></param>
        internal void RecuperaXmlGrid()
        {
            if ((null == XmlGrid))
            {
                using (UsuarioDataSet dataset = new UsuarioDataSet())
                {
                    UsuarioGrid usuarioGrid = dataset.LocalizaLayoutFormulario(Sistema.Usuario.COD, Sistema.Empresa.COD, this.Modulo.Classe.Name);
                    if (null != usuarioGrid)
                        XmlGrid = usuarioGrid.XML;
                }
            }
        }

        /// <summary>
        /// Atualização do Layout da Grid no Banco de Dados
        /// </summary>
        /// <param name="Contexto"></param>
        internal void AtualizaXmlGrid()
        {
            if ((null != Sistema.Usuario) && (null != Sistema.Empresa))
            {
                try
                {
                    // Recuperando as Configurações Atual da Grid para Salvar no Banco de Dados
                    String ConfiguracaoXML = null;
                    var ms = new MemoryStream();
                    grid.SaveLayoutToStream(ms);
                    ms.Position = 0;
                    ConfiguracaoXML = new StreamReader(ms, Encoding.Default).ReadToEnd();
                    ms.Dispose();

                    if (XmlGrid != ConfiguracaoXML)
                    {
                        using (UsuarioDataSet dataset = new UsuarioDataSet())
                        {
                            dataset.SalvarLayoutFormulario(
                                Sistema.Usuario.COD,
                                Sistema.Empresa.COD,
                                this.Modulo.Classe.Name,
                                ConfiguracaoXML);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Funcoes.ExibirExcessao(ex);
                }
            }
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (null != Dados)
            {
                Dados.DataSource = null;
                Dados.Dispose();
                AtualizaXmlGrid();
            }

            if (null != Modulo) Modulo = null;
            if (null != Campos) Campos = null;

            if (null != gridControl.DataSource)
                ((BindingSource)gridControl.DataSource).Dispose();

            if (disposing && (null != components))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Label para Seleção de Filtros Personalizados
        private void labelFiltrosPersonalizados_Click(object sender, EventArgs e)
        {
            using (FrmFiltros f = new FrmFiltros())
            {
                f.Campos = this.Campos;
                f.ShowDialog();
                if (!String.IsNullOrEmpty(f.FiltroString))
                {
                    this.filtroPersonalizado = f.FiltroString;
                    this.labelRemoverFiltro.Text = "[Remover] " + f.FiltroValuesString;
                    this.filtroControl1.Clear();
                    btnConsultar.PerformClick();
                }
            }
        }
        #endregion

        #region Executar a consulta no banco de dados
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (grid.GetSelectedRows().Count() > 0)            
                UltimaSelecao = grid.GetSelectedRows()[0];
            
            List<Filtro> Filtros = new List<Filtro>();
            Filtros.Add(new Filtro() { Campo = "CAMPO", Tipo = TypeCode.Int32, Criterio = "Contem", ParametroInicial = "1" });
            Funcoes.SerializarFiltro(Filtros);

            Filtros = Funcoes.DeserializarFiltro(Funcoes.SerializarFiltro(Filtros));

            // Filtro que será aplicado na query dentro do banco
            FiltroParaAplicar = String.Empty;

            // Pegando o Filtro Avançado ou o Filtro digitado pelo usuário
            String strFiltro = filtroControl1.ToString();
            String strDescricao = filtroControl1.ToValuesString();
            if (!string.IsNullOrEmpty(strFiltro))
            {
                FiltroParaAplicar = strFiltro;
                if (!string.IsNullOrEmpty(strDescricao))
                    labelRemoverFiltro.Text = "[Remover] " + strDescricao;
            }
            if (!String.IsNullOrEmpty(this.filtroPersonalizado))
                FiltroParaAplicar = filtroPersonalizado;

            /* Aplicando o novo filtro */
            gridControl.DataSource = null;
            atualizarDados.RunWorkerAsync();

        }
        #endregion

        #region Personalizar as colunas do grid
        private void btnPersonalizar_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            grid.ShowCustomization();
        }
        #endregion

        #region Remover o ultimo filtro utilizado
        private void labelRemoverFiltro_Click(object sender, EventArgs e)
        {
            if (Funcoes.Questao(Properties.Resources.MsgGostariaDeRemover))
            {
                filtroPersonalizado = string.Empty;
                FiltroParaAplicar = string.Empty;
                labelRemoverFiltro.Text = string.Empty;
                filtroControl1.Clear();
                btnConsultar.PerformClick();
            }
        }
        #endregion

        #region Botão de Remoção de Registros
        private void NavBar_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (e.Link.ItemName == "btnInserir")
                ExecutaAcao(PermissoesBasicas.Inserir, ModoFormulario.mfInsercao);
            else if (e.Link.ItemName == "btnEditar")
                ExecutaAcao(PermissoesBasicas.Editar, ModoFormulario.mfEdicao);
            else if (e.Link.ItemName == "btnRemover")
                ExecutaAcao(PermissoesBasicas.Excluir, ModoFormulario.mfExclusao);
            else if (e.Link.ItemName == "btnVisualizar")
                ExecutaAcao(PermissoesBasicas.Visualizar, ModoFormulario.mfVisualizacao);
        }
        #endregion

        #region Visualizar registros ao Pressionar Duplo Clique na Grid
        private void grid_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo info = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));
            if (info.InRow || info.InRowCell)
                NavBar_LinkClicked(btnVisualizar, new NavBarLinkEventArgs(new NavBarItemLink(btnVisualizar)));
        }
        #endregion

        private void ExecutaAcao(String Permissao, ModoFormulario Modo)
        {
            if (!Sistema.VerificaPermissaoUsuario(Modulo, Permissao))
            {
                Funcoes.Alerta(Properties.Resources.MsgModuloBloqueado);
                return;
            }
            else
            {
                if ((grid.SelectedRowsCount <= 0) && (ModoFormulario.mfInsercao != Modo))
                    Funcoes.Alerta(Properties.Resources.MsgNecessarioSelecionarRegistro);
                else if ((1 == grid.SelectedRowsCount) || (ModoFormulario.mfInsercao == Modo))
                {
                    /* Remover Registros */
                    if (ModoFormulario.mfExclusao == Modo)
                    {
                        bool PodeRemover = false;
                        if ((null != TypeEdicao) && (Parametros.ExibirRegistroAoRemover))
                        {
                            using (FrmBaseEdicao instance = (FrmBaseEdicao)Activator.CreateInstance(TypeEdicao, ModoFormulario.mfExclusao, Modulo, grid.GetFocusedRow()))
                            {
                                if (instance.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                                    PodeRemover = true;
                            }
                        }
                        else if (Funcoes.Questao(Properties.Resources.MsgGostariaDeRemover))
                            PodeRemover = true;
                        if (PodeRemover)
                        {
                            Remover();
                            btnConsultar.PerformClick();
                        }
                    }
                    /* Adicionar Registros, Editar Registros, Visualizar Registros */
                    else if (null != TypeEdicao)
                    {
                        using (FrmBaseEdicao instance = (FrmBaseEdicao)Activator.CreateInstance(TypeEdicao, Modo, Modulo, grid.GetFocusedRow()))
                        {
                            if (Modo == ModoFormulario.mfInsercao)
                                UltimaSelecao = -1;
                            if (instance.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                                btnConsultar.PerformClick();
                        }
                    }
                }
            }
        }

        protected virtual void Remover()
        {
            try
            {
                throw new Exception("Necessário Implementar");
            }
            catch (Exception ex)
            {
                Funcoes.ExibirExcessao(ex);
            }
        }

        protected virtual void Consultar()
        {
            try
            {
                throw new Exception("Necessário Implementar");
            }
            catch (Exception ex)
            {
                Funcoes.ExibirExcessao(ex);
            }
        }

        private void grid_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (0 == e.RowHandle % 2)
                e.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
        }
    }
}
