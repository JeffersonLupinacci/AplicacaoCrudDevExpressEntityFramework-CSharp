using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio.Net.Integracao
{
    public class Campo
    {
        public virtual Type FieldType { get; set; }
        public virtual String FieldName { get; set; }
        public virtual String Caption { get; set; }
        public virtual Boolean Visible { get; set; }
        public virtual Boolean ExibirNoCustomizador { get; set; }
    }

}
