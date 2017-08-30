using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Negocio.Net.Integracao
{
    public class Validacao
    {
        public String Mensagem { get; set; }
        public Control Controle { get; set; }
        public Validacao(String Mensagem, Control Controle) {
            this.Controle = Controle;
            this.Mensagem = Mensagem;
        }
    }
}
