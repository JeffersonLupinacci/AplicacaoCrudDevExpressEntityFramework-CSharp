using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Net.Dominio.Entidades
{
    public class Marca
    {
        [PersonalizarColuna(Caption = "Código", Visivel = true)]
        public virtual int COD_MARCA { get; set; }
        [PersonalizarColuna(Caption = "Descrição", Visivel = true)]
        public virtual String DESCRICAO { get; set; }
        [PersonalizarColuna(Caption = "Inativo", Visivel = true)]
        public virtual bool INATIVO { get; set; }
    }
}
