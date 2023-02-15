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
    public partial class EditarClientes : MaterialForm
    {
        
        public EditarClientes(string dni, string nom, string pass, string num, string tel, string email, string activo)
        {
            InitializeComponent();
            dniText.Text = dni;
            nomText.Text = nom;
            passText.Text = pass;
            numNum.Value = Int32.Parse(num);
            telText.Text = tel;
            emailText.Text = email;
            if (activo.Equals("true"))
            {
                actiBox.SelectedItem = "Activo";
            }
            else
            {
                actiBox.SelectedItem = "No Activo";
            }
        }


        private void EditarClientes_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);

        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "ListadoClientes").SingleOrDefault<Form>();
            if (existe != null)

            {
                MessageBox.Show("Esa ventana ya está abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                ListadoClientes GC = new ListadoClientes();
                GC.TextoCIFC.Text = TextoCIFAnyadir.Text;
                GC.Show();
                this.Close();
            }
        }

        private void editarB_Click(object sender, EventArgs e)
        {

            string numActi = "false";

            if (actiBox.GetItemText(actiBox.SelectedItem).Equals("Activo"))
            {
                numActi = "true";
            }

            String url = "http://localhost:8081/cliente/modify/" + dniText.Text;

            funciones.conexion r = new funciones.conexion(url, "PUT");

            String datos = @"{
" + "\n" +
@"        ""dnicli"": """ + dniText.Text + "\"," + "\n" +
@"        ""nombrecli"": """ + nomText.Text + "\"," + "\n" +
@"        ""passwordcli"": """ + passText.Text + "\"," + "\n" +
@"        ""numhorascli"": " + numNum.Value + "," + "\n" +
@"        ""telefonocli"": """ + telText.Text + "\"," + "\n" +
@"        ""emailcli"": """ + emailText.Text + "\"," + "\n" +
@"        ""activo"": " + numActi + "" + "\n" +
            @"    }";

            r.putItem(url, datos);

            MessageBox.Show("Editado con éxito");

        }
    }
}
