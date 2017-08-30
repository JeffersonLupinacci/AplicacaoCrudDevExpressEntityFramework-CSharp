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
    partial class FrmMovModelos : Negocio.Net.Integracao.FrmBaseMovimentacao
    {
        public FrmMovModelos()
        {
            InitializeComponent();
            TypeDados = typeof(Modelo);
            TypeEdicao = typeof(FrmEdiModelos);
        }

        protected override void Consultar() 
        {
            try
            {
                using (ModeloDataSet dataset = new ModeloDataSet())
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
                        IEnumerable<Modelo> consulta = dataset.ConsultaNoTracking(null).ToList();
                        this.Dados.DataSource = consulta;
                    }
                }
            }
            catch (Exception ex) {
                Funcoes.ExibirExcessao(ex);
            }
        }

        protected override void Remover()
        {
            using (ModeloDataSet dataset = new ModeloDataSet())
            {
                try
                {
                    dataset.Excluir(String.Format("COD_MODELO == {0} ", ((Modelo)grid.GetFocusedRow()).COD_MODELO));
                }
                catch (Exception ex) {
                    Funcoes.ExibirExcessao(ex);
                }
            }
        }
    }
}
