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

namespace RaquetZone.formularios.Rol2
{
    public partial class EditarClientes : MaterialForm
    {
        
        public EditarClientes(string dni, string nom, string pass, string num, string tel, string email, string activo)
        {
            InitializeComponent();
            dniText.Text = dni;
            nomText.Text = nom;
            passText.Text = pass;
            numNum.Value = Int32.Parse(num);
            telText.Text = tel;
            emailText.Text = email;
            if (activo.Equals("true"))
            {
                actiBox.SelectedItem = "Activo";
            }
            else
            {
                actiBox.SelectedItem = "No Activo";
            }
        }


        private void EditarClientes_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);

        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "ListadoClientes").SingleOrDefault<Form>();
            if (existe != null)

            {
                MessageBox.Show("Esa ventana ya está abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                ListadoClientes GC = new ListadoClientes();
                GC.TextoCIFC.Text = TextoCIFAnyadir.Text;
                GC.Show();
                this.Close();
            }
        }

        private void editarB_Click(object sender, EventArgs e)
        {
            if (ValidarEmail(emailText.Text) == true)
            {

                if (ValidarDNI(dniText.Text) == true)
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

                                String url = ConfigurationManager.AppSettings["AccesoBD"] + "cliente/modify/" + dniText.Text;

                                funciones.conexion r = new funciones.conexion(url, "PUT");

                                String datos = @"{
                    " + "\n" +
                    @"        ""dnicli"": """ + dniText.Text + "\"," + "\n" +
                    @"        ""nombrecli"": """ + nomText.Text + "\"," + "\n" +
                    @"        ""passwordcli"": """ + passText.Text + "\"," + "\n" +
                    @"        ""numhorascli"": " + numNum.Value + "," + "\n" +
                    @"        ""telefonocli"": """ + telText.Text + "\"," + "\n" +
                    @"        ""emailcli"": """ + emailText.Text + "\"," + "\n" +
                    @"        ""activo"": " + numActi + "" + "\n" +
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
