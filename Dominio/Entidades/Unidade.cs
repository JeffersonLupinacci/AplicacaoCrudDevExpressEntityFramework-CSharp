using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Net.Dominio.Entidades
{
    public class Unidade 
    {
        [PersonalizarColuna(Caption = "Código", Visivel = true)]
        public virtual int COD_UNIDADE { get; set; }

        [PersonalizarColuna(Caption = "Sigla", Visivel = true)]
        public virtual String SIGLA { get; set; }

        [PersonalizarColuna(Caption = "Descrição", Visivel = true)]
        public virtual String DESCRICAO { get; set; }

        [PersonalizarColuna(Caption = "Inativo", Visivel = true)]
        public virtual Boolean INATIVO { get; set; }

        [PersonalizarColuna(Caption = "Fator de Conversão", Visivel = false)]
        public Double FATOR { get; set; }

        [PersonalizarColuna(Caption = "Código da Unidade Maior", Visivel = false)]
        public virtual Nullable<int> COD_UNIDADE_MAIOR { get; set; }
    }
}
