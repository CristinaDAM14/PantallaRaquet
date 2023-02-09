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
    public partial class ListadoServicios : MaterialForm
    {
        public ListadoServicios()
        {
            InitializeComponent();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            String id = ListaServicios.CurrentRow.Cells[0].Value.ToString();

            if (MessageBox.Show("¿Quieres eliminar el servicio con ID " + id + "?", "Eliminar", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {


                String url = "http://localhost:8081/servicio/delete/" + id;

                funciones.conexion r = new funciones.conexion(url, "DELETE");

                r.deleteItem(url);

                MessageBox.Show("Eliminado");

                MostrarServicios();
            }
            else
            {
                MessageBox.Show("La operación se ha detenido, no se ha eliminado al servicio");
            }
        }

        private void ListadoServicios_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);

            MostrarServicios();

            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "AnyadirReservas").SingleOrDefault<Form>();
            if (existe != null)

            {
                buttonEliminar.Visible = false;
                buttonEliminar.Enabled = false;
                editar.Visible = false;
                editar.Enabled = false;
                Anyadir.Visible = false;
                Anyadir.Enabled = false;
                bReservas.Visible = true;
                bReservas.Enabled = true;

            }
            else
            {
                buttonEliminar.Visible = true;
                buttonEliminar.Enabled = true;
                editar.Visible = true;
                editar.Enabled = true;
                Anyadir.Visible = true;
                Anyadir.Enabled = true;
                bReservas.Visible = false;
                bReservas.Enabled = false;
            }
        }

        private void MostrarServicios()
        {
            if(funciones.funciones.mostrarServicioP(TextoCIFP.Text) == null)
            {
                MessageBox.Show("No tienes ningún dato de Servicios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ListaServicios.DataSource = funciones.funciones.mostrarServicioP(TextoCIFP.Text);

                ListaServicios.Columns[0].Visible = false;
            }
            
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buscadorButton_Click(object sender, EventArgs e)
        {
            bool supervisorServicios = false;

            foreach (DataGridViewRow Row in ListaServicios.Rows)
            {
                String strFila = Row.Index.ToString();
                string Valor = Convert.ToString(Row.Cells["descripcionserv"].Value);

                if (Valor == this.buscarNombre.Text)
                {
                    ListaServicios.Rows[Convert.ToInt32(strFila)].DefaultCellStyle.BackColor = Color.ForestGreen;
                    ListaServicios.CurrentCell = ListaServicios[1, Convert.ToInt32(strFila)];
                    supervisorServicios = true;
                }
            }

            if (supervisorServicios == false)
            {
                MessageBox.Show("Nombre Inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void editar_Click(object sender, EventArgs e)
        {
            string idText = ListaServicios.CurrentRow.Cells[0].Value.ToString();
            string desText = ListaServicios.CurrentRow.Cells[1].Value.ToString();
            string tiempoText = ListaServicios.CurrentRow.Cells[2].Value.ToString();
            string precioText = ListaServicios.CurrentRow.Cells[3].Value.ToString();
            string ivaText = ListaServicios.CurrentRow.Cells[4].Value.ToString();
            string descuentoText = ListaServicios.CurrentRow.Cells[5].Value.ToString();

            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "EditarServicios").SingleOrDefault<Form>();
            if (existe != null)

            {
                MessageBox.Show("Esa ventana ya está abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                EditarServicios GS = new EditarServicios(idText, desText, tiempoText, precioText, ivaText, descuentoText);
                GS.TextoCIFAnyadir.Text = TextoCIFP.Text;
                GS.Show();
            }
        }

        private void Anyadir_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "AnyadirServicio").SingleOrDefault<Form>();
            if (existe != null)

            {
                this.Close();

            }
            else
            {
                AnyadirServicio AS = new AnyadirServicio();
                AS.TextoCIFAnyadir.Text = TextoCIFP.Text;
                AS.Show();
                this.Close();
            }
        }

        private void bReservas_Click(object sender, EventArgs e)
        {
            string id = ListaServicios.CurrentRow.Cells[0].Value.ToString();

            AnyadirReservas AR = (AnyadirReservas)Application.OpenForms["AnyadirReservas"];
            if (Application.OpenForms.OfType<AnyadirReservas>().Any())
            {
                AR.conseguirIDSer(id);
            }

            this.Close();
        }
    }
}
