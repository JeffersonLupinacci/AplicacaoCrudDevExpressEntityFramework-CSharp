using DevExpress.XtraEditors;
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
    public partial class FrmBaseEdicao : FrmBase
    {

        protected Validador Validador = new Validador();

        /// <summary>
        /// Módulo Vinculado a Tela de Edição
        /// </summary>
        protected Modulo Modulo { get { return innerModulo; } }
        private Modulo innerModulo { get; set; }

        /// <summary>
        /// Modo como o formulário deverá se comportar
        /// </summary>        
        protected ModoFormulario ModoFormulario { get { return innerModoFormulario; } }
        private ModoFormulario innerModoFormulario { get; set; }

        /// <summary>
        /// Entidade a ser manipulada por este formulário
        /// </summary>
        protected Object Entidade { get { return innerEntidade; } }
        private Object innerEntidade { get; set; }

        /// <summary>
        /// Construtor padrão
        /// </summary>
        public FrmBaseEdicao()
        {            
            InitializeComponent();
            Validador.Formulario = this;
        }

        /// <summary>
        /// Construtor da Classe de Edição
        /// </summary>
        /// <param name="ModoFormulario">Modo de Trabalho do Formulário</param>
        /// <param name="Modulo">Módulo do Formulário</param>
        /// <param name="Entidade">Entidade que deverá se manipulada pela Classe</param>
        public FrmBaseEdicao(ModoFormulario ModoFormulario, Modulo Modulo, Object Entidade)
        {
            InitializeComponent();
            Validador.Formulario = this;
            this.Icon = Program.Recursos.AppIcon;
            this.Text = Modulo.Descricao;

            if (Integracao.ModoFormulario.mfExclusao == ModoFormulario)
            {
                this.btnConfirmar.Image = Program.Recursos.Icone("btnRemover");
                this.btnConfirmar.Text = Properties.Resources.btnRemover;
                this.btnFechar.Image = Program.Recursos.Icone("btnVoltar");
                this.btnFechar.Text = Properties.Resources.btnVoltar;
            }
            else if (Integracao.ModoFormulario.mfVisualizacao == ModoFormulario)
            {
                this.btnConfirmar.Visible = false;
                this.btnFechar.Image = Program.Recursos.Icone("btnVoltar");
                this.btnFechar.Text = Properties.Resources.btnVoltar;
            }
            else
            {
                this.btnConfirmar.Image = Program.Recursos.Icone("btnConfirmar");
                this.btnConfirmar.Text = Properties.Resources.btnConfirmar;
                this.btnFechar.Image = Program.Recursos.Icone("btnFechar");
                this.btnFechar.Text = Properties.Resources.btnFechar;
            }

            this.innerModulo = Modulo;
            this.innerModoFormulario = ModoFormulario;
            this.innerEntidade = Entidade;

        }

        private void FrmBaseEdicao_Shown(object sender, EventArgs e)
        {
            if ((Integracao.ModoFormulario.mfExclusao == ModoFormulario) || (Integracao.ModoFormulario.mfVisualizacao == ModoFormulario))
            {
                /* Bloqueando os componentes do tipo TextEdit */
                var TextEdits = Funcoes.RecuperaControles(this, typeof(TextEdit));
                foreach (TextEdit c in TextEdits)
                    BloquearTextEdit(c);

                /* Bloqueando os componentes do tipo CheckEdit */
                var CheckEdits = Funcoes.RecuperaControles(this, typeof(CheckEdit));
                foreach (var c in CheckEdits) c.Enabled = false;
            }
        }

        #region Botão Fechar Formulário
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
        #endregion

        #region Botão Confirmar Formulário
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ConfirmarRegistro())
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }
        #endregion

        protected virtual Boolean ConfirmarRegistro()
        {
            try
            {
                throw new Exception("Necessário Implementar");
            }
            catch (Exception ex)
            {
                Funcoes.ExibirExcessao(ex);
            }
            return false;
        }

        protected void BloquearTextEdit(TextEdit c)
        {
            c.Enabled = false;
            c.Properties.Appearance.BackColor = System.Drawing.Color.White;
            c.Properties.Appearance.Options.UseBackColor = true;
        }

        #region Fechamento do Formulário ao Pressionar Esc no Botão Fechar
        private void btnFechar_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Escape == e.KeyCode)
                Close();
        }
        #endregion


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (null != Validador)
                Validador.Dispose();
            
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }       
    }
}
