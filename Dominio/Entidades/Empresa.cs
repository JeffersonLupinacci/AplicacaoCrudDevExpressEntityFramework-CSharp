using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Net.Dominio.Entidades
{
    public class Empresa 
    {
        public virtual int COD_EMPRESA { get; set; }
        public virtual String RAZAOSOCIAL { get; set; }
        public virtual String NOMEFANTASIA { get; set; }
        public virtual bool INATIVO { get; set; }
        
    }
}
