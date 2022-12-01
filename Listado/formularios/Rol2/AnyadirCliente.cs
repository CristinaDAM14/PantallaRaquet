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
            GestionClientes GC = new GestionClientes();
            GC.Show();
            this.Close();
        }

        private void buttonAnyadir_Click(object sender, EventArgs e)
        {
            String url = "http://localhost:8081/cliente/add";

            funciones.conexion r = new funciones.conexion(url, "POST");

            String datos = @"{
" + "\n" +
@"        ""dnicli"": """ + dniText.Text + "\"," + "\n" +
@"        ""nombrecli"": """ + nomText.Text + "\"," + "\n" +
@"        ""passwordcli"": """ + passText.Text + "\"," + "\n" +
@"        ""numhorascli"": " + numNum.Value + "," + "\n" +
@"        ""telefonocli"": """ + telText.Text + "\"," + "\n" +
@"        ""emailcli"": """ + emailText.Text + "\"" + "\n" +
@"    }";

            String res = r.postItem(datos);

            MessageBox.Show("Cliente añadido a la base de datos");
        }
    }
}
