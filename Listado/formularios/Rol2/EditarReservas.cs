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
    public partial class EditarReservas : MaterialForm
    {
        public EditarReservas(string id, string num, string fecha, string hora, string dniCli, string idSer, string dniUser)
        {
            InitializeComponent();

            idText.Text = id;
            pistaNumeric.Value = Int32.Parse(num);



            diaNum.Value = Int32.Parse(fecha.Substring(8, 2));
            mesNum.Value = Int32.Parse(fecha.Substring(5, 2));
            anyoNum.Value = Int32.Parse(fecha.Substring(0, 4));

            string horaDada = hora.Substring(0, 5);
            dniText.Text = dniCli;
            idServi.Text = idSer;
            textUsuario.Text = dniUser;
            
            //seleccionar combobox
            bool comprobador = false;
            int contador = 0;

            do
            {

                if (horaBox.Items[contador].Equals(horaDada))
                {
                    comprobador = true;
                    horaBox.Text = (string)horaBox.Items[contador];
                }
                contador++;

            } while (comprobador != true);

        }

        private void EditarReservas_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);
        }

        private void editarB_Click(object sender, EventArgs e)
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

            String url = ConfigurationManager.AppSettings["AccesoBD"] + "reserva/modify/" + idText.Text;

            funciones.conexion r = new funciones.conexion(url, "PUT");

            String datos = @" {
            " + "\n" +
            @"        ""idRes"": " +  idText.Text + "," + "\n" +
            @"        ""numPista"": " + pistaNumeric.Value + "," + "\n" +
            @"        ""fechaRes"": """ + completarFecha + "\"," + "\n" +
            @"        ""horaRes"": """ + completarHora + "\"," + "\n" +
            @"        ""cliente"": {" + "\n" +
            @"            ""dnicli"": """ + dniText.Text +"\"" + "\n" +
            @"        }," + "\n" +
            @"        ""servicio"": {" + "\n" +
            @"            ""idserv"": " + idServi.Text + "" + "\n" +
            @"        }," + "\n" +
            @"            ""empresa"": {" + "\n" +
            @"                ""cifemp"": """ + TextoCIFAnyadir.Text + "\"" + "\n" +
            @"        }," + "\n" +
            @"        ""usuario"": {" + "\n" +
            @"            ""dniusr"": """ + textUsuario.Text + "\"" + "\n" +
            @"        }" + "\n" +
            @"}";

            r.putItem(url, datos);

            MessageBox.Show("Editado con éxito");
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
    }
    }
