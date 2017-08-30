using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Negocio.Net.Integracao
{
    public class Validador : IDisposable
    {
        /// <summary>
        /// Formulário Vinculado ao Validador
        /// </summary>
        private FrmBase innerFormulario =null;

        /// <summary>
        /// Lista de Validações que o Validador estará tratando
        /// </summary>
        private List<Validacao> innerValidacoes =new List<Validacao>();
        
        /// <summary>
        /// Somente Leitura - Formulário Vinculado a Instância do Validador
        /// </summary>
        public FrmBase Formulario { set { innerFormulario = value; } }
        
        /// <summary>
        /// Somente Leitura = Listagem das Validações Relacionadas ao Validador
        /// </summary>
        public List<Validacao> Validacoes { get { return innerValidacoes; } }

        /// <summary>
        /// Função de Limpeza das Validações Existentes dentro do Validador
        /// </summary>
        public void Limpar() { innerValidacoes.Clear(); }
        
        /// <summary>
        /// Adicionar uma mensagem a exibir ao usuário pois ocorreu uma validação
        /// </summary>
        /// <param name="Mensagem">Mensagem em Formato String</param>
        /// <param name="Controle">Controle visual que receberá foco ao clicar na grade</param>
        public void Adicionar(String Mensagem, Control Controle) {
            innerValidacoes.Add(new Validacao(Mensagem, Controle));
        }

        /// <summary>
        /// Booleano que informa se o Validador possui mensagens de erro e seus devidos componentes
        /// </summary>
        /// <returns>Verdadeiro caso possua erros </returns>
        public bool PossuiPendencias() {
            return (innerValidacoes.Count > 0) ? true : false;
        }

        /// <summary>
        /// Exibe um formulário contendo todas as mensagens de erro que o usuario poderá visualizar
        /// </summary>
        public void ExibePendencias()
        {
            if (PossuiPendencias())
            {
                using (TratarExcessao e = new TratarExcessao())
                {
                    e.Text = Properties.Resources.FrmText_TratarValidacao;
                    e.Validacoes = Validacoes;
                    e.ShowDialog();

                    if (null != e.Controle)
                    {
                        System.Windows.Forms.Control[] c = innerFormulario.Controls.Find(e.Controle.Name, true);
                        if (null != c)
                        {
                            if (c[0].CanFocus)
                                c[0].Focus();
                        }
                    }
                }                
            }
            
        }

        public void Dispose()
        {
            Limpar();        
        }
    }
}
