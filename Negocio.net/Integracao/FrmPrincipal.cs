using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevExpress.XtraBars;

using Negocio.Net.Dominio;
using Negocio.Net.Dominio.Entidades;

namespace Negocio.Net.Integracao
{

    public partial class FrmPrincipal : FrmBase
    {
        private PopupMenu popupAbas;
        private BarManager GerenciadorMenu = new BarManager();
        private BarButtonItem btnFecharAba = new BarButtonItem() { Caption = Properties.Resources.LabelFecharAbaAtual, Id = 1, Name = "btnFecharAba" };
        private BarButtonItem btnFecharTodasAbas = new BarButtonItem() { Caption = Properties.Resources.LabelFecharTodasAsAbas, Id = 2, Name = "btnFecharTodasAbas" };
        private BarButtonItem btnFecharTodasAbasExceto = new BarButtonItem() { Caption = Properties.Resources.LabelFecharTodasAsAbasExceto, Id = 2, Name = "btnFecharTodasAbasExceto" };
        private int PageNumber = 0;

        /// <summary>
        /// Formulário Principal do Sistema
        /// </summary>
        public FrmPrincipal()
        {
            popupAbas = new DevExpress.XtraBars.PopupMenu(GerenciadorMenu) { Name = "Abas", MenuCaption = "Gerenciar Abas" };
            popupAbas.ItemLinks.Add(btnFecharAba);
            popupAbas.ItemLinks.Add(btnFecharTodasAbas).BeginGroup = true;
            popupAbas.ItemLinks.Add(btnFecharTodasAbasExceto);
            new PopupMenuCloseHelper(popupAbas);

            btnFecharAba.ItemClick += btnFecharAba_ItemClick;
            btnFecharTodasAbas.ItemClick += btnFecharAba_ItemClick;
            btnFecharTodasAbasExceto.ItemClick += btnFecharAba_ItemClick;

            InitializeComponent();
            Icon = Program.Recursos.AppIcon;
            Text = Properties.Resources.ApplicationName;
            Paginas.Visible = false;

        }

        #region FrmPrincipal_FormClosing - Finalizar Aplicativo
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Ignorando a mensagem ao destruir
            if ((this.Owner as FrmInicializacao).ignoreFormClosing) return;

            // Perguntando ao usuário se ele gostaria de finalizar o aplicativo
            var res = MessageBox.Show(this, Properties.Resources.MsgFinalizarAplicativo, Properties.Resources.ApplicationName,
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (res != DialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }
            else
                SalvarAtalhosDoUsuario();
            Application.Exit();

        }
        #endregion

        #region ribbon_ItemClick - Carrega o formulario do módulo dentro do PageControl Paginas
        private void ribbon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if ((null != e.Item.Tag) && (e.Item.Tag is Modulo))
            {
                Modulo _m = (Modulo)e.Item.Tag;
                // Localizando a Janela do Módulo Requisitado
                foreach (DevExpress.XtraTab.XtraTabPage PaginaEx in Paginas.TabPages)
                {
                    Control.ControlCollection ControlesEx = PaginaEx.Controls;
                    if (ControlesEx.Count > 0)
                    {
                        Control.ControlCollection PainelEx = ControlesEx[ControlesEx.Count - 1].Controls;
                        if (PainelEx[PainelEx.Count - 1] is FrmBaseMovimentacao)
                        {
                            FrmBaseMovimentacao Formulario = (FrmBaseMovimentacao)PainelEx[PainelEx.Count - 1];
                            if (Formulario.Modulo.Guid == _m.Guid)
                            {
                                Paginas.SelectedTabPage = PaginaEx;
                                return;
                            }
                        }
                    }
                }


                if ((null != _m.Permissoes.Where(x => x.Guid == new Guid(PermissoesBasicas.Visualizar)).FirstOrDefault()) && (_m.Classe != null))
                {
                    DevExpress.XtraTab.XtraTabPage Pagina = new DevExpress.XtraTab.XtraTabPage();
                    Pagina.Text = _m.Descricao;
                    Pagina.Tag = PageNumber++;
                    Paginas.TabPages.Add(Pagina);
                    DevExpress.XtraEditors.PanelControl painel = new DevExpress.XtraEditors.PanelControl
                    {
                        Parent = Pagina,
                        Dock = DockStyle.Fill,
                        BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
                    };

                    // Criando o formulário de movimentação com o modulo adquirido como parametro
                    FrmBaseMovimentacao instance = (FrmBaseMovimentacao)Activator.CreateInstance(_m.Classe);
                    instance.TopLevel = false;
                    instance.FormBorderStyle = FormBorderStyle.None;
                    instance.Dock = DockStyle.Fill;
                    instance.Visible = true;
                    instance.Modulo = _m;

                    // adicionando o painel que possui o formulario
                    painel.Controls.Add(instance);

                    // adicionando a nova página as tabs
                    Paginas.TabPages.Add(Pagina);
                    Paginas.SelectedTabPage = Pagina;
                    Paginas.Visible = true;
                }
            }
        }
        #endregion

