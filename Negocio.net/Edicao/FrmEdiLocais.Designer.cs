namespace Negocio.Net.Edicao
{
    partial class FrmEdiLocais
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.edDescriao = new DevExpress.XtraEditors.TextEdit();
            this.lblDescricao = new DevExpress.XtraEditors.LabelControl();
            this.lblCodigo = new DevExpress.XtraEditors.LabelControl();
            this.edCodigo = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelFormulario)).BeginInit();
            this.panelFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edDescriao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edCodigo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFormulario
            // 
            this.panelFormulario.Controls.Add(this.edDescriao);
            this.panelFormulario.Controls.Add(this.lblDescricao);
            this.panelFormulario.Controls.Add(this.lblCodigo);
            this.panelFormulario.Controls.Add(this.edCodigo);
            this.panelFormulario.Size = new System.Drawing.Size(462, 80);
            // 
            // edDescriao
            // 
            this.edDescriao.Location = new System.Drawing.Point(74, 46);
            this.edDescriao.Name = "edDescriao";
            this.edDescriao.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.edDescriao.Properties.Appearance.Options.UseBackColor = true;
            this.edDescriao.Size = new System.Drawing.Size(367, 20);
            this.edDescriao.TabIndex = 19;
            // 
            // lblDescricao
            // 
            this.lblDescricao.Location = new System.Drawing.Point(14, 49);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(46, 13);
            this.lblDescricao.TabIndex = 18;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(14, 23);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(33, 13);
            this.lblCodigo.TabIndex = 17;
            this.lblCodigo.Text = "Código";
            // 
            // edCodigo
            // 
            this.edCodigo.Enabled = false;
            this.edCodigo.Location = new System.Drawing.Point(74, 20);
            this.edCodigo.Name = "edCodigo";
            this.edCodigo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.edCodigo.Properties.Appearance.Options.UseBackColor = true;
            this.edCodigo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.edCodigo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.edCodigo.Size = new System.Drawing.Size(100, 20);
            this.edCodigo.TabIndex = 16;
            // 
            // FrmEdiLocais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(462, 129);
            this.Name = "FrmEdiLocais";
            this.Shown += new System.EventHandler(this.FrmEdiLocais_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.panelFormulario)).EndInit();
            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edDescriao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edCodigo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit edDescriao;
        private DevExpress.XtraEditors.LabelControl lblDescricao;
        private DevExpress.XtraEditors.LabelControl lblCodigo;
        private DevExpress.XtraEditors.TextEdit edCodigo;
    }
}
