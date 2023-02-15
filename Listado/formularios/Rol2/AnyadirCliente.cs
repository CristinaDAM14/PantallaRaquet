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
    public partial class AnyadirCliente : MaterialForm
    {
        public AnyadirCliente()
        {
            InitializeComponent();
        }

        private void AnyadirCliente_Load(object sender, EventArgs e)
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

        private void buttonAnyadir_Click(object sender, EventArgs e)
        {

            if (funciones.funciones.IsNumeric(nomText.Text) == false)
            {

                if (funciones.funciones.IsNumeric(telText.Text) == true)
                {
                    if (telText.Text.Length == 9)
                    {
                        String url = "http://localhost:8081/empresa/" + TextoCIFAnyadir.Text + "/cliente";

                        funciones.conexion r = new funciones.conexion(url, "POST");

                        String datos = @"{
                    " + "\n" +
            @"        ""dnicli"": """ + dniText.Text + "\"," + "\n" +
            @"        ""nombrecli"": """ + nomText.Text + "\"," + "\n" +
            @"        ""passwordcli"": """ + passText.Text + "\"," + "\n" +
            @"        ""numhorascli"": 0," + "\n" +
            @"        ""telefonocli"": """ + telText.Text + "\"," + "\n" +
            @"        ""emailcli"": """ + emailText.Text + "\"," + "\n" +
            @"        ""empresa"": [" + "\n" +
            @"            {" + "\n" +
            @"                ""cifemp"": """ + TextoCIFAnyadir.Text + "\"" + "\n" +
            @"            }" + "\n" +
            @"            ]" + "\n" +
            @"}";

                        String res = r.postItem(datos);

                        MessageBox.Show("Cliente añadido a la base de datos");

                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Formato del número de teléfono incorrecto, tiene que tener 9 números", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Formato del número de teléfono incorrecto, no puede incluir letras", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
                {
                MessageBox.Show("Formato del nombre incorrecto, no puede contener números", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiar()
        {
            dniText.Text = "";
            nomText.Text = "";
            passText.Text = "";
            telText.Text = "";
            emailText.Text = "";
        }

    }
}
