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

namespace RaquetZone.formularios.Rol2
{
    public partial class EditarClientes : MaterialForm
    {
        
        public EditarClientes(string dni, string nom, string pass, string num, string tel, string email)
        {
            InitializeComponent();
            dniText.Text = dni;
            nomText.Text = nom;
            passText.Text = pass;
            numText.Text = num;
            telText.Text = tel;
            emailText.Text = email;
        }


        private void EditarClientes_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            ListadoClientes LC = new ListadoClientes();
            LC.Show();
            this.Hide();
            
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

            String url = "http://localhost:8081/cliente/modify" + dniText.Text;

            RaquetZone.funciones.conexion r = new RaquetZone.funciones.conexion(url, "PUT");

            String datos = @"{
" + "\n" +
@"        ""dnicli"": """ + dniText.Text + "\"," + "\n" +
@"        ""nombrecli"": """ + nomText.Text + "\"," + "\n" +
@"        ""passwordcli"": """ + passText.Text + "\"," + "\n" +
@"        ""numhorascli"": " + Int32.Parse(numText.Text) + "," + "\n" +
@"        ""telefonocli"": """ + telText.Text + "\"," + "\n" +
@"        ""emailcli"": """ + emailText.Text + "\"" + "\n" +
@"    }";

            r.putItem(url, datos);

            MessageBox.Show("Editado con éxito");
        }
    }
}
