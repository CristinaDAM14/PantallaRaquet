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

            
        }

        private void ListadoProductos_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);

            Mostrar();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (listaProductos.CurrentRow != null)
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
            else
            {
                MessageBox.Show("Selecciona un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void editarProductos_Click(object sender, EventArgs e)
        {
            if (listaProductos.CurrentRow != null)
            {
            string id = listaProductos.CurrentRow.Cells[0].Value.ToString();
            string nom = listaProductos.CurrentRow.Cells[1].Value.ToString();
            string cate = listaProductos.CurrentRow.Cells[2].Value.ToString();
            string precio = listaProductos.CurrentRow.Cells[3].Value.ToString();
            string iva = listaProductos.CurrentRow.Cells[4].Value.ToString();
            string descuento = listaProductos.CurrentRow.Cells[5].Value.ToString();
            string stock = listaProductos.CurrentRow.Cells[6].Value.ToString();

            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "EditarProductos").SingleOrDefault<Form>();
            if (existe != null)

            {
                MessageBox.Show("Esa ventana ya está abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                EditarProductos EP = new EditarProductos(id, nom, cate, precio, iva, descuento, stock);
                EP.TextoCIFAnyadir.Text = TextoCIFP.Text;
                EP.Show();
                this.Close();
            }

            }
            else
            {
                MessageBox.Show("Selecciona un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }

        private void Mostrar()
        {
            if (funciones.funciones.mostrarProdP(TextoCIFP.Text) == null)
            {
                MessageBox.Show("No tienes ningún dato de Productos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listaProductos.DataSource = RaquetZone.funciones.funciones.mostrarProdP(TextoCIFP.Text);
            }

        }

        private void buscadorButton_Click(object sender, EventArgs e)
        {

            bool supervisorProductos = false;

            foreach (DataGridViewRow Row in listaProductos.Rows)
            {
                String strFila = Row.Index.ToString();
                string Valor = Convert.ToString(Row.Cells["nombreprod"].Value);

                if (Valor == this.buscarNombre.Text)
                {
                    listaProductos.Rows[Convert.ToInt32(strFila)].DefaultCellStyle.BackColor = Color.ForestGreen;
                    listaProductos.CurrentCell = listaProductos[1, Convert.ToInt32(strFila)];
                    supervisorProductos = true;
                }
            }

            if (supervisorProductos == false)
            {
                MessageBox.Show("Nombre Inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                GP1.cifEmpresa.Text = TextoCIFP.Text;
                GP1.Show();
                this.Close();
            }

            
        }

        private void limpiarB_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Row in listaProductos.Rows)
            {
                String strFila = Row.Index.ToString();
                listaProductos.Rows[Convert.ToInt32(strFila)].DefaultCellStyle.BackColor = Color.White;
            }
        }
    }
}
