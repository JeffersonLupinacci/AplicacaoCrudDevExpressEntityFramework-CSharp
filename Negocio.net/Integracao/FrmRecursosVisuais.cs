using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio.Net.Integracao
{
    public partial class FrmRecursosVisuais : Form
    {

        public Icon AppIcon {
            get { return this.Icon; }
        }

        public Image Icone(string resourceName)
        {
            if (null != this.IconesCompartilhados.ImageSource)
                return this.IconesCompartilhados.ImageSource.Images[resourceName];
            else
                return null;
        }

        public int IconeIndex(string resourceName) {
            return this.IconesCompartilhados.ImageSource.Images.Keys.IndexOf(resourceName);            
        }

        public FrmRecursosVisuais()
        {
            InitializeComponent();
        }
    }
}
