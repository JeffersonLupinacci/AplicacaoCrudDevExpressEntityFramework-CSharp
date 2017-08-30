using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Net.Integracao
{
    public class Filtro
    {
        public string Campo { get; set; }
        public TypeCode Tipo { get; set; }
        public string Criterio { get; set; }
        public string ParametroInicial { get; set; }
        public string ParametroFinal { get; set; }
    }
}
