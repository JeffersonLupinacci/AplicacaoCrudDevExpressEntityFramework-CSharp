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
    partial class FrmMovLocais : Negocio.Net.Integracao.FrmBaseMovimentacao
    {
        public FrmMovLocais()
        {
            InitializeComponent();
            TypeDados = typeof(Local);
            TypeEdicao = typeof(FrmEdiLocais);
        }

        protected override void Consultar()
        {
            try
            {
                using (LocalDataSet dataset = new LocalDataSet())
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
                        IEnumerable<Local> consulta = dataset.ConsultaNoTracking(null).ToList();
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
            using (LocalDataSet dataset = new LocalDataSet())
            {
                try
                {
                    dataset.Excluir(String.Format("COD_LOCAL == {0} ", ((Local)grid.GetFocusedRow()).COD_LOCAL));
                }
                catch (Exception ex)
                {
                    Funcoes.ExibirExcessao(ex);
                }
            }
        }
    }
}
