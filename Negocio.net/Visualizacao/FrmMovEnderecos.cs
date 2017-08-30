using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Linq.Dynamic;

using Negocio.Net.Integracao;
using Negocio.Net.Dominio;
using Negocio.Net.Dominio.Entidades;
using Negocio.Net.Edicao;

namespace Negocio.Net.Visualizacao
{
    partial class FrmMovEnderecos : Negocio.Net.Integracao.FrmBaseMovimentacao
    {
        public FrmMovEnderecos()
        {
            InitializeComponent();
            TypeDados = typeof(Endereco);
            TypeEdicao = typeof(FrmEdiEnderecos);
        }

        protected override void Consultar()
        {
            try
            {
                using (EnderecoDataSet dataset = new EnderecoDataSet())
                {
                    if (!String.IsNullOrEmpty(FiltroParaAplicar))
                    {
                        var query = dataset.ConsultaNoTracking(FiltroParaAplicar);
                        this.Dados.DataSource = query.ToList();

                        // Forçando uma segunda change de trazer o filtro
                        if (null == this.Dados.DataSource)
                            this.Dados.DataSource = query.ToList();
                    }
                    else
                    {
                        IEnumerable<Endereco> consulta = dataset.ConsultaNoTracking(null).ToList();
                        this.Dados.DataSource = consulta;
                    }
                }
            }
            catch (Exception ex)
            {
                Funcoes.ExibirExcessao(ex);
            }
        }

        protected override void Remover()
        {
            using (EnderecoDataSet dataset = new EnderecoDataSet())
            {
                try
                {
                    dataset.Excluir(String.Format("COD_ENDERECO == {0} ", ((Endereco)grid.GetFocusedRow()).COD_ENDERECO));
                }
                catch (Exception ex)
                {
                    Funcoes.ExibirExcessao(ex);
                }
            }
        }
    }
}
