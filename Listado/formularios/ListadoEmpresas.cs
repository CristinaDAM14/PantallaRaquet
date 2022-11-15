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

namespace RaquetZone.formularios
{
    public partial class RaquetZoneEmpresas : MaterialForm
    {
        public RaquetZoneEmpresas()
        {
            InitializeComponent();
            MostrarEmpresas();
        }

        private void editar_Click(object sender, EventArgs e)
        {
            string cif = listaDatosEmpresas.CurrentRow.Cells[0].Value.ToString();
            string nom = listaDatosEmpresas.CurrentRow.Cells[1].Value.ToString();
            string web = listaDatosEmpresas.CurrentRow.Cells[2].Value.ToString();
            string tel = listaDatosEmpresas.CurrentRow.Cells[3].Value.ToString();
            string email = listaDatosEmpresas.CurrentRow.Cells[4].Value.ToString();
            string direc = listaDatosEmpresas.CurrentRow.Cells[5].Value.ToString();
            string acti = listaDatosEmpresas.CurrentRow.Cells[6].Value.ToString();

            EditarEmpresa EU1 = new EditarEmpresa(cif, nom, web, tel, email, direc, acti);
            EU1.Show();
            this.Hide();
        }

        private void RaquetZoneEmpresas_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
             String cif = listaDatosEmpresas.CurrentRow.Cells[0].Value.ToString();

            if (MessageBox.Show("¿Quieres eliminar la empresa con CIF " + cif + "?", "Eliminar", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                

                String url = "http://localhost:8081/empresa/delete" + cif;

                RaquetZone.funciones.conexion r = new RaquetZone.funciones.conexion(url, "DELETE");

                r.deleteItem(url);

                MessageBox.Show("Eliminado");

                listaDatosEmpresas.DataSource = RaquetZone.funciones.funciones.mostrarEmp();
            }
            else
            {
                MessageBox.Show("La operación se ha detenido, no se ha eliminado la empresa");
            }
        }

        private void MostrarEmpresas()
        {
            listaDatosEmpresas.DataSource = RaquetZone.funciones.funciones.mostrarEmp();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            GestionEmpresas GE1 = new GestionEmpresas();
            GE1.Show();
            this.Hide();
        }

        private void buscadorButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Row in listaDatosEmpresas.Rows)
            {
                String strFila = Row.Index.ToString();
                string Valor = Convert.ToString(Row.Cells["cifemp"].Value);

                if (Valor == this.buscarCIF.Text)
                {
                    listaDatosEmpresas.Rows[Convert.ToInt32(strFila)].DefaultCellStyle.BackColor = Color.ForestGreen;
                    listaDatosEmpresas.CurrentCell = listaDatosEmpresas[0, Convert.ToInt32(strFila)];
                }
            }
        }
    }
}
