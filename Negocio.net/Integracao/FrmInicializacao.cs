using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

using Negocio.Net.Dominio;
using Negocio.Net.Dominio.Entidades;
using Negocio.Net.Dominio.Poco;
using Negocio.Net.Visualizacao;

namespace Negocio.Net.Integracao
{
    public partial class FrmInicializacao : FrmBase
    {

        /// <summary>
        /// Ignora a Mensagem de Finalizar a Aplicação que é disparada no Formulário Principal
        /// </summary>
        public bool ignoreFormClosing;

        public FrmPrincipal FrmPrincipal = null;
        public FrmLogin FrmLogin = null;

        public FrmInicializacao()
        {
            InitializeComponent();

            // Logo do Sistema
            logo.Image = Program.Recursos.Icone("icone");

            // Titulo da Janela
            this.Text = Properties.Resources.FrmText_Inicializacao.ToString();

            // Icone da Janela
            this.Icon = Program.Recursos.AppIcon;

            // Tamanho máximo da barra de progresso
            this.progresso.Properties.Maximum = 100;

        }

        #region CarregarSistemaDePermissoes
        private void CarregarSistemaDePermissoes()
        {
            /* Consultar o HTTP e recuperar todas as guid de modulos disponiveis para somente inserir na lista o que estiver disponivel */

            Sistema.AdicionaModuloDisponivel(new Modulo(Modulos.CadastroGeral, Properties.Resources.ModuloCadastroGeral, true, typeof(FrmBaseMovimentacao)));
            Sistema.AdicionaModuloDisponivel(new Modulo(Modulos.TipoDeCadastro, Properties.Resources.ModuloTipoDeCadastro, true, typeof(FrmBaseMovimentacao)));
            Sistema.AdicionaModuloDisponivel(new Modulo(Modulos.Classificacao, Properties.Resources.ModuloClassificacao, true, typeof(FrmBaseMovimentacao)));
            Sistema.AdicionaModuloDisponivel(new Modulo(Modulos.Colaborador, Properties.Resources.ModuloColaborador, true, typeof(FrmBaseMovimentacao)));
            Sistema.AdicionaModuloDisponivel(new Modulo(Modulos.Cidade, Properties.Resources.ModuloCidade, true, typeof(FrmBaseMovimentacao)));
            Sistema.AdicionaModuloDisponivel(new Modulo(Modulos.Estado, Properties.Resources.ModuloEstado, true, typeof(FrmBaseMovimentacao)));
            Sistema.AdicionaModuloDisponivel(new Modulo(Modulos.Pais, Properties.Resources.ModuloPais, true, typeof(FrmBaseMovimentacao)));
            Sistema.AdicionaModuloDisponivel(new Modulo(Modulos.Regiao, Properties.Resources.ModuloRegiao, true, typeof(FrmBaseMovimentacao)));

            Sistema.AdicionaModuloDisponivel(new Modulo(Modulos.Produto, Properties.Resources.ModuloProduto, true, typeof(FrmBaseMovimentacao)));
            Sistema.AdicionaModuloDisponivel(new Modulo(Modulos.Grupo, Properties.Resources.ModuloGrupo, true, typeof(FrmBaseMovimentacao)));
            Sistema.AdicionaModuloDisponivel(new Modulo(Modulos.Subgrupo, Properties.Resources.ModuloSubgrupo, true, typeof(FrmBaseMovimentacao)));            
            Sistema.AdicionaModuloDisponivel(new Modulo(Modulos.Empresa, Properties.Resources.ModuloEmpresa, true, typeof(FrmBaseMovimentacao)));
            Sistema.AdicionaModuloDisponivel(new Modulo(Modulos.Usuario, Properties.Resources.ModuloUsuario, true, typeof(FrmBaseMovimentacao)));
            Sistema.AdicionaModuloDisponivel(new Modulo(Modulos.SairDoAplicativo, Properties.Resources.ModuloSairDoAplicativo, false, null));
            Sistema.AdicionaModuloDisponivel(new Modulo(Modulos.TrocarDeUsuario, Properties.Resources.ModuloTrocarDeUsuario, false, null));
            Sistema.AdicionaModuloDisponivel(new Modulo(Modulos.AlterarSenhaDeAcesso, Properties.Resources.ModuloAlterarSenhaDeAcesso, false, null));

            Sistema.AdicionaModuloDisponivel(new Modulo(Modulos.Endereco, Properties.Resources.ModuloEndereco, true, typeof(FrmMovEnderecos)));
            Sistema.AdicionaModuloDisponivel(new Modulo(Modulos.Unidade, Properties.Resources.ModuloUnidade, true, typeof(FrmMovUnidades)));
            Sistema.AdicionaModuloDisponivel(new Modulo(Modulos.Marca, Properties.Resources.ModuloMarca, true, typeof(FrmMovMarcas)));
            Sistema.AdicionaModuloDisponivel(new Modulo(Modulos.Modelo, Properties.Resources.ModuloModelo, true, typeof(FrmMovModelos)));            
            Sistema.AdicionaModuloDisponivel(new Modulo(Modulos.Local, Properties.Resources.ModuloLocal, true, typeof(FrmMovLocais)));

            UsuarioPermissao P = new UsuarioPermissao();
            P.MODULO = "45C9CCB1-E641-4383-8E4E-20FED99950AD";
            P.TAREFA = "BAD3F9A7-6349-461A-9A4D-77EAF89C6527";
            Sistema.PermissoesUsuario.Add(P);
            //if (Funcoes.ModoDebug)
                foreach (Modulo m in Sistema.ModulosDisponiveis)
                    Sistema.AdicionaModuloContratado(m);

        }
        #endregion

