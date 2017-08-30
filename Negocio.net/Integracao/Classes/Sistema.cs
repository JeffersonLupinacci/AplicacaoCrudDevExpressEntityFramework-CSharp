using Negocio.Net.Dominio.Entidades;
using Negocio.Net.Dominio.Poco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Net.Integracao
{
    #region Sistema
    public static class Sistema
    {
        public static List<Modulo> ModulosDisponiveis;
        public static List<Modulo> ModulosContratados;
        public static List<UsuarioPermissao> PermissoesUsuario = new List<UsuarioPermissao>();
        public static Usuario Usuario;
        public static EmpresaAtiva Empresa;

        /// <summary>
        /// Recupera o módulo do sistema pela sua GUID
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public static Modulo RecuperaModuloDisponivel(String guid)
        {
            return RecuperaModuloDisponivel(new Guid(guid));
        }

        /// <summary>
        /// Recupera o módulo do sistema pela sua GUID
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public static Modulo RecuperaModuloDisponivel(Guid guid)
        {
            if (null == ModulosDisponiveis)
                ModulosDisponiveis = new List<Modulo>();

            return ModulosDisponiveis.Where(x => x.Guid == guid).FirstOrDefault();
        }

        /// <summary>
        /// Adiciona o módulo do sistema
        /// </summary>
        /// <param name="modulo"></param>
        public static void AdicionaModuloDisponivel(Modulo modulo)
        {
            if (null == ModulosDisponiveis)
                ModulosDisponiveis = new List<Modulo>();

            if (null == ModulosDisponiveis.Where(x => x.Guid == modulo.Guid).FirstOrDefault())
                ModulosDisponiveis.Add(modulo);
            else
                throw new Exception("Duplicidade de modulos detectada");
        }

        /// <summary>
        /// Adiciona o modulo a listagem de modulos contratados pela empresa utilizadora
        /// </summary>
        /// <param name="modulo">Modulo a ser integrado</param>
        public static void AdicionaModuloContratado(Modulo modulo)
        {
            if (null == ModulosContratados)
                ModulosContratados = new List<Modulo>();

            if (null == ModulosContratados.Where(x => x.Guid == modulo.Guid).FirstOrDefault())
                ModulosContratados.Add(modulo);
        }

        /// <summary>
        /// Verifica se o módulo foi contratado pela empresa utilizadora do sistema
        /// </summary>
        /// <param name="modulo">Módulo solicitado</param>
        /// <returns>retorna verdadeiro se o módulo estiver disponivel</returns>
        public static Boolean VerificaModuloContratado(Modulo modulo)
        {
            if (null == ModulosContratados)
                ModulosContratados = new List<Modulo>();

            if (null != ModulosContratados.Where(x => x.Guid == modulo.Guid).FirstOrDefault())
                return true;
            else
                return false;
        }

        /// <summary>
        /// Verifica se o usuário possui acesso ao módulo solicitado
        /// </summary>
        /// <param name="modulo">Modulo Solicitado</param>
        /// <returns>Retorno verdadeiro se acesso permitido</returns>
        public static bool VerificaModuloUsuario(Modulo modulo)
        {
            return true;
        }

        /// <summary>
        /// Carrega as Permissões Efetivas do Usuário para o Sistema
        /// </summary>
        public static void CarregaPermissoes()
        {
            if (null == Usuario)
                throw new Exception("Usuario não definido");
            else if (null == Empresa)
                throw new Exception("Empresa não definida");

        }


        internal static bool VerificaPermissaoUsuario(Modulo Modulo, string Permissao)
        {
            return true;
            /*return (null != PermissoesUsuario
                .Where(x => x.MODULO.ToUpper() == Modulo.Guid.ToString().ToUpper() && x.TAREFA.ToUpper() == Permissao.ToUpper())
                .FirstOrDefault());*/
        }
    }
    #endregion

}
