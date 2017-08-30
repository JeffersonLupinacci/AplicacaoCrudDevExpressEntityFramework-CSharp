using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Linq.Dynamic;
using Negocio.Net.Dominio;

namespace Negocio.Net.Integracao
{
    public partial class FrmFiltros : Negocio.Net.Integracao.FrmBase
    {
        private int ContadorFiltros = 1;
        public IEnumerable<Campo> Campos { get; set; }

        public string FiltroString = "";
        public string FiltroValuesString = "";

        #region Construtor da Classe
        public FrmFiltros()
        {
            InitializeComponent();

            labelFiltros.Text = "[+] " + Properties.Resources.LabelFiltrosPersonalizados; 
            btnConfirmar.Image = Program.Recursos.Icone("btnConfirmar");
            btnConfirmar.Text = Properties.Resources.btnConfirmar;
            btnFechar.Image = Program.Recursos.Icone("btnFechar");
            btnFechar.Text = Properties.Resources.btnFechar;
        }
        #endregion

        private void FrmFiltros_Shown(object sender, EventArgs e)
        {
            filtro_01.Campos = this.Campos;
        }

        #region Incremento de Novo Filtro
        private void labelControl4_Click(object sender, EventArgs e)
        {
            /* Componente de Filtragem */
            FiltroControl anterior_f = (FiltroControl)(this.Controls.Find("filtro_0" + (ContadorFiltros).ToString(), true)[0]);
            ContadorFiltros++;
            FiltroControl f = new FiltroControl()
            {
                Name = "filtro_0" + ContadorFiltros.ToString(),
                Parent = filtro_01.Parent,
                Left = filtro_01.Left,
                Top = anterior_f.Top + anterior_f.Height + 5,
                Campos = this.Campos
            };
            this.Height = this.Height + f.Height + 5;
            labelFiltros.Top = labelFiltros.Top + f.Height + 5;

            /* Label [E]/[OU]/[-] */
            if (ContadorFiltros == 2)
            {
                label_e_ou_01.Visible = true;
                CriarLabel("label_remove_0", "[-]", 1, label_e_ou_01.Left);
            }
            else if (ContadorFiltros > 2)
            {
                LabelControl anterior_r = (LabelControl)(this.Controls.Find("label_remove_0" + (ContadorFiltros - 1).ToString(), true)[0]);
                anterior_r.Visible = false;
                CriarLabel("label_e_ou_0", "[E]", 2, label_e_ou_01.Left);
                CriarLabel("label_remove_0", "[-]", 1, label_e_ou_01.Left);
            }
        }
        #endregion

        #region CriarLabel
        private void CriarLabel(String Nome, String Texto, int Fator, int Esquerda)
        {
            LabelControl anterior_r = (LabelControl)(this.Controls.Find(Nome + (ContadorFiltros - Fator).ToString(), true)[0]);
            LabelControl r = new LabelControl()
            {
                Name = Nome + (ContadorFiltros - (Fator - 1)).ToString(),
                Parent = label_remove_01.Parent,
                Left = Esquerda,
                Top = anterior_r.Top + anterior_r.Height + 16,
                Text = Texto,
                ForeColor = label_remove_01.ForeColor,
                Cursor = label_remove_01.Cursor,
                ToolTip = Nome + (ContadorFiltros - (Fator - 1)).ToString()
            };
            if (Nome == "label_remove_0")
                r.Click += label_remove_Click;
            else
                r.Click += label_e_ou_Click;
        }
        #endregion

        #region Label de seleção de Ligação [E] [OU]
        private void label_e_ou_Click(object sender, EventArgs e)
        {
            LabelControl C = (LabelControl)sender;
            if (C.Text == "[E]")
                C.Text = "[OU]";
            else
                C.Text = "[E]";
        }
        #endregion

        #region Label de seleção de Ligação [E] [OU]
        private void label_remove_Click(object sender, EventArgs e)
        {
            if (Funcoes.Questao(Properties.Resources.MsgGostariaDeRemover))
            {
                /* Removendo o Componete e seus Labels */
                Control[] Controle = (this.Controls.Find("filtro_0" + ContadorFiltros, true));
                if (Controle.Length > 0)
                    Controle[0].Dispose();
                Controle = (this.Controls.Find("label_remove_0" + ContadorFiltros, true));
                if (Controle.Length > 0)
                    Controle[0].Dispose();
                Controle = (this.Controls.Find("label_e_ou_0" + ContadorFiltros, true));
                if (Controle.Length > 0)
                    Controle[0].Dispose();

                /* Tamanho do Formulario */
                this.Height = this.Height - filtro_01.Height - 5;
                labelFiltros.Top = labelFiltros.Top - filtro_01.Height - 5;
                ContadorFiltros--;

                if (ContadorFiltros > 1)
                {
                    Controle = (this.Controls.Find("label_remove_0" + ContadorFiltros, true));
                    if (Controle.Length > 0)
                        Controle[0].Visible = true;
                    Controle = (this.Controls.Find("label_e_ou_0" + ContadorFiltros, true));
                    if (Controle.Length > 0)
                        Controle[0].Dispose();
                }
                else
                {
                    Controle = (this.Controls.Find("label_e_ou_0" + ContadorFiltros, true));
                    if (Controle.Length > 0)
                        Controle[0].Visible = false;
                }

            }
        }
        #endregion

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            
            for (int i = 1; i <= ContadorFiltros; i++)
            {
                Control[] ctrFiltro = this.Controls.Find("filtro_0" + i, true);
                if (ctrFiltro.Length > 0)
                {
                    if (((FiltroControl)ctrFiltro[0]).IsValid())
                    {
                        string temp = "";
                        string temp2 = "";
                        if (!String.IsNullOrEmpty(FiltroString))
                        {
                            Control[] ctrLigacao = this.Controls.Find("label_e_ou_0" + (i - 1), true);
                            if (ctrLigacao.Length > 0)
                            {
                                if (((LabelControl)ctrLigacao[0]).Text == "[E]")
                                {
                                    temp += " && ";
                                    temp2 += " e";
                                }
                                else
                                {
                                    temp += " || ";
                                    temp2 += " ou ";
                                }
                            }
                        }
                        temp += " (" + ((FiltroControl)ctrFiltro[0]).ToString() + ") ";
                        temp2 += ((FiltroControl)ctrFiltro[0]).ToValuesString();
                        
                        FiltroString += temp;
                        FiltroValuesString += temp2;
                    }
                }
            }

            if (!String.IsNullOrEmpty(FiltroString))
                this.Close();
            else
                Funcoes.Erro(Properties.Resources.FiltroIncorretoDetectado);

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
