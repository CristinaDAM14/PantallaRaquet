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
    public partial class ListadoReservas : MaterialForm
    {
        public ListadoReservas()
        {
            InitializeComponent();
            MostrarReservas();
        }

        private void ListadoReservas_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            String id = listaReservas.CurrentRow.Cells[0].Value.ToString();

            if (MessageBox.Show("¿Quieres eliminar la reserva con ID " + id + "?", "Eliminar", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {


                String url = "http://localhost:8081/reserva/delete/" + id;

                RaquetZone.funciones.conexion r = new RaquetZone.funciones.conexion(url, "DELETE");

                r.deleteItem(url);

                MessageBox.Show("Eliminado");

                MostrarReservas();
            }
            else
            {
                MessageBox.Show("La operación se ha detenido, no se ha eliminado el producto");
            }
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
            listaReservas.DataSource = funciones.funciones.mostrarReservas();

        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editarReservas_Click(object sender, EventArgs e)
        {
            string idText = listaReservas.CurrentRow.Cells[0].Value.ToString();
            string numText = listaReservas.CurrentRow.Cells[1].Value.ToString();
            string fechaText = listaReservas.CurrentRow.Cells[2].Value.ToString();
            string horaText = listaReservas.CurrentRow.Cells[3].Value.ToString();
            string dniCliText = listaReservas.CurrentRow.Cells[4].Value.ToString();
            string idSerText = listaReservas.CurrentRow.Cells[10].Value.ToString();

            EditarReservas EC = new EditarReservas(idText, numText, fechaText, horaText, dniCliText, idSerText);
            EC.Show();
            this.Close();
        }

        private void Anyadir_Click(object sender, EventArgs e)
        {
            AnyadirReservas AR = new AnyadirReservas();
            AR.Show();
            this.Close();
        }
    }
}
