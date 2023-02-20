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
    public partial class EditarEmpresa : MaterialForm
    {
        public EditarEmpresa(string cif, string nom, string web, string tel, string email, string direc, string acti)
        {
            InitializeComponent();
            cifText.Text = cif;
            nomText.Text = nom;
            webText.Text = web;
            telText.Text = tel;
            emailText.Text = email;
            direccText.Text = direc;
            actiText.Text = acti;

        }

        private void EditarEmpresa_Load(object sender, EventArgs e)
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

        private void buttonEditar_Click_1(object sender, EventArgs e)
        {
            if (ValidarEmail(emailText.Text) == true)
            {
                    if (ValidarWeb(webText.Text) == true)
                    {

                        if (funciones.funciones.IsNumeric(telText.Text) == true || telText.Text.Length == 9)
                        {

                        String url = ConfigurationManager.AppSettings["AccesoBD"] + "empresa/modify/" + cifText.Text;

                        funciones.conexion r = new funciones.conexion(url, "PUT");

                        String datos = @"{
            " + "\n" +
            @"        ""cifemp"": """ + cifText.Text + "\"," + "\n" +
            @"        ""nomemp"": """ + nomText.Text + "\"," + "\n" +
            @"        ""webemp"": """ + webText.Text + "\"," + "\n" +
            @"        ""telemp"": """ + telText.Text + "\"," + "\n" +
            @"        ""emailemp"": """ + emailText.Text + "\"," + "\n" +
            @"        ""direcemp"": """ + direccText.Text + "\"," + "\n" +
            @"        ""activiemp"": """ + actiText.Text + "\"" + "\n" +
            @"    }";

                        r.putItem(url, datos);

                        MessageBox.Show("Editado con éxito");
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
                    MessageBox.Show("Formato del Email incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            
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
