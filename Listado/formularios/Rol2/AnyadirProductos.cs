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
    public partial class AnyadirProductos : MaterialForm
    {
        public AnyadirProductos()
        {
            InitializeComponent();
        }

        private void AnyadirProductos_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            GestionProductos GP = new GestionProductos();
            GP.Show();
            this.Hide();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

            String url = "http://localhost:8081/producto/add";

            RaquetZone.funciones.conexion r = new RaquetZone.funciones.conexion(url, "POST");

            String datos = @"{
" + "\n" +
@"        ""nombreprod"": """ + nomText.Text + "\"," + "\n" +
@"        ""categoriaprod"": """ + categoriaText.Text + "\"," + "\n" +
@"        ""precioprod"": """ + Double.Parse(preText.Text) + "\"," + "\n" +
@"        ""ivaprod"": """ + Double.Parse(ivaText.Text) + "\"," + "\n" +
@"        ""descuentoprod"": """ + Double.Parse(desText.Text) + "\"," + "\n" +
@"        ""stockprod"": """ + Int32.Parse(stockText.Text) + "\"" + "\n" +
@"    }";

            String res = r.postItem(datos);

            MessageBox.Show("Resultado: " + datos);

        }
    }
}
