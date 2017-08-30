namespace Negocio.Net.Integracao
{
    partial class FrmInicializacao
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
            this.progresso = new DevExpress.XtraEditors.ProgressBarControl();
            this.lblProgresso = new DevExpress.XtraEditors.LabelControl();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.progresso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // progresso
            // 
            this.progresso.Location = new System.Drawing.Point(68, 31);
            this.progresso.Name = "progresso";
            this.progresso.Size = new System.Drawing.Size(358, 18);
            this.progresso.TabIndex = 0;
            // 
            // lblProgresso
            // 
            this.lblProgresso.Location = new System.Drawing.Point(68, 12);
            this.lblProgresso.Name = "lblProgresso";
            this.lblProgresso.Size = new System.Drawing.Size(0, 13);
            this.lblProgresso.TabIndex = 1;
            // 
            // logo
            // 
            this.logo.Location = new System.Drawing.Point(3, 4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(59, 50);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            // 
            // FrmInicializacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 59);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.lblProgresso);
            this.Controls.Add(this.progresso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmInicializacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmInicializacao_FormClosing);
            this.Shown += new System.EventHandler(this.FrmInicializacao_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.progresso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ProgressBarControl progresso;
        private DevExpress.XtraEditors.LabelControl lblProgresso;
        private System.Windows.Forms.PictureBox logo;

    }
}

