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
using System.Text.RegularExpressions;
using MaterialSkin;
using System.Configuration;

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

        private void bVolver_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "ListadoProductos").SingleOrDefault<Form>();
            if (existe != null)

            {
                MessageBox.Show("Esa ventana ya está abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                ListadoProductos GP = new ListadoProductos();
                GP.TextoCIFP.Text = cifEmpresa.Text;
                GP.Show();
                this.Close();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarNombre(categoriaText.Text) == true)
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


                String url = ConfigurationManager.AppSettings["AccesoBD"] + "producto/add";

                funciones.conexion r = new funciones.conexion(url, "POST");

                String datos = @"{
" + "\n" +
    @"        ""nombreprod"": """ + nomText.Text + "\"," + "\n" +
    @"        ""categoriaprod"": """ + categoriaText.Text + "\"," + "\n" +
    @"        ""precioprod"": " + precioNum.Value + "," + "\n" +
    @"        ""ivaprod"": " + Double.Parse(iva) + "," + "\n" +
    @"        ""descuentoprod"": " + desNum.Value + "," + "\n" +
    @"        ""stockprod"": " + stockNumeric.Value + "," + "\n" +
    @"        ""empresa"": {" + "\n" +
    @"            ""cifemp"": """ + cifEmpresa.Text + "\"" + "\n" +
    @"        }" + "\n" +
    @"    }";

                String res = r.postItem(datos);

                MessageBox.Show("Producto añadido a la base de datos");

                limpiar();
            }
            else
            {
                MessageBox.Show("Formato de la categoría incorrecto,", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiar()
        {
            nomText.Text = "";
            categoriaText.Text = "";
            precioNum.Value = 0;
            desNum.Value = 0;
            stockNumeric.Value = 0;
        }

        //Validaciones
        public bool ValidarNombre(string nombre)
        {
            bool contieneSoloLetras = Regex.IsMatch(nombre, @"^[a-zA-Z]+$");
            return contieneSoloLetras;
        }

    }
}
