namespace Negocio.Net.Integracao
{
    partial class FrmBaseEdicao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelBotoes = new DevExpress.XtraEditors.PanelControl();
            this.btnConfirmar = new DevExpress.XtraEditors.SimpleButton();
            this.btnFechar = new DevExpress.XtraEditors.SimpleButton();
            this.panelFormulario = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelBotoes)).BeginInit();
            this.panelBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelFormulario)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBotoes
            // 
            this.panelBotoes.Controls.Add(this.btnConfirmar);
            this.panelBotoes.Controls.Add(this.btnFechar);
            this.panelBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotoes.Location = new System.Drawing.Point(0, 125);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new System.Drawing.Size(477, 49);
            this.panelBotoes.TabIndex = 0;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmar.Location = new System.Drawing.Point(254, 5);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(106, 39);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Location = new System.Drawing.Point(366, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(106, 39);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            this.btnFechar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnFechar_KeyDown);
            // 
            // panelFormulario
            // 
            this.panelFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormulario.Location = new System.Drawing.Point(0, 0);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(477, 125);
            this.panelFormulario.TabIndex = 1;
            // 
            // FrmBaseEdicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 174);
            this.Controls.Add(this.panelFormulario);
            this.Controls.Add(this.panelBotoes);
            this.Name = "FrmBaseEdicao";
            this.ShowInTaskbar = false;
            this.Text = "FrmBase";
            this.Shown += new System.EventHandler(this.FrmBaseEdicao_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.panelBotoes)).EndInit();
            this.panelBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelFormulario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelBotoes;
        private DevExpress.XtraEditors.SimpleButton btnFechar;
        protected DevExpress.XtraEditors.PanelControl panelFormulario;
        private DevExpress.XtraEditors.SimpleButton btnConfirmar;
    }
}