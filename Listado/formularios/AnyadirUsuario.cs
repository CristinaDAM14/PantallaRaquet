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

        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            

            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "RaquetZoneUsuarios").SingleOrDefault<Form>();
            if (existe != null)

            {
                this.Close();
            }
            else
            {
                RaquetZoneUsuarios GU1 = new RaquetZoneUsuarios();
                GU1.Show();
                this.Close();
            }

            
        }



        private void buttonEditar_Click_1(object sender, EventArgs e)
        {

            if (funciones.funciones.IsNumeric(nombreText.Text) == false)
            {

                if (funciones.funciones.IsNumeric(telText.Text) == true)
                {
                    if (telText.Text.Length == 9)
                    {
                        String url = "http://localhost:8081/usuario/add";

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
            @"        ""direccionusr"": """ + direccText.Text + "\"" + "\n" +
            @"    }";
                        r.postItem(datos);

                        MessageBox.Show("Usuario añadido a la base de datos");
                    }
                    else
                    {
                        MessageBox.Show("Formato del número de teléfono incorrecto, tiene que tener 9 números", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Formato del número de teléfono incorrecto, no puede incluir letras", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Formato del nombre incorrecto, no puede contener números", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

    }
}
