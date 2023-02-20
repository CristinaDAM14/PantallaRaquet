using RestSharp;
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
    public partial class AnyadirUsuario : MaterialForm
    {
        public AnyadirUsuario()
        {
            InitializeComponent();

            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "PantallaPrincipalRol2").SingleOrDefault<Form>();
            if (existe != null)

            {

                this.Text = "Añadir Empleado";
                rolCombo.Text = "Empleado";
                rolCombo.Enabled = false;

            }

        }

        private void AnyadirUsuario_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);

            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "PantallaPrincipalRol2").SingleOrDefault<Form>();
            if (existe != null)
            {
                textEmpresa.Visible = false;
                textEmpresa.Enabled = false;
                bEmpresa.Visible = false;
                bEmpresa.Enabled = false;
                labelEmpresa.Visible = false;
                labelEmpresa.Enabled = false;

            } 
        }

        private void bVolver_Click(object sender, EventArgs e)
        {

            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "RaquetZoneUsuarios").SingleOrDefault<Form>();
            if (existe != null)

            {
                MessageBox.Show("Esa ventana ya está abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                RaquetZoneUsuarios LU1 = new RaquetZoneUsuarios();
                LU1.TextoCIFC.Text = TextoCIFAnyadir.Text;
                LU1.Show();
                this.Close();
            }
        }



        private void buttonEditar_Click_1(object sender, EventArgs e)
        {

            Form existe1 = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "PantallaPrincipalRol2").SingleOrDefault<Form>();

            if (ValidarEmail(emailText.Text) == true)
            {

                if (ValidarDNI(dniText.Text) == true)
                {

                    if (ValidarNombre(nombreText.Text) == true)
                    {

                        if (funciones.funciones.IsNumeric(telText.Text) == true || telText.Text.Length == 9)
                        {

                                if (textEmpresa.Text.Equals("") && existe1 == null)
                                {
                                    MessageBox.Show("No puedes dejar el campo de la empresa vacío", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else if (!textEmpresa.Text.Equals(""))
                                {
                                    String url = ConfigurationManager.AppSettings["AccesoBD"] + "empresa/" + textEmpresa.Text + "/usuario";

                                    funciones.conexion r = new funciones.conexion(url, "POST");

                                    int num = SeleccionarRol(rolCombo.Text);

                                    String datos = @"{
" + "\n" +
                        @"        ""dniusr"": """ + dniText.Text + "\"," + "\n" +
                        @"        ""nombreusr"": """ + nombreText.Text + "\"," + "\n" +
                        @"        ""passwordusr"": """ + passText.Text + "\"," + "\n" +
                        @"        ""rolusr"": """ + num + "\"," + "\n" +
                        @"        ""telefonousr"": """ + telText.Text + "\"," + "\n" +
                        @"        ""emailusr"": """ + emailText.Text + "\"," + "\n" +
                        @"        ""direccionusr"": """ + direccText.Text + "\"," + "\n" +
                        @"        ""activo"": "" true ""," + "\n" +
                        @"        ""empresa"": [" + "\n" +
                        @"            {" + "\n" +
                        @"                ""cifemp"": """ + textEmpresa.Text + "\"" + "\n" +
                        @"            }" + "\n" +
                        @"            ]" + "\n" +
                        @"}";
                                    r.postItem(datos);

                                    MessageBox.Show("Usuario añadido a la base de datos");

                                    limpiar();
                                }
                                else
                                {
                                    String url = ConfigurationManager.AppSettings["AccesoBD"] + "empresa/" + TextoCIFAnyadir.Text + "/usuario";

                                    funciones.conexion r = new funciones.conexion(url, "POST");

                                    int num = SeleccionarRol(rolCombo.Text);

                                    String datos = @"{
" + "\n" +
                        @"        ""dniusr"": """ + dniText.Text + "\"," + "\n" +
                        @"        ""nombreusr"": """ + nombreText.Text + "\"," + "\n" +
                        @"        ""passwordusr"": """ + passText.Text + "\"," + "\n" +
                        @"        ""rolusr"": """ + num + "\"," + "\n" +
                        @"        ""telefonousr"": """ + telText.Text + "\"," + "\n" +
                        @"        ""emailusr"": """ + emailText.Text + "\"," + "\n" +
                        @"        ""direccionusr"": """ + direccText.Text + "\"," + "\n" +
                        @"        ""activo"": "" true ""," + "\n" +
                        @"        ""empresa"": [" + "\n" +
                        @"            {" + "\n" +
                        @"                ""cifemp"": """ + TextoCIFAnyadir.Text + "\"" + "\n" +
                        @"            }" + "\n" +
                        @"            ]" + "\n" +
                        @"}";
                                    r.postItem(datos);

                                    MessageBox.Show("Usuario añadido a la base de datos");

                                    limpiar();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Formato del número de teléfono incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                    }
                    else
                    {
                        MessageBox.Show("Formato del nombre incorrecto, no puede contener números", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Formato del DNI incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Formato del Email incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void limpiar()
        {
            dniText.Text = "";
            nombreText.Text = "";
            passText.Text = "";
            direccText.Text = "";
            emailText.Text = "";
            telText.Text = "";
            textEmpresa.Text = "";
        }

        private int SeleccionarRol(string rol)
        {
            int num = 0;

            if (rol.Equals("Empleado"))
            {
                num = 1;
            }
            else if(rol.Equals("Administrador"))
            {
                num = 2;
            }
            else
            {
                num = 3;
            }

            return num;
        }

        public void conseguirCIF(string cif)
        {
            textEmpresa.Text = cif;
        }

        private void bEmpresa_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "RaquetZoneEmpresas").SingleOrDefault<Form>();
            if (existe != null)

            {
                MessageBox.Show("Esa ventana ya está abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                RaquetZoneEmpresas RU = new RaquetZoneEmpresas();
                RU.Show();
            }
        }

        //Validaciones
        static bool ValidarDNI(string dni)
        {
            if (dni.Length != 9)
            {
                return false;
            }

            string dniNumbers = dni.Substring(0, dni.Length - 1);
            string dniLeter = dni.Substring(dni.Length - 1, 1);
            var numbersValid = int.TryParse(dniNumbers, out int dniInteger);
            if (!numbersValid)
            {
                return false;
            }
            if (CalcularLetra(dniInteger) != dniLeter)
            {
                return false;
            }
            return true;
        }


        static string CalcularLetra(int num)
        {
            string[] control = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
            var mod = num % 23;
            return control[mod];
        }

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

        public bool ValidarNombre(string nombre)
        {
            bool contieneSoloLetras = Regex.IsMatch(nombre, @"^[a-zA-Z]+$");
            return contieneSoloLetras;
        }
    }
}

