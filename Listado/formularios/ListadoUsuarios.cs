using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RaquetZone.formularios
{
    public partial class RaquetZoneUsuarios : Form
    {
        public RaquetZoneUsuarios()
        {
            InitializeComponent();
        }


        private void mostrarLista_Click(object sender, EventArgs e)
        {

            listaDatos.DataSource = RaquetZone.funciones.funciones.mostrarUsr();
        }

        private void editar_Click(object sender, EventArgs e)
        {
            EditarUsuario EU1 = new EditarUsuario();
            EU1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GestionUsuarios GU1 = new GestionUsuarios();
            GU1.Show();
            this.Hide();
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            EliminarUsuario EU = new EliminarUsuario();
            EU.Show();
        }
    }
}
