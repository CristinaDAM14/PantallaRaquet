using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaquetZone.formularios
{
    public partial class AnyadirEmpresa : Form
    {
        public AnyadirEmpresa()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GestionEmpresas G1 = new GestionEmpresas();
            G1.Show();
            this.Hide();
        }

        private void anyadirButton_Click(object sender, EventArgs e)
        {
            /*
             Aqui se obtienen los datos y se genera la cadena JSON que se envia
             */

            String cif = cifText.Text;
            String nombre = nomText.Text;
            String web = webText.Text;
            String telefono = telText.Text;
            String email = emailText.Text;
            String direccion = direcText.Text;
            String actividad = actText.Text;


            /* No se comprueban errores */
            String url = "http://localhost:8081/empresa/add";

            RaquetZone.funciones.conexion r = new RaquetZone.funciones.conexion(url, "POST");

            String datos = @"{
" + "\n" +
@"        ""cifemp"": """ + cif + "\"," + "\n" +
@"        ""nomemp"": """ + nombre + "\"," + "\n" +
@"        ""webemp"": """ + web + "\"," + "\n" +
@"        ""telemp"": """ + telefono + "\"," + "\n" +
@"        ""emailemp"": """ + email + "\"," + "\n" +
@"        ""direcemp"": """ + direccion + "\"," + "\n" +
@"        ""activiemp"": """ + actividad + "\"" + "\n" +
@"    }";
            String res = r.postItem(datos);

            MessageBox.Show("Resultado: " + res);
        }
    }
}
