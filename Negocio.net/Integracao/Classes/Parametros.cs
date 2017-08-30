using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Net.Integracao
{
    public enum ModoFormulario
    {
        mfInsercao,
        mfEdicao,
        mfExclusao,        
        mfVisualizacao,        
        mfNavegacao
    }

    public enum ModoGrid
    {
        mgInsercao,
        mgEdicao,
        mgVisualizacao
    }

    public static class Parametros
    {
        public static Boolean ExibirRegistroAoRemover { get { return true; } }
    }
}
