using Negocio.Net.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Negocio.Net.Integracao
{
    public static class Funcoes
    {
        [DllImport("DllInscE32.dll")]
        public static extern int ConsisteInscricaoEstadual(string vInsc, string vUF);

        private static readonly char[] Divisores = new char[] { '.', '/', '-' };

        private static readonly string[] Formatos = new string[] {
            "yyyy/MM/dd", "yyyy.MM.dd", "yyyy-MM-dd", 
            "yyyy/dd/MM", "yyyy.dd.MM", "yyyy-dd-MM",
            "dd/MM/yyyy", "dd.MM.yyyy", "dd-MM-yyyy",
            "MM/dd/yyyy", "MM.dd.yyyy", "MM-dd-yyyy",
            "yyyyMMdd", "ddMMyyyy", "MMddyyyy"
        };

        public static bool ModoDebug = System.Diagnostics.Debugger.IsAttached;

        #region Booleano Questao(Pergunta ao usuario)
        public static Boolean Questao(String s)
        {
            DialogResult dr = MessageBox.Show(s, Properties.Resources.ApplicationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                return true;
            else
                return false;
        }
        #endregion

        #region AlertaComponente(Mensagem, Componente Visual)
        public static void AlertaComponente(String s, Control sender)
        {
            // Executa a Mensagem de Alerta
            Alerta(s);
            if (sender.CanFocus)
                sender.Focus();
        }
        #endregion

        #region Alerta(Mensagem)
        public static void Alerta(String s)
        {
            MessageBox.Show(s, Properties.Resources.ApplicationName, MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
        }
        #endregion

        #region Erro(Mensagem)
        public static void Erro(String s)
        {
            MessageBox.Show(s, Properties.Resources.ApplicationName, MessageBoxButtons.OK,
                            MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }
        #endregion

        #region ContemLetras
        public static bool contemLetras(string letras)
        {
            if (letras.Where(c => char.IsLetter(c)).Count() > 0)
                return true;
            else
                return false;
        }
        #endregion

        #region ContemNumeros
        public static bool contemNumeros(string numeros)
        {
            if (numeros.Where(c => char.IsNumber(c)).Count() > 0)
                return true;
            else
                return false;
        }
        #endregion

        #region ContemLetrasEnumeros
        public static bool ContemLetrasEnumeros(string texto)
        {
            if (contemLetras(texto) && contemNumeros(texto))
                return true;
            else
                return false;
        }
        #endregion

        #region NumeroInteiroValido
        public static bool NumeroInteiroValido(string numero)
        {
            Regex rgx = new Regex(@"^[0-9]+$");
            if (rgx.IsMatch(numero))
                return true;
            else
                return false;
        }
        #endregion

        #region NumeroRealValido
        public static bool NumeroRealValido(string numeroreal)
        {
            Regex rgx = new Regex(@"^[0-9]+?(.|,[0-9]+)$");
            if (rgx.IsMatch(numeroreal))
                return true;
            else
                return false;
        }
        #endregion

        #region CepValido
        public static bool CepValido(string cep)
        {
            Regex rgx = new Regex(@"^\d{5}\-?\d{3}$");
            if (rgx.IsMatch(cep))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region EmailValido
        public static bool EmailValido(string email)
        {
            Regex rgx = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
            if (rgx.IsMatch(email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region UrlValida
        public static bool UrlValida(string http)
        {
            Regex rgx = new Regex(@"^((http)|(https)|(ftp)):\/\/([\- \w]+\.)+\w{2,3}(\/ [%\-\w]+(\.\w{2,})?)*$");
            if (rgx.IsMatch(http))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region IpValido
        public static bool IpValido(string ip)
        {
            Regex rgx = new Regex(@"^\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b$");
            if (rgx.IsMatch(ip))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region DataValida
        public static bool DataValida(string data)
        {
            Regex rgx = new Regex(@"^((0[1-9]|[12]\d)\/(0[1-9]|1[0-2])|30\/(0[13-9]|1[0-2])|31\/(0[13578]|1[02]))\/\d{4}$");
            if (rgx.IsMatch(data))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region TelefoneValido
        public static bool TelefoneValido(string telefone)
        {
            Regex rgx = new Regex(@"^([0-9]{2})\s[0-9]{4}-[0-9]{4}$");
            if (rgx.IsMatch(telefone))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region CpfValido
#pragma warning disable 0162
        public static bool CpfValido(string cpf)
        {
            // Se vazio
            if (cpf.Length == 0)
                return false;

            //Expressao regular que valida cpf
            Regex rgx = new Regex(@"^\d{3}\.?\d{3}\.?\d{3}\-?\d{2}$");
            if (rgx.IsMatch(cpf))
            {
                return true;
            }
            else
            {
                return false;
            }

            // Limpa caracteres especiais pontos e espaços
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "").Replace("/", "").Replace(" ", "");
            cpf = cpf.Replace("+", "").Replace("*", "").Replace(",", "").Replace("?", "");
            cpf = cpf.Replace("!", "").Replace("@", "").Replace("#", "").Replace("$", "");
            cpf = cpf.Replace("%", "").Replace("¨", "").Replace("&", "").Replace("(", "");
            cpf = cpf.Replace("=", "").Replace("[", "").Replace("]", "").Replace(")", "");
            cpf = cpf.Replace("{", "").Replace("}", "").Replace(":", "").Replace(";", "");
            cpf = cpf.Replace("<", "").Replace(">", "").Replace("ç", "").Replace("Ç", "");

            // Se so tem numeros
            if (contemLetras(cpf))
                return false;
            else
                return true;

            // Se o tamanho for < 11 entao retorna como inválido
            if (cpf.Length != 11)
                return false;

            // Caso coloque todos os numeros iguais
            switch (cpf)
            {
                case "11111111111": return false;
                case "00000000000": return false;
                case "2222222222": return false;
                case "33333333333": return false;
                case "44444444444": return false;
                case "55555555555": return false;
                case "66666666666": return false;
                case "77777777777": return false;
                case "88888888888": return false;
                case "99999999999": return false;
            }

            // Calcula Validade do CPF
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
                return false;

            tempCpf = cpf.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }
#pragma warning restore 0162
        #endregion

        #region CnpjValido
#pragma warning disable 0162
        public static bool CnpjValido(string cnpj)
        {
            // Se vazio
            if (cnpj.Length == 0)
                return false;

            //Expressao regular que valida cpf
            Regex rgx = new Regex(@"^\d{2}.?\d{3}.?\d{3}/?\d{4}-?\d{2}$");
            if (rgx.IsMatch(cnpj))
            {
                return true;
            }
            else
            {
                return false;
            }

            // Limpa caracteres especiais
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "").Replace(" ", "");
            cnpj = cnpj.Replace("+", "").Replace("*", "").Replace(",", "").Replace("?", "");
            cnpj = cnpj.Replace("!", "").Replace("@", "").Replace("#", "").Replace("$", "");
            cnpj = cnpj.Replace("%", "").Replace("¨", "").Replace("&", "").Replace("(", "");
            cnpj = cnpj.Replace("=", "").Replace("[", "").Replace("]", "").Replace(")", "");
            cnpj = cnpj.Replace("{", "").Replace("}", "").Replace(":", "").Replace(";", "");
            cnpj = cnpj.Replace("<", "").Replace(">", "").Replace("ç", "").Replace("Ç", "");

            // Se comtem letras
            if (contemLetras(cnpj))
                return false;
            else
                return true;

            // Se o tamanho for < 11 entao retorna como inválido
            if (cnpj.Length != 14)
                return false;

            // Caso coloque todos os numeros iguais
            switch (cnpj)
            {
                case "11111111111111": return false;
                case "00000000000000": return false;
                case "22222222222222": return false;
                case "33333333333333": return false;
                case "44444444444444": return false;
                case "55555555555555": return false;
                case "66666666666666": return false;
                case "77777777777777": return false;
                case "88888888888888": return false;
                case "99999999999999": return false;
            }

            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;

            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");

            if (cnpj.Length != 14)
                return false;

            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;

            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            resto = (soma % 11);

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;

            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }
#pragma warning restore 0162
        #endregion

        #region bool ComtemSomenteNumeros
        /// <summary>
        /// Verifica se a a string possui somente números 
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static bool ContemSomenteNumeros(string numero)
        {
            Regex rx = new Regex(@"^\d+$");
            return rx.IsMatch(numero);
        }
        #endregion

        #region bool ComtemSomenteLetras
        /// <summary>
        /// Verifica se a a string possui somente letras
        /// </summary>
        /// <param name="palavra"></param>
        /// <returns></returns>
        public static bool ContemSomenteLetras(string palavra)
        {
            Regex rx = new Regex(@"^[a-zA-Z]*$");
            return rx.IsMatch(palavra);
        }
        #endregion

        #region string SomenteNumeros
        /// <summary>
        /// Retorna somente números de uma determinada string
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static string SomenteNumeros(string numero)
        {
            return string.Join(null, System.Text.RegularExpressions.Regex.Split(numero, "[^\\d]"));
        }
        #endregion

        public static DateTime? StringToDate(string value)
        {
            // Somente Numeros
            var data = new String(value.Where(c => Char.IsDigit(c) || Divisores.Contains(c)).ToArray());

            // Tenta converter nos formatos esperados:
            DateTime retorno;
            foreach (var formato in Formatos)
            {
                if (DateTime.TryParseExact(data, formato, CultureInfo.CurrentCulture, DateTimeStyles.None, out retorno))
                    return retorno;
            }

            // Formato desconhecido.
            return null;
        }

        #region Validação da Inscrição Estadual utilizando a DLL do Sintegra
        public static Boolean InscricaoEstadualValida(String InscricaoEstadual, String Estado)
        {
            if (ConsisteInscricaoEstadual(InscricaoEstadual, Estado) == 1)
                return true;
            else
                return false;
        }
        #endregion

        #region Recupera o Caption do Atributo gravado na anotação da classe
        public static string CaptionDoAttributo(Type Classe, String Campo)
        {
            var props = from p in Classe.GetProperties()
                        let attr = p.GetCustomAttributes(typeof(PersonalizarColuna), true)
                        where attr.Length == 1 && p.Name == Campo
                        select new { Property = p, Attribute = attr.First() as PersonalizarColuna };

            return props.FirstOrDefault().Attribute.Caption;
        }
        #endregion

        #region Listagem dos Atributos da Classe
        public static IEnumerable<Campo> AtributosDaClasse(Type Classe)
        {
            if (null != Classe)
            {
                var props = from p in Classe.GetProperties()
                            let attr = p.GetCustomAttributes(typeof(PersonalizarColuna), true)
                            where attr.Length == 1
                            select new Campo
                            {
                                FieldType = p.PropertyType,
                                FieldName = (attr.First() as PersonalizarColuna).Coluna != null ? (attr.First() as PersonalizarColuna).Coluna : p.Name,
                                Caption = (attr.First() as PersonalizarColuna).Caption,
                                Visible = (attr.First() as PersonalizarColuna).Visivel,
                                ExibirNoCustomizador = (attr.First() as PersonalizarColuna).ExibirNoCustomizador
                            };
                return props;
            }
            else { return null; }
        }
        #endregion

        #region Conversão do XML do Filtro em List<Filtro>
        public static List<Filtro> DeserializarFiltro(String Xml)
        {
            XmlSerializer x = new XmlSerializer(typeof(List<Filtro>));
            return (List<Filtro>)x.Deserialize(new StringReader(Xml));
        }
        #endregion

        #region Conversão da List<Filtro> em XML
        public static string SerializarFiltro(List<Filtro> Filtros)
        {
            XmlDocument serialXml = new XmlDocument();
            using (var xs = serialXml.CreateNavigator().AppendChild())
            {
                XmlSerializer XmlSerializer = new XmlSerializer(Filtros.GetType());
                XmlSerializer.Serialize(xs, Filtros);
            }
            return serialXml.OuterXml;
        }
        #endregion

        public static IEnumerable<Control> RecuperaControles(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => RecuperaControles(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        public static IEnumerable<Control> RecuperaControles(IList<Control> controls, Type type)
        {
            return controls.Where(c => c.GetType() == type);
        }

        public static void ExibirExcessao(Exception ex)
        {
            using (TratarExcessao e = new TratarExcessao())
            {
                e.Text = Properties.Resources.FrmText_TratarExcessao;
                e.Excessao = ex;
                e.ShowDialog();
            }
        }
        
        public static void ConfigurarColunasGrid(DevExpress.XtraGrid.Views.Grid.GridView grid, Type TypeDados)
        {
            IEnumerable<Campo> Campos = Funcoes.AtributosDaClasse(TypeDados);
            foreach (DevExpress.XtraGrid.Columns.GridColumn coluna in grid.Columns)
            {
                Campo Campo = Campos.Where(x => x.FieldName == coluna.FieldName).FirstOrDefault();
                if (null != Campo)
                {
                    coluna.Caption = Campo.Caption;
                    coluna.OptionsColumn.ShowInCustomizationForm = (Campo.Visible == true ? Campo.Visible : Campo.ExibirNoCustomizador);
                }
            }
        }
    }
}
