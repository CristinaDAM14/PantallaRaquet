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
    public partial class ListadoClientes : MaterialForm
    {
        public ListadoClientes()
        {
            InitializeComponent();
            MostrarClientes();
        }

        private void ListadoClientes_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);

        }

        private void editarProductos_Click(object sender, EventArgs e)
        {
            string dniText = listaClientes.CurrentRow.Cells[0].Value.ToString();
            string nomText = listaClientes.CurrentRow.Cells[1].Value.ToString();
            string passText = listaClientes.CurrentRow.Cells[2].Value.ToString();
            string numText = listaClientes.CurrentRow.Cells[3].Value.ToString();
            string telText = listaClientes.CurrentRow.Cells[4].Value.ToString();
            string emailText = listaClientes.CurrentRow.Cells[5].Value.ToString();

            EditarClientes EC = new EditarClientes(dniText, nomText, passText, numText, telText, emailText);
            EC.Show();
            this.Hide();
        }

        private void MostrarClientes()
        {
            listaClientes.DataSource = RaquetZone.funciones.funciones.mostrarCli();
        }

        private void buscadorButton_Click(object sender, EventArgs e)
        {
            bool supervisorClientes = false;

            foreach (DataGridViewRow Row in listaClientes.Rows)
            {
                String strFila = Row.Index.ToString();
                string Valor = Convert.ToString(Row.Cells["dnicli"].Value);

                if (Valor == this.buscarDNI.Text)
                {
                    listaClientes.Rows[Convert.ToInt32(strFila)].DefaultCellStyle.BackColor = Color.ForestGreen;
                    listaClientes.CurrentCell = listaClientes[0, Convert.ToInt32(strFila)];
                    supervisorClientes = true;
                }
            }

            if (supervisorClientes == false)
            {
                MessageBox.Show("DNI Inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            String dni = listaClientes.CurrentRow.Cells[0].Value.ToString();

            if (MessageBox.Show("¿Quieres eliminar el cliente con DNI " + dni + "?", "Eliminar", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {


                String url = "http://localhost:8081/cliente/delete" + dni;

                RaquetZone.funciones.conexion r = new RaquetZone.funciones.conexion(url, "DELETE");

                r.deleteItem(url);

                MessageBox.Show("Eliminado");

                listaClientes.DataSource = RaquetZone.funciones.funciones.mostrarCli();
            }
            else
            {
                MessageBox.Show("La operación se ha detenido, no se ha eliminado al cliente");
            }
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            GestionClientes GC = new GestionClientes();
            GC.Show();
            this.Close();
        }

        private void emailButton_Click(object sender, EventArgs e)
        {
            string emailText = listaClientes.CurrentRow.Cells[5].Value.ToString();

            EmailClientes EC = new EmailClientes(emailText);
            EC.Show();
        }
    }
}
