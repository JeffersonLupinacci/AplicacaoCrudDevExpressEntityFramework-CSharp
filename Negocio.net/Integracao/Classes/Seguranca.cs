using Negocio.Net.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Net.Integracao
{

    #region Módulo
    public class Modulo
    {
        private List<Permissao> _Permissoes = new List<Permissao>();
        private Guid _Guid;
        private String _Descricao;
        private Type _Classe;

        public Modulo(String guid, String descricao, Boolean dataset, Type classe, params Permissao[] permissoes)
        {
            this._Guid = new Guid(guid);            
            this._Descricao = descricao;
            this._Classe = classe;
            if (dataset)
            {
                _Permissoes.Add(new Permissao(new Guid(PermissoesBasicas.Inserir), "Permissão de Inserção"));
                _Permissoes.Add(new Permissao(new Guid(PermissoesBasicas.Editar), "Permissão de Edição"));
                _Permissoes.Add(new Permissao(new Guid(PermissoesBasicas.Excluir), "Permissão de Exclusão"));
                _Permissoes.Add(new Permissao(new Guid(PermissoesBasicas.Visualizar), "Permissão de Visualização"));
            }

            if (null != permissoes) {
                foreach (Permissao permissao in permissoes)
                {
                    Permissao _p = _Permissoes.Where(x => x.Guid == permissao.Guid).FirstOrDefault();
                    if (null == _p)
                        _Permissoes.Add(permissao);
                    else
                        throw new Exception("Conflito de Identificadores de Permissão:\nPermissões Conflitantes: " +
                                    "[" + permissao.Descricao + "] com o [" + _p.Descricao + "] no módulo ["+ this._Descricao+"]");
                }
            }
        }
        public Guid Guid { get { return _Guid; } }
        public String Descricao { get { return _Descricao; } }
        public Type Classe { get { return _Classe; } }
        public List<Permissao> Permissoes { get { return _Permissoes; } }
    }
    #endregion

    #region Permissão
    public class Permissao
    {
        private Guid _Guid;
        private String _Descricao;

        /// <summary>
        /// Permissao de Acesso
        /// </summary>
        /// <param name="guid">Chave de Referencia a Permissao</param>
        /// <param name="descricao">Descricao da Permissao</param>
        /// <param name="modulo">Módulo que a permissão é integrante</param>
        public Permissao(Guid guid, String descricao)
        {
            _Guid = guid;
            _Descricao = descricao;
        }
        /// <summary>
        /// Chave de referencia da permissão
        /// </summary>
        public Guid Guid { get { return _Guid; } }
        /// <summary>
        /// Descrição da Permissão
        /// </summary>
        public String Descricao { get { return _Descricao; } }
    }
    #endregion

}
