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
    public partial class EditarEmpresa : MaterialForm
    {
        public EditarEmpresa(string cif, string nom, string web, string tel, string email, string direc, string acti)
        {
            InitializeComponent();
            cifText.Text = cif;
            nomText.Text = nom;
            webText.Text = web;
            telText.Text = tel;
            emailText.Text = email;
            direccText.Text = direc;
            actiText.Text = acti;

        }

        private void EditarEmpresa_Load(object sender, EventArgs e)
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

        private void buttonEditar_Click_1(object sender, EventArgs e)
        {
            String url = "http://localhost:8081/empresa/modify/" + cifText.Text;

            funciones.conexion r = new funciones.conexion(url, "PUT");

            String datos = @"{
" + "\n" +
@"        ""cifemp"": """ + cifText.Text + "\"," + "\n" +
@"        ""nomemp"": """ + nomText.Text + "\"," + "\n" +
@"        ""webemp"": """ + webText.Text + "\"," + "\n" +
@"        ""telemp"": """ + telText.Text + "\"," + "\n" +
@"        ""emailemp"": """ + emailText.Text + "\"," + "\n" +
@"        ""direcemp"": """ + direccText.Text + "\"," + "\n" +
@"        ""activiemp"": """ + actiText.Text + "\"" + "\n" +
@"    }";

            r.putItem(url, datos);

            MessageBox.Show("Editado con éxito");
        }
    }
}
