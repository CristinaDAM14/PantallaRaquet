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
    public partial class AnyadirCompras : MaterialForm
    {
        public AnyadirCompras()
        {
            InitializeComponent();
        }

        private void AnyadirCompras_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);

        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "ListadoCompras").SingleOrDefault<Form>();
            if (existe != null)

            {
                this.Close();

            }
            else
            {
                ListadoCompras PP2 = new ListadoCompras();
            PP2.Show();
            this.Close();
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Preparamos la hora
            string hora = horaNum.Value.ToString();
            string min = minNum.Value.ToString();

            if(min.Length == 1)
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
            
            //Hacemos el POST

            String url = "http://localhost:8081/compra/add";

            RaquetZone.funciones.conexion r = new RaquetZone.funciones.conexion(url, "POST");

            String datos = @"{
" + "\n" +
@"        ""fechacomp"": """ + completarFecha + "\"," + "\n" +
@"        ""horacomp"": """ + completarHora + "\"" + "\n" +
@"    }";

            String res = r.postItem(datos);

            MessageBox.Show("Compra añadida a la base de datos");
        }
    }
}
