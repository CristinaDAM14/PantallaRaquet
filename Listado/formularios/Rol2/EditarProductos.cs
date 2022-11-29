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
            ivaBox.Text = iva + "%";
            desText.Text = descuento;
            stockNumeric.Value = Int32.Parse(stock);
        }

        private void EditarProductos_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);

        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            ListadoProductos LP = new ListadoProductos();
            LP.Show();
            this.Close();
        }

        private void editarB_Click(object sender, EventArgs e)
        {

            string iva = ivaBox.GetItemText(ivaBox.SelectedItem);

            if (iva.Equals("4%"))
            {
                iva = "4";
            }
            else if (iva.Equals("10%"))
            {
                iva = "10";
            }
            else
            {
                iva = "21";
            }

            String url = "http://localhost:8081/producto/modify" + idText.Text;

            funciones.conexion r = new funciones.conexion(url, "PUT");

            String datos = @"{
" + "\n" +
@"        ""idprod"": """ + idText.Text + "\"," + "\n" +
@"        ""nombreprod"": """ + nomText.Text + "\"," + "\n" +
@"        ""categoriaprod"": """ + categoriaText.Text + "\"," + "\n" +
@"        ""precioprod"": """ + Double.Parse(preText.Text) + "\"," + "\n" +
@"        ""ivaprod"": """ + Double.Parse(iva) + "\"," + "\n" +
@"        ""descuentoprod"": """ + Double.Parse(desText.Text) + "\"," + "\n" +
@"        ""stockprod"": """ + stockNumeric.Value + "\"" + "\n" +
@"    }";

            r.putItem(url, datos);

            MessageBox.Show("Editado con éxito");
        }
    }
    }

