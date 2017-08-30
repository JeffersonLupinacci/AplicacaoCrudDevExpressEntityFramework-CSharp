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
    public partial class FrmEdiEnderecos : Negocio.Net.Integracao.FrmBaseEdicao
    {
        public FrmEdiEnderecos(ModoFormulario ModoFormulario, Modulo Modulo, Object Entidade)
            : base(ModoFormulario, Modulo, Entidade)
        {
            InitializeComponent();

            using (EnderecoDataSet dataset = new EnderecoDataSet())
            {
                Endereco registro = null;

                if ((ModoFormulario == Integracao.ModoFormulario.mfEdicao) ||
                    (ModoFormulario == Integracao.ModoFormulario.mfExclusao) ||
                    (ModoFormulario == Integracao.ModoFormulario.mfVisualizacao))
                {
                    registro = dataset.Consulta(String.Format("COD_ENDERECO == {0}", ((Endereco)Entidade).COD_ENDERECO)).FirstOrDefault();
                    if (null != registro)
                    {
                        edCodigo.Text = registro.COD_ENDERECO.ToString();
                        edDescriao.Text = registro.DESCRICAO;
                    }
                }
                else
                {
                    registro = new Endereco();
                }
            }
        }

        protected override Boolean ConfirmarRegistro()
        {
            /* Criação ou alteração de Dados */
            if ((ModoFormulario.mfInsercao == ModoFormulario) || (ModoFormulario.mfEdicao == ModoFormulario))
            {
                Validador.Limpar();

                if (string.IsNullOrEmpty(edDescriao.Text.Trim()))
                    Validador.Validacoes.Add(new Validacao("Necessário informar a Descrição.", edDescriao));

                if (Validador.PossuiPendencias())
                {
                    Validador.ExibePendencias();
                    return false;
                }

                using (EnderecoDataSet dataset = new EnderecoDataSet())
                {
                    Endereco registro = null;

                    if (ModoFormulario.mfInsercao == ModoFormulario)
                        registro = new Endereco();
                    else if (ModoFormulario.mfEdicao == ModoFormulario)
                        registro = dataset.Consulta(String.Format("COD_ENDERECO == {0}", ((Endereco)Entidade).COD_ENDERECO)).FirstOrDefault();

                    if (null != registro)
                        registro.DESCRICAO = edDescriao.Text.Trim();

                    try
                    {
                        if (registro.COD_ENDERECO > 0)
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

        private void FrmEdiEnderecos_Shown(object sender, EventArgs e)
        {
            edCodigo.Enabled = false;
            if (edDescriao.CanFocus)
                edDescriao.Focus();
        }
    }
}
