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
    public partial class EditarUsuario : MaterialForm
    {
        public EditarUsuario()
        {
            InitializeComponent();
        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            RaquetZoneUsuarios LU1 = new RaquetZoneUsuarios();
            LU1.Show();
            this.Hide();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            String dni = dniText.Text;

            String url = "http://localhost:8081/usuario/modify" + dni;

            RaquetZone.funciones.conexion r = new RaquetZone.funciones.conexion(url, "PUT");

            String body = @"{
" + "\n" +
@"        ""dniusr"": """ + dni + "\"," + "\n" +
@"        ""nombreusr"": """ + nomText.Text + "\"," + "\n" +
@"        ""passwordusr"": """ + passText.Text + "\"," + "\n" +
@"        ""rolusr"": """ + Int32.Parse(rolCombo.Text) + "\"," + "\n" +
@"        ""telefonousr"": """ + telText.Text + "\"," + "\n" +
@"        ""emailusr"": """ + emailText.Text + "\"," + "\n" +
@"        ""direccionusr"": """ + direccText.Text + "\"" + "\n" +
@"    }";
            r.putItem(url, body);
            MessageBox.Show("El usuario ha sido modificado");
        }
    }
}
