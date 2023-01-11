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
    public partial class EditarServicios : MaterialForm
    {
        public EditarServicios(string id, string des, string tiempoText, string precioText, string ivaText, string descuentoText)
        {
            InitializeComponent();
            idText.Text = id;
            desText.Text = des;
            precioNum.Value = Int32.Parse(precioText);
            ivaBox.Text = ivaText + "%";
            desNum.Value = Int32.Parse(descuentoText);
            tiempoNumeric.Value = Int32.Parse(tiempoText);
        }

        private void EditarServicios_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);

        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            ListadoServicios LS = new ListadoServicios();
            LS.Show();
            this.Close();
        }

        private void editarS_Click(object sender, EventArgs e)
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


            String url = "http://localhost:8081/servicio/modify" + idText.Text;

            funciones.conexion r = new funciones.conexion(url, "PUT");

            String datos = @"{
" + "\n" +
@"        ""idserv"": """ + idText.Text + "\"," + "\n" +
@"        ""descripcionserv"": """ + desText.Text + "\"," + "\n" +
@"        ""unidadestiemposerv"": """ + tiempoNumeric.Value + "\"," + "\n" +
@"        ""precioserv"": """ + precioNum.Value + "\"," + "\n" +
@"        ""ivaserv"": """ + Double.Parse(iva) + "\"," + "\n" +
@"        ""descuentoserv"": """ + desNum.Value + "\"" + "\n" +
@"    }";

            r.putItem(url, datos);

            MessageBox.Show("Editado con éxito");

        }
    }
    }
