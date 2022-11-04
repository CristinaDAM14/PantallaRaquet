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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        //Comprobación de la contraseña
        private void iniciarButton_Click(object sender, EventArgs e)
        {
            string usuario = dniText.Text;
            string password = passwText.Text;

            string url = "http://localhost:8081/usuario/login/?dni=" + usuario + "&password=" + password;

            RaquetZone.funciones.conexion r = new RaquetZone.funciones.conexion(url, "GET");

            string persona = r.getItem();

            

            string rol = "rolusr\":3";
            string rol2 = "rolusr\":2";

            bool tipoRol = persona.Contains(rol);
            bool tipoRol2 = persona.Contains(rol2);

            if (persona == "[]")
            {

                MessageBox.Show("Error a la hora de incluir los datos","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if(tipoRol == true)
            {

                MessageBox.Show("Acabas de iniciar sesión con el DNI " + usuario,"Sesión iniciada",MessageBoxButtons.OK);
                PantallaPrincipal P1 = new PantallaPrincipal();
                P1.Show();
                this.Hide();

            }
            else if (tipoRol2 == true)
            {

                MessageBox.Show("Acabas de iniciar sesión con el DNI " + usuario, "Sesión iniciada", MessageBoxButtons.OK);
                PantallaPrincipalRol2 P2 = new PantallaPrincipalRol2();
                P2.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("El apartado de clientes todavía no está creado");
            }
        }
    }
}
