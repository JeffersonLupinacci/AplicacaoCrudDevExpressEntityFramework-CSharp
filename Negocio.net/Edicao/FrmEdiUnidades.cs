using Negocio.Net.Dominio;
using Negocio.Net.Dominio.Entidades;
using Negocio.Net.Integracao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Negocio.Net.Edicao
{
    public partial class FrmEdiUnidades : Negocio.Net.Integracao.FrmBaseEdicao
    {
        public FrmEdiUnidades(ModoFormulario ModoFormulario, Modulo Modulo, Object Entidade)
            : base(ModoFormulario, Modulo, Entidade)
        {
            InitializeComponent();

            using (UnidadeDataSet dataset = new UnidadeDataSet())
            {
                Unidade registro = null;

                if ((ModoFormulario == Integracao.ModoFormulario.mfEdicao) ||
                    (ModoFormulario == Integracao.ModoFormulario.mfExclusao) ||
                    (ModoFormulario == Integracao.ModoFormulario.mfVisualizacao))
                {
                    registro = dataset.Consulta(String.Format("COD_UNIDADE == {0}", ((Unidade)Entidade).COD_UNIDADE)).FirstOrDefault();
                    if (null != registro)
                    {
                        edCodigo.Text = registro.COD_UNIDADE.ToString();
                        edDescriao.Text = registro.DESCRICAO;
                        edSigla.Text = registro.SIGLA;
                        chkInativo.Checked = registro.INATIVO;
                    }
                }
                else
                {
                    registro = new Unidade();
                }

                gridListUnidades.TypeDados = typeof(Unidade);
                gridListUnidades.Componentes = new Control[3] { edDescricaoConversao, edSiglaConversao, edFatorConversao };
                gridListUnidades.ColunasVisiveis = new string[3] { "SIGLA", "DESCRICAO", "FATOR" };
                gridListUnidades.DataSource = dataset.Consulta(String.Format("COD_UNIDADE_MAIOR == {0}", registro.COD_UNIDADE)).ToList();

                gridListUnidades.AdicionarEventHandler += gridListUnidades_AdicionarEventHandler;
                gridListUnidades.EditarEventHandler += gridListUnidades_EditarEventHandler;
                gridListUnidades.CancelarEventHandler += gridListUnidades_CancelarEventHandler;
                gridListUnidades.ConfirmarEventHandler += gridListUnidades_ConfirmarEventHandler;
            }
        }

        void gridListUnidades_ConfirmarEventHandler()
        {
            if (null != gridListUnidades.DataSource)
            {
                Unidade unidade = null;
                if (gridListUnidades.ModoGrid == ModoGrid.mgInsercao)
                {
                    unidade = new Unidade();
                    ((List<Unidade>)gridListUnidades.DataSource).Add(unidade);
                }
                else
                    unidade = (Unidade)gridListUnidades.Selecao;

                if (null != unidade)
                {
                    unidade.SIGLA = edSiglaConversao.Text;
                    unidade.DESCRICAO = edDescricaoConversao.Text;
                    unidade.FATOR = Convert.ToDouble(edFatorConversao.Text.Replace('.',','));
                }
            }
        }

        void gridListUnidades_CancelarEventHandler()
        {
            edDescricaoConversao.Text = "";
            edSiglaConversao.Text = "";
            edFatorConversao.Text = "";
        }

        void gridListUnidades_EditarEventHandler()
        {
            if (null != gridListUnidades.DataSource)
            {
                Unidade unidade = (Unidade)gridListUnidades.Selecao;
                if (null != unidade)
                {
                    edDescricaoConversao.Text = unidade.DESCRICAO;
                    edSiglaConversao.Text = unidade.SIGLA;
                    edFatorConversao.Text = unidade.FATOR.ToString();
                }
            }
        }

        void gridListUnidades_AdicionarEventHandler()
        {
            edDescricaoConversao.Text = "";
            edSiglaConversao.Text = "";
            edFatorConversao.Text = "";
        }




        private void FrmEdiUnidades_Shown(object sender, EventArgs e)
        {
            edCodigo.Enabled = false;
            if (edDescriao.CanFocus)
                edDescriao.Focus();
        }

        protected override Boolean ConfirmarRegistro()
        {
            /* Criação ou alteração de Dados */
            if ((ModoFormulario.mfInsercao == ModoFormulario) || (ModoFormulario.mfEdicao == ModoFormulario))
            {
                Validador.Limpar();

                if (string.IsNullOrEmpty(edDescriao.Text.Trim()))
                    Validador.Validacoes.Add(new Validacao("Necessário informar a Descrição da Unidade.", edDescriao));
                if (string.IsNullOrEmpty(edSigla.Text.Trim()))
                    Validador.Validacoes.Add(new Validacao("Necessário informar a Sigla da Unidade.", edSigla));

                if (Validador.PossuiPendencias())
                {
                    Validador.ExibePendencias();
                    return false;
                }

                using (UnidadeDataSet dataset = new UnidadeDataSet())
                {
                    Unidade registro = null;

                    if (ModoFormulario.mfInsercao == ModoFormulario)
                        registro = new Unidade();
                    else if (ModoFormulario.mfEdicao == ModoFormulario)
                        registro = dataset.Consulta(String.Format("COD_UNIDADE == {0}", ((Unidade)Entidade).COD_UNIDADE)).FirstOrDefault();

                    if (null != registro)
                    {
                        registro.DESCRICAO = edDescriao.Text.Trim();
                        registro.SIGLA = edSigla.Text.Trim();
                        registro.INATIVO = chkInativo.Checked;
                    }

                    try
                    {
                        if (registro.COD_UNIDADE > 0)
                            dataset.Atualizar(registro);
                        else
                            dataset.Adicionar(registro);
                    }
                    catch (Exception ex)
                    {
                        Funcoes.ExibirExcessao(ex);
                        return false;
                    }
                }
            }
            return true;
        }

    }
}
