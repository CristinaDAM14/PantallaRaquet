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

        public void SeleccionarVacaciones()
        {


            SpecialDate vacaciones1 = new SpecialDate();
            List<SpecialDate> SpecialDates = new List<SpecialDate>();

            vacaciones1.BackColor = Color.PeachPuff;
            vacaciones1.ForeColor = Color.DarkOliveGreen;
            vacaciones1.Font = new Font("Segoe UI", 14F, FontStyle.Regular,GraphicsUnit.Point, ((byte)(0)));
            vacaciones1.Value = new DateTime(2023, 2, 23);
            SpecialDates.Add(vacaciones1);
            sfCalendar1.SpecialDates = SpecialDates;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            SeleccionarVacaciones();
            //DateTime selectedDate = sfCalendar1.SelectedDate;
            DateTime selectedDate = sfCalendar1.SelectedDate.Value;
            MessageBox.Show(Convert.ToString(selectedDate));
        }

        private void anyadirVaca_Click(object sender, EventArgs e)
        {
            String fecha = sfCalendar1.SelectedDate.Value.ToString("yyyy-MM-dd");

            String url = "http://localhost:8081/horario/add";

            RaquetZone.funciones.conexion r = new RaquetZone.funciones.conexion(url, "POST");

            var datos = @"{" + "\n" +
@"        ""fechahor"": """+  fecha + "\"," + "\n" +
@"        ""usuario"": {" + "\n" +
@"            ""dniusr"": """ + boxEmpleados.GetItemText(boxEmpleados.SelectedItem) + "\"" + "\n" +
@"        }" + "\n" +
@"}";

            String res = r.postItem(datos);

            MessageBox.Show("Vacaciones añadidas a la base de datos");
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {

        }

        private void bTrofeo_Click(object sender, EventArgs e)
        {
            SpecialDate trofeo = new SpecialDate();
            List<SpecialDate> SpecialDates = new List<SpecialDate>();

            Image image1 = Image.FromFile("D:\\Clase_Segundo\\Interfaces\\Listado\\Listado\\img\\trofeo1.png");

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

            Image image2 = Image.FromFile("D:\\Clase_Segundo\\Interfaces\\Listado\\Listado\\img\\cumple.png");

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
    }
}
