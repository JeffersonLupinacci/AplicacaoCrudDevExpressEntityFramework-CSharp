namespace Negocio.Net.Integracao
{
    partial class FiltroControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.edDataIni = new DevExpress.XtraEditors.DateEdit();
            this.edDataFim = new DevExpress.XtraEditors.DateEdit();
            this.edCampos = new DevExpress.XtraEditors.LookUpEdit();
            this.edTipo = new DevExpress.XtraEditors.LookUpEdit();
            this.lblAte = new DevExpress.XtraEditors.LabelControl();
            this.edTexto = new DevExpress.XtraEditors.TextEdit();
            this.edNumericoIni = new DevExpress.XtraEditors.CalcEdit();
            this.edNumericoFim = new DevExpress.XtraEditors.CalcEdit();
            this.edInteiroIni = new DevExpress.XtraEditors.TextEdit();
            this.edInteiroFim = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.edDataIni.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDataIni.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDataFim.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDataFim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edCampos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edTexto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edNumericoIni.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edNumericoFim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edInteiroIni.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edInteiroFim.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // edDataIni
            // 
            this.edDataIni.EditValue = null;
            this.edDataIni.Location = new System.Drawing.Point(193, 2);
            this.edDataIni.Name = "edDataIni";
            this.edDataIni.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edDataIni.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edDataIni.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.edDataIni.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.edDataIni.Size = new System.Drawing.Size(100, 20);
            this.edDataIni.TabIndex = 3;
            this.edDataIni.Leave += new System.EventHandler(this.edDataIni_Leave);
            // 
            // edDataFim
            // 
            this.edDataFim.EditValue = null;
            this.edDataFim.Location = new System.Drawing.Point(321, 2);
            this.edDataFim.Name = "edDataFim";
            this.edDataFim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edDataFim.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edDataFim.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.edDataFim.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.edDataFim.Size = new System.Drawing.Size(100, 20);
            this.edDataFim.TabIndex = 4;
            // 
            // edCampos
            // 
            this.edCampos.Location = new System.Drawing.Point(1, 2);
            this.edCampos.Name = "edCampos";
            this.edCampos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edCampos.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Caption", "Coluna")});
            this.edCampos.Properties.DisplayMember = "Caption";
            this.edCampos.Properties.NullText = "";
            this.edCampos.Size = new System.Drawing.Size(110, 20);
            this.edCampos.TabIndex = 0;
            this.edCampos.EditValueChanged += new System.EventHandler(this.edCampos_EditValueChanged);
            // 
            // edTipo
            // 
            this.edTipo.Location = new System.Drawing.Point(115, 2);
            this.edTipo.Name = "edTipo";
            this.edTipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edTipo.Properties.NullText = "";
            this.edTipo.Size = new System.Drawing.Size(73, 20);
            this.edTipo.TabIndex = 1;
            this.edTipo.EditValueChanged += new System.EventHandler(this.edTipo_EditValueChanged);
            // 
            // lblAte
            // 
            this.lblAte.Location = new System.Drawing.Point(299, 5);
            this.lblAte.Name = "lblAte";
            this.lblAte.Size = new System.Drawing.Size(16, 13);
            this.lblAte.TabIndex = 4;
            this.lblAte.Text = "até";
            // 
            // edTexto
            // 
            this.edTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edTexto.Location = new System.Drawing.Point(193, 2);
            this.edTexto.Name = "edTexto";
            this.edTexto.Size = new System.Drawing.Size(277, 20);
            this.edTexto.TabIndex = 2;
            // 
            // edNumericoIni
            // 
            this.edNumericoIni.Location = new System.Drawing.Point(193, 2);
            this.edNumericoIni.Name = "edNumericoIni";
            this.edNumericoIni.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edNumericoIni.Size = new System.Drawing.Size(100, 20);
            this.edNumericoIni.TabIndex = 7;
            this.edNumericoIni.Leave += new System.EventHandler(this.edNumericoIni_Leave);
            // 
            // edNumericoFim
            // 
            this.edNumericoFim.Location = new System.Drawing.Point(321, 2);
            this.edNumericoFim.Name = "edNumericoFim";
            this.edNumericoFim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edNumericoFim.Size = new System.Drawing.Size(100, 20);
            this.edNumericoFim.TabIndex = 8;
            // 
            // edInteiroIni
            // 
            this.edInteiroIni.Location = new System.Drawing.Point(193, 2);
            this.edInteiroIni.Name = "edInteiroIni";
            this.edInteiroIni.Size = new System.Drawing.Size(100, 20);
            this.edInteiroIni.TabIndex = 5;
            this.edInteiroIni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edInteiroIni_KeyPress);
            this.edInteiroIni.Leave += new System.EventHandler(this.edInteiroIni_Leave);
            // 
            // edInteiroFim
            // 
            this.edInteiroFim.Location = new System.Drawing.Point(321, 2);
            this.edInteiroFim.Name = "edInteiroFim";
            this.edInteiroFim.Size = new System.Drawing.Size(100, 20);
            this.edInteiroFim.TabIndex = 6;
            this.edInteiroFim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edInteiroIni_KeyPress);
            // 
            // FiltroControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.edTexto);
            this.Controls.Add(this.edInteiroFim);
            this.Controls.Add(this.edNumericoFim);
            this.Controls.Add(this.lblAte);
            this.Controls.Add(this.edTipo);
            this.Controls.Add(this.edCampos);
            this.Controls.Add(this.edDataFim);
            this.Controls.Add(this.edDataIni);
            this.Controls.Add(this.edInteiroIni);
            this.Controls.Add(this.edNumericoIni);
            this.Name = "FiltroControl";
            this.Size = new System.Drawing.Size(471, 24);
            ((System.ComponentModel.ISupportInitialize)(this.edDataIni.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDataIni.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDataFim.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDataFim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edCampos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edTexto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edNumericoIni.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edNumericoFim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edInteiroIni.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edInteiroFim.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit edDataIni;
        private DevExpress.XtraEditors.DateEdit edDataFim;
        private DevExpress.XtraEditors.LookUpEdit edCampos;
        private DevExpress.XtraEditors.LookUpEdit edTipo;
        private DevExpress.XtraEditors.LabelControl lblAte;
        private DevExpress.XtraEditors.TextEdit edTexto;
        private DevExpress.XtraEditors.CalcEdit edNumericoIni;
        private DevExpress.XtraEditors.CalcEdit edNumericoFim;
        private DevExpress.XtraEditors.TextEdit edInteiroIni;
        private DevExpress.XtraEditors.TextEdit edInteiroFim;

    }
}
