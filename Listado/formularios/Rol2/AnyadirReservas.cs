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

        private void bVolver_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void editarB_Click(object sender, EventArgs e)
        {
            if (dniText.Text.Equals("") || idServi.Text.Equals(""))
            {
                MessageBox.Show("No puedes dejar los campos de DNI y/o ID vacíos");
            }
            else
            {

                //Preparamos la hora
                string hora = horaNum.Value.ToString();
                string min = minNum.Value.ToString();

                if (min.Length == 1)
                {
                    min = "0" + min;
                }
                if (hora.Length == 1)
                {
                    hora = "0" + hora;
                }

                string completarHora = hora + ":" + min + ":00";

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

                String url = "http://localhost:8081/reserva/add";

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
                @"        }" + "\n" +
                @"    }"; ;

                r.postItem(datos);

                MessageBox.Show("Reserva añadida a la base de datos");

                limpiar();

                //POST NOTIFICACIONES

                String url2 = "http://localhost:9000/notificaciones/add";

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
        }

        private void limpiar()
        {
            idServi.Text = "";
            dniText.Text = "";
            horaNum.Value = 0;
            minNum.Value = 0;
            diaNum.Value = 0;
            mesNum.Value = 0;
            anyoNum.Value = 0;
            pistaNumeric.Value = 0;
        }

    }
}
