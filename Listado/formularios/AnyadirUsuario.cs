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
        }

        private void AnyadirUsuario_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            /*
             Aqui se obtienen los datos y se genera la cadena JSON que se envia
             */

            String dni = dniText.Text;
            String nombre = nombreText.Text;
            String password = passText.Text;
            int rol = Int32.Parse(rolCombo.Text);
            String telefono = telText.Text;
            String email = emailText.Text;
            String direccion = direccText.Text;


            /* No se comprueban errores */
            String url = "http://localhost:8081/usuario/add";

            RaquetZone.funciones.conexion r = new RaquetZone.funciones.conexion(url, "POST");

            String datos = @"{
" + "\n" +
@"        ""dniusr"": """ + dni + "\"," + "\n" +
@"        ""nombreusr"": """ + nombre + "\"," + "\n" +
@"        ""passwordusr"": """ + password + "\"," + "\n" +
@"        ""rolusr"": """ + rol + "\"," + "\n" +
@"        ""telefonousr"": """ + telefono + "\"," + "\n" +
@"        ""emailusr"": """ + email + "\"," + "\n" +
@"        ""direccionusr"": """ + direccion + "\"" + "\n" +
@"    }";
            String res = r.postItem(datos);

            MessageBox.Show("Resultado: " + datos);
            
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            GestionUsuarios GU1 = new GestionUsuarios();
            GU1.Show();
            this.Hide();
        }
    }
}
