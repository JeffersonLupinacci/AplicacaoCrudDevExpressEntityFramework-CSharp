namespace Negocio.Net.Edicao
{
    partial class FrmEdiUnidades
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkInativo = new DevExpress.XtraEditors.CheckEdit();
            this.edSigla = new DevExpress.XtraEditors.TextEdit();
            this.lblSigla = new DevExpress.XtraEditors.LabelControl();
            this.edDescriao = new DevExpress.XtraEditors.TextEdit();
            this.lblDescricao = new DevExpress.XtraEditors.LabelControl();
            this.lblCodigo = new DevExpress.XtraEditors.LabelControl();
            this.edCodigo = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gridListUnidades = new Negocio.Net.Integracao.GridListControl();
            this.edFatorConversao = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.edSiglaConversao = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.edDescricaoConversao = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelFormulario)).BeginInit();
            this.panelFormulario.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkInativo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSigla.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDescriao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edFatorConversao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSiglaConversao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDescricaoConversao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFormulario
            // 
            this.panelFormulario.Controls.Add(this.groupBox1);
            this.panelFormulario.Controls.Add(this.xtraTabControl1);
            this.panelFormulario.Size = new System.Drawing.Size(574, 353);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkInativo);
            this.groupBox1.Controls.Add(this.edSigla);
            this.groupBox1.Controls.Add(this.lblSigla);
            this.groupBox1.Controls.Add(this.edDescriao);
            this.groupBox1.Controls.Add(this.lblDescricao);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.edCodigo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 79);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unidade Padrão";
            // 
            // chkInativo
            // 
            this.chkInativo.Location = new System.Drawing.Point(468, 19);
            this.chkInativo.Name = "chkInativo";
            this.chkInativo.Properties.Caption = "Inativo";
            this.chkInativo.Size = new System.Drawing.Size(75, 19);
            this.chkInativo.TabIndex = 13;
            // 
            // edSigla
            // 
            this.edSigla.EditValue = "";
            this.edSigla.Location = new System.Drawing.Point(486, 45);
            this.edSigla.Name = "edSigla";
            this.edSigla.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.edSigla.Properties.Appearance.Options.UseBackColor = true;
            this.edSigla.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edSigla.Properties.MaxLength = 3;
            this.edSigla.Size = new System.Drawing.Size(57, 20);
            this.edSigla.TabIndex = 12;
            // 
            // lblSigla
            // 
            this.lblSigla.Location = new System.Drawing.Point(454, 48);
            this.lblSigla.Name = "lblSigla";
            this.lblSigla.Size = new System.Drawing.Size(22, 13);
            this.lblSigla.TabIndex = 11;
            this.lblSigla.Text = "Sigla";
            // 
            // edDescriao
            // 
            this.edDescriao.Location = new System.Drawing.Point(72, 45);
            this.edDescriao.Name = "edDescriao";
            this.edDescriao.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.edDescriao.Properties.Appearance.Options.UseBackColor = true;
            this.edDescriao.Size = new System.Drawing.Size(367, 20);
            this.edDescriao.TabIndex = 10;
            // 
            // lblDescricao
            // 
            this.lblDescricao.Location = new System.Drawing.Point(12, 48);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(46, 13);
            this.lblDescricao.TabIndex = 9;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(12, 22);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(33, 13);
            this.lblCodigo.TabIndex = 8;
            this.lblCodigo.Text = "Código";
            // 
            // edCodigo
            // 
            this.edCodigo.Enabled = false;
            this.edCodigo.Location = new System.Drawing.Point(72, 19);
            this.edCodigo.Name = "edCodigo";
            this.edCodigo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.edCodigo.Properties.Appearance.Options.UseBackColor = true;
            this.edCodigo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.edCodigo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.edCodigo.Size = new System.Drawing.Size(100, 20);
            this.edCodigo.TabIndex = 7;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 97);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.PageImagePosition = DevExpress.XtraTab.TabPageImagePosition.None;
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabControl1.Size = new System.Drawing.Size(556, 250);
            this.xtraTabControl1.TabIndex = 20;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gridListUnidades);
            this.xtraTabPage2.Controls.Add(this.edFatorConversao);
            this.xtraTabPage2.Controls.Add(this.labelControl3);
            this.xtraTabPage2.Controls.Add(this.edSiglaConversao);
            this.xtraTabPage2.Controls.Add(this.labelControl1);
            this.xtraTabPage2.Controls.Add(this.edDescricaoConversao);
            this.xtraTabPage2.Controls.Add(this.labelControl2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(550, 222);
            this.xtraTabPage2.Text = "Unidades de Conversão";
            // 
            // gridListUnidades
            // 
            this.gridListUnidades.ColunasVisiveis = null;
            this.gridListUnidades.Componentes = null;
            this.gridListUnidades.DataSource = null;
            this.gridListUnidades.Location = new System.Drawing.Point(9, 66);
            this.gridListUnidades.Name = "gridListUnidades";
            this.gridListUnidades.Size = new System.Drawing.Size(533, 151);
            this.gridListUnidades.TabIndex = 26;
            this.gridListUnidades.TypeDados = null;
            // 
            // edFatorConversao
            // 
            this.edFatorConversao.EditValue = "";
            this.edFatorConversao.Location = new System.Drawing.Point(113, 39);
            this.edFatorConversao.Name = "edFatorConversao";
            this.edFatorConversao.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.edFatorConversao.Properties.Appearance.Options.UseBackColor = true;
            this.edFatorConversao.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edFatorConversao.Properties.Mask.BeepOnError = true;
            this.edFatorConversao.Properties.Mask.EditMask = "####,0.0000";
            this.edFatorConversao.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.edFatorConversao.Properties.Mask.PlaceHolder = ' ';
            this.edFatorConversao.Properties.Mask.SaveLiteral = false;
            this.edFatorConversao.Size = new System.Drawing.Size(80, 20);
            this.edFatorConversao.TabIndex = 25;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(9, 42);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(96, 13);
            this.labelControl3.TabIndex = 24;
            this.labelControl3.Text = "Fator de Conversão";
            // 
            // edSiglaConversao
            // 
            this.edSiglaConversao.EditValue = "";
            this.edSiglaConversao.Location = new System.Drawing.Point(485, 12);
            this.edSiglaConversao.Name = "edSiglaConversao";
            this.edSiglaConversao.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.edSiglaConversao.Properties.Appearance.Options.UseBackColor = true;
            this.edSiglaConversao.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edSiglaConversao.Properties.MaxLength = 3;
            this.edSiglaConversao.Size = new System.Drawing.Size(57, 20);
            this.edSiglaConversao.TabIndex = 23;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(453, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(22, 13);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "Sigla";
            // 
            // edDescricaoConversao
            // 
            this.edDescricaoConversao.Location = new System.Drawing.Point(68, 12);
            this.edDescricaoConversao.Name = "edDescricaoConversao";
            this.edDescricaoConversao.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.edDescricaoConversao.Properties.Appearance.Options.UseBackColor = true;
            this.edDescricaoConversao.Size = new System.Drawing.Size(367, 20);
            this.edDescricaoConversao.TabIndex = 21;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(9, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 20;
            this.labelControl2.Text = "Descrição";
            // 
            // FrmEdiUnidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(574, 402);
            this.Name = "FrmEdiUnidades";
            this.Shown += new System.EventHandler(this.FrmEdiUnidades_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.panelFormulario)).EndInit();
            this.panelFormulario.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkInativo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSigla.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDescriao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edFatorConversao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSiglaConversao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDescricaoConversao.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.CheckEdit chkInativo;
        private DevExpress.XtraEditors.TextEdit edSigla;
        private DevExpress.XtraEditors.LabelControl lblSigla;
        private DevExpress.XtraEditors.TextEdit edDescriao;
        private DevExpress.XtraEditors.LabelControl lblDescricao;
        private DevExpress.XtraEditors.LabelControl lblCodigo;
        private DevExpress.XtraEditors.TextEdit edCodigo;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private Integracao.GridListControl gridListUnidades;
        private DevExpress.XtraEditors.TextEdit edFatorConversao;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit edSiglaConversao;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit edDescricaoConversao;
        private DevExpress.XtraEditors.LabelControl labelControl2;

    }
}
