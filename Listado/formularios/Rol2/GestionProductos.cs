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
    public partial class GestionProductos : MaterialForm
    {
        public GestionProductos()
        {
            InitializeComponent();
        }

        private void GestionProductos_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);

        }

        private void buttonAP_Click(object sender, EventArgs e)
        {
            AnyadirProductos AP = new AnyadirProductos();
            AP.Show();
            this.Hide();
        }

        private void buttonLP_Click(object sender, EventArgs e)
        {
            ListadoProductos LP = new ListadoProductos();
            LP.Show();
            this.Hide();
        }
    }
}
