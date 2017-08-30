using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraTreeList.Nodes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Negocio.Net.Integracao
{
    public partial class TratarExcessao : Negocio.Net.Integracao.FrmBase
    {

        /// <summary>
        /// Excessão Ocorrida no Sistema que deverá ser tratada
        /// </summary>
        public Exception Excessao { get; set; }

        /// <summary>
        /// Lista de Validações que deverão ser geridas e exibidas ao usuário
        /// </summary>
        public List<Validacao> Validacoes { get; set; }

        /// <summary>
        /// Controle que que solicitou a exibição das validações
        /// </summary>
        public Control Controle { get; set; }

        /// <summary>
        /// Construtor Padrão do Tratamento de Excessões
        /// </summary>
        public TratarExcessao()
        {
            InitializeComponent();
            this.Icon = Program.Recursos.AppIcon;
            this.btnFechar.Image = Program.Recursos.Icone("btnFechar");
            this.btnFechar.Text = Properties.Resources.btnFechar;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
            grid_DoubleClick(grid, new EventArgs());
        }

        /// <summary>
        /// Alterando a exibição das Exceptions, de Completo para Somente a ultima Gerada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkFullException_Click(object sender, EventArgs e)
        {
            ExibirExcessao(!checkFullException.Checked);
        }

        /// <summary>
        /// Exibição de Validações em Formato Grid, não funciona com excessões diretas
        /// </summary>
        private void ExibirValidacao()
        {
            gridControl.Visible = true;
            checkFullException.Visible = false;
            BindingSource Dados = new BindingSource();
            Dados.DataSource = Validacoes;
            gridControl.DataSource = Dados;
        }

        /// <summary>
        /// Tratamento para Exibir o Conteudo da Excessão recebida por parametro a este Formulário
        /// </summary>
        /// <param name="DescricaoCompleta">Caso o Tratamento possui InnerExceptions, será listados todos</param>
        private void ExibirExcessao(Boolean DescricaoCompleta)
        {
            meAlerta.Visible = true;
            Exception _excessao = Excessao;

            if (null != _excessao)
            {
                StringBuilder sb = new StringBuilder();

                #region Excessões que ocorrem ao Validar Entidades no Banco
                if (_excessao is DbEntityValidationException)
                {
                    foreach (var failure in ((DbEntityValidationException)_excessao).EntityValidationErrors)
                    {
                        foreach (var error in failure.ValidationErrors)
                        {
                            sb.AppendFormat(error.ErrorMessage);
                            sb.AppendLine();
                        }
                    }
                }
                #endregion

                #region Excessões que ocorrem ao Validar Objetos na Aplicação
                else
                {
                    if (null == _excessao.InnerException)
                        meAlerta.Text = _excessao.Message;
                    else
                    {
                        while (null != _excessao.InnerException)
                        {
                            _excessao = _excessao.InnerException;
                            if (((!DescricaoCompleta) && (null == _excessao.InnerException)) || (DescricaoCompleta))
                            {
                                sb.AppendFormat("{0} - {1}", _excessao.Source, _excessao.Message);
                                sb.AppendLine();
                                sb.AppendLine();
                            }
                        }
                    }
                }
                #endregion

                meAlerta.Text = sb.ToString();
                /* Mensagem de Validação de Foreign Key*/
                if (!DescricaoCompleta)
                {
                    if (meAlerta.Text.Contains("violates not-null constraint"))
                        meAlerta.Text = Properties.Resources.MsgErrorNotNull;

                    else if (meAlerta.Text.Contains("violates foreign key constraint"))
                        meAlerta.Text = Properties.Resources.MsgErrorForeignKey;
                }

            }
        }

        /// <summary>
        /// Duplo clique na Grid Permite com que o usuário acesse o controle visual diretamente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grid_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            if (null != view)
            {
                GridHitInfo info = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));
                if (((null != info) && ((info.InRow || info.InRowCell) && (1 == grid.SelectedRowsCount))) && (null != grid))
                {
                    Object instance = grid.GetFocusedRow();
                    if (null != instance)
                    {
                        this.Controle = ((Validacao)instance).Controle;
                        this.Close();
                    }
                }
            }
        }

        private void TratarExcessao_Shown(object sender, EventArgs e)
        {
            meAlerta.Visible = false;
            gridControl.Visible = false;
            if (null != Excessao)
                ExibirExcessao(false);
            else if ((null != Validacoes) && (Validacoes.Count > 0))
                ExibirValidacao();
        }
            
    }
}
