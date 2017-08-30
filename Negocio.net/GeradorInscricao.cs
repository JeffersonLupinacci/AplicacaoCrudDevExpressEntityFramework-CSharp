using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Net
{

    class GeradorInscricao
    {
        [DllImport("DllInscE32.dll")]
        public static extern int ConsisteInscricaoEstadual(string vInsc, string vUF);

        private List<string> Validos = new List<string>();

        public GeradorInscricao() {
            var Codigo = "";
            for (int i = 0; i < 1; i++)
            {
                Codigo = i.ToString("D9");
                if (ConsisteInscricaoEstadual(Codigo, "ES") == 1) {
                    Validos.Add(Codigo);
                }
            }
        }    
    }
}
