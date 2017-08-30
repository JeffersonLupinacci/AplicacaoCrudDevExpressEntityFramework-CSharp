using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic;
using System.Data.Entity;

namespace Negocio.Net.Dominio
{
    public class RepositorioGenerico<T> : IDisposable where T : class
    {
        private Contexto contexto = new Contexto(Constantes.NomeDaConexao);

        /// <summary>
        /// Recupera o Contexto do DataSet
        /// </summary>
        public Contexto Contexto { get { return Contexto; } }

        /// <summary>
        /// Execução de Consultas Dinamicas com Filtro
        /// </summary>
        /// <param name="paramWhere"></param>
        /// <returns></returns>
        public IQueryable<T> ConsultaNoTracking(String paramWhere)
        {
            if (!String.IsNullOrEmpty(paramWhere))
                return contexto.Set<T>().AsNoTracking().AsQueryable().Where(paramWhere);
            else
                return contexto.Set<T>().AsNoTracking().AsQueryable();
        }

        /// <summary>
        /// Execução de Consultas Dinamicas com Filtro
        /// </summary>
        /// <param name="paramWhere"></param>
        /// <returns></returns>        
        public IQueryable<T> Consulta(String paramWhere)
        {
            if (!String.IsNullOrEmpty(paramWhere))
                return contexto.Set<T>().AsQueryable().Where(paramWhere);
            else
                return contexto.Set<T>().AsQueryable();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IQueryable<T> Consulta(Func<T, bool> predicate)
        {
            return contexto.Set<T>().Where(predicate).AsQueryable();
        }

        /// <summary>
        /// Retorna a Entidade do Contexto pela Chave
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public T RecuperarPelaChave(params object[] chave)
        {
            return contexto.Set<T>().Find(chave);
        }

        /// <summary>
        /// Retorna todos as Entidades do Contexto
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> RecuperarTodos()
        {
            return contexto.Set<T>();
        }

        /// <summary>
        /// Adiciona a Entidade no Contexto
        /// </summary>
        /// <param name="Entidade"></param>
        public void Adicionar(T Entidade)
        {
            using (var Transacao = contexto.Database.BeginTransaction())
            {
                try
                {
                    contexto.Set<T>().Add(Entidade);
                    contexto.SaveChanges();
                    Transacao.Commit();
                }
                catch (Exception ex)
                {
                    Transacao.Rollback();
                    throw ex;
                }
            }
        }

        /// <summary>
        /// Atualiza a Entidade
        /// </summary>
        /// <param name="Entidade"></param>
        public void Atualizar(T Entidade)
        {
            using (var Transacao = contexto.Database.BeginTransaction())
            {
                try
                {
                    contexto.Entry(Entidade).State = EntityState.Modified;
                    contexto.SaveChanges();
                    Transacao.Commit();
                }
                catch (Exception ex)
                {
                    Transacao.Rollback();
                    throw ex;
                }
            }
        }

        public void Excluir(String paramWhere)
        {
            using (var Transacao = contexto.Database.BeginTransaction())
            {
                try
                {
                    contexto.Set<T>()
                        .Where(paramWhere).ToList()
                        .ForEach(del => contexto.Set<T>().Remove(del));
                    contexto.SaveChanges();
                    Transacao.Commit();
                }
                catch (Exception ex)
                {
                    Transacao.Rollback();
                    throw ex;
                }
            }
        }

        public void Excluir(Func<T, bool> predicate)
        {
            using (var Transacao = contexto.Database.BeginTransaction())
            {
                try
                {
                    contexto.Set<T>()
                        .Where(predicate).ToList()
                        .ForEach(del => contexto.Set<T>().Remove(del));
                    contexto.SaveChanges();
                    Transacao.Commit();
                }
                catch (Exception ex)
                {
                    Transacao.Rollback();
                    throw ex;
                }
            }
        }

        public void Dispose()
        {
            contexto.Dispose();
        }
    }
}
