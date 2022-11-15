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
    public partial class EditarProductos : MaterialForm
    {
        public EditarProductos(string id, string nom, string cate, string precio, string iva, string descuento, string stock)
        {
            InitializeComponent();
            idText.Text = id;
            nomText.Text = nom;
            categoriaText.Text = cate;
            preText.Text = precio;
            ivaText.Text = iva;
            desText.Text = descuento;
            stockText.Text = stock;
        }

        private void EditarProductos_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            ListadoProductos LP = new ListadoProductos();
            LP.Show();
            this.Hide();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            String url = "http://localhost:8081/producto/modify" + idText.Text;

            RaquetZone.funciones.conexion r = new RaquetZone.funciones.conexion(url, "PUT");

            String datos = @"{
" + "\n" +
@"        ""nombreprod"": """ + nomText.Text + "\"," + "\n" +
@"        ""categoriaprod"": """ + categoriaText.Text + "\"," + "\n" +
@"        ""precioprod"": """ + Double.Parse(preText.Text) + "\"," + "\n" +
@"        ""ivaprod"": """ + Double.Parse(ivaText.Text) + "\"," + "\n" +
@"        ""descuentoprod"": """ + Double.Parse(desText.Text) + "\"," + "\n" +
@"        ""stockprod"": """ + Int32.Parse(stockText.Text) + "\"" + "\n" +
@"    }";

            r.putItem(url, datos);

            MessageBox.Show("Editado con éxito");
        }
    }
    }

