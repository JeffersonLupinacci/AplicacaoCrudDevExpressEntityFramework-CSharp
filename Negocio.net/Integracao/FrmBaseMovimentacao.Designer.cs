namespace Negocio.Net.Integracao
{
    partial class FrmBaseMovimentacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaseMovimentacao));
            this.splitMovimentacao = new DevExpress.XtraEditors.SplitContainerControl();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navAcoes = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnInserir = new DevExpress.XtraNavBar.NavBarItem();
            this.btnEditar = new DevExpress.XtraNavBar.NavBarItem();
            this.btnRemover = new DevExpress.XtraNavBar.NavBarItem();
            this.btnVisualizar = new DevExpress.XtraNavBar.NavBarItem();
            this.Separador = new DevExpress.XtraNavBar.NavBarSeparatorItem();
            this.btnPersonalizar = new DevExpress.XtraNavBar.NavBarItem();
            this.splitGrid = new System.Windows.Forms.SplitContainer();
            this.labelRemoverFiltro = new DevExpress.XtraEditors.LabelControl();
            this.btnConsultar = new DevExpress.XtraEditors.SimpleButton();
            this.labelFiltrosPersonalizados = new DevExpress.XtraEditors.LabelControl();
            this.filtroControl1 = new Negocio.Net.Integracao.FiltroControl();
            this.progresso = new DevExpress.XtraWaitForm.ProgressPanel();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.grid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.atualizarDados = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitMovimentacao)).BeginInit();
            this.splitMovimentacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitGrid)).BeginInit();
            this.splitGrid.Panel1.SuspendLayout();
            this.splitGrid.Panel2.SuspendLayout();
            this.splitGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // splitMovimentacao
            // 
            this.splitMovimentacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMovimentacao.Location = new System.Drawing.Point(0, 0);
            this.splitMovimentacao.Name = "splitMovimentacao";
            this.splitMovimentacao.Panel1.Controls.Add(this.navBarControl1);
            this.splitMovimentacao.Panel1.Text = "Panel1";
            this.splitMovimentacao.Panel2.Controls.Add(this.splitGrid);
            this.splitMovimentacao.Panel2.Text = "Panel2";
            this.splitMovimentacao.Size = new System.Drawing.Size(804, 599);
            this.splitMovimentacao.SplitterPosition = 156;
            this.splitMovimentacao.TabIndex = 0;
            this.splitMovimentacao.Text = "splitContainerControl1";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navAcoes;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navAcoes});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.btnInserir,
            this.btnEditar,
            this.btnRemover,
            this.Separador,
            this.btnPersonalizar,
            this.btnVisualizar});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 156;
            this.navBarControl1.Size = new System.Drawing.Size(156, 599);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navAcoes
            // 
            this.navAcoes.Caption = "Ações";
            this.navAcoes.Expanded = true;
            this.navAcoes.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnInserir),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnEditar),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnRemover),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnVisualizar),
            new DevExpress.XtraNavBar.NavBarItemLink(this.Separador),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnPersonalizar)});
            this.navAcoes.LargeImage = ((System.Drawing.Image)(resources.GetObject("navAcoes.LargeImage")));
            this.navAcoes.Name = "navAcoes";
            // 
            // btnInserir
            // 
            this.btnInserir.Caption = "Novo [F2]";
            this.btnInserir.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnInserir.LargeImage")));
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnInserir.SmallImage")));
            this.btnInserir.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavBar_LinkClicked);
            // 
            // btnEditar
            // 
            this.btnEditar.Caption = "Editar [F3]";
            this.btnEditar.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.LargeImage")));
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.SmallImage")));
            this.btnEditar.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavBar_LinkClicked);
            // 
            // btnRemover
            // 
            this.btnRemover.Caption = "Remover [F4]";
            this.btnRemover.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRemover.LargeImage")));
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnRemover.SmallImage")));
            this.btnRemover.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavBar_LinkClicked);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Caption = "Visualizar[F5]";
            this.btnVisualizar.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnVisualizar.LargeImage")));
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnVisualizar.SmallImage")));
            this.btnVisualizar.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavBar_LinkClicked);
            // 
            // Separador
            // 
            this.Separador.CanDrag = false;
            this.Separador.Enabled = false;
            this.Separador.Hint = null;
            this.Separador.LargeImageIndex = 0;
            this.Separador.LargeImageSize = new System.Drawing.Size(0, 0);
            this.Separador.Name = "Separador";
            this.Separador.SmallImageIndex = 0;
            this.Separador.SmallImageSize = new System.Drawing.Size(0, 0);
            // 
            // btnPersonalizar
            // 
            this.btnPersonalizar.Caption = "Personalizar";
            this.btnPersonalizar.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPersonalizar.LargeImage")));
            this.btnPersonalizar.Name = "btnPersonalizar";
            this.btnPersonalizar.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnPersonalizar.SmallImage")));
            this.btnPersonalizar.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnPersonalizar_LinkClicked);
            // 
            // splitGrid
            // 
            this.splitGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitGrid.IsSplitterFixed = true;
            this.splitGrid.Location = new System.Drawing.Point(0, 0);
            this.splitGrid.Name = "splitGrid";
            this.splitGrid.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitGrid.Panel1
            // 
            this.splitGrid.Panel1.Controls.Add(this.labelRemoverFiltro);
            this.splitGrid.Panel1.Controls.Add(this.btnConsultar);
            this.splitGrid.Panel1.Controls.Add(this.labelFiltrosPersonalizados);
            this.splitGrid.Panel1.Controls.Add(this.filtroControl1);
            this.splitGrid.Panel1MinSize = 48;
            // 
            // splitGrid.Panel2
            // 
            this.splitGrid.Panel2.Controls.Add(this.progresso);
            this.splitGrid.Panel2.Controls.Add(this.gridControl);
            this.splitGrid.Size = new System.Drawing.Size(643, 599);
            this.splitGrid.SplitterDistance = 48;
            this.splitGrid.SplitterWidth = 1;
            this.splitGrid.TabIndex = 9;
            // 
            // labelRemoverFiltro
            // 
            this.labelRemoverFiltro.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline);
            this.labelRemoverFiltro.Appearance.ForeColor = System.Drawing.Color.Indigo;
            this.labelRemoverFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelRemoverFiltro.Location = new System.Drawing.Point(124, 28);
            this.labelRemoverFiltro.Name = "labelRemoverFiltro";
            this.labelRemoverFiltro.Size = new System.Drawing.Size(0, 13);
            this.labelRemoverFiltro.TabIndex = 3;
            this.labelRemoverFiltro.Click += new System.EventHandler(this.labelRemoverFiltro_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.Appearance.Options.UseTextOptions = true;
            this.btnConsultar.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Hide;
            this.btnConsultar.Location = new System.Drawing.Point(552, 3);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(88, 23);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar [F7]";
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // labelFiltrosPersonalizados
            // 
            this.labelFiltrosPersonalizados.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline);
            this.labelFiltrosPersonalizados.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelFiltrosPersonalizados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelFiltrosPersonalizados.Location = new System.Drawing.Point(5, 28);
            this.labelFiltrosPersonalizados.Name = "labelFiltrosPersonalizados";
            this.labelFiltrosPersonalizados.Size = new System.Drawing.Size(103, 13);
            this.labelFiltrosPersonalizados.TabIndex = 1;
            this.labelFiltrosPersonalizados.Text = "Filtros personalizados";
            this.labelFiltrosPersonalizados.Click += new System.EventHandler(this.labelFiltrosPersonalizados_Click);
            // 
            // filtroControl1
            // 
            this.filtroControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filtroControl1.Campos = null;
            this.filtroControl1.Location = new System.Drawing.Point(3, 3);
            this.filtroControl1.Name = "filtroControl1";
            this.filtroControl1.Size = new System.Drawing.Size(545, 23);
            this.filtroControl1.TabIndex = 0;
            // 
            // progresso
            // 
            this.progresso.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progresso.Appearance.Options.UseBackColor = true;
            this.progresso.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progresso.AppearanceCaption.Options.UseFont = true;
            this.progresso.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.progresso.AppearanceDescription.Options.UseFont = true;
            this.progresso.Caption = "Aguarde um instante";
            this.progresso.Description = "Carregando os dados ...";
            this.progresso.Enabled = false;
            this.progresso.ImageHorzOffset = 9;
            this.progresso.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.progresso.Location = new System.Drawing.Point(420, 7);
            this.progresso.Name = "progresso";
            this.progresso.Padding = new System.Windows.Forms.Padding(3);
            this.progresso.Size = new System.Drawing.Size(215, 55);
            this.progresso.TabIndex = 7;
            this.progresso.UseWaitCursor = true;
            this.progresso.Visible = false;
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
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.MainView = this.grid;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(643, 550);
            this.gridControl.TabIndex = 1;
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
            this.grid.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.grid_CustomDrawCell);
            // 
            // FrmBaseMovimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 599);
            this.Controls.Add(this.splitMovimentacao);
            this.Name = "FrmBaseMovimentacao";
            this.Text = "FrmBaseMovimentacao";
            this.Shown += new System.EventHandler(this.FrmBaseMovimentacao_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmBaseMovimentacao_KeyDown);
            this.Resize += new System.EventHandler(this.FrmBaseMovimentacao_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.splitMovimentacao)).EndInit();
            this.splitMovimentacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.splitGrid.Panel1.ResumeLayout(false);
            this.splitGrid.Panel1.PerformLayout();
            this.splitGrid.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitGrid)).EndInit();
            this.splitGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitMovimentacao;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navAcoes;
        protected System.ComponentModel.BackgroundWorker atualizarDados;
        private System.Windows.Forms.SplitContainer splitGrid;
        protected DevExpress.XtraGrid.GridControl gridControl;
        protected DevExpress.XtraGrid.Views.Grid.GridView grid;
        protected DevExpress.XtraWaitForm.ProgressPanel progresso;
        private FiltroControl filtroControl1;
        private DevExpress.XtraEditors.SimpleButton btnConsultar;
        private DevExpress.XtraEditors.LabelControl labelFiltrosPersonalizados;
        private DevExpress.XtraNavBar.NavBarItem btnInserir;
        private DevExpress.XtraNavBar.NavBarItem btnEditar;
        private DevExpress.XtraNavBar.NavBarItem btnRemover;
        private DevExpress.XtraNavBar.NavBarSeparatorItem Separador;
        private DevExpress.XtraNavBar.NavBarItem btnPersonalizar;
        private DevExpress.XtraEditors.LabelControl labelRemoverFiltro;
        private DevExpress.XtraNavBar.NavBarItem btnVisualizar;
    }
}