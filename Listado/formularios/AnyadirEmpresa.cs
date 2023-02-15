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
    public partial class AnyadirEmpresa : MaterialForm
    {
        public AnyadirEmpresa()
        {
            InitializeComponent();
        }

        private void AnyadirEmpresa_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);

        }

        private void bVolver_Click(object sender, EventArgs e)
        {

            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "RaquetZoneEmpresas").SingleOrDefault<Form>();
            if (existe != null)

            {
                MessageBox.Show("Esa ventana ya está abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                RaquetZoneEmpresas LU1 = new RaquetZoneEmpresas();
                LU1.Show();
                this.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (funciones.funciones.IsNumeric(telText.Text) == true && telText.Text.Length == 9)
            {

                String url = "http://localhost:8081/empresa/add";

                funciones.conexion r = new funciones.conexion(url, "POST");

                String datos = @"{
" + "\n" +
    @"        ""cifemp"": """ + cifText.Text + "\"," + "\n" +
    @"        ""nomemp"": """ + nomText.Text + "\"," + "\n" +
    @"        ""webemp"": """ + webText.Text + "\"," + "\n" +
    @"        ""telemp"": """ + telText.Text + "\"," + "\n" +
    @"        ""emailemp"": """ + emailText.Text + "\"," + "\n" +
    @"        ""direcemp"": """ + direcText.Text + "\"," + "\n" +
    @"        ""activiemp"": """ + actText.Text + "\"" + "\n" +
    @"    }";
                String res = r.postItem(datos);

                MessageBox.Show("Empresa añadida a la base de datos");
                limpiar();
            }
            else
            {
                MessageBox.Show("Formato del número de teléfono mal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

                
        }

        private void limpiar()
        {
            cifText.Text = "";
            nomText.Text = "";
            webText.Text = "";
            telText.Text = "";
            emailText.Text = "";
            direcText.Text = "";
            actText.Text = "";
        }
    }
}
