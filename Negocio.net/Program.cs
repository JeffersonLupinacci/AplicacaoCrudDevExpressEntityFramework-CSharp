using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio.Net
{

    static class Program
    {
        public static Integracao.FrmRecursosVisuais Recursos;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Inicialização dos Recursos Compartilhaveis
            Recursos = new Integracao.FrmRecursosVisuais();

            // Inicializando o Formulario de Integração
            Application.Run(new Integracao.FrmInicializacao());

            // Liberando Memória
            if (null != Recursos)
                Recursos.Dispose();
        }
    }
}
