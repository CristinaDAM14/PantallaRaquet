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
        public EditarUsuario(string dni, string nom, string pass, string rol, string tel, string email, string direcc)
        {
            InitializeComponent();

            dniText.Text = dni;
            nomText.Text = nom;
            passText.Text = pass;
            rolCombo.Text = rol; 
            telText.Text = tel;
            emailText.Text = email;
            direccText.Text = direcc;
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

                this.Text = "Editar Empleado";

            }
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            RaquetZoneUsuarios LU1 = new RaquetZoneUsuarios();
            LU1.Show();
            this.Close();
        }

        private void editarB_Click(object sender, EventArgs e)
        {
            String url = "http://localhost:8081/usuario/modify" + dniText.Text;

            funciones.conexion r = new funciones.conexion(url, "PUT");

            String body = @"{
" + "\n" +
@"        ""dniusr"": """ + dniText.Text + "\"," + "\n" +
@"        ""nombreusr"": """ + nomText.Text + "\"," + "\n" +
@"        ""passwordusr"": """ + passText.Text + "\"," + "\n" +
@"        ""rolusr"": """ + Int32.Parse(rolCombo.Text) + "\"," + "\n" +
@"        ""telefonousr"": """ + telText.Text + "\"," + "\n" +
@"        ""emailusr"": """ + emailText.Text + "\"," + "\n" +
@"        ""direccionusr"": """ + direccText.Text + "\"" + "\n" +
@"    }";
            r.putItem(url, body);
            MessageBox.Show("Editado con éxito");
        }
    }
}
