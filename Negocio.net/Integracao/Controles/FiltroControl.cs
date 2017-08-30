using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio.Net.Integracao
{
    /* Filtros para String:
     * Contem, Começa com, Termina Com 
     
     * Filtros para Inteiro, Data, 
     * Igual, Diferente, Maior que, Menor que, Entre
     */

    public partial class FiltroControl : UserControl
    {
        private TypeCode[] inteiros = new TypeCode[] { TypeCode.Int16, TypeCode.Int32, TypeCode.Int64, TypeCode.Single, TypeCode.UInt16, TypeCode.UInt32, TypeCode.UInt64 };
        private TypeCode[] flutuantes = new TypeCode[] { TypeCode.Decimal, TypeCode.Double };
        private List<string> _tiposString = new List<string>();
        private List<string> _tiposNumeric = new List<string>();

        public IEnumerable<Campo> Campos { set { edCampos.Properties.DataSource = value; } get { return (IEnumerable<Campo>)edCampos.Properties.DataSource; } }

        #region ToString()
        public override string ToString()
        {
            String strFiltro = "";
            Campo campo = (Campo)edCampos.GetSelectedDataRow();
            if (null != campo)
            {
                string tipo = (string)edTipo.GetSelectedDataRow();
                if (!string.IsNullOrEmpty(tipo))
                {
                    switch (Type.GetTypeCode(campo.FieldType))
                    {
                        #region Texto
                        case TypeCode.String:
                            {
                                if (tipo == "Igual")
                                {
                                    if (!string.IsNullOrEmpty(edTexto.Text))
                                        strFiltro = string.Format(" {0}.ToLower() == \"{1}\" ", campo.FieldName, edTexto.Text.ToLower());
                                }
                                else if (tipo == "Contêm")
                                {
                                    if (!string.IsNullOrEmpty(edTexto.Text))
                                        strFiltro = string.Format(" {0}.ToLower().Contains(\"{1}\") ", campo.FieldName, edTexto.Text.ToLower());
                                }
                                else if (tipo == "Começa com")
                                {
                                    if (!string.IsNullOrEmpty(edTexto.Text))
                                        strFiltro = string.Format(" {0}.ToLower().StartsWith(\"{1}\") ", campo.FieldName, edTexto.Text.ToLower());
                                }
                                else if (tipo == "Termina com")
                                {
                                    if (!string.IsNullOrEmpty(edTexto.Text))
                                        strFiltro = string.Format(" {0}.ToLower().EndsWith(\"{1}\") ", campo.FieldName, edTexto.Text.ToLower());
                                }
                                break;
                            }
                        #endregion
                        #region Inteiro
                        case TypeCode.Int16:
                        case TypeCode.Int32:
                        case TypeCode.Int64:
                        case TypeCode.UInt16:
                        case TypeCode.UInt32:
                        case TypeCode.UInt64:
                        case TypeCode.SByte:
                        case TypeCode.Byte:
                            {
                                if (!String.IsNullOrEmpty(edInteiroIni.Text))
                                {
                                    if (tipo == "Igual")
                                        strFiltro = string.Format(" {0} == {1} ", campo.FieldName, edInteiroIni.Text);
                                    else if (tipo == "Diferente")
                                        strFiltro = string.Format(" {0} != {1} ", campo.FieldName, edInteiroIni.Text);
                                    else if (tipo == "Maior que")
                                        strFiltro = string.Format(" {0} > {1} ", campo.FieldName, edInteiroIni.Text);
                                    else if (tipo == "Menor que")
                                        strFiltro = string.Format(" {0} < {1} ", campo.FieldName, edInteiroIni.Text);
                                    else if (tipo == "Entre")
                                        strFiltro = string.Format(" {0} >= {1} && {2} <= {3} ", campo.FieldName, edInteiroIni.Text, campo.FieldName, edInteiroFim.Text);
                                }                                
                                break;
                            }
                        #endregion
                        #region Flutuante
                        case TypeCode.Single:
                        case TypeCode.Double:
                        case TypeCode.Decimal:
                            {
                                if (tipo == "Igual")
                                    strFiltro = string.Format(" {0} == {1} ", campo.FieldName, edNumericoIni.Text.Replace(".", "").Replace(",", "."));
                                else if (tipo == "Diferente")
                                    strFiltro = string.Format(" {0} != {1} ", campo.FieldName, edNumericoIni.Text.Replace(".", "").Replace(",", "."));
                                else if (tipo == "Maior que")
                                    strFiltro = string.Format(" {0} > {1} ", campo.FieldName, edNumericoIni.Text.Replace(".", "").Replace(",", "."));
                                else if (tipo == "Menor que")
                                    strFiltro = string.Format(" {0} < {1} ", campo.FieldName, edNumericoIni.Text.Replace(".", "").Replace(",", "."));
                                else if (tipo == "Entre")
                                    strFiltro = string.Format(" {0} >= {1} && {2} <= {3} ",
                                        campo.FieldName, edNumericoIni.Text.Replace(".", "").Replace(",", "."),
                                        campo.FieldName, edNumericoFim.Text.Replace(".", "").Replace(",", "."));
                                break;
                            }
                        #endregion
                        #region Data
                        case TypeCode.DateTime:
                            {
                                if (tipo == "Igual")
                                    strFiltro = string.Format(" {0} == Convert.ToDateTime({1}) ", campo.FieldName, edDataIni.DateTime);
                                else if (tipo == "Diferente")
                                    strFiltro = string.Format(" {0} != Convert.ToDateTime({1}) ", campo.FieldName, edDataIni.DateTime);
                                else if (tipo == "Maior que")
                                    strFiltro = string.Format(" {0} > Convert.ToDateTime({1}) ", campo.FieldName, edDataIni.DateTime);
                                else if (tipo == "Menor que")
                                    strFiltro = string.Format(" {0} < Convert.ToDateTime({1}) ", campo.FieldName, edDataIni.DateTime);
                                else if (tipo == "Entre")
                                    strFiltro = string.Format(" {0} >= Convert.ToDateTime({1}) && {2} <= Convert.ToDateTime({3}) ",
                                        campo.FieldName, edDataIni.DateTime,
                                        campo.FieldName, edDataFim.DateTime.AddHours(23).AddMinutes(59).AddSeconds(59));
                                break;
                            }
                        #endregion
                    }
                }
            }
            return strFiltro;
        }
        #endregion

        #region ToValuesString
        public String ToValuesString(){
            String strFiltro = "";
            Campo campo = (Campo)edCampos.GetSelectedDataRow();
            if (null != campo)
            {
                string tipo = (string)edTipo.GetSelectedDataRow();
                if (!string.IsNullOrEmpty(tipo))
                {
                    switch (Type.GetTypeCode(campo.FieldType))
                    {
                        #region Texto
                        case TypeCode.String:
                            {
                                if (tipo == "Igual")
                                {
                                    if (!string.IsNullOrEmpty(edTexto.Text))
                                        strFiltro = string.Format(" {0} igual {1} ", campo.Caption, edTexto.Text.ToLower());
                                }
                                else if (tipo == "Contêm")
                                {
                                    if (!string.IsNullOrEmpty(edTexto.Text))
                                        strFiltro = string.Format(" {0} contêm {1} ", campo.Caption, edTexto.Text.ToLower());
                                }
                                else if (tipo == "Começa com")
                                {
                                    if (!string.IsNullOrEmpty(edTexto.Text))
                                        strFiltro = string.Format(" {0} começa com {1} ", campo.Caption, edTexto.Text.ToLower());
                                }
                                else if (tipo == "Termina com")
                                {
                                    if (!string.IsNullOrEmpty(edTexto.Text))
                                        strFiltro = string.Format(" {0} termina com {1} ", campo.Caption, edTexto.Text.ToLower());
                                }
                                break;
                            }
                        #endregion
                        #region Inteiro
                        case TypeCode.Int16:
                        case TypeCode.Int32:
                        case TypeCode.Int64:
                        case TypeCode.UInt16:
                        case TypeCode.UInt32:
                        case TypeCode.UInt64:
                        case TypeCode.SByte:
                        case TypeCode.Byte:
                            {
                                if (!String.IsNullOrEmpty(edInteiroIni.Text))
                                {
                                    if (tipo == "Igual")
                                        strFiltro = string.Format(" {0} igual {1} ", campo.Caption, edInteiroIni.Text);
                                    else if (tipo == "Diferente")
                                        strFiltro = string.Format(" {0} diferente {1} ", campo.Caption, edInteiroIni.Text);
                                    else if (tipo == "Maior que")
                                        strFiltro = string.Format(" {0} maior que {1} ", campo.Caption, edInteiroIni.Text);
                                    else if (tipo == "Menor que")
                                        strFiltro = string.Format(" {0} menor que {1} ", campo.Caption, edInteiroIni.Text);
                                    else if (tipo == "Entre")
                                        strFiltro = string.Format(" {0} entre {1} e {2} ", campo.Caption, edInteiroIni.Text, edInteiroFim.Text);
                                }                                
                                break;
                            }
                        #endregion
                        #region Flutuante
                        case TypeCode.Single:
                        case TypeCode.Double:
                        case TypeCode.Decimal:
                            {
                                if (tipo == "Igual")
                                    strFiltro = string.Format(" {0} igual {1} ", campo.Caption, edNumericoIni.Text.Replace(".", "").Replace(",", "."));
                                else if (tipo == "Diferente")
                                    strFiltro = string.Format(" {0} diferente {1} ", campo.Caption, edNumericoIni.Text.Replace(".", "").Replace(",", "."));
                                else if (tipo == "Maior que")
                                    strFiltro = string.Format(" {0} maior que {1} ", campo.Caption, edNumericoIni.Text.Replace(".", "").Replace(",", "."));
                                else if (tipo == "Menor que")
                                    strFiltro = string.Format(" {0} menor que {1} ", campo.Caption, edNumericoIni.Text.Replace(".", "").Replace(",", "."));
                                else if (tipo == "Entre")
                                    strFiltro = string.Format(" {0} entre {1} e {2} ",
                                        campo.Caption, edNumericoIni.Text.Replace(".", "").Replace(",", "."),
                                        edNumericoFim.Text.Replace(".", "").Replace(",", "."));
                                break;
                            }
                        #endregion
                        #region Data
                        case TypeCode.DateTime:
                            {
                                if (tipo == "Igual")
                                    strFiltro = string.Format(" {0} igual {1} ", campo.Caption, edDataIni.DateTime);
                                else if (tipo == "Diferente")
                                    strFiltro = string.Format(" {0} diferente {1} ", campo.Caption, edDataIni.DateTime);
                                else if (tipo == "Maior que")
                                    strFiltro = string.Format(" {0} maior que {1} ", campo.Caption, edDataIni.DateTime);
                                else if (tipo == "Menor que")
                                    strFiltro = string.Format(" {0} menor que {1} ", campo.Caption, edDataIni.DateTime);
                                else if (tipo == "Entre")
                                    strFiltro = string.Format(" {0} entre {1} e {2} ",
                                        campo.Caption, edDataIni.DateTime,
                                        edDataFim.DateTime.AddHours(23).AddMinutes(59).AddSeconds(59));
                                break;
                            }
                        #endregion
                    }
                }
            }
            return strFiltro;
        }
        #endregion

        #region IsValid()
        public bool IsValid()
        {

            Campo Campo = (Campo)edCampos.GetSelectedDataRow();
            if (null == Campo)
                return false;
            String Tipo = (String)edTipo.GetSelectedDataRow();
            if (String.IsNullOrEmpty(Tipo))
                return false;

            switch (Type.GetTypeCode(Campo.FieldType))
            {
                case TypeCode.String:
                    {
                        if (String.IsNullOrEmpty(edTexto.Text))
                            return false;
                        break;
                    }
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                case TypeCode.SByte:
                case TypeCode.Byte:
                    {
                        if (String.IsNullOrEmpty(edInteiroIni.Text))
                            return false;
                        if ((Tipo == "Entre") && (String.IsNullOrEmpty(edInteiroFim.Text)))
                            return false;
                        break;
                    }
                case TypeCode.Single:
                case TypeCode.Double:
                case TypeCode.Decimal:
                    {
                        if (String.IsNullOrEmpty(edNumericoIni.Text))
                            return false;
                        if ((Tipo == "Entre") && (String.IsNullOrEmpty(edNumericoFim.Text)))
                            return false;
                        break;
                    }
                case TypeCode.DateTime:
                    {
                        if (String.IsNullOrEmpty(edDataIni.Text))
                            return false;
                        if ((Tipo == "Entre") && (String.IsNullOrEmpty(edDataFim.Text)))
                            return false;
                        break;
                    }
            }

            return true;
        }
        #endregion

        #region Clear()
        internal void Clear()
        {
            this.edCampos.ItemIndex = -1;
            this.edTexto.Text = string.Empty;
            this.edNumericoIni.Text = string.Empty;
            this.edNumericoFim.Text = string.Empty;
            this.edInteiroIni.Text = string.Empty;
            this.edInteiroFim.Text = string.Empty;
            this.edDataIni.Text = string.Empty;
            this.edDataFim.Text = string.Empty;
        }
        #endregion

        #region Construtor da Classe
        public FiltroControl()
        {
            _tiposString.Add("Igual");
            _tiposString.Add("Contêm");
            _tiposString.Add("Começa com");
            _tiposString.Add("Termina com");

            _tiposNumeric.Add("Igual");
            _tiposNumeric.Add("Diferente");
            _tiposNumeric.Add("Maior que");
            _tiposNumeric.Add("Menor que");
            _tiposNumeric.Add("Entre");

            InitializeComponent();
        }
        #endregion

        #region Seletor de Campos
        private void edCampos_EditValueChanged(object sender, EventArgs e)
        {
            // Recuperando o valor do controle para determinar os filtros
            lblAte.Visible = false;
            this.edTexto.Text = string.Empty;
            this.edNumericoIni.Text = string.Empty;
            this.edNumericoFim.Text = string.Empty;
            this.edInteiroIni.Text = string.Empty;
            this.edInteiroFim.Text = string.Empty;
            this.edDataIni.Text = string.Empty;
            this.edDataFim.Text = string.Empty;
            this.edTexto.Enabled = true;
            this.edTexto.Visible = true;
            this.edDataIni.Visible = false;
            this.edDataFim.Visible = false;
            this.edNumericoIni.Visible = false;
            this.edNumericoFim.Visible = false;
            this.edInteiroIni.Visible = false;
            this.edInteiroFim.Visible = false;

            Campo c = (Campo)edCampos.GetSelectedDataRow();
            if (null != c)
            {

                if ((Type.GetTypeCode(c.FieldType)) == TypeCode.String)
                {
                    this.edTipo.Properties.DataSource = _tiposString;
                    this.edTipo.ItemIndex = 0;
                    if (this.edTexto.CanFocus)
                        this.edTexto.Focus();
                }
                else if ((Type.GetTypeCode(c.FieldType)) == TypeCode.DateTime)
                {
                    edTipo.Properties.DataSource = _tiposNumeric;
                    this.edTipo.ItemIndex = 0;
                    this.edTexto.Visible = false;
                    this.edDataIni.Visible = true;
                    if (this.edDataIni.CanFocus)
                        this.edDataIni.Focus();
                }
                else if (inteiros.Contains(Type.GetTypeCode(c.FieldType)))
                {
                    edTipo.Properties.DataSource = _tiposNumeric;
                    this.edTipo.ItemIndex = 0;
                    this.edTexto.Visible = false;
                    this.edInteiroIni.Visible = true;
                    if (this.edInteiroIni.CanFocus)
                        this.edInteiroIni.Focus();
                }
                else if (flutuantes.Contains(Type.GetTypeCode(c.FieldType)))
                {
                    edTipo.Properties.DataSource = _tiposNumeric;
                    this.edTipo.ItemIndex = 0;
                    this.edTexto.Visible = false;
                    this.edNumericoIni.Visible = true;
                    if (this.edNumericoIni.CanFocus)
                        this.edNumericoIni.Focus();
                }
                else
                {
                    edTipo.Properties.DataSource = _tiposString;
                    this.edTexto.Enabled = false;
                }
            }
        }
        #endregion

        #region Seletor de tipos
        private void edTipo_EditValueChanged(object sender, EventArgs e)
        {
            if (edTipo.Properties.DataSource == _tiposNumeric)
            {
                lblAte.Visible = false;
                edDataFim.Visible = false;
                edNumericoFim.Visible = false;
                edInteiroFim.Visible = false;
                if (edTipo.ItemIndex == 4)
                {
                    lblAte.Visible = true;
                    Campo c = (Campo)edCampos.GetSelectedDataRow();
                    if (null != c)
                    {
                        if (Type.GetTypeCode(c.FieldType) == TypeCode.DateTime) { edDataFim.Visible = true; }
                        else if (flutuantes.Contains(Type.GetTypeCode(c.FieldType))) { edNumericoFim.Visible = true; }
                        else if (inteiros.Contains(Type.GetTypeCode(c.FieldType))) { edInteiroFim.Visible = true; }
                    }
                }
            }
        }
        #endregion

        private void edDataIni_Leave(object sender, EventArgs e)
        {
            if (edDataFim.DateTime < edDataIni.DateTime)
                edDataFim.DateTime = edDataIni.DateTime;
        }

        private void edNumericoIni_Leave(object sender, EventArgs e)
        {
            if (edNumericoFim.Value < edNumericoIni.Value)
                edNumericoFim.Value = edNumericoIni.Value;
        }

        private void edInteiroIni_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(edInteiroIni.Text))
                if (String.IsNullOrEmpty(edInteiroFim.Text) || (Convert.ToInt64(edInteiroFim.Text) < Convert.ToInt64(edInteiroIni.Text)))
                    edInteiroFim.Text = edInteiroIni.Text;
        }

        private void edInteiroIni_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }
        
    }
}
