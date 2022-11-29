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
    public partial class AnyadirCompras : MaterialForm
    {
        public AnyadirCompras()
        {
            InitializeComponent();
        }

        private void AnyadirCompras_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);

        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            GestionCompras PP2 = new GestionCompras();
            PP2.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String url = "http://localhost:8081/compra/add";

            RaquetZone.funciones.conexion r = new RaquetZone.funciones.conexion(url, "POST");

            String datos = @"{
" + "\n" +
@"        ""fechacomp"": """ + fechaText.Text + "\"," + "\n" +
@"        ""horacomp"": """ + horaText.Text + "\"," + "\n" +
@"    }";

            String res = r.postItem(datos);

            MessageBox.Show("Compra añadida a la base de datos");
        }
    }
}
