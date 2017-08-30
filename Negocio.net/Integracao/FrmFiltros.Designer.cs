namespace Negocio.Net.Integracao
{
    partial class FrmFiltros
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnConfirmar = new DevExpress.XtraEditors.SimpleButton();
            this.btnFechar = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.label_remove_01 = new DevExpress.XtraEditors.LabelControl();
            this.label_e_ou_01 = new DevExpress.XtraEditors.LabelControl();
            this.labelFiltros = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.filtro_01 = new Negocio.Net.Integracao.FiltroControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnConfirmar);
            this.panelControl1.Controls.Add(this.btnFechar);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 84);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(517, 49);
            this.panelControl1.TabIndex = 6;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(292, 5);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(106, 39);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(404, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(106, 39);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.label_remove_01);
            this.panelControl2.Controls.Add(this.label_e_ou_01);
            this.panelControl2.Controls.Add(this.labelFiltros);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.filtro_01);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(517, 84);
            this.panelControl2.TabIndex = 7;
            // 
            // label_remove_01
            // 
            this.label_remove_01.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline);
            this.label_remove_01.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.label_remove_01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_remove_01.Location = new System.Drawing.Point(488, 31);
            this.label_remove_01.Name = "label_remove_01";
            this.label_remove_01.Size = new System.Drawing.Size(12, 13);
            this.label_remove_01.TabIndex = 14;
            this.label_remove_01.Text = "[-]";
            this.label_remove_01.Visible = false;
            // 
            // label_e_ou_01
            // 
            this.label_e_ou_01.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline);
            this.label_e_ou_01.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.label_e_ou_01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_e_ou_01.Location = new System.Drawing.Point(487, 31);
            this.label_e_ou_01.Name = "label_e_ou_01";
            this.label_e_ou_01.Size = new System.Drawing.Size(14, 13);
            this.label_e_ou_01.TabIndex = 13;
            this.label_e_ou_01.Text = "[E]";
            this.label_e_ou_01.Visible = false;
            this.label_e_ou_01.Click += new System.EventHandler(this.label_e_ou_Click);
            // 
            // labelFiltros
            // 
            this.labelFiltros.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline);
            this.labelFiltros.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelFiltros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelFiltros.Location = new System.Drawing.Point(13, 56);
            this.labelFiltros.Name = "labelFiltros";
            this.labelFiltros.Size = new System.Drawing.Size(122, 13);
            this.labelFiltros.TabIndex = 10;
            this.labelFiltros.Text = "[+] Filtros personalizados";
            this.labelFiltros.Click += new System.EventHandler(this.labelControl4_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl3.Location = new System.Drawing.Point(205, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 13);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Parametros";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl2.Location = new System.Drawing.Point(127, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Critério";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl1.Location = new System.Drawing.Point(13, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Coluna";
            // 
            // filtro_01
            // 
            this.filtro_01.Location = new System.Drawing.Point(9, 26);
            this.filtro_01.Name = "filtro_01";
            this.filtro_01.Size = new System.Drawing.Size(473, 24);
            this.filtro_01.TabIndex = 6;
            // 
            // FrmFiltros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(517, 133);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmFiltros";
            this.Text = "Filtros Personalizados";
            this.Shown += new System.EventHandler(this.FrmFiltros_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnConfirmar;
        private DevExpress.XtraEditors.SimpleButton btnFechar;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private FiltroControl filtro_01;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelFiltros;
        private DevExpress.XtraEditors.LabelControl label_e_ou_01;
        private DevExpress.XtraEditors.LabelControl label_remove_01;
    }
}
