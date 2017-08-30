using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Net.Dominio.Entidades
{
    public class UsuarioToolbar
    {
        public virtual int COD { get; set; }
        public virtual int COD_USUARIO { get; set; }
        public virtual int COD_EMPRESA { get; set; }
        public virtual String BOTAO { get; set; }        
    }
}
