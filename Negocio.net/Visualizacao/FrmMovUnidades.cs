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
    partial class FrmMovUnidades : Negocio.Net.Integracao.FrmBaseMovimentacao
    {
        public FrmMovUnidades()
        {
            InitializeComponent();            
            TypeDados = typeof(Unidade);
            TypeEdicao = typeof(FrmEdiUnidades);
        }

        protected override void Consultar()
        {
            try
            {
                using (UnidadeDataSet dataset = new UnidadeDataSet())
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
                        IEnumerable<Unidade> consulta = dataset.ConsultaNoTracking(null).ToList();
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
            using (UnidadeDataSet dataset = new UnidadeDataSet())
            {
                try
                {
                    dataset.Excluir(String.Format("COD_UNIDADE == {0} ", ((Unidade)grid.GetFocusedRow()).COD_UNIDADE));
                }
                catch (Exception ex){
                    Funcoes.ExibirExcessao(ex);
                }
            }
        }
    }
}
