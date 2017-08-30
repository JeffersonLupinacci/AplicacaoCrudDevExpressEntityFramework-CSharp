using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Net.Dominio.Poco
{    
    public class EmpresaAtiva
    {
        [PersonalizarColuna(Caption="Código")]
        public virtual int COD { get; set; }

        [PersonalizarColuna(Caption="Nome da Empresa")]
        public virtual String NOME { get; set; }
    }
}
