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
    public partial class FrmEdiLocais : Negocio.Net.Integracao.FrmBaseEdicao
    {
        public FrmEdiLocais(ModoFormulario ModoFormulario, Modulo Modulo, Object Entidade)
            : base(ModoFormulario, Modulo, Entidade)
        {
            InitializeComponent();

            using (LocalDataSet dataset = new LocalDataSet())
            {
                Local registro = null;

                if ((ModoFormulario == Integracao.ModoFormulario.mfEdicao) ||
                    (ModoFormulario == Integracao.ModoFormulario.mfExclusao) ||
                    (ModoFormulario == Integracao.ModoFormulario.mfVisualizacao))
                {
                    registro = dataset.Consulta(String.Format("COD_LOCAL == {0}", ((Local)Entidade).COD_LOCAL)).FirstOrDefault();
                    if (null != registro)
                    {
                        edCodigo.Text = registro.COD_LOCAL.ToString();
                        edDescriao.Text = registro.DESCRICAO;
                    }
                }
                else
                {
                    registro = new Local();
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

                using (LocalDataSet dataset = new LocalDataSet())
                {
                    Local registro = null;

                    if (ModoFormulario.mfInsercao == ModoFormulario)
                        registro = new Local();
                    else if (ModoFormulario.mfEdicao == ModoFormulario)
                        registro = dataset.Consulta(String.Format("COD_LOCAL == {0}", ((Local)Entidade).COD_LOCAL)).FirstOrDefault();

                    if (null != registro)
                        registro.DESCRICAO = edDescriao.Text.Trim();

                    try
                    {
                        if (registro.COD_LOCAL > 0)
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

        private void FrmEdiLocais_Shown(object sender, EventArgs e)
        {
            edCodigo.Enabled = false;
            if (edDescriao.CanFocus)
                edDescriao.Focus();
        }
    }
}
