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
                rolCombo.Text = "1";
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
            GestionUsuarios GU1 = new GestionUsuarios();
            GU1.Show();
            this.Close();
        }

        private void buttonEditar_Click_1(object sender, EventArgs e)
        {
            String url = "http://localhost:8081/usuario/add";

            funciones.conexion r = new funciones.conexion(url, "POST");

            String datos = @"{
" + "\n" +
@"        ""dniusr"": """ + dniText.Text + "\"," + "\n" +
@"        ""nombreusr"": """ + nombreText.Text + "\"," + "\n" +
@"        ""passwordusr"": """ + passText.Text + "\"," + "\n" +
@"        ""rolusr"": """ + Int32.Parse(rolCombo.Text) + "\"," + "\n" +
@"        ""telefonousr"": """ + telText.Text + "\"," + "\n" +
@"        ""emailusr"": """ + emailText.Text + "\"," + "\n" +
@"        ""direccionusr"": """ + direccText.Text + "\"" + "\n" +
@"    }";
            String res = r.postItem(datos);

            MessageBox.Show("Usuario añadido a la base de datos");
        }
    }
}
