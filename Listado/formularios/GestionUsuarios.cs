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
    public partial class GestionUsuarios : Form
    {
        public GestionUsuarios()
        {
            InitializeComponent();
        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void buttonLU_Click(object sender, EventArgs e)
        {
            RaquetZoneUsuarios LU1 = new RaquetZoneUsuarios();
            LU1.Show();
            this.Hide();
        }

        private void buttonAU_Click(object sender, EventArgs e)
        {
            AnyadirUsuario AU1 = new AnyadirUsuario();
            AU1.Show();
            this.Hide();
        }
    }
}
