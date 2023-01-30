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
    public partial class ListadoProductos : MaterialForm
    {
        public ListadoProductos()
        {
            InitializeComponent();
            Mostrar();
            
        }

        private void ListadoProductos_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            String id = listaProductos.CurrentRow.Cells[0].Value.ToString();

            if (MessageBox.Show("¿Quieres eliminar el producto con ID " + id + "?", "Eliminar", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {


                String url = "http://localhost:8081/producto/delete/" + id;

                RaquetZone.funciones.conexion r = new RaquetZone.funciones.conexion(url, "DELETE");

                r.deleteItem(url);

                MessageBox.Show("Eliminado");

                listaProductos.DataSource = RaquetZone.funciones.funciones.mostrarProdP(TextoCIFP.Text);
            }
            else
            {
                MessageBox.Show("La operación se ha detenido, no se ha eliminado el producto");
            }
        }

        private void editarProductos_Click(object sender, EventArgs e)
        {

            string id = listaProductos.CurrentRow.Cells[0].Value.ToString();
            string nom = listaProductos.CurrentRow.Cells[1].Value.ToString();
            string cate = listaProductos.CurrentRow.Cells[2].Value.ToString();
            string precio = listaProductos.CurrentRow.Cells[3].Value.ToString();
            string iva = listaProductos.CurrentRow.Cells[4].Value.ToString();
            string descuento = listaProductos.CurrentRow.Cells[5].Value.ToString();
            string stock = listaProductos.CurrentRow.Cells[6].Value.ToString();

            EditarProductos EP = new EditarProductos(id, nom, cate, precio, iva, descuento, stock);
            EP.Show();
            this.Close();

        }

        private void Mostrar()
        {
            listaProductos.DataSource = RaquetZone.funciones.funciones.mostrarProdP(TextoCIFP.Text);
        }

        private void buscadorButton_Click(object sender, EventArgs e)
        {

            bool supervisorProductos = false;

            foreach (DataGridViewRow Row in listaProductos.Rows)
            {
                String strFila = Row.Index.ToString();
                string Valor = Convert.ToString(Row.Cells["idprod"].Value);

                if (Valor == this.buscarID.Text)
                {
                    listaProductos.Rows[Convert.ToInt32(strFila)].DefaultCellStyle.BackColor = Color.ForestGreen;
                    listaProductos.CurrentCell = listaProductos[0, Convert.ToInt32(strFila)];
                    supervisorProductos = true;
                }
            }

            if (supervisorProductos == false)
            {
                MessageBox.Show("ID Inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "AnyadirProductos").SingleOrDefault<Form>();
            if (existe != null)

            {
                this.Close();

            }
            else
            {
                AnyadirProductos GP1 = new AnyadirProductos();
                GP1.Show();
                this.Close();
            }
        }
    }
}
