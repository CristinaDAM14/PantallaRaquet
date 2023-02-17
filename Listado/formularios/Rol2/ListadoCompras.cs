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
        }

        private void ListadoCompras_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);

            MostrarCompras();

        }

        private void MostrarCompras()
        {
            if (funciones.funciones.mostrarCompProd() == null)
            {
                MessageBox.Show("No tienes ningún dato de Compras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listaCompras.DataSource = RaquetZone.funciones.funciones.mostrarCompProd();
                listaCompras.Columns[2].Visible = false;
                listaCompras.Columns[9].Visible = false;
                listaCompras.Columns[14].Visible = false;
            }

            
        }

        private void MostrarComprasPorFecha()
        {
            listaCompras.DataSource = RaquetZone.funciones.funciones.mostrarCompFecha();
        }

        private void buttonFactura_Click(object sender, EventArgs e)
        {
            if (listaCompras.CurrentRow != null)
            {

            String id = listaCompras.CurrentRow.Cells[1].Value.ToString();
            String fecha = listaCompras.CurrentRow.Cells[10].Value.ToString();
            String nombre = listaCompras.CurrentRow.Cells[3].Value.ToString();
            String descuento = listaCompras.CurrentRow.Cells[7].Value.ToString();
            String precio = listaCompras.CurrentRow.Cells[5].Value.ToString();
            String cliente = listaCompras.CurrentRow.Cells[13].Value.ToString();
            String cantidad = listaCompras.CurrentRow.Cells[18].Value.ToString();

            funciones.funciones.facturasPDF(id, fecha, nombre, descuento, precio, cliente, cantidad);
            }
            else
            {
                MessageBox.Show("Selecciona una compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }

        private void bVolver_Click(object sender, EventArgs e)
        {
                this.Close();     
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

        private void button1_Click(object sender, EventArgs e)
        {

            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "AnyadirComprasProd").SingleOrDefault<Form>();
            if (existe != null)

            {
                this.Close();

            }
            else
            {
                AnyadirComprasProd P23 = new AnyadirComprasProd();
                P23.cifEmpresa.Text = TextoCIFP.Text;
                P23.Show();
                this.Close();
            }
        }

        private void limpiarB_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Row in listaCompras.Rows)
            {
                String strFila = Row.Index.ToString();
                listaCompras.Rows[Convert.ToInt32(strFila)].DefaultCellStyle.BackColor = Color.White;
            }
        }
    }
    }

