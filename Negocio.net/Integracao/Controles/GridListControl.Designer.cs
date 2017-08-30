namespace Negocio.Net.Integracao
{
    partial class GridListControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.grid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnConfirmar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemover = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdicionar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.MainView = this.grid;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(530, 141);
            this.gridControl.TabIndex = 25;
            this.gridControl.UseEmbeddedNavigator = true;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grid});
            // 
            // grid
            // 
            this.grid.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grid.Appearance.FocusedRow.Options.UseFont = true;
            this.grid.GridControl = this.gridControl;
            this.grid.Name = "grid";
            this.grid.OptionsBehavior.Editable = false;
            this.grid.OptionsCustomization.AllowColumnMoving = false;
            this.grid.OptionsCustomization.AllowColumnResizing = false;
            this.grid.OptionsCustomization.AllowFilter = false;
            this.grid.OptionsCustomization.AllowGroup = false;
            this.grid.OptionsCustomization.AllowQuickHideColumns = false;
            this.grid.OptionsFilter.AllowColumnMRUFilterList = false;
            this.grid.OptionsFilter.AllowFilterEditor = false;
            this.grid.OptionsFilter.AllowFilterIncrementalSearch = false;
            this.grid.OptionsFilter.AllowMRUFilterList = false;
            this.grid.OptionsFilter.AllowMultiSelectInCheckedFilterPopup = false;
            this.grid.OptionsFilter.ShowAllTableValuesInCheckedFilterPopup = false;
            this.grid.OptionsFind.AllowFindPanel = false;
            this.grid.OptionsFind.ShowClearButton = false;
            this.grid.OptionsFind.ShowCloseButton = false;
            this.grid.OptionsFind.ShowFindButton = false;
            this.grid.OptionsMenu.EnableColumnMenu = false;
            this.grid.OptionsMenu.EnableFooterMenu = false;
            this.grid.OptionsMenu.EnableGroupPanelMenu = false;
            this.grid.OptionsMenu.ShowAutoFilterRowItem = false;
            this.grid.OptionsMenu.ShowDateTimeGroupIntervalItems = false;
            this.grid.OptionsMenu.ShowGroupSortSummaryItems = false;
            this.grid.OptionsMenu.ShowSplitItem = false;
            this.grid.OptionsView.ShowDetailButtons = false;
            this.grid.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.grid.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.btnConfirmar);
            this.panelControl1.Controls.Add(this.btnCancelar);
            this.panelControl1.Controls.Add(this.btnRemover);
            this.panelControl1.Controls.Add(this.btnEditar);
            this.panelControl1.Controls.Add(this.btnAdicionar);
            this.panelControl1.Location = new System.Drawing.Point(0, 147);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(530, 34);
            this.panelControl1.TabIndex = 31;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfirmar.Location = new System.Drawing.Point(329, 5);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 24);
            this.btnConfirmar.TabIndex = 35;
            this.btnConfirmar.Text = "C&onfirmar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.Location = new System.Drawing.Point(167, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 24);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "Can&celar";
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemover.Location = new System.Drawing.Point(248, 5);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 24);
            this.btnRemover.TabIndex = 33;
            this.btnRemover.Text = "&Remover";
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.Location = new System.Drawing.Point(86, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 24);
            this.btnEditar.TabIndex = 32;
            this.btnEditar.Text = "&Editar";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdicionar.Location = new System.Drawing.Point(5, 5);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 24);
            this.btnAdicionar.TabIndex = 31;
            this.btnAdicionar.Text = "&Adicionar";
            // 
            // GridListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControl);
            this.Name = "GridListControl";
            this.Size = new System.Drawing.Size(530, 184);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraGrid.GridControl gridControl;
        protected DevExpress.XtraGrid.Views.Grid.GridView grid;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnConfirmar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnRemover;
        private DevExpress.XtraEditors.SimpleButton btnEditar;
        private DevExpress.XtraEditors.SimpleButton btnAdicionar;
    }
}
