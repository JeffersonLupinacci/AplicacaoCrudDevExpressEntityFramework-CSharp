using Negocio.Net.Dominio.Entidades;
using Negocio.Net.Dominio.Poco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Net.Dominio
{

    public class EmpresaDataSet : IDisposable
    {
        private Contexto contexto;

        public EmpresaDataSet() {
            contexto = new Contexto(Constantes.NomeDaConexao);
        }

        public IQueryable<Empresa> AsQueryable() {
            return contexto.Empresas.AsQueryable();
        }

        public IList<EmpresaAtiva> EmpresasAtivas()
        {
            return contexto.Database.SqlQuery<EmpresaAtiva>(Consultas.sqlEmpresasAtivas)
                    .ToList();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

    }
}
