using Negocio.Net.Dominio;
using Negocio.Net.Dominio.Entidades;
using Negocio.Net.Dominio.Poco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio.Net.Integracao
{
    public partial class FrmLogin : FrmBase
    {
        /// <summary>
        /// Formulário de validação de acesso do usuario
        /// </summary>
        public FrmLogin()
        {
            InitializeComponent();
            this.Icon = Program.Recursos.AppIcon;
            this.Text = Properties.Resources.ApplicationName;

            btnEntrar.Image = Program.Recursos.Icone("btnConfirmar");
            btnEntrar.Text = Properties.Resources.btnEntrar;
            btnEntrar.ToolTip = Properties.Resources.HintBtnEntrar;
            btnSair.Image = Program.Recursos.Icone("btnFechar");
            btnSair.Text = Properties.Resources.btnSair;
            btnSair.ToolTip = Properties.Resources.HintBtnSair;

            lblNomeDeUsuario.Text = Properties.Resources.LabelNomeDeUsuario;
            lblNomeDeUsuario.ToolTip = Properties.Resources.HintNomeDeUsuario;
            lblNomeDeUsuario.Parent = pictureBox1;
            lblNomeDeUsuario.BackColor = System.Drawing.Color.Transparent;

            lblSenhaDeAcesso.Text = Properties.Resources.LabelSenhaDeAcesso;
            lblSenhaDeAcesso.ToolTip = Properties.Resources.HintSenhaDeAcesso;
            lblSenhaDeAcesso.Parent = pictureBox1;
            lblSenhaDeAcesso.BackColor = System.Drawing.Color.Transparent;

            lblEmpresa.Text = Properties.Resources.LabelEmpresaPadrao;
            lblEmpresa.ToolTip = Properties.Resources.HintEmpresaAcesso;
            lblEmpresa.Parent = pictureBox1;
            lblEmpresa.BackColor = System.Drawing.Color.Transparent;

            listarEmpresas();

            edtEmpresa.Properties.Columns[0].Caption = Funcoes
                .CaptionDoAttributo(typeof(EmpresaAtiva), "NOME");

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            (this.Owner as FrmInicializacao).ignoreFormClosing = true;
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (edtNomeDeUsuario.Text.Trim().Length == 0)
            {
                Funcoes.AlertaComponente(Properties.Resources.MsgNecessarioNomeUsuario, edtNomeDeUsuario);
                return;
            }
            else if (edtSenhaDeAcesso.Text.Trim().Length == 0)
            {
                Funcoes.AlertaComponente(Properties.Resources.MsgNecessarioSenhaUsuario, edtSenhaDeAcesso);
                return;
            }
            else if (null == edtEmpresa.GetSelectedDataRow())
            {
                Funcoes.AlertaComponente(Properties.Resources.MsgNecessarioEmpresaUsuario, edtEmpresa);
                return;
            }

            using (UsuarioDataSet dataset = new UsuarioDataSet())
            {

                /* Recuperando o usuario no banco de dados */
                Usuario usuario = dataset.LocalizarPorNome(edtNomeDeUsuario.Text.Trim().ToLower());

                /* Validando se o usuário existe */
                if (null == usuario)
                {
                    Funcoes.Erro(Properties.Resources.MsgUsuarioSenhaInvalido);
                    return;
                }
                else
                {
                    /* Validando se a senha informada esta correta */
                    if (!Dominio.Poco.CodificaSenha
                        .Validar(edtNomeDeUsuario.Text.Trim().ToLower() + edtSenhaDeAcesso.Text.Trim().ToLower(),
                        usuario.SENHA))
                    {
                        Funcoes.Erro(Properties.Resources.MsgUsuarioSenhaInvalido);
                        return;
                    }
                    /* Validando se o usuario esta ativo */
                    else if (usuario.INATIVO)
                    {
                        Funcoes.Erro(Properties.Resources.MsgUsuarioInativo);
                        return;
                    }
                }

                /* Recuperando as Empresas do Usuario para verificar se a empresa selecionada pode ser manipulada */
                Dominio.Poco.EmpresaAtiva empresa = (EmpresaAtiva)edtEmpresa.GetSelectedDataRow();
                                              
                if (!(dataset.VerificaAcessoEmpresa(usuario.COD, empresa.COD)))
                {
                    Funcoes.Erro(Properties.Resources.MsgEmpresaSemAcesso);
                    return;
                }

                Sistema.Usuario = usuario;
                Sistema.Empresa = empresa;
                Sistema.CarregaPermissoes();
            }

            edtNomeDeUsuario.Text = "";
            edtSenhaDeAcesso.Text = "";

            this.Hide();
            (this.Owner as FrmInicializacao).FrmPrincipal.TrocarDeUsuario();
            (this.Owner as FrmInicializacao).FrmPrincipal.Show();
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            (this.Owner as FrmInicializacao).ignoreFormClosing = true;
            Application.Exit();
        }

        public void listarEmpresas()
        {
            using (EmpresaDataSet dataset = new EmpresaDataSet()) {
                BindingSource bindEmpresas = new BindingSource();
                bindEmpresas.DataSource = dataset.EmpresasAtivas();
                edtEmpresa.Properties.DataSource = bindEmpresas;
            }            
        }

        private void FrmLogin_Shown(object sender, EventArgs e)
        {
            if (Funcoes.ModoDebug)
            {
                edtNomeDeUsuario.Text = "usuario";
                edtSenhaDeAcesso.Text = "senha";
                edtEmpresa.ItemIndex = 0;
                //btnEntrar.PerformClick();
            }
        }

    }
}
