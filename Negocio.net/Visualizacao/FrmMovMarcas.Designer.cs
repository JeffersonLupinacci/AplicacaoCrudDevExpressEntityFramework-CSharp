namespace Negocio.Net.Visualizacao
{
    partial class FrmMovMarcas
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
            this.components = new System.ComponentModel.Container();
            ((System.ComponentModel.ISupportInitialize)(this.Dados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.gridControl.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gridControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gridControl.EmbeddedNavigator.Buttons.EnabledAutoRepeat = false;
            this.gridControl.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.gridControl.EmbeddedNavigator.Buttons.Remove.Visible = false;
            // 
            // grid
            // 
            this.grid.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grid.Appearance.FocusedRow.Options.UseFont = true;
            this.grid.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grid.OptionsBehavior.Editable = false;
            this.grid.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // progresso
            // 
            this.progresso.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progresso.Appearance.Options.UseBackColor = true;
            this.progresso.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progresso.AppearanceCaption.Options.UseFont = true;
            this.progresso.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.progresso.AppearanceDescription.Options.UseFont = true;
            this.progresso.Location = new System.Drawing.Point(124, 264);
            this.progresso.UseWaitCursor = false;
            // 
            // FrmMovMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(804, 599);
            this.Name = "FrmMovMarcas";
            ((System.ComponentModel.ISupportInitialize)(this.Dados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
