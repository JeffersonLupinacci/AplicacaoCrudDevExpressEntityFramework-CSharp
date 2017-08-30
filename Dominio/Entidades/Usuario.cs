using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Net.Dominio.Entidades
{
    public class Usuario
    {
        public virtual int COD { get; set; }
        public virtual String NOME { get; set; }
        public virtual String LOGIN { get; set; }
        public virtual String SENHA { get; set; }
        public virtual bool INATIVO { get; set; }
        public virtual bool ADMINISTRADOR { get; set; }
    }
}
