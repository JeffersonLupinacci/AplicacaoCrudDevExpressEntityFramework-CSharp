using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio.Net.Integracao
{
    public partial class FrmBase : Form
    {
        public FrmBase()
        {
            InitializeComponent();                                
            // Alterar o Pressionar do enter por Tab
            this.KeyPreview = true;
            this.KeyPress += SimularTabPorEnter;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
       
        // Simular o Tab ao executar o Enter
        private void SimularTabPorEnter(object sender, KeyPressEventArgs e)
        {
            if (0 == (e.KeyChar.CompareTo((char)Keys.Return))){
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
    }
}
