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

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            String url = "http://localhost:8081/empresa/modify" + cifText.Text;

            RaquetZone.funciones.conexion r = new RaquetZone.funciones.conexion(url, "PUT");

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

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            RaquetZoneEmpresas LE1 = new RaquetZoneEmpresas();
            LE1.Show();
            this.Hide();
        }

    }
}
