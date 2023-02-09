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
    public partial class AnyadirServicio : MaterialForm
    {
        public AnyadirServicio()
        {
            InitializeComponent();
        }

        private void AnyadirServicio_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);

        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "ListadoServicios").SingleOrDefault<Form>();
            if (existe != null)

            {
                MessageBox.Show("Esa ventana ya está abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                ListadoServicios GS = new ListadoServicios();
                GS.TextoCIFP.Text = TextoCIFAnyadir.Text;
                GS.Show();
                this.Close();
            }

        }

        private void AnyadirButton_Click(object sender, EventArgs e)
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


            String url = "http://localhost:8081/servicio/add";

            funciones.conexion r = new funciones.conexion(url, "POST");

            String datos = @"{
" + "\n" +
@"        ""descripcionserv"": """ + desText.Text + "\"," + "\n" +
@"        ""unidadestiemposerv"": """ + tiempoNumeric.Value + "\"," + "\n" +
@"        ""precioserv"": """ + precioNum.Value + "\"," + "\n" +
@"        ""ivaserv"": """ + Double.Parse(iva) + "\"," + "\n" +
@"        ""descuentoserv"": """ + desNum.Value + "\"" + "\n" +
@"    }";

            String res = r.postItem(datos);

            MessageBox.Show("Servicio añadido a la base de datos");

            limpiar();

        }

        private void limpiar()
        {
            desText.Text = "";
            tiempoNumeric.Value = 0;
            precioNum.Value = 0;
            desNum.Value = 0;
        }
    }
}
