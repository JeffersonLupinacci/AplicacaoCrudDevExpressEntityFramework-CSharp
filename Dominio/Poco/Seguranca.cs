using Negocio.Net.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Net.Dominio.Poco
{

    #region Módulo
    public class Modulo
    {
        private List<Permissao> _Permissoes = new List<Permissao>();
        private Guid _Guid;
        private String _Descricao;
        public Modulo(String guid, String descricao, Boolean dataset, params Permissao[] permissoes)
        {
            this._Guid = new Guid(guid);
            this._Descricao = descricao;
            if (dataset)
            {
                _Permissoes.Add(new Permissao(new Guid("616947E5-FE5F-4192-BA53-7B677F2689AC"), "Permissão de Inserção"));
                _Permissoes.Add(new Permissao(new Guid("0ECED206-BF40-4360-9686-3EE6FD0EFE09"), "Permissão de Edição"));
                _Permissoes.Add(new Permissao(new Guid("BAD3F9A7-6349-461A-9A4D-77EAF89C6527"), "Permissão de Exclusão"));
                _Permissoes.Add(new Permissao(new Guid("B7BE7552-15EC-475B-9722-5E2BC8762D06"), "Permissão de Visualização"));
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
