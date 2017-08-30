namespace Negocio.Net.Integracao
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnTrocarDeUsuario = new DevExpress.XtraBars.BarButtonItem();
            this.btnGerenciarEmpresas = new DevExpress.XtraBars.BarButtonItem();
            this.btnGerenciarUsuarios = new DevExpress.XtraBars.BarButtonItem();
            this.btnSairAplicativo = new DevExpress.XtraBars.BarButtonItem();
            this.btnAlterarSenhaAcesso = new DevExpress.XtraBars.BarButtonItem();
            this.btnGerenciarCadastros = new DevExpress.XtraBars.BarButtonItem();
            this.btnGerenciarTiposDeCadastro = new DevExpress.XtraBars.BarButtonItem();
            this.btnGerenciarClassificacao = new DevExpress.XtraBars.BarButtonItem();
            this.btnGerenciarCidades = new DevExpress.XtraBars.BarButtonItem();
            this.btnGerenciarEstados = new DevExpress.XtraBars.BarButtonItem();
            this.btnGerenciarPaises = new DevExpress.XtraBars.BarButtonItem();
            this.btnGerenciarRegioes = new DevExpress.XtraBars.BarButtonItem();
            this.btnGerenciarColaboradores = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.btnGerenciarProdutos = new DevExpress.XtraBars.BarButtonItem();
            this.btnGerenciarGrupo = new DevExpress.XtraBars.BarButtonItem();
            this.btnGerenciarSubGrupo = new DevExpress.XtraBars.BarButtonItem();
            this.btnGerenciarUnidades = new DevExpress.XtraBars.BarButtonItem();
            this.btnGerenciarMarca = new DevExpress.XtraBars.BarButtonItem();
            this.btnGerenciarModelos = new DevExpress.XtraBars.BarButtonItem();
            this.btnGerenciarLocal = new DevExpress.XtraBars.BarButtonItem();
            this.btnGerenciarEndereco = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonMiniToolbar1 = new DevExpress.XtraBars.Ribbon.RibbonMiniToolbar(this.components);
            this.pageArquivos = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.pageGroupCadastros = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageGroupProdutos = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageGroupEmpresas = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pagePainelDeControle = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.pageGroupConfiguracoes = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.Paginas = new DevExpress.XtraTab.XtraTabControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paginas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Blue;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnTrocarDeUsuario,
            this.btnGerenciarEmpresas,
            this.btnGerenciarUsuarios,
            this.btnSairAplicativo,
            this.btnAlterarSenhaAcesso,
            this.btnGerenciarCadastros,
            this.btnGerenciarTiposDeCadastro,
            this.btnGerenciarClassificacao,
            this.btnGerenciarCidades,
            this.btnGerenciarEstados,
            this.btnGerenciarPaises,
            this.btnGerenciarRegioes,
            this.btnGerenciarColaboradores,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10,
            this.barStaticItem1,
            this.btnGerenciarProdutos,
            this.btnGerenciarGrupo,
            this.btnGerenciarSubGrupo,
            this.btnGerenciarUnidades,
            this.btnGerenciarMarca,
            this.btnGerenciarModelos,
            this.btnGerenciarLocal,
            this.btnGerenciarEndereco});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 39;
            this.ribbonControl1.MiniToolbars.Add(this.ribbonMiniToolbar1);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.pageArquivos,
            this.pagePainelDeControle});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.ShowCategoryInCaption = false;
            this.ribbonControl1.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.ShowOnMultiplePages;
            this.ribbonControl1.Size = new System.Drawing.Size(674, 142);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.TransparentEditors = true;
            // 
            // btnTrocarDeUsuario
            // 
            this.btnTrocarDeUsuario.Caption = "&Trocar de Usuário";
            this.btnTrocarDeUsuario.Id = 1;
            this.btnTrocarDeUsuario.Name = "btnTrocarDeUsuario";
            this.btnTrocarDeUsuario.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTrocarDeUsuario_ItemClick);
            // 
            // btnGerenciarEmpresas
            // 
            this.btnGerenciarEmpresas.Caption = "Empresas";
            this.btnGerenciarEmpresas.Id = 2;
            this.btnGerenciarEmpresas.Name = "btnGerenciarEmpresas";
            // 
            // btnGerenciarUsuarios
            // 
            this.btnGerenciarUsuarios.Caption = "Usuários";
            this.btnGerenciarUsuarios.Id = 3;
            this.btnGerenciarUsuarios.Name = "btnGerenciarUsuarios";
            // 
            // btnSairAplicativo
            // 
            this.btnSairAplicativo.Caption = "&Sair do Aplicativo";
            this.btnSairAplicativo.Id = 4;
            this.btnSairAplicativo.Name = "btnSairAplicativo";
            this.btnSairAplicativo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSairAplicativo_ItemClick);
            // 
            // btnAlterarSenhaAcesso
            // 
            this.btnAlterarSenhaAcesso.Caption = "Alterar senha de acesso";
            this.btnAlterarSenhaAcesso.Id = 5;
            this.btnAlterarSenhaAcesso.Name = "btnAlterarSenhaAcesso";
            // 
            // btnGerenciarCadastros
            // 
            this.btnGerenciarCadastros.Caption = "Cadastro Geral";
            this.btnGerenciarCadastros.Id = 6;
            this.btnGerenciarCadastros.Name = "btnGerenciarCadastros";
            // 
            // btnGerenciarTiposDeCadastro
            // 
            this.btnGerenciarTiposDeCadastro.Caption = "Tipo de Cadastro";
            this.btnGerenciarTiposDeCadastro.Id = 10;
            this.btnGerenciarTiposDeCadastro.Name = "btnGerenciarTiposDeCadastro";
            // 
            // btnGerenciarClassificacao
            // 
            this.btnGerenciarClassificacao.Caption = "Classificação";
            this.btnGerenciarClassificacao.Id = 11;
            this.btnGerenciarClassificacao.Name = "btnGerenciarClassificacao";
            // 
            // btnGerenciarCidades
            // 
            this.btnGerenciarCidades.Caption = "Cidade";
            this.btnGerenciarCidades.Id = 12;
            this.btnGerenciarCidades.Name = "btnGerenciarCidades";
            // 
            // btnGerenciarEstados
            // 
            this.btnGerenciarEstados.Caption = "Estado";
            this.btnGerenciarEstados.Id = 13;
            this.btnGerenciarEstados.Name = "btnGerenciarEstados";
            // 
            // btnGerenciarPaises
            // 
            this.btnGerenciarPaises.Caption = "País";
            this.btnGerenciarPaises.Id = 14;
            this.btnGerenciarPaises.Name = "btnGerenciarPaises";
            // 
            // btnGerenciarRegioes
            // 
            this.btnGerenciarRegioes.Caption = "Região";
            this.btnGerenciarRegioes.Id = 15;
            this.btnGerenciarRegioes.Name = "btnGerenciarRegioes";
            // 
            // btnGerenciarColaboradores
            // 
            this.btnGerenciarColaboradores.Caption = "Colaboradores";
            this.btnGerenciarColaboradores.Id = 16;
            this.btnGerenciarColaboradores.Name = "btnGerenciarColaboradores";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "barButtonItem8";
            this.barButtonItem8.Id = 18;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "barButtonItem9";
            this.barButtonItem9.Id = 19;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "barButtonItem10";
            this.barButtonItem10.Id = 23;
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "barStaticItem1";
            this.barStaticItem1.Id = 25;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // btnGerenciarProdutos
            // 
            this.btnGerenciarProdutos.Caption = "Produto";
            this.btnGerenciarProdutos.Id = 26;
            this.btnGerenciarProdutos.Name = "btnGerenciarProdutos";
            // 
            // btnGerenciarGrupo
            // 
            this.btnGerenciarGrupo.Caption = "Grupo";
            this.btnGerenciarGrupo.Id = 27;
            this.btnGerenciarGrupo.Name = "btnGerenciarGrupo";
            // 
            // btnGerenciarSubGrupo
            // 
            this.btnGerenciarSubGrupo.Caption = "Subgrupo";
            this.btnGerenciarSubGrupo.Id = 28;
            this.btnGerenciarSubGrupo.Name = "btnGerenciarSubGrupo";
            // 
            // btnGerenciarUnidades
            // 
            this.btnGerenciarUnidades.Caption = "Unidade";
            this.btnGerenciarUnidades.Id = 29;
            this.btnGerenciarUnidades.Name = "btnGerenciarUnidades";
            // 
            // btnGerenciarMarca
            // 
            this.btnGerenciarMarca.Caption = "Marca";
            this.btnGerenciarMarca.Id = 30;
            this.btnGerenciarMarca.Name = "btnGerenciarMarca";
            // 
            // btnGerenciarModelos
            // 
            this.btnGerenciarModelos.Caption = "Modelo";
            this.btnGerenciarModelos.Id = 31;
            this.btnGerenciarModelos.Name = "btnGerenciarModelos";
            // 
            // btnGerenciarLocal
            // 
            this.btnGerenciarLocal.Caption = "Local";
            this.btnGerenciarLocal.Id = 32;
            this.btnGerenciarLocal.Name = "btnGerenciarLocal";
            // 
            // btnGerenciarEndereco
            // 
            this.btnGerenciarEndereco.Caption = "Endereço";
            this.btnGerenciarEndereco.Id = 33;
            this.btnGerenciarEndereco.Name = "btnGerenciarEndereco";
            // 
            // pageArquivos
            // 
            this.pageArquivos.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pageGroupCadastros,
            this.pageGroupProdutos,
            this.pageGroupEmpresas});
            this.pageArquivos.Name = "pageArquivos";
            this.pageArquivos.Text = "Arquivos";
            // 
            // pageGroupCadastros
            // 
            this.pageGroupCadastros.ItemLinks.Add(this.btnGerenciarCadastros);
            this.pageGroupCadastros.ItemLinks.Add(this.btnGerenciarTiposDeCadastro);
            this.pageGroupCadastros.ItemLinks.Add(this.btnGerenciarClassificacao);
            this.pageGroupCadastros.ItemLinks.Add(this.btnGerenciarColaboradores);
            this.pageGroupCadastros.ItemLinks.Add(this.btnGerenciarCidades);
            this.pageGroupCadastros.ItemLinks.Add(this.btnGerenciarEstados);
            this.pageGroupCadastros.ItemLinks.Add(this.btnGerenciarPaises);
            this.pageGroupCadastros.ItemLinks.Add(this.btnGerenciarRegioes);
            this.pageGroupCadastros.Name = "pageGroupCadastros";
            this.pageGroupCadastros.Text = "Cadastros";
            // 
            // pageGroupProdutos
            // 
            this.pageGroupProdutos.ItemLinks.Add(this.btnGerenciarProdutos);
            this.pageGroupProdutos.ItemLinks.Add(this.btnGerenciarGrupo);
            this.pageGroupProdutos.ItemLinks.Add(this.btnGerenciarSubGrupo);
            this.pageGroupProdutos.ItemLinks.Add(this.btnGerenciarUnidades);
            this.pageGroupProdutos.ItemLinks.Add(this.btnGerenciarMarca);
            this.pageGroupProdutos.ItemLinks.Add(this.btnGerenciarModelos);
            this.pageGroupProdutos.ItemLinks.Add(this.btnGerenciarLocal);
            this.pageGroupProdutos.ItemLinks.Add(this.btnGerenciarEndereco);
            this.pageGroupProdutos.Name = "pageGroupProdutos";
            this.pageGroupProdutos.Text = "Produtos";
            // 
            // pageGroupEmpresas
            // 
            this.pageGroupEmpresas.ItemLinks.Add(this.btnGerenciarEmpresas);
            this.pageGroupEmpresas.ItemLinks.Add(this.btnGerenciarUsuarios);
            this.pageGroupEmpresas.Name = "pageGroupEmpresas";
            this.pageGroupEmpresas.Text = "Empresa";
            // 
            // pagePainelDeControle
            // 
            this.pagePainelDeControle.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pageGroupConfiguracoes,
            this.ribbonPageGroup1});
            this.pagePainelDeControle.Name = "pagePainelDeControle";
            this.pagePainelDeControle.Text = "Painel de Controle";
            // 
            // pageGroupConfiguracoes
            // 
            this.pageGroupConfiguracoes.ItemLinks.Add(this.btnAlterarSenhaAcesso);
            this.pageGroupConfiguracoes.Name = "pageGroupConfiguracoes";
            this.pageGroupConfiguracoes.Text = "Configurações";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTrocarDeUsuario);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSairAplicativo);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Aplicativo";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 325);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(674, 27);
            // 
            // Paginas
            // 
            this.Paginas.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader;
            this.Paginas.CustomHeaderButtons.AddRange(new DevExpress.XtraTab.Buttons.CustomHeaderButton[] {
            new DevExpress.XtraTab.Buttons.CustomHeaderButton()});
            this.Paginas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Paginas.Location = new System.Drawing.Point(0, 142);
            this.Paginas.Name = "Paginas";
            this.Paginas.Size = new System.Drawing.Size(674, 183);
            this.Paginas.TabIndex = 2;
            this.Paginas.CloseButtonClick += new System.EventHandler(this.Paginas_CloseButtonClick);
            this.Paginas.CustomHeaderButtonClick += new DevExpress.XtraTab.ViewInfo.CustomHeaderButtonEventHandler(this.Paginas_CustomHeaderButtonClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(674, 352);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 352);
            this.Controls.Add(this.Paginas);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.Name = "FrmPrincipal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paginas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnTrocarDeUsuario;
        private DevExpress.XtraBars.Ribbon.RibbonPage pagePainelDeControle;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageArquivos;
        private DevExpress.XtraBars.BarButtonItem btnGerenciarEmpresas;
        private DevExpress.XtraBars.BarButtonItem btnGerenciarUsuarios;
        private DevExpress.XtraBars.BarButtonItem btnSairAplicativo;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pageGroupEmpresas;
        private DevExpress.XtraBars.BarButtonItem btnAlterarSenhaAcesso;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pageGroupConfiguracoes;
        private DevExpress.XtraBars.BarButtonItem btnGerenciarCadastros;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pageGroupCadastros;
        private DevExpress.XtraBars.BarButtonItem btnGerenciarTiposDeCadastro;
        private DevExpress.XtraBars.BarButtonItem btnGerenciarClassificacao;
        private DevExpress.XtraBars.BarButtonItem btnGerenciarCidades;
        private DevExpress.XtraBars.BarButtonItem btnGerenciarEstados;
        private DevExpress.XtraBars.BarButtonItem btnGerenciarPaises;
        private DevExpress.XtraBars.BarButtonItem btnGerenciarRegioes;
        private DevExpress.XtraBars.BarButtonItem btnGerenciarColaboradores;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarButtonItem btnGerenciarProdutos;
        private DevExpress.XtraBars.BarButtonItem btnGerenciarGrupo;
        private DevExpress.XtraBars.BarButtonItem btnGerenciarSubGrupo;
        private DevExpress.XtraBars.BarButtonItem btnGerenciarUnidades;
        private DevExpress.XtraBars.BarButtonItem btnGerenciarMarca;
        private DevExpress.XtraBars.BarButtonItem btnGerenciarModelos;
        private DevExpress.XtraBars.BarButtonItem btnGerenciarLocal;
        private DevExpress.XtraBars.BarButtonItem btnGerenciarEndereco;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pageGroupProdutos;
        private DevExpress.XtraTab.XtraTabControl Paginas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraBars.Ribbon.RibbonMiniToolbar ribbonMiniToolbar1;
    }
}