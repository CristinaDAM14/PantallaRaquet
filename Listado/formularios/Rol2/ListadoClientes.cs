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
            
        }

        private void ListadoClientes_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);

            MostrarClientes();

            Form existe1 = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "AnyadirCompras").SingleOrDefault<Form>();
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "AnyadirReservas").SingleOrDefault<Form>();
            if (existe != null)

            {
                buttonEliminar.Visible = false;
                buttonEliminar.Enabled = false;
                editarProductos.Visible = false;
                editarProductos.Enabled = false;
                button1.Visible = false;
                button1.Enabled = false;
                emailButton.Visible = false;
                emailButton.Enabled = false;
                anyadirCompra.Visible = false;
                anyadirCompra.Enabled = false;
                bReservas.Visible = true;
                bReservas.Enabled = true;

            }
            else if (existe1 != null)

            {
                buttonEliminar.Visible = false;
                buttonEliminar.Enabled = false;
                editarProductos.Visible = false;
                editarProductos.Enabled = false;
                button1.Visible = false;
                button1.Enabled = false;
                emailButton.Visible = false;
                emailButton.Enabled = false;
                buttonEliminar.Visible = false;
                buttonEliminar.Enabled = false;
                anyadirCompra.Visible = true;
                anyadirCompra.Enabled = true;
                bReservas.Visible = false;
                bReservas.Enabled = false;

            }
            else
            {
                buttonEliminar.Visible = true;
                buttonEliminar.Enabled = true;
                editarProductos.Visible = true;
                editarProductos.Enabled = true;
                button1.Visible = true;
                button1.Enabled = true;
                emailButton.Visible = true;
                emailButton.Enabled = true;
                anyadirCompra.Visible = false;
                anyadirCompra.Enabled = false;
                bReservas.Visible = false;
                bReservas.Enabled = false;
            }

        }

        private void editarProductos_Click(object sender, EventArgs e)
        {
            string dniText = listaClientes.CurrentRow.Cells[0].Value.ToString();
            string nomText = listaClientes.CurrentRow.Cells[1].Value.ToString();
            string passText = listaClientes.CurrentRow.Cells[2].Value.ToString();
            string numText = listaClientes.CurrentRow.Cells[3].Value.ToString();
            string telText = listaClientes.CurrentRow.Cells[4].Value.ToString();
            string emailText = listaClientes.CurrentRow.Cells[5].Value.ToString();

            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "EditarClientes").SingleOrDefault<Form>();
            if (existe != null)

            {
                MessageBox.Show("Esa ventana ya está abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                EditarClientes EC = new EditarClientes(dniText, nomText, passText, numText, telText, emailText);
                EC.TextoCIFAnyadir.Text = TextoCIFC.Text;
                EC.Show();
                this.Close();
            }
        }

        private void MostrarClientes()
        {
            if (funciones.funciones.mostrarCliP(TextoCIFC.Text) == null)
            {
                MessageBox.Show("No tienes ningún dato de Clientes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listaClientes.DataSource = funciones.funciones.mostrarCliP(TextoCIFC.Text);

                listaClientes.Columns[2].Visible = false;
            }

            

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


                String url = "http://localhost:8081/cliente/delete/" + dni;

                RaquetZone.funciones.conexion r = new RaquetZone.funciones.conexion(url, "DELETE");

                r.deleteItem(url);

                MessageBox.Show("Eliminado");

                listaClientes.DataSource = RaquetZone.funciones.funciones.mostrarCliP(TextoCIFC.Text);
            }
            else
            {
                MessageBox.Show("La operación se ha detenido, no se ha eliminado al cliente");
            }
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void emailButton_Click(object sender, EventArgs e)
        {
            string emailText = listaClientes.CurrentRow.Cells[5].Value.ToString();

            EmailClientes EC = new EmailClientes(emailText);
            EC.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "AnyadirCliente").SingleOrDefault<Form>();
            if (existe != null)

            {
                this.Close();

            }
            else
            {
                AnyadirCliente GC1 = new AnyadirCliente();
                GC1.TextoCIFAnyadir.Text = TextoCIFC.Text;
                GC1.Show();
                this.Close();
            }
        }

        private void bReservas_Click(object sender, EventArgs e)
        {
            string dni = listaClientes.CurrentRow.Cells[0].Value.ToString();

            AnyadirReservas AR = (AnyadirReservas)Application.OpenForms["AnyadirReservas"];
            if (Application.OpenForms.OfType<AnyadirReservas>().Any())
            {
                AR.conseguirDNI(dni);
            }

            this.Close();
        }

        private void anyadirCompra_Click(object sender, EventArgs e)
        {
            string dni = listaClientes.CurrentRow.Cells[0].Value.ToString();

            AnyadirCompras AR = (AnyadirCompras)Application.OpenForms["AnyadirCompras"];
            if (Application.OpenForms.OfType<AnyadirCompras>().Any())
            {
                AR.conseguirDNI(dni);
            }

            this.Close();
        }
    }
}
