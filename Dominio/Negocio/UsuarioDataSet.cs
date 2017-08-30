using Negocio.Net.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic;

namespace Negocio.Net.Dominio
{
    public class UsuarioDataSet : IDisposable
    {
        private Contexto contexto;

        public UsuarioDataSet()
        {
            contexto = new Contexto(Constantes.NomeDaConexao);
        }

        public Usuario LocalizarPorNome(string nomeUsuario)
        {
            return Localizar(string.Format("LOGIN == \"{0}\"", nomeUsuario));
        }

        public Usuario Localizar(string paramWhere)
        {
            return contexto.Usuarios.AsQueryable().Where(paramWhere).FirstOrDefault();
        }

        public Boolean VerificaAcessoEmpresa(int CodUsuario, int CodEmpresa)
        {
            return contexto.Database.SqlQuery<int>(Dominio.Consultas.sqlEmpresasDoUsuario,
                new Npgsql.NpgsqlParameter("COD_USUARIO", CodUsuario),
                new Npgsql.NpgsqlParameter("COD_EMPRESA", CodEmpresa)).FirstOrDefault() > 0 ? true : false;
        }

        public List<UsuarioToolbar> ListarItensToolbar(int CodUsuario, int CodEmpresa)
        {
            return contexto.UsuariosToolbar.Where(x => (x.COD_USUARIO == CodUsuario) && (x.COD_EMPRESA == CodEmpresa)).ToList();
        }

        public void SalvarItensToolbar(List<string> BotoesFavoritos, List<string> BotoesLiberados, int CodUsuario, int CodEmpresa)
        {
            using (var Transacao = contexto.Database.BeginTransaction())
            {
                try
                {
                    /* Recuperando os botões salvos como favoritos pelo usuário */
                    List<UsuarioToolbar> botoesSalvos = contexto.UsuariosToolbar.Where(x => (x.COD_USUARIO == CodUsuario) && (x.COD_EMPRESA == CodEmpresa)).ToList();

                    Boolean encontrou = false;
                    foreach (UsuarioToolbar toolbar in botoesSalvos)
                    {


                        /* Removendo vinculos antigos não utilizados ou removidos por politica de permissoes */
                        encontrou = false;
                        for (int i = 0; i < BotoesLiberados.Count; i++)
                            if (BotoesLiberados[i] == toolbar.BOTAO)
                            {
                                encontrou = true;
                                break;
                            }

                        /* Verificando os Botões Favoritos e removendo os definidos pelo usuário*/
                        if (encontrou)
                        {
                            encontrou = false;
                            for (int i = 0; i < BotoesFavoritos.Count; i++)
                                if (BotoesFavoritos[i] == toolbar.BOTAO)
                                {
                                    encontrou = true;
                                    break;
                                }
                        }

                        if (!encontrou)
                            contexto.UsuariosToolbar.Remove(toolbar);
                    }

                    /* Cadastrando botões permitidos */
                    for (int i = 0; i < BotoesFavoritos.Count; i++)
                    {
                        if (null == botoesSalvos.Where(x => x.BOTAO == BotoesFavoritos[i]).FirstOrDefault())
                        {
                            contexto.UsuariosToolbar.Add(new UsuarioToolbar()
                            {
                                COD_EMPRESA = CodEmpresa,
                                COD_USUARIO = CodUsuario,
                                BOTAO = BotoesFavoritos[i]
                            });
                        }
                    }

                    contexto.SaveChanges();
                    Transacao.Commit();
                }
                catch (Exception)
                {
                    Transacao.Rollback();
                }
            }
        }

        public UsuarioGrid LocalizaLayoutFormulario(int CodUsuario, int CodEmpresa, string NomeFormulario)
        {
            return contexto.UsuariosGrid.Where(x =>
                x.COD_USUARIO == CodUsuario &&
                x.COD_EMPRESA == CodEmpresa &&
                x.FORMULARIO == NomeFormulario).FirstOrDefault();
        }

        public void SalvarLayoutFormulario(int CodUsuario, int CodEmpresa, string NomeFormulario, string ConfiguracaoXML)
        {
            using (var Transacao = contexto.Database.BeginTransaction())
            {
                try
                {
                    UsuarioGrid usuarioGrid = contexto.UsuariosGrid
                        .Where(x => x.COD_USUARIO == CodUsuario && x.COD_EMPRESA == CodEmpresa && x.FORMULARIO == NomeFormulario)
                        .FirstOrDefault();
                    if (null == usuarioGrid)
                    {
                        usuarioGrid = new UsuarioGrid()
                        {
                            COD_USUARIO = CodUsuario,
                            COD_EMPRESA = CodEmpresa,
                            FORMULARIO = NomeFormulario,
                            XML = ConfiguracaoXML
                        };
                        contexto.UsuariosGrid.Add(usuarioGrid);
                    }
                    else {
                        usuarioGrid.XML = ConfiguracaoXML;
                    }
                    contexto.SaveChanges();
                    Transacao.Commit();
                }
                catch (Exception)
                {
                    Transacao.Rollback();
                }
            }
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

    }
}

