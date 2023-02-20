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
using System.Configuration;

namespace RaquetZone.formularios.Rol2
{
    public partial class ListadoReservas : MaterialForm
    {
        public ListadoReservas()
        {
            InitializeComponent();
        }

        private void ListadoReservas_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);
            MostrarReservas();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

            if (listaReservas.CurrentRow != null)
            {
                String id = listaReservas.CurrentRow.Cells[0].Value.ToString();

                if (MessageBox.Show("¿Quieres eliminar la reserva con ID " + id + "?", "Eliminar", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {


                    String url = ConfigurationManager.AppSettings["AccesoBD"] + "reserva/delete/" + id;

                    RaquetZone.funciones.conexion r = new RaquetZone.funciones.conexion(url, "DELETE");

                    r.deleteItem(url);

                    MessageBox.Show("Eliminado");

                }
                else
                {
                    MessageBox.Show("La operación se ha detenido, no se ha eliminado el producto");
                }

            }
            else
            {
                MessageBox.Show("Selecciona una reserva", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MostrarReservas();

        }

        private void buscadorButton_Click(object sender, EventArgs e)
        {

            if (radioPista.Checked == true)
            {
                radioFecha.Checked = false;
                MostrarReservas();
                BuscarPista();
            }
            else if (radioFecha.Checked == true)
            {
                radioPista.Checked = false;
                MostrarReservas();
                BuscarFechas();
            }
            else
            {
                MostrarReservas();
                BuscarPista();
            }

            
        }

        private void BuscarFechas()
        {
            bool supervisorReservas = false;

            foreach (DataGridViewRow Row in listaReservas.Rows)
            {
                String strFila = Row.Index.ToString();
                string Valor = Convert.ToString(Row.Cells["fechaRes"].Value);

                if (Valor == this.buscarFecha.Text)
                {
                    listaReservas.Rows[Convert.ToInt32(strFila)].DefaultCellStyle.BackColor = Color.ForestGreen;
                    //listaReservas.CurrentCell = listaReservas[0, Convert.ToInt32(strFila)];
                    supervisorReservas = true;
                }
            }

            if (supervisorReservas == false)
            {
                MessageBox.Show("Fecha Inválida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BuscarPista()
        {
            bool supervisorReservas = false;

            foreach (DataGridViewRow Row in listaReservas.Rows)
            {
                String strFila = Row.Index.ToString();
                string Valor = Convert.ToString(Row.Cells["numPista"].Value);

                if (Valor == this.buscarFecha.Text)
                {
                    listaReservas.Rows[Convert.ToInt32(strFila)].DefaultCellStyle.BackColor = Color.GreenYellow;
                    //listaReservas.CurrentCell = listaReservas[0, Convert.ToInt32(strFila)];
                    supervisorReservas = true;
                }
            }

            if (supervisorReservas == false)
            {
                MessageBox.Show("Número de pista Inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void MostrarReservas()
        {
            if (funciones.funciones.mostrarReservas() == null)
            {
                MessageBox.Show("No tienes ningún dato de Reservas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listaReservas.DataSource = funciones.funciones.mostrarReservas();
                listaReservas.Columns[0].Visible = false;
            }

        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editarReservas_Click(object sender, EventArgs e)
        {

            if (listaReservas.CurrentRow != null)
            {
               string idText = listaReservas.CurrentRow.Cells[0].Value.ToString();
            string numText = listaReservas.CurrentRow.Cells[1].Value.ToString();
            string fechaText = listaReservas.CurrentRow.Cells[2].Value.ToString();
            string horaText = listaReservas.CurrentRow.Cells[3].Value.ToString();
            string dniCliText = listaReservas.CurrentRow.Cells[4].Value.ToString();
            string idSerText = listaReservas.CurrentRow.Cells[6].Value.ToString();
            string dniUser = listaReservas.CurrentRow.Cells[9].Value.ToString();

                Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "EditarReservas").SingleOrDefault<Form>();
            if (existe != null)

            {
                MessageBox.Show("Esa ventana ya está abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                EditarReservas EC = new EditarReservas(idText, numText, fechaText, horaText, dniCliText, idSerText, dniUser);
                EC.TextoCIFAnyadir.Text = TextoCIFC.Text;
                EC.Show();
                this.Close();
            }

            }
            else
            {
                MessageBox.Show("Selecciona una reserva", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }

        private void Anyadir_Click(object sender, EventArgs e)
        {

                Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "AnyadirReservas").SingleOrDefault<Form>();
                if (existe != null)

                {
                    MessageBox.Show("Esa ventana ya está abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    AnyadirReservas AR = new AnyadirReservas();
                    AR.TextoCIFAnyadir.Text = TextoCIFC.Text;
                    AR.Show();
                    this.Close();
                }

        }

        private void limpiarB_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Row in listaReservas.Rows)
            {
                String strFila = Row.Index.ToString();
                listaReservas.Rows[Convert.ToInt32(strFila)].DefaultCellStyle.BackColor = Color.White;
            }
        }
    }
}
