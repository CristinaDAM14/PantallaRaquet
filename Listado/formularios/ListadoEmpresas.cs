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
        }

        private void editar_Click(object sender, EventArgs e)
        {
            EditarEmpresa EU1 = new EditarEmpresa();
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
            //EliminarEmpresa EE = new EliminarEmpresa();
            //EE.Show();

            if (MessageBox.Show(" Quieres eliminar?", "Eliminar", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MessageBox.Show("Eliminado");
            }
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            listaDatosEmpresas.DataSource = RaquetZone.funciones.funciones.mostrarEmp();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            GestionEmpresas GE1 = new GestionEmpresas();
            GE1.Show();
            this.Hide();
        }
    }
}
