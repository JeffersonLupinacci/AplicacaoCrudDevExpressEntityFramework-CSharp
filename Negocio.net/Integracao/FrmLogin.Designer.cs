namespace Negocio.Net.Integracao
{
    partial class FrmLogin
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
            this.edtEmpresa = new DevExpress.XtraEditors.LookUpEdit();
            this.lblEmpresa = new DevExpress.XtraEditors.LabelControl();
            this.lblSenhaDeAcesso = new DevExpress.XtraEditors.LabelControl();
            this.lblNomeDeUsuario = new DevExpress.XtraEditors.LabelControl();
            this.edtNomeDeUsuario = new DevExpress.XtraEditors.TextEdit();
            this.edtSenhaDeAcesso = new DevExpress.XtraEditors.TextEdit();
            this.btnSair = new DevExpress.XtraEditors.SimpleButton();
            this.btnEntrar = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.edtEmpresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtNomeDeUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtSenhaDeAcesso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // edtEmpresa
            // 
            this.edtEmpresa.Location = new System.Drawing.Point(30, 251);
            this.edtEmpresa.Name = "edtEmpresa";
            this.edtEmpresa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edtEmpresa.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOME", "Empresa")});
            this.edtEmpresa.Properties.DisplayMember = "NOME";
            this.edtEmpresa.Properties.NullText = "";
            this.edtEmpresa.Size = new System.Drawing.Size(202, 20);
            this.edtEmpresa.TabIndex = 2;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpresa.Location = new System.Drawing.Point(30, 231);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(51, 13);
            this.lblEmpresa.TabIndex = 7;
            this.lblEmpresa.Text = "lblEmpresa";
            // 
            // lblSenhaDeAcesso
            // 
            this.lblSenhaDeAcesso.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblSenhaDeAcesso.Location = new System.Drawing.Point(30, 186);
            this.lblSenhaDeAcesso.Name = "lblSenhaDeAcesso";
            this.lblSenhaDeAcesso.Size = new System.Drawing.Size(87, 13);
            this.lblSenhaDeAcesso.TabIndex = 6;
            this.lblSenhaDeAcesso.Text = "lblSenhaDeAcesso";
            // 
            // lblNomeDeUsuario
            // 
            this.lblNomeDeUsuario.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeDeUsuario.Location = new System.Drawing.Point(30, 141);
            this.lblNomeDeUsuario.Name = "lblNomeDeUsuario";
            this.lblNomeDeUsuario.Size = new System.Drawing.Size(86, 13);
            this.lblNomeDeUsuario.TabIndex = 5;
            this.lblNomeDeUsuario.Text = "lblNomeDeUsuario";
            // 
            // edtNomeDeUsuario
            // 
            this.edtNomeDeUsuario.Location = new System.Drawing.Point(30, 160);
            this.edtNomeDeUsuario.Name = "edtNomeDeUsuario";
            this.edtNomeDeUsuario.Size = new System.Drawing.Size(202, 20);
            this.edtNomeDeUsuario.TabIndex = 0;
            // 
            // edtSenhaDeAcesso
            // 
            this.edtSenhaDeAcesso.EditValue = "";
            this.edtSenhaDeAcesso.Location = new System.Drawing.Point(30, 205);
            this.edtSenhaDeAcesso.Name = "edtSenhaDeAcesso";
            this.edtSenhaDeAcesso.Size = new System.Drawing.Size(202, 20);
            this.edtSenhaDeAcesso.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(134, 289);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(98, 39);
            this.btnSair.TabIndex = 4;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(28, 289);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(98, 39);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Negocio.Net.Properties.Resources.background;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 370);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 370);
            this.ControlBox = false;
            this.Controls.Add(this.edtEmpresa);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.lblSenhaDeAcesso);
            this.Controls.Add(this.lblNomeDeUsuario);
            this.Controls.Add(this.edtNomeDeUsuario);
            this.Controls.Add(this.edtSenhaDeAcesso);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.Shown += new System.EventHandler(this.FrmLogin_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.edtEmpresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtNomeDeUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtSenhaDeAcesso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnEntrar;
        private DevExpress.XtraEditors.SimpleButton btnSair;
        private DevExpress.XtraEditors.TextEdit edtSenhaDeAcesso;
        private DevExpress.XtraEditors.TextEdit edtNomeDeUsuario;
        private DevExpress.XtraEditors.LabelControl lblNomeDeUsuario;
        private DevExpress.XtraEditors.LabelControl lblSenhaDeAcesso;
        private DevExpress.XtraEditors.LabelControl lblEmpresa;
        private DevExpress.XtraEditors.LookUpEdit edtEmpresa;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}