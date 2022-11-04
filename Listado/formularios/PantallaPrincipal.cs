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
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var abrirGU = new GestionUsuarios();
            abrirGU.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var abrirGE = new GestionEmpresas();
            abrirGE.Show(); 
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void loginBotton_Click(object sender, EventArgs e)
        {
            Login L1 = new Login();
            L1.Show();
            this.Hide();
        }
    }
}
