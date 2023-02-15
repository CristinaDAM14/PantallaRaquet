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
    public partial class EditarCompras : MaterialForm
    {
        public EditarCompras(string id, string fecha, string hora, string dni)
        {
            InitializeComponent();
            idText.Text = id;

            diaNum.Value = Int32.Parse(fecha.Substring(0, 2));
            mesNum.Value = Int32.Parse(fecha.Substring(3, 2));
            anyoNum.Value = Int32.Parse(fecha.Substring(6, 4));

            horaNum.Value = Int32.Parse(hora.Substring(0, 2));
            minNum.Value = Int32.Parse(hora.Substring(3, 2));

            dniText.Text = dni;

        }

        private void EditarCompras_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);

        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "ListadoComprasSolas").SingleOrDefault<Form>();
            if (existe != null)

            {
                MessageBox.Show("Esa ventana ya está abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                ListadoComprasSolas LC = new ListadoComprasSolas();
                LC.TextoCIFP.Text = TextoCIFAnyadir.Text;
                LC.Show();
                this.Close();
            }
        }

        private void editarB_Click(object sender, EventArgs e)
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

            string completarFecha = anyo + "-" + mes + "-" + dia + "T00:00:00.000+00:00";

            String url = "http://localhost:8081/compra/modify/" + idText.Text;

            funciones.conexion r = new funciones.conexion(url, "PUT");

            String datos = @"{
" + "\n" +
@"        ""idcomp"": " + idText.Text + "," + "\n" +
@"        ""fechacomp"": """ + completarFecha + "\"," + "\n" +
@"        ""horacomp"": """ + completarHora + "\"," + "\n" +
@"        ""cliente"": {" + "\n" +
@"            ""dnicli"": """ + dniText.Text + "\"," + "\n" +
@"            ""empresa"": [" + "\n" +
@"                {" + "\n" +
@"                    ""cifemp"": """ + TextoCIFAnyadir.Text + "\"" + "\n" +
@"                }" + "\n" +
@"            ]" + "\n" +
@"        }" + "\n" +
@"    }";

            r.putItem(url, datos);

            MessageBox.Show("Editado con éxito");
        }
    }
    }