        #region btnTrocarDeUsuario_ItemClick - Trocar de Usuário Utilizador
        private void btnTrocarDeUsuario_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SalvarAtalhosDoUsuario();
            this.Hide();
            (this.Owner as FrmInicializacao).FrmLogin.listarEmpresas();
            (this.Owner as FrmInicializacao).FrmLogin.Show();
        }
        #endregion

        #region btnSairAplicativo_ItemClick - Fechar o Aplicativo
        private void btnSairAplicativo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SalvarAtalhosDoUsuario();
            this.Close();
        }
        #endregion

        #region btnFecharAba_ItemClick - Removedor de Paginas
        private void btnFecharAba_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item == btnFecharAba)
            {
                if (Paginas.SelectedTabPageIndex >= 0)
                    RemoverPagina(Paginas.SelectedTabPageIndex);
            }
            else if (e.Item == btnFecharTodasAbas)
            {
                while (Paginas.TabPages.Count > 0)
                    for (int i = 0; i < Paginas.TabPages.Count; i++)
                        RemoverPagina(i);
            }
            else if (e.Item == btnFecharTodasAbasExceto)
            {
                int _pageNumber = (int)Paginas.SelectedTabPage.Tag;
                while (Paginas.TabPages.Count > 1)
                    for (int i = 0; i < Paginas.TabPages.Count; i++)
                        if (_pageNumber != (int)Paginas.TabPages[i].Tag)
                            RemoverPagina(i);
            }
            Paginas.Visible = Paginas.TabPages.Count > 0;
        }
        #endregion

        #region Paginas_CloseButtonClick - Fechar a aba atual ao clicar no [X] da Aba
        private void Paginas_CloseButtonClick(object sender, EventArgs e)
        {
            btnFecharAba.PerformClick();
            GC.Collect();
        }
        #endregion

        #region Paginas_CustomHeaderButtonClick - Exibe o Menu Responsavel pelo fechamento das abas
        private void Paginas_CustomHeaderButtonClick(object sender, DevExpress.XtraTab.ViewInfo.CustomHeaderButtonEventArgs e)
        {
            btnFecharAba.Visibility = (Paginas.TabPages.Count >= 1) ? BarItemVisibility.Always : BarItemVisibility.Never;
            btnFecharTodasAbas.Visibility = (Paginas.TabPages.Count > 1) ? BarItemVisibility.Always : BarItemVisibility.Never;
            btnFecharTodasAbasExceto.Visibility = (Paginas.TabPages.Count > 1) ? BarItemVisibility.Always : BarItemVisibility.Never;
            this.popupAbas.ShowPopup(new Point() { X = Cursor.Position.X - 5, Y = Cursor.Position.Y - 5 });
        }
        #endregion

        #region RemoverPagina(int) - Remove a Página pelo seu indice
        private void RemoverPagina(int PageIndex)
        {
            DevExpress.XtraTab.XtraTabPage Pagina = Paginas.TabPages[PageIndex];
            Control.ControlCollection Controles = Pagina.Controls;
            if (Controles.Count > 0)
            {
                Control.ControlCollection Painel = Controles[Controles.Count - 1].Controls;
                if (Painel.Count > 0)
                {
                    Form Formulario = (Form)Painel[Painel.Count - 1];
                    Formulario.Dispose();
                }
            }
            Paginas.TabPages.Remove(Pagina);
        }
        #endregion

        #region ConfiguraBotoesRibbon() - Vincula o Modulo e a Imagem com o Botão no Ribbon Control
        private void ConfiguraBotoesRibbon()
        {
            /* Vinculando o Modulo do Sistema ao Botão de Ação do Software */
            btnGerenciarCadastros.Tag = Sistema.RecuperaModuloDisponivel(Modulos.CadastroGeral);
            btnGerenciarTiposDeCadastro.Tag = Sistema.RecuperaModuloDisponivel(Modulos.TipoDeCadastro);
            btnGerenciarClassificacao.Tag = Sistema.RecuperaModuloDisponivel(Modulos.Classificacao);
            btnGerenciarColaboradores.Tag = Sistema.RecuperaModuloDisponivel(Modulos.Colaborador);
            btnGerenciarCidades.Tag = Sistema.RecuperaModuloDisponivel(Modulos.Cidade);
            btnGerenciarEstados.Tag = Sistema.RecuperaModuloDisponivel(Modulos.Estado);
            btnGerenciarPaises.Tag = Sistema.RecuperaModuloDisponivel(Modulos.Pais);
            btnGerenciarRegioes.Tag = Sistema.RecuperaModuloDisponivel(Modulos.Regiao);

            btnGerenciarProdutos.Tag = Sistema.RecuperaModuloDisponivel(Modulos.Produto);
            btnGerenciarGrupo.Tag = Sistema.RecuperaModuloDisponivel(Modulos.Grupo);
            btnGerenciarSubGrupo.Tag = Sistema.RecuperaModuloDisponivel(Modulos.Subgrupo);
            btnGerenciarUnidades.Tag = Sistema.RecuperaModuloDisponivel(Modulos.Unidade);
            btnGerenciarMarca.Tag = Sistema.RecuperaModuloDisponivel(Modulos.Marca);
            btnGerenciarModelos.Tag = Sistema.RecuperaModuloDisponivel(Modulos.Modelo);
            btnGerenciarLocal.Tag = Sistema.RecuperaModuloDisponivel(Modulos.Local);
            btnGerenciarEndereco.Tag = Sistema.RecuperaModuloDisponivel(Modulos.Endereco);

            btnGerenciarEmpresas.Tag = Sistema.RecuperaModuloDisponivel(Modulos.Empresa);
            btnGerenciarUsuarios.Tag = Sistema.RecuperaModuloDisponivel(Modulos.Usuario);

            btnSairAplicativo.Tag = Sistema.RecuperaModuloDisponivel(Modulos.SairDoAplicativo);
            btnAlterarSenhaAcesso.Tag = Sistema.RecuperaModuloDisponivel(Modulos.AlterarSenhaDeAcesso);
            btnTrocarDeUsuario.Tag = Sistema.RecuperaModuloDisponivel(Modulos.TrocarDeUsuario);

            ribbonControl1.Images = Program.Recursos.IconesCompartilhados;
            ribbonControl1.LargeImages = Program.Recursos.IconesCompartilhados;
            foreach (DevExpress.XtraBars.BarItem item in ribbonControl1.Items)
            {
                /* Carrega as Informações do Modulo ao Botão e Verifica se foi contratado sua utilização */
                if (item.Tag is Modulo)
                {
                    item.Caption = ((Modulo)item.Tag).Descricao;
                    if (!Sistema.VerificaModuloContratado(((Modulo)item.Tag)))
                        item.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                }
                else
                    item.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

                if (item.Visibility != DevExpress.XtraBars.BarItemVisibility.Never)
                {
                    /* Verificando se o usuario possui permissão para acionar o modulo que a empresa contratou */
                    if ((Sistema.Usuario.ADMINISTRADOR) || Sistema.VerificaModuloUsuario(((Modulo)item.Tag)))

                        item.ImageIndex = Program.Recursos.IconeIndex(item.Name);
                    item.LargeImageIndex = Program.Recursos.IconeIndex(item.Name + "Large");
                    item.ItemClick += ribbon_ItemClick;
                }
            }

            ribbonControl1.Toolbar.ItemLinks.Clear();

            using (UsuarioDataSet dataset = new UsuarioDataSet())
            {
                /* Recuperando os botões salvos como favoritos pelo usuário */
                List<UsuarioToolbar> botoesSalvos = dataset.ListarItensToolbar(Sistema.Usuario.COD, Sistema.Empresa.COD);
                foreach (UsuarioToolbar toolbar in botoesSalvos)
                {
                    BarItem botaoRibbon = ribbonControl1.Items[toolbar.BOTAO];
                    if ((null != botaoRibbon) && (botaoRibbon.Visibility != BarItemVisibility.Never))
                        ribbonControl1.Toolbar.ItemLinks.Add(botaoRibbon);
                }
            }
        }
        #endregion

        #region TrocarDeUsuario() - Configura a Tela com as Configurações do Usuario
        public void TrocarDeUsuario()
        {
            // Maximizando a Janela Principal
            this.WindowState = FormWindowState.Maximized;

            ConfiguraBotoesRibbon();
        }
        #endregion

        #region SalvarAtalhosDoUsuario() - Salvando os Atalhos do Toolbar Personalizado do Usuário no Banco
        private void SalvarAtalhosDoUsuario()
        {
            List<string> BotoesFavoritos = new List<string>();
            List<string> BotoesLiberados = new List<string>();
            for (int i = 0; i < ribbonControl1.Toolbar.ItemLinks.Count; i++)
                BotoesFavoritos.Add(ribbonControl1.Toolbar.ItemLinks[i].Item.Name);

            for (int i = 0; i < ribbonControl1.Items.Count; i++)
                if (BarItemVisibility.Never != ribbonControl1.Items[i].Visibility)
                    BotoesLiberados.Add(ribbonControl1.Items[i].Name);

            using (UsuarioDataSet dataset = new UsuarioDataSet())
            {
                dataset.SalvarItensToolbar(BotoesFavoritos, BotoesLiberados, Sistema.Usuario.COD, Sistema.Empresa.COD);
            }
        }
        #endregion
    }
}
