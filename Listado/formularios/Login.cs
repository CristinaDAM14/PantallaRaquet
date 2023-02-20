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
using System.Text.RegularExpressions;
using System.Configuration;

namespace RaquetZone.formularios
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);
        }

        //Comprobación de la contraseña
        private void iniciarButton_Click(object sender, EventArgs e)
        {
            string usuario = dniText.Text;
            string password = passwText.Text;

            string url = ConfigurationManager.AppSettings["AccesoBD"] + "usuario/login/?dni=" + usuario + "&password=" + password;

            RaquetZone.funciones.conexion r = new RaquetZone.funciones.conexion(url, "GET");

            string persona = r.getItem();

            string rol = "rolusr\":3";
            string rol2 = "rolusr\":2";
            string rol1 = "rolusr\":1";

            bool tipoRol = persona.Contains(rol);
            bool tipoRol2 = persona.Contains(rol2);
            bool tipoRol1 = persona.Contains(rol1);

            if (persona == "[]")
            {

                MessageBox.Show("Error a la hora de introducir los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tipoRol == true)
            {

                MessageBox.Show("Acabas de iniciar sesión con el DNI " + usuario, "Sesión iniciada", MessageBoxButtons.OK, MessageBoxIcon.None);
                PantallaPrincipal P1 = new PantallaPrincipal();
                P1.Show();
                this.Hide();

            }
            else if (tipoRol2 == true)
            {
               String url2 = ConfigurationManager.AppSettings["AccesoBD"] + "empresas";

                funciones.conexion r2 = new funciones.conexion(url2, "GET");

                string compa = r2.getItem();

                    var matches = Regex.Matches(compa, @"cifemp[\s\S]{0,3}([A-Z0-9]{1,15})[\s\S]");
                    List<string> rescateCIF = new List<string>();
                    var rescateCIF1 = matches.Cast<Match>().SelectMany(o => o.Groups.Cast<Capture>().Skip(1).Select(c => c.Value));

                    rescateCIF.AddRange(rescateCIF1);

                    int contador = 0;
                    bool comprobacion = false;
                    int vacio = 0;

                    do
                    {
                        
                        String urlSE = ConfigurationManager.AppSettings["AccesoBD"] + "empresa/" + rescateCIF[contador] + "/propietarios";

                        funciones.conexion r3 = new funciones.conexion(urlSE, "GET");

                        string SEmpresa = r3.getItem();

                        if (!SEmpresa.Equals(""))
                        {
                            comprobacion = SEmpresa.Contains(usuario);

                            if (comprobacion == true)
                            {
                                comboCIF.Items.Add(rescateCIF[contador]);
                                vacio++;
                            }
                            comprobacion = false;
                            SEmpresa = "";
                        }
                        contador++;

                    } while (contador != rescateCIF.Count);

                    if (vacio == 0)
                    {
                        MessageBox.Show("Acabas de intentar iniciar sesión con el DNI " + usuario + ", pero este usuario no está vinculado a ninguna empresa ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                MessageBox.Show("Acabas de iniciar sesión con el DNI " + usuario, "Sesión iniciada", MessageBoxButtons.OK, MessageBoxIcon.None);
                Rol2.PantallaPrincipalRol2 P2 = new Rol2.PantallaPrincipalRol2();

                    foreach (var item in comboCIF.Items)
                    {
                        P2.comboCIFP2.Items.Add(item);
                    }
                    P2.Show();
                    this.Hide();
                    }    
            }
            else if (tipoRol1 == true)
            {
                MessageBox.Show("Acabas de intentar iniciar sesión con el DNI " + usuario + ", pero un empleado no puede entrar ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
        }

        private void contraOlvidada_Click(object sender, EventArgs e)
        {
            ComprobarCorreo CC = new ComprobarCorreo();
            CC.Show();

        }
    }
}
