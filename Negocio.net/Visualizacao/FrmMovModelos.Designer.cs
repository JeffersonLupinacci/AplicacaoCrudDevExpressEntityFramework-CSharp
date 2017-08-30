namespace Negocio.Net.Visualizacao
{
    partial class FrmMovModelos
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
            ((System.ComponentModel.ISupportInitialize)(this.Dados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();            
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.Dados;
            this.gridControl.Size = new System.Drawing.Size(515, 308);
            // 
            // grid
            // 
            this.grid.OptionsBehavior.Editable = false;
            this.grid.OptionsBehavior.ReadOnly = true;
            this.grid.OptionsCustomization.AllowFilter = false;
            this.grid.OptionsPrint.EnableAppearanceEvenRow = true;
            // 
            // progresso
            // 
            this.progresso.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progresso.Appearance.Options.UseBackColor = true;
            this.progresso.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progresso.AppearanceCaption.Options.UseFont = true;
            this.progresso.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.progresso.AppearanceDescription.Options.UseFont = true;
            this.progresso.Location = new System.Drawing.Point(71, 135);            
            // 
            // FrmMovModelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(698, 342);
            this.Name = "FrmMovModelos";
            ((System.ComponentModel.ISupportInitialize)(this.Dados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();            
            this.ResumeLayout(false);

        }

        #endregion
    }
}
