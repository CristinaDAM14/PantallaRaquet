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
using System.Configuration;

namespace RaquetZone.formularios.Rol2
{
    public partial class AnyadirReservas : MaterialForm
    {
        public AnyadirReservas()
        {
            InitializeComponent();
        }

        private void AnyadirReservas_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);

            horaBox.Text = (string)horaBox.Items[0];
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "ListadoServicios").SingleOrDefault<Form>();
            if (existe != null)

            {
                MessageBox.Show("Esa ventana ya está abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                ListadoServicios LS = new ListadoServicios();
                LS.TextoCIFP.Text = TextoCIFAnyadir.Text;
                LS.Show();
            }
        }

        private void bCliente_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "ListadoClientes").SingleOrDefault<Form>();
            if (existe != null)

            {
                MessageBox.Show("Esa ventana ya está abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                ListadoClientes LC = new ListadoClientes();
                LC.TextoCIFC.Text = TextoCIFAnyadir.Text;
                LC.Show();
            }
        }

        public void conseguirDNI(string dni)
        {
            dniText.Text = dni;
        }

        public void conseguirIDSer(string id)
        {
            idServi.Text = id;
        }

        public void conseguirDNIUsuario(string dniU)
        {
            textUsuario.Text = dniU;
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "ListadoReservas").SingleOrDefault<Form>();
            if (existe != null)

            {
                MessageBox.Show("Esa ventana ya está abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                ListadoReservas LR = new ListadoReservas();
                LR.TextoCIFC.Text = TextoCIFAnyadir.Text;
                LR.Show();
                this.Close();
            }
        }

        private void editarB_Click(object sender, EventArgs e)
        {
            if (dniText.Text.Equals("") || idServi.Text.Equals("") || textUsuario.Text.Equals(""))
            {
                MessageBox.Show("No puedes dejar los campos de DNI y/o ID vacíos");
            }
            else
            {

                //Preparamos la hora
                string completarHora = horaBox.GetItemText(horaBox.SelectedItem) + ":00";

                //Preparamos la fecha
                string dia = diaNum.Value.ToString();
                string mes = mesNum.Value.ToString();
                string anyo = anyoNum.Value.ToString();

                if (dia.Length == 1)
                {
                    dia = "0" + dia;
                }
                if (mes.Length == 1)
                {
                    mes = "0" + mes;
                }

                string completarFecha = anyo + "-" + mes + "-" + dia;

                String url = ConfigurationManager.AppSettings["AccesoBD"] + "reserva/add";

                funciones.conexion r = new funciones.conexion(url, "POST");

                String datos = @" {
            " + "\n" +
                @"        ""numPista"": " + pistaNumeric.Value + "," + "\n" +
                @"        ""fechaRes"": """ + completarFecha + "\"," + "\n" +
                @"        ""horaRes"": """ + completarHora + "\"," + "\n" +
                @"        ""cliente"": {" + "\n" +
                @"            ""dnicli"": """ + dniText.Text + "\"" + "\n" +
                @"        }," + "\n" +
                @"        ""servicio"": {" + "\n" +
                @"            ""idserv"": " + idServi.Text + "" + "\n" +
                @"        }," + "\n" +
                @"            ""empresa"": {" + "\n" +
                @"                ""cifemp"": """ + TextoCIFAnyadir.Text + "\"" + "\n" +
                @"        }," + "\n" +
                @"        ""usuario"": {" + "\n" +
                @"            ""dniusr"": """ +  textUsuario.Text + "\"" + "\n" +
                @"        }" + "\n" +
                @"}";

                r.postItem(datos);

                MessageBox.Show("Reserva añadida a la base de datos");

                

                //POST NOTIFICACIONES

                String url2 = ConfigurationManager.AppSettings["AccesoBDNotificaciones"] + "notificaciones/add";

                funciones.conexion r2 = new funciones.conexion(url2, "POST");

                String datoNoti = @"{" + "\n" +
                @"        ""titulo"": "" Reserva para " + dniText.Text + "\"," + "\n" +
                @"        ""descripcion"": ""Reserva para " + dniText.Text + " con el servicio de id " + idServi.Text + "\"," + "\n" +
                @"        ""fechaCreacion"": """ + completarFecha + "\"," + "\n" +
                @"        ""leida"": 0," + "\n" +
                @"        ""dni_cliente"": """ + dniText.Text + "\"" + "\n" +
                @"    }";

                r2.postItem(datoNoti);
            }
            
            limpiar();
        }

        private void limpiar()
        {
            idServi.Text = "";
            dniText.Text = "";
            textUsuario.Text = "";
            horaBox.Text = (string)horaBox.Items[0];
            diaNum.Value = 1;
            mesNum.Value = 1;
            anyoNum.Value = 2000;
            pistaNumeric.Value = 1;
        }

        private void crearB_Click(object sender, EventArgs e)
        {
            AnyadirCliente AC = new AnyadirCliente();
            AC.Show();
        }

        private void crearUsuario_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "AnyadirUsuario").SingleOrDefault<Form>();
            if (existe != null)

            {
                MessageBox.Show("Esa ventana ya está abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                AnyadirUsuario RU = new AnyadirUsuario();
                RU.TextoCIFAnyadir.Text = TextoCIFAnyadir.Text;
                RU.Show();
            }
        }

        private void buscarUsuario_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "RaquetZoneUsuarios").SingleOrDefault<Form>();
            if (existe != null)

            {
                MessageBox.Show("Esa ventana ya está abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                RaquetZoneUsuarios RU = new RaquetZoneUsuarios();
                RU.TextoCIFC.Text = TextoCIFAnyadir.Text;
                RU.Show();
            }
        }
    }
}
