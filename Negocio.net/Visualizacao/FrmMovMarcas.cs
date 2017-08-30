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
    partial class FrmMovMarcas : Negocio.Net.Integracao.FrmBaseMovimentacao
    {
        public FrmMovMarcas()
        {
            InitializeComponent();
            TypeDados = typeof(Marca);
            TypeEdicao = typeof(FrmEdiMarcas);
        }

        protected override void Consultar()
        {
            try
            {
                using (MarcaDataSet dataset = new MarcaDataSet())
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
                        IEnumerable<Marca> consulta = dataset.ConsultaNoTracking(null).ToList();
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
            using (MarcaDataSet dataset = new MarcaDataSet())
            {
                try
                {
                    dataset.Excluir(String.Format("COD_MARCA == {0} ", ((Marca)grid.GetFocusedRow()).COD_MARCA));
                }
                catch (Exception ex)
                {
                    Funcoes.ExibirExcessao(ex);
                }
            }
        }
    }
}
