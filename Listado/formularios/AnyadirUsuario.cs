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

namespace RaquetZone.formularios
{
    public partial class AnyadirUsuario : Form
    {
        public AnyadirUsuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GestionUsuarios GU1 = new GestionUsuarios();
            GU1.Show();
            this.Hide();
        }

        private void anyadirButton_Click(object sender, EventArgs e)
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
            String url = "http://localhost:8081/usuario";

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
    }
}
