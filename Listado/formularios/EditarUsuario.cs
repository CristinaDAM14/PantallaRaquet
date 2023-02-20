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
    public partial class EditarUsuario : MaterialForm
    {
        public EditarUsuario(string dni, string nom, string pass, string rol, string tel, string email, string direcc, string activo)
        {
            InitializeComponent();

            dniText.Text = dni;
            nomText.Text = nom;
            passText.Text = pass;

            string rolCompleto = PasarNumRol(rol);

            rolCombo.Text = rolCompleto; 
            telText.Text = tel;
            emailText.Text = email;
            direccText.Text = direcc;
            if (activo.Equals("true"))
            {
                actiBox.SelectedItem = "Activo";
            }
            else
            {
                actiBox.SelectedItem = "No Activo";
            }
           

        }
        

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);

            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "PantallaPrincipalRol2").SingleOrDefault<Form>();
            if (existe != null)

            {
                rolCombo.Enabled = false;
                this.Text = "Editar Empleado";

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

        private void editarB_Click(object sender, EventArgs e)
        {
            if (ValidarEmail(emailText.Text) == true)
            {

                    if (ValidarNombre(nomText.Text) == true)
                    {

                        if (funciones.funciones.IsNumeric(telText.Text) == true || telText.Text.Length == 9)
                        {
                            string numActi = "false";

                            if (actiBox.GetItemText(actiBox.SelectedItem).Equals("Activo"))
                            {
                                numActi = "true";
                            }

                            String url =  ConfigurationManager.AppSettings["AccesoBD"] + "usuario/modify/" + dniText.Text;

                            funciones.conexion r = new funciones.conexion(url, "PUT");

                            int num = SeleccionarRol(rolCombo.Text);

                            String body = @"{
" + "\n" +
                @"        ""dniusr"": """ + dniText.Text + "\"," + "\n" +
                @"        ""nombreusr"": """ + nomText.Text + "\"," + "\n" +
                @"        ""passwordusr"": """ + passText.Text + "\"," + "\n" +
                @"        ""rolusr"": """ + num + "\"," + "\n" +
                @"        ""telefonousr"": """ + telText.Text + "\"," + "\n" +
                @"        ""emailusr"": """ + emailText.Text + "\"," + "\n" +
                @"        ""direccionusr"": """ + direccText.Text + "\"," + "\n" +
                @"        ""activo"": " + numActi + "," + "\n" +
                @"        ""empresa"": [" + "\n" +
                @"            {" + "\n" +
                @"     ""cifemp"": """ + TextoCIFAnyadir.Text + "\"" + "\n" +
                @"            }" + "\n" +
                @"        ]" + "\n" +
                @"    }";
                            r.putItem(url, body);
                            MessageBox.Show("Editado con éxito");

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
                MessageBox.Show("Formato del Email incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private int SeleccionarRol(string rol)
        {
            int num = 0;

            if (rol.Equals("Empleado"))
            {
                num = 1;
            }
            else if (rol.Equals("Administrador"))
            {
                num = 2;
            }
            else
            {
                num = 3;
            }

            return num;
        }

        private string PasarNumRol(string num)
        {
            string rol = "";

            if (num.Equals("1"))
            {
                rol = "Empleado";
            }
            else if (num.Equals("2"))
            {
                rol = "Administrador";
            }
            else
            {
                rol = "SuperAdmin";
            }

            return rol;
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
