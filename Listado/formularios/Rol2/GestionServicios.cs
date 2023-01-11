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
    public partial class GestionServicios : MaterialForm
    {
        public GestionServicios()
        {
            InitializeComponent();
        }

        private void GestionServicios_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);

        }

        private void buttonLS_Click(object sender, EventArgs e)
        {
            ListadoServicios LS = new ListadoServicios();
            LS.Show();
            this.Close();
        }

        private void buttonAS_Click(object sender, EventArgs e)
        {
            AnyadirServicio AS = new AnyadirServicio();
            AS.Show();
            this.Close();
        }
    }
}