        #region ExibeMensagem - Barra de Progresso
        /// <summary>
        /// Exibe uma mensagem no formulário e força o sistema 
        /// operacional da executar o repaint no monitor
        /// </summary>
        /// <param name="Mensagem">Mensagem que deverá ser exibida na barra de progresso</param>
        private void ExibeMensagem(String Mensagem)
        {
            this.lblProgresso.Text = Mensagem;
            this.progresso.Position += 10;
            this.Refresh();
        }
        #endregion

        #region Notificações do banco PostgresSql
        public void EscutarNotificacoesPostgreSQL()
        {
            /* Rotina de Notificação para ser utilizado como chats, controle de mensagens, e alertas para paineis inteligentes de eventos, pode ser utilizado para executar refresh em dashboards de acompanhamento*/
            //Npgsql.NpgsqlConnection conn = new Npgsql.NpgsqlConnection(ConfigurationManager.ConnectionStrings["NegocioNetContexto"].ToString());
            //conn.Open();

            //// informar as notificacoes que deverao ser escutadas
            //Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand("listen notificacao", conn);            
            //cmd.ExecuteNonQuery();
            //conn.Notification += Notification;
        }
        private void Notification(object sender, Npgsql.NpgsqlNotificationEventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion

        private void FrmInicializacao_FormClosing(object sender, FormClosingEventArgs e)
        {
            ignoreFormClosing = true;
        }

        private void FrmInicializacao_Shown(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            #region Conectar com o banco de dados
            ExibeMensagem(Properties.Resources.MsgInicializandoBancoDeDados);
            try
            {
                using (EmpresaDataSet dataset = new EmpresaDataSet())
                {
                    ExibeMensagem(Properties.Resources.MsgConsultandoDisponibilidade);
                    Empresa empresa = dataset.AsQueryable().FirstOrDefault();
                    if (null == empresa)
                        Funcoes.Alerta("Nenhuma empresa registrada no banco de dados.");
                }
            }
            catch (Exception ex)
            {
                Funcoes.ExibirExcessao(ex);
                Application.Exit();
                return;
            };
            #endregion

            #region Registrando classes de permissão da empresa
            ExibeMensagem(Properties.Resources.MsgValidandoInstalacao);
            CarregarSistemaDePermissoes();
            #endregion

            #region Alocar Formularios em Memória
            ExibeMensagem(Properties.Resources.MsgInicializandoFrmPrincipal);
            FrmPrincipal = new FrmPrincipal();
            FrmPrincipal.Owner = this;

            ExibeMensagem(Properties.Resources.MsgInicializandoFrmLogin);
            FrmLogin = new FrmLogin();
            FrmLogin.Owner = this;

            ExibeMensagem(Properties.Resources.MsgAlocandoRecurosBasicos);
            using (FrmBase f = new FrmBase()) { }
            using (FrmBaseEdicao f = new FrmBaseEdicao()) { }
            using (FrmBaseMovimentacao f = new FrmBaseMovimentacao()) { }
            #endregion

            EscutarNotificacoesPostgreSQL();

            this.Cursor = Cursors.Default;

            // Ocultando o Formulário de Carregamento e Exibindo o Login
            this.Hide();
            if (null != FrmLogin)
                FrmLogin.Show();

        }

    }
}
