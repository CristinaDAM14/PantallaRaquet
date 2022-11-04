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
    public partial class PantallaPrincipalRol2 : Form
    {
        public PantallaPrincipalRol2()
        {
            InitializeComponent();
        }

        private void loginBotton_Click(object sender, EventArgs e)
        {
            Login LU1 = new Login();
            LU1.Show();
            this.Hide();
        }

        private void buttonGE_Click(object sender, EventArgs e)
        {
            var abrirGU = new GestionUsuarios();
            abrirGU.Show();
        }
    }
}
