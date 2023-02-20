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
    public partial class AnyadirCliente : MaterialForm
    {
        public AnyadirCliente()
        {
            InitializeComponent();
        }

        private void AnyadirCliente_Load(object sender, EventArgs e)
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

        private void buttonAnyadir_Click(object sender, EventArgs e)
        {

            if (ValidarEmail(emailText.Text) == true)
            {

                if (ValidarDNI(dniText.Text) == true)
                {

                    if (ValidarNombre(nomText.Text) == true)
                    {

                        if (funciones.funciones.IsNumeric(telText.Text) == true || telText.Text.Length == 9)
                        {
                            String url = ConfigurationManager.AppSettings["AccesoBD"] + "empresa/" + TextoCIFAnyadir.Text + "/cliente";

                        funciones.conexion r = new funciones.conexion(url, "POST");

                        String datos = @"{
                    " + "\n" +
            @"        ""dnicli"": """ + dniText.Text + "\"," + "\n" +
            @"        ""nombrecli"": """ + nomText.Text + "\"," + "\n" +
            @"        ""passwordcli"": """ + passText.Text + "\"," + "\n" +
            @"        ""numhorascli"": 0," + "\n" +
            @"        ""telefonocli"": """ + telText.Text + "\"," + "\n" +
            @"        ""emailcli"": """ + emailText.Text + "\"," + "\n" +
            @"        ""activo"": "" true """ + "\n" +
            @"}";

                        String res = r.postItem(datos);

                        MessageBox.Show("Cliente añadido a la base de datos");

                        limpiar();
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
            nomText.Text = "";
            passText.Text = "";
            telText.Text = "";
            emailText.Text = "";
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
