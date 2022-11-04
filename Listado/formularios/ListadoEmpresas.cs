using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaquetZone.formularios
{
    public partial class RaquetZoneEmpresas : Form
    {
        public RaquetZoneEmpresas()
        {
            InitializeComponent();
        }

        private void mostrarListaEmpresas_Click(object sender, EventArgs e)
        {

            listaDatosEmpresas.DataSource = RaquetZone.funciones.funciones.mostrarEmp();

        }

        private void editar_Click(object sender, EventArgs e)
        {
            EditarEmpresa EU1 = new EditarEmpresa();
            EU1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GestionEmpresas GE1 = new GestionEmpresas();
            GE1.Show();
            this.Hide();
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            
            
            //EliminarEmpresa EE = new EliminarEmpresa();
            //EE.Show();

            if (MessageBox.Show( " Quieres eliminar?","Eliminar", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                MessageBox.Show("Eliminado");
            }
        
        }
    }
}
