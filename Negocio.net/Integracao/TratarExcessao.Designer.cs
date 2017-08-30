namespace Negocio.Net.Integracao
{
    partial class TratarExcessao
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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.grid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.meAlerta = new DevExpress.XtraEditors.MemoEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.checkFullException = new DevExpress.XtraEditors.CheckEdit();
            this.btnFechar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meAlerta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkFullException.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl);
            this.panelControl2.Controls.Add(this.meAlerta);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(512, 151);
            this.panelControl2.TabIndex = 3;
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.gridControl.Location = new System.Drawing.Point(2, 2);
            this.gridControl.MainView = this.grid;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(508, 147);
            this.gridControl.TabIndex = 2;
            this.gridControl.UseEmbeddedNavigator = true;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grid});
            // 
            // grid
            // 
            this.grid.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grid.Appearance.FocusedRow.Options.UseFont = true;
            this.grid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
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
            this.grid.OptionsView.ShowColumnHeaders = false;
            this.grid.OptionsView.ShowDetailButtons = false;
            this.grid.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.grid.OptionsView.ShowGroupPanel = false;
            this.grid.DoubleClick += new System.EventHandler(this.grid_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumnMensagem";
            this.gridColumn1.FieldName = "Mensagem";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // meAlerta
            // 
            this.meAlerta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meAlerta.Location = new System.Drawing.Point(2, 2);
            this.meAlerta.Name = "meAlerta";
            this.meAlerta.Size = new System.Drawing.Size(508, 147);
            this.meAlerta.TabIndex = 0;
            this.meAlerta.UseOptimizedRendering = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.checkFullException);
            this.panelControl1.Controls.Add(this.btnFechar);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 151);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(512, 52);
            this.panelControl1.TabIndex = 2;
            // 
            // checkFullException
            // 
            this.checkFullException.Location = new System.Drawing.Point(5, 6);
            this.checkFullException.Name = "checkFullException";
            this.checkFullException.Properties.Caption = "Exibir rastreamento da excessão.";
            this.checkFullException.Size = new System.Drawing.Size(241, 19);
            this.checkFullException.TabIndex = 1;
            this.checkFullException.Click += new System.EventHandler(this.checkFullException_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Location = new System.Drawing.Point(417, 6);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(88, 39);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // TratarExcessao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(512, 203);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name = "TratarExcessao";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Shown += new System.EventHandler(this.TratarExcessao_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meAlerta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkFullException.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.MemoEdit meAlerta;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnFechar;
        private DevExpress.XtraEditors.CheckEdit checkFullException;
        protected DevExpress.XtraGrid.GridControl gridControl;
        protected DevExpress.XtraGrid.Views.Grid.GridView grid;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;

    }
}
