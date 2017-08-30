using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Net.Dominio.Entidades
{
    public class Endereco
    {
        [PersonalizarColuna(Caption = "Código", Visivel = true)]
        public virtual int COD_ENDERECO { get; set; }
        [PersonalizarColuna(Caption = "Descrição", Visivel = true)]
        public virtual String DESCRICAO { get; set; }
        
    }
}
