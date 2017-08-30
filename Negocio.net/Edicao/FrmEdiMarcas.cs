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
    public partial class FrmEdiMarcas : Negocio.Net.Integracao.FrmBaseEdicao
    {

        public FrmEdiMarcas(ModoFormulario ModoFormulario, Modulo Modulo, Object Entidade)
            : base(ModoFormulario, Modulo, Entidade)
        {
            InitializeComponent();

            using (MarcaDataSet dataset = new MarcaDataSet())
            {
                Marca registro = null;

                if ((ModoFormulario == Integracao.ModoFormulario.mfEdicao) ||
                    (ModoFormulario == Integracao.ModoFormulario.mfExclusao) ||
                    (ModoFormulario == Integracao.ModoFormulario.mfVisualizacao))
                {
                    registro = dataset.Consulta(String.Format("COD_MARCA == {0}", ((Marca)Entidade).COD_MARCA)).FirstOrDefault();
                    if (null != registro)
                    {
                        edCodigo.Text = registro.COD_MARCA.ToString();
                        edDescriao.Text = registro.DESCRICAO;                        
                        chkInativo.Checked = registro.INATIVO;
                    }
                }
                else
                {
                    registro = new Marca();
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
                    Validador.Validacoes.Add(new Validacao("Necessário informar a Descrição da Unidade.", edDescriao));
                
                if (Validador.PossuiPendencias())
                {
                    Validador.ExibePendencias();
                    return false;
                }

                using (MarcaDataSet dataset = new MarcaDataSet())
                {
                    Marca registro = null;

                    if (ModoFormulario.mfInsercao == ModoFormulario)
                        registro = new Marca();
                    else if (ModoFormulario.mfEdicao == ModoFormulario)
                        registro = dataset.Consulta(String.Format("COD_MARCA == {0}", ((Marca)Entidade).COD_MARCA)).FirstOrDefault();

                    if (null != registro)
                    {
                        registro.DESCRICAO = edDescriao.Text.Trim();
                        registro.INATIVO = chkInativo.Checked;
                    }

                    try
                    {
                        if (registro.COD_MARCA > 0)
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

        private void FrmEdiMarcas_Shown(object sender, EventArgs e)
        {
            edCodigo.Enabled = false;
            if (edDescriao.CanFocus)
                edDescriao.Focus();
        }
    }
}
