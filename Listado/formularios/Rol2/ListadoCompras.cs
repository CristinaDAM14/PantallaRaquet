using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
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
            String id = listaCompras.CurrentRow.Cells[0].Value.ToString();
            String fecha = listaCompras.CurrentRow.Cells[1].Value.ToString();

            /*string url = "http://localhost:8081/compras/" + id;

            funciones.conexion r = new funciones.conexion(url, "GET");

            string producto = r.getItem();

            var jprod = JsonConvert.DeserializeObject<funciones.compras>(producto);
            string descuentoJ = jprod.descuentoprod;
            string precioJ = jprod.precioprod;
            string nombreJ = jprod.nombreprod;
            string cantidadJ = jprod.cantidadprodcomp;

            int suma = Int32.Parse(precioJ) * Int32.Parse(cantidadJ);
            string total = suma.ToString();
            */
            funciones.funciones.facturasPDF(id, fecha);

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
            string id = listaCompras.CurrentRow.Cells[0].Value.ToString();
            string fecha = listaCompras.CurrentRow.Cells[1].Value.ToString();
            string hora;

            if(listaCompras.CurrentRow.Cells[2].Value == null)
            {
                hora = "0";
            }
            else
            {
            hora = listaCompras.CurrentRow.Cells[2].Value.ToString();
            }
            


            EditarCompras EC = new EditarCompras(id, fecha, hora);
            EC.Show();
            this.Hide();
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "GestionCompras").SingleOrDefault<Form>();
            if (existe != null)

            {
                this.Close();

            }
            else
            {
            GestionCompras P2 = new GestionCompras();
            P2.Show();
            this.Close();
            }

            
        }

        private void buscadorButton_Click(object sender, EventArgs e)
        {
            bool supervisorClientes = false;

            foreach (DataGridViewRow Row in listaCompras.Rows)
            {
                String strFila = Row.Index.ToString();
                string Valor = Convert.ToString(Row.Cells["idcomp"].Value);

                if (Valor == this.buscarID.Text)
                {
                    listaCompras.Rows[Convert.ToInt32(strFila)].DefaultCellStyle.BackColor = Color.ForestGreen;
                    listaCompras.CurrentCell = listaCompras[0, Convert.ToInt32(strFila)];
                    supervisorClientes = true;
                }
            }

            if (supervisorClientes == false)
            {
                MessageBox.Show("ID Inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
