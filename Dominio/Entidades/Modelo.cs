using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Net.Dominio.Entidades
{
    public class Modelo 
    {
        [PersonalizarColuna(Caption = "Código", Visivel = true)]
        public virtual int COD_MODELO { get; set; }
        [PersonalizarColuna(Caption = "Descrição", Visivel = true)]
        public virtual String DESCRICAO { get; set; }
        [PersonalizarColuna(Caption = "Inativo", Visivel = true)]
        public virtual bool INATIVO { get; set; }
    }
}
