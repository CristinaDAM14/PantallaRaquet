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
    public partial class GestionEmpresas : Form
    {
        public GestionEmpresas()
        {
            InitializeComponent();
        }

        private void buttonLE_Click(object sender, EventArgs e)
        {
            RaquetZoneEmpresas LE1 = new RaquetZoneEmpresas();
            LE1.Show();
            this.Hide();
        }

        private void buttonAE_Click(object sender, EventArgs e)
        {
            AnyadirEmpresa AE1 = new AnyadirEmpresa();
            AE1.Show();
            this.Hide();
        }
    }
}
