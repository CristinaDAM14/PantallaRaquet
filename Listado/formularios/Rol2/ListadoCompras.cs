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
    public partial class ListadoCompras : MaterialForm
    {
        public ListadoCompras()
        {
            InitializeComponent();
            MostrarCompras();
        }

        private void ListadoCompras_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);

            if(radioID.Checked == true)
            {
                radioFecha.Checked = false;
                MostrarCompras();
            }
            else if(radioFecha.Checked == true)
            {
                radioID.Checked = false;
                MostrarComprasPorFecha();
            }
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            PantallaPrincipalRol2 P2 = new PantallaPrincipalRol2();
            P2.Show();
            this.Close();
        }

        private void MostrarCompras()
        {
            listaCompras.DataSource = RaquetZone.funciones.funciones.mostrarComp();
        }

        private void MostrarComprasPorFecha()
        {
            listaCompras.DataSource = RaquetZone.funciones.funciones.mostrarCompFecha();
        }

        private void buttonFactura_Click(object sender, EventArgs e)
        {
            string id = listaCompras.CurrentRow.Cells[0].Value.ToString();
            string fecha = listaCompras.CurrentRow.Cells[1].Value.ToString();

            funciones.funciones.facturasPDF(id, fecha);
            MessageBox.Show("Factura creada");

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            String id = listaCompras.CurrentRow.Cells[0].Value.ToString();

            if (MessageBox.Show("¿Quieres eliminar la compra con ID " + id + "?", "Eliminar", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {


                String url = "http://localhost:8081/compra/delete" + id;

                funciones.conexion r = new funciones.conexion(url, "DELETE");

                r.deleteItem(url);

                MessageBox.Show("Eliminado");

                if (radioID.Checked == true)
                {
                    radioFecha.Checked = false;
                    MostrarCompras();
                }
                else if (radioFecha.Checked == true)
                {
                    radioID.Checked = false;
                    MostrarComprasPorFecha();
                }
                else
                {
                    MostrarCompras();
                }
            }
            else
            {
                MessageBox.Show("La operación se ha detenido, no se ha eliminado la compra");
            }
        }

        private void editarCompras_Click(object sender, EventArgs e)
        {

        }
    }
}
