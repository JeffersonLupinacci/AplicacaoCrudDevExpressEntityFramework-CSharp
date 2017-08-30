using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Negocio.Net.Integracao
{
    public partial class GridListControl : UserControl
    {
        public event GridListEventHandler AdicionarEventHandler;
        public event GridListEventHandler EditarEventHandler;
        public event GridListEventHandler CancelarEventHandler;
        public event GridListEventHandler RemoverEventHandler;
        public event GridListEventHandler ConfirmarEventHandler;
        public event GridListEventHandler SelecaoEventHandler;

        private object innerDataSource { get; set; }
        private ModoGrid innerModoGrid { get; set; }

        /// <summary>
        /// Recupera o modo do Componente
        /// </summary>
        public ModoGrid ModoGrid { get { return innerModoGrid; } }

        /// <summary>
        /// Type dos dados que serão gerenciados pela GRID
        /// </summary>
        public Type TypeDados { get; set; }

        /// <summary>
        /// Array contendo os Componentes Visuais Vinculados a GRID
        /// </summary>
        public Control[] Componentes { get; set; }

        /// <summary>
        /// Array Contendo as Colunas que ficaram visiveis na GRID
        /// </summary>
        public string[] ColunasVisiveis { get; set; }

        /// <summary>
        /// Fonte de Dados 
        /// </summary>
        private BindingSource Dados = new BindingSource();

        /// <summary>
        /// Define o DataSource do Componente
        /// </summary>
        /// <param name="DataSource"></param>
        public object DataSource{
            get
            {
                return innerDataSource;
            }
            set
            {
                innerDataSource = value;
                innerModoGrid = ModoGrid.mgVisualizacao;
                Dados.DataSource = innerDataSource;
                gridControl.DataSource = Dados;

                Funcoes.ConfigurarColunasGrid(grid, TypeDados);

                if ((null != ColunasVisiveis) && (ColunasVisiveis.Length > 0))
                {
                    foreach (DevExpress.XtraGrid.Columns.GridColumn coluna in grid.Columns)
                        if (null == ColunasVisiveis.Where(x => x == coluna.FieldName).FirstOrDefault())
                            coluna.Visible = false;
                    int Ordem = 0;
                    foreach (String campo in ColunasVisiveis)
                    {
                        DevExpress.XtraGrid.Columns.GridColumn coluna = grid.Columns.ColumnByFieldName(campo);
                        if (null != coluna)
                        {
                            coluna.Visible = true;
                            coluna.VisibleIndex = Ordem++;
                        }
                    }
                }

                AlteraControle();
            }
        }

        public object Selecao { get { return grid.GetFocusedRow();} }

        /// <summary>
        /// Construtor Padrão
        /// </summary>
        public GridListControl()
        {
            InitializeComponent();
            grid.CustomDrawCell += grid_CustomDrawCell;
            innerModoGrid = ModoGrid.mgVisualizacao;
            btnAdicionar.Click += GerenciarClick;
            btnEditar.Click += GerenciarClick;
            btnCancelar.Click += GerenciarClick;
            btnRemover.Click += GerenciarClick;
            btnConfirmar.Click += GerenciarClick;
            AlteraControle();
        }

        /// <summary>
        /// Mapeamento de Rotinas de Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GerenciarClick(object sender, EventArgs e)
        {
            #region Adição de Registros
            if ((sender == btnAdicionar) && (null != AdicionarEventHandler))
            {
                AdicionarEventHandler();
                innerModoGrid = ModoGrid.mgInsercao;
            }
            #endregion

            #region Edição de Registros
            else if ((sender == btnEditar) && (null != EditarEventHandler))
            {
                if (grid.SelectedRowsCount <= 0)
                {
                    Funcoes.Alerta(Properties.Resources.MsgNecessarioSelecionarRegistro);
                    return;
                }
                else
                {
                    EditarEventHandler();
                    innerModoGrid = ModoGrid.mgEdicao;
                }
            }
            #endregion

            #region Retorno do Componente ao Seu Status Inicial
            else if ((sender == btnCancelar) && (null != CancelarEventHandler))
            {
                CancelarEventHandler();
                innerModoGrid = ModoGrid.mgVisualizacao;
            }
            #endregion

            #region Confirmação da Alteração ou Edição do Registro
            else if ((sender == btnConfirmar) && (null != ConfirmarEventHandler))
            {
                ConfirmarEventHandler();
                innerModoGrid = ModoGrid.mgVisualizacao;
                grid.RefreshData();
            }
            #endregion

            #region Remoção de Registro
            else if ((sender == btnRemover) && (null != RemoverEventHandler))
            {
                if (grid.SelectedRowsCount <= 0)
                {
                    Funcoes.Alerta(Properties.Resources.MsgNecessarioSelecionarRegistro);
                    return;
                }
                if (Funcoes.Questao(Properties.Resources.MsgGostariaDeRemover))
                {
                    RemoverEventHandler();
                    innerModoGrid = ModoGrid.mgVisualizacao;
                    grid.RefreshData();
                }
            }
            #endregion

            AlteraControle();
        }

        /// <summary>
        /// Altera o visual do Componente e libera os controles
        /// </summary>
        private void AlteraControle()
        {
            if (null != Dados)
            {
                btnAdicionar.Enabled = (innerModoGrid == ModoGrid.mgVisualizacao);
                btnEditar.Enabled = ((innerModoGrid == ModoGrid.mgVisualizacao) && (grid.SelectedRowsCount == 1));
                btnRemover.Enabled = ((innerModoGrid == ModoGrid.mgVisualizacao) && (grid.SelectedRowsCount == 1));
                btnCancelar.Enabled = (innerModoGrid != ModoGrid.mgVisualizacao);
                btnConfirmar.Enabled = (innerModoGrid != ModoGrid.mgVisualizacao);

                gridControl.Enabled = (innerModoGrid == ModoGrid.mgVisualizacao);

                if ((null != Componentes) && (Componentes.Length > 0))
                {
                    /* Bloqueando os componentes do tipo TextEdit */
                    var TextEdits = Funcoes.RecuperaControles(Componentes, typeof(TextEdit));
                    foreach (TextEdit c in TextEdits)
                        BloquearTextEdit(c, (ModoGrid.mgVisualizacao != innerModoGrid));

                    /* Bloqueando os componentes do tipo CheckEdit */
                    var CheckEdits = Funcoes.RecuperaControles(Componentes, typeof(CheckEdit));
                    foreach (var c in CheckEdits) c.Enabled = (ModoGrid.mgVisualizacao != innerModoGrid);

                    if (Componentes[0].CanFocus)
                        Componentes[0].Focus();
                }
            }
            else
            {
                btnAdicionar.Enabled = false;
                btnEditar.Enabled = false;
                btnRemover.Enabled = false;
                btnCancelar.Enabled = false;
                btnConfirmar.Enabled = false;
                gridControl.Enabled = false;
            }
        }

        /// <summary>
        /// Bloqueio de Componentes TextEdit
        /// </summary>
        /// <param name="c"></param>
        /// <param name="Enabled"></param>
        protected void BloquearTextEdit(TextEdit c, Boolean Enabled)
        {
            c.Enabled = Enabled;
            c.Properties.Appearance.BackColor = System.Drawing.Color.White;
            c.Properties.Appearance.Options.UseBackColor = true;
        }

        /// <summary>
        /// Grid Zebrada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grid_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (0 == e.RowHandle % 2)
                e.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
        }

        protected override void Dispose(bool disposing)
        {
            if (null != Componentes)
                Componentes = null;

            if (null != Dados)
            {
                Dados.DataSource = null;
                Dados.Dispose();
            }

            if (null != gridControl.DataSource)
                ((BindingSource)gridControl.DataSource).Dispose();

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}
