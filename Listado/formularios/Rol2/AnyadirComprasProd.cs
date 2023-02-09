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
using System.Text.RegularExpressions;

namespace RaquetZone.formularios.Rol2
{
    public partial class AnyadirComprasProd : MaterialForm
    {
        public AnyadirComprasProd()
        {
            InitializeComponent();

        }

        private void AnyadirComprasProd_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);

            List<string> productosList = new List<string>(TodoProductos());

            for (int i = 0; i < productosList.Count; i++)
            {
                boxProducto.Items.Add(productosList[i]);
            }

            boxProducto.Text = (string)boxProducto.Items[0];

            sacarIDProducto();
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "ListadoCompras").SingleOrDefault<Form>();
            if (existe != null)

            {
                MessageBox.Show("Esa ventana ya está abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                ListadoCompras GP = new ListadoCompras();
                GP.TextoCIFP.Text = cifEmpresa.Text;
                GP.Show();
                this.Close();
            }
        }

        private void crearB_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "AnyadirCompras").SingleOrDefault<Form>();
            if (existe != null)

            {
                MessageBox.Show("Esa ventana ya está abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                AnyadirCompras AC = new AnyadirCompras();
                AC.TextoCIFAnyadir.Text = cifEmpresa.Text;
                AC.Show();
                this.Close();
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "ListadoComprasSolas").SingleOrDefault<Form>();
            if (existe != null)

            {
                MessageBox.Show("Esa ventana ya está abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                ListadoComprasSolas AC = new ListadoComprasSolas();
                AC.TextoCIFP.Text = cifEmpresa.Text;
                AC.Show();
            }
        }

        public void conseguirIDCompra(string idC)
        {
            idcompraText.Text = idC;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idcompraText.Text.Equals(""))
            {
                MessageBox.Show("No puedes dejar el campode ID Compra vacío ");
            }
            else
            {

                string idProducto = sacarIDProducto();

                 String url = "http://localhost:8081/producto_compra/add";

                 funciones.conexion r = new funciones.conexion(url, "POST");



                 String datos = @"{
" + "\n" +
 @"        ""id"": {" + "\n" +
 @"            ""idProducto"": " + idProducto + "," + "\n" +
 @"            ""idCompra"": " + idcompraText.Text + "\n" +
 @"        }," + "\n" +
 @"        ""producto"": {" + "\n" +
 @"            ""idprod"": " + idProducto + "\n" +
 @"            }," + "\n" +
 @"        ""compra"": {" + "\n" +
 @"            ""idcomp"": " + idcompraText.Text + "\n" +
 @"            }," + "\n" +
 @"        ""cantidadprodcomp"": " + cantidadNum.Value + "\n" +
 @"    }";

                r.postItem(datos);

                 MessageBox.Show("Compra añadida a la base de datos");
            }
        }

        public static List<string> TodoProductos()
        {
            String url2 = "http://localhost:8081/productos";

            funciones.conexion r2 = new funciones.conexion(url2, "GET");

            string produc = r2.getItem();

            var matches = Regex.Matches(produc, "nombreprod\":\"{0,3}([a-zA-Z0-9]{0,15})");
            List<string> sacarProductos = new List<string>();
            var sacarProductos1 = matches.Cast<Match>().SelectMany(o => o.Groups.Cast<Capture>().Skip(1).Select(c => c.Value));

            sacarProductos.AddRange(sacarProductos1);

            List<string> ListaSinRepeticiones = sacarProductos.Distinct().ToList();
            return ListaSinRepeticiones;
        }

        public string sacarIDProducto()
        {
            String url23 = "http://localhost:8081/producto/" + boxProducto.Text;

            funciones.conexion r23 = new funciones.conexion(url23, "GET");

            string produc = r23.getItem();

            var mat1 = Regex.Matches(produc, "idprod\":\"{0,3}([a-zA-Z0-9]{0,15})");
            List<string> sacarID = new List<string>();
            var sacarID1 = mat1.Cast<Match>().SelectMany(o => o.Groups.Cast<Capture>().Skip(1).Select(c => c.Value));

            sacarID.AddRange(sacarID1);
            return sacarID[0];
        }
    }
}
