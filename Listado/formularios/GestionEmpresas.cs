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
    public partial class GestionEmpresas : MaterialForm
    {
        public GestionEmpresas()
        {
            InitializeComponent();
        }

        private void GestionEmpresas_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);

        }

        private void buttonAE_Click_1(object sender, EventArgs e)
        {
            AnyadirEmpresa AE1 = new AnyadirEmpresa();
            AE1.Show();
            this.Hide();
        }

        private void buttonLE_Click_1(object sender, EventArgs e)
        {
            RaquetZoneEmpresas LE1 = new RaquetZoneEmpresas();
            LE1.Show();
            this.Hide();
        }
    }
}
