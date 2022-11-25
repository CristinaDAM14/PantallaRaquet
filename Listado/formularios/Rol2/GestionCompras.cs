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
    public partial class GestionCompras : MaterialForm
    {
        public GestionCompras()
        {
            InitializeComponent();
        }

        private void GestionCompras_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);

        }

        private void buttonLFC_Click(object sender, EventArgs e)
        {
            ListadoCompras LC = new ListadoCompras();
            LC.Show();
            this.Hide();
        }

        private void buttonAC_Click(object sender, EventArgs e)
        {

        }
    }
}
