using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Configuration;

namespace RaquetZone.formularios
{
    public partial class AnyadirEmpresa : MaterialForm
    {
        public AnyadirEmpresa()
        {
            InitializeComponent();
        }

        private void AnyadirEmpresa_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);

        }

        private void bVolver_Click(object sender, EventArgs e)
        {

            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "RaquetZoneEmpresas").SingleOrDefault<Form>();
            if (existe != null)

            {
                MessageBox.Show("Esa ventana ya está abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                RaquetZoneEmpresas LU1 = new RaquetZoneEmpresas();
                LU1.Show();
                this.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarEmail(emailText.Text) == true)
            {

                if (ValidarCIF(cifText.Text) == true)
                {
                    if (ValidarWeb(webText.Text) == true)
                    {

                        if (funciones.funciones.IsNumeric(telText.Text) == true || telText.Text.Length == 9)
                        {

                        String url = ConfigurationManager.AppSettings["AccesoBD"] + "empresa/add";

                                        funciones.conexion r = new funciones.conexion(url, "POST");

                                        String datos = @"{
                        " + "\n" +
                            @"        ""cifemp"": """ + cifText.Text + "\"," + "\n" +
                            @"        ""nomemp"": """ + nomText.Text + "\"," + "\n" +
                            @"        ""webemp"": """ + webText.Text + "\"," + "\n" +
                            @"        ""telemp"": """ + telText.Text + "\"," + "\n" +
                            @"        ""emailemp"": """ + emailText.Text + "\"," + "\n" +
                            @"        ""direcemp"": """ + direcText.Text + "\"," + "\n" +
                            @"        ""activiemp"": """ + actText.Text + "\"" + "\n" +
                            @"    }";
                                        String res = r.postItem(datos);

                                        MessageBox.Show("Empresa añadida a la base de datos");
                                        limpiar();

                        }
                        else
                        {
                            MessageBox.Show("Formato del número de teléfono incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Formato de la dirección Web incorrecta, tiene que tener un formato de \"www.ejemplo.com\" ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Formato del CIF incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Formato del Email incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

                


        }

        private void limpiar()
        {
            cifText.Text = "";
            nomText.Text = "";
            webText.Text = "";
            telText.Text = "";
            emailText.Text = "";
            direcText.Text = "";
            actText.Text = "";
        }

        //Validaciones

        public bool ValidarEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                string DomainMapper(Match match)
                {
                    var idn = new IdnMapping();

                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

        }

        public bool ValidarCIF(string cif)
        {
            if (string.IsNullOrEmpty(cif)) return false;
            cif = cif.Trim().ToUpper();

            if (cif.Length != 9) return false;
            string firstChar = cif.Substring(0, 1);

            string cadena = "ABCDEFGHJNPQRSUVW";
            if (cadena.IndexOf(firstChar) == -1) return false;
            try
            {
                Int32 sumaPar = default(Int32);
                Int32 sumaImpar = default(Int32);

                string cif_sinControl = cif.Substring(0, 8);
                string digits = cif_sinControl.Substring(1, 7);
                for (Int32 n = 0; n <= digits.Length - 1; n += 2)
                {
                    if (n < 6)
                    {
                        sumaPar += Convert.ToInt32(digits[n + 1].ToString());
                    }
                    Int32 dobleImpar = 2 * Convert.ToInt32(digits[n].ToString());

                    sumaImpar += (dobleImpar % 10) + (dobleImpar / 10);
                }

                Int32 sumaTotal = sumaPar + sumaImpar;

                sumaTotal = (10 - (sumaTotal % 10)) % 10;

                string digitoControl = "";
                switch (firstChar)
                {
                    case "N":
                    case "P":
                    case "Q":
                    case "R":
                    case "S":
                    case "W":

                        char[] characters = { 'J', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I' };
                        digitoControl = characters[sumaTotal].ToString();
                        break;
                        digitoControl = sumaTotal.ToString();
                        break;
                }
                return digitoControl.Equals(cif.Substring(8, 1));
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ValidarWeb(string direccionWeb)
        {
            string webCompleta = "https://" + direccionWeb;
            Uri uri;
            bool esDireccionWeb = Uri.TryCreate(webCompleta, UriKind.Absolute, out uri)
                                  && (uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps);
            return esDireccionWeb;
        }
    }
}
