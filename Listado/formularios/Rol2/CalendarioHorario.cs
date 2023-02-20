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
using Syncfusion.WinForms.Input;
using System.Text.RegularExpressions;
using System.IO;
using System.Configuration;

namespace RaquetZone.formularios.Rol2
{

    public partial class CalendarioHorario : MaterialForm
    {
        public CalendarioHorario()
        {
            InitializeComponent();
        }

        private void CalendarioHorario_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);

            boxEmpleados.Text = (string)boxEmpleados.Items[0];

        }

        private void anyadirVaca_Click(object sender, EventArgs e)
        {
            String fecha = sfCalendar1.SelectedDate.Value.ToString("yyyy-MM-dd");

            String url = ConfigurationManager.AppSettings["AccesoBD"] + "horario/add";

            RaquetZone.funciones.conexion r = new RaquetZone.funciones.conexion(url, "POST");

            var datos = @"{" + "\n" +
@"        ""fechahor"": """+  fecha + "\"," + "\n" +
@"        ""usuario"": {" + "\n" +
@"            ""dniusr"": """ + boxEmpleados.GetItemText(boxEmpleados.SelectedItem) + "\"" + "\n" +
@"        }" + "\n" +
@"}";

            String res = r.postItem(datos);

            MessageBox.Show("Vacaciones añadidas a la base de datos");

            mostrarVacaciones(listadoFechas());
        }

        private void bTrofeo_Click(object sender, EventArgs e)
        {
            SpecialDate trofeo = new SpecialDate();
            List<SpecialDate> SpecialDates = new List<SpecialDate>();

            string basePath = Application.StartupPath;
            string relativePath = @"imgCalendario\trofeo1.png";

            string fullPath = Path.Combine(basePath, relativePath);

            Image image1 = Image.FromFile(fullPath);

            trofeo.BackColor = Color.White;
            trofeo.Font = new Font("Segoe UI", 6F, FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));
            trofeo.ForeColor = Color.Magenta;
            trofeo.Image = image1;
            trofeo.Description = "Torneo";
            trofeo.ImageAlign = ContentAlignment.MiddleCenter;
            trofeo.IsDateVisible = false;
            trofeo.TextAlign = ContentAlignment.MiddleCenter;
            trofeo.TextImageRelation = TextImageRelation.TextBeforeImage;
            trofeo.Value = sfCalendar1.SelectedDate.Value;
            SpecialDates.Add(trofeo);
            sfCalendar1.SpecialDates = SpecialDates;
        }

        private void bcumple_Click(object sender, EventArgs e)
        {
            SpecialDate trofeo = new SpecialDate();
            List<SpecialDate> SpecialDates = new List<SpecialDate>();

            string basePath = Application.StartupPath;
            string relativePath = @"imgCalendario\cumple.png";

            string fullPath = Path.Combine(basePath, relativePath);

            Image image2 = Image.FromFile(fullPath);

            trofeo.BackColor = Color.White;
            trofeo.Font = new Font("Segoe UI", 6F, FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));
            trofeo.ForeColor = Color.Magenta;
            trofeo.Image = image2;
            trofeo.Description = "Cumpleaños";
            trofeo.ImageAlign = ContentAlignment.MiddleCenter;
            trofeo.IsDateVisible = false;
            trofeo.TextAlign = ContentAlignment.MiddleCenter;
            trofeo.TextImageRelation = TextImageRelation.TextBeforeImage;
            trofeo.Value = sfCalendar1.SelectedDate.Value;
            SpecialDates.Add(trofeo);
            sfCalendar1.SpecialDates = SpecialDates;
        }

        public List<string> listadoFechas()
        {
            String url2 = ConfigurationManager.AppSettings["AccesoBD"] + "usuario/" + boxEmpleados.GetItemText(boxEmpleados.SelectedItem) + "/horarios";

            funciones.conexion r2 = new funciones.conexion(url2, "GET");

            string fechasVaca = r2.getItem();

            var matches = Regex.Matches(fechasVaca, @"fechahor[\s\S]{0,3}([^A-Z]{1,10})[\s\S]");
            List<string> rescateFechas = new List<string>();
            var rescateFechas1 = matches.Cast<Match>().SelectMany(o => o.Groups.Cast<Capture>().Skip(1).Select(c => c.Value));

            rescateFechas.AddRange(rescateFechas1);

            return rescateFechas;
        }

        public void mostrarVacaciones(List<string> rescateFechas)
        {

            int contador = 0;
            List<SpecialDate> SpecialDates = new List<SpecialDate>();
            SpecialDates.Clear();

            if (rescateFechas.Count == 0)
            {
                SpecialDate vacaciones1 = new SpecialDate();

                string fechahoy1 = DateTime.Today.ToString();

                string dia1 = fechahoy1.Substring(0, 2);
                string mes1 = fechahoy1.Substring(3, 2);
                string anyo1 = fechahoy1.Substring(6, 4);

                fechahoy1 = anyo1 + "-" + mes1 + "-" + dia1;
                DateTime fechah1 = DateTime.Parse(fechahoy1);
                sfCalendar1.SelectedDate = fechah1;

                vacaciones1.BackColor = Color.WhiteSmoke;
                vacaciones1.ForeColor = Color.Black;
                vacaciones1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                vacaciones1.Value = fechah1;
                SpecialDates.Add(vacaciones1);
                sfCalendar1.SpecialDates = SpecialDates;

                MessageBox.Show("Este empleado no tiene todavía ningún día de vacaciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

            do
            {
                DateTime date = DateTime.Parse(rescateFechas[contador]);

                SpecialDate vacaciones1 = new SpecialDate();

                sfCalendar1.SelectedDate = date;

                vacaciones1.BackColor = Color.PeachPuff;
                vacaciones1.ForeColor = Color.DarkOliveGreen;
                vacaciones1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                vacaciones1.Value = date;
                SpecialDates.Add(vacaciones1);
                sfCalendar1.SpecialDates = SpecialDates;

                contador++;


            } while (contador != rescateFechas.Count);
            }

            //poner puntero en la fecha actual
            string fechahoy = DateTime.Today.ToString();

            string dia = fechahoy.Substring(0, 2);
            string mes = fechahoy.Substring(3, 2);
            string anyo = fechahoy.Substring(6, 4);

            fechahoy = anyo + "-" + mes + "-" + dia;
            DateTime fechah = DateTime.Parse(fechahoy);
            sfCalendar1.SelectedDate = fechah;
        }

        private void mMostrar_Click_1(object sender, EventArgs e)
        {
            mostrarVacaciones(listadoFechas());
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Quieres eliminar las vacaciones del día "+ sfCalendar1.SelectedDate.Value +"?", "Eliminar", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                List<string> fechas = new List<string>();
                fechas.AddRange(listadoFechas());

                String url2 = ConfigurationManager.AppSettings["AccesoBD"] + "usuario/" + boxEmpleados.GetItemText(boxEmpleados.SelectedItem) + "/horarios";

                funciones.conexion r2 = new funciones.conexion(url2, "GET");

                string fechasVaca = r2.getItem();

                var matches = Regex.Matches(fechasVaca, @"idhor[\s\S]{0,3}([0-9]{1,10})[\s\S]");
                List<string> rescateID = new List<string>();
                var rescateID1 = matches.Cast<Match>().SelectMany(o => o.Groups.Cast<Capture>().Skip(1).Select(c => c.Value));

                rescateID.AddRange(rescateID1);
                int contador1 = 0;
                bool finiquitao = false;
                string idFecha = "";

                string fechahoy = sfCalendar1.SelectedDate.Value.ToString();

                string dia = fechahoy.Substring(0, 2);
                string mes = fechahoy.Substring(3, 2);
                string anyo = fechahoy.Substring(6, 4);

                fechahoy = anyo + "-" + mes + "-" + dia;
                do
                {
                    if (fechas[contador1].Equals(fechahoy))
                    {
                        finiquitao = true;
                        idFecha = rescateID[contador1];
                    }
                    contador1++;

                } while (finiquitao != true);

                String url = ConfigurationManager.AppSettings["AccesoBD"] + "horario/delete/" + idFecha;

                RaquetZone.funciones.conexion r = new RaquetZone.funciones.conexion(url, "DELETE");

                r.deleteItem(url);

                MessageBox.Show("Eliminado");

                mostrarVacaciones(listadoFechas());
            }
            else
            {
                MessageBox.Show("La operación se ha detenido, no se ha eliminado la fecha");
            }
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "RaquetZoneUsuarios").SingleOrDefault<Form>();
            if (existe != null)

            {
                MessageBox.Show("Esa ventana ya está abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                RaquetZoneUsuarios GC = new RaquetZoneUsuarios();
                GC.TextoCIFC.Text = TextoCIFAnyadir.Text;
                GC.Show();
                this.Close();
            }
        }
    }
}
