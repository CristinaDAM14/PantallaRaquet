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
    public partial class GestionUsuarios : MaterialForm
    {
        public GestionUsuarios()
        {
            InitializeComponent();

            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "PantallaPrincipalRol2").SingleOrDefault<Form>();
            if (existe != null)

            {

               buttonAU.Text = "Añadir Empleado";
               buttonLU.Text = "Listado de Empleados";
               this.Text = "Gestión de Empleados";

            }
        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);

        }
        private void buttonAU_Click_1(object sender, EventArgs e)
        {
            AnyadirUsuario AU1 = new AnyadirUsuario();
            AU1.Show();
            this.Hide();
        }

        private void buttonLU_Click_1(object sender, EventArgs e)
        {
            RaquetZoneUsuarios LU1 = new RaquetZoneUsuarios();
            LU1.Show();
            this.Hide();
        }
    }
}
