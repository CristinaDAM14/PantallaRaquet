using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace RaquetZone.formularios
{
    public partial class ComprobarCorreo : MaterialForm
    {
        public ComprobarCorreo()
        {
            InitializeComponent();
        }

        private void ComprobarCorreo_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);

        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {

            string usuario = dniText.Text;
            string email = emailText.Text;

            try
            {
                if (MessageBox.Show("DNI: " + usuario + "\n Email: " + email + "\n ¿Estás seguro de que estos son tus datos?", "Recuperación de contraseña", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    string url = "http://localhost:8081/usuario/" + usuario;

                    funciones.conexion r = new funciones.conexion(url, "GET");

                    string persona = r.getItem();

                    var juser = JsonConvert.DeserializeObject<funciones.usuario>(persona);
                    string emailJ = juser.emailusr;

                    if (emailJ == email)
                    {
                        string pass = juser.passwordusr;
                        string body = "La contraseña que olvidaste es " + pass;
                        string subject = "Recuperación de contraseña";
                        Cursor.Current = Cursors.WaitCursor;
                        funciones.funciones.sendEmail(email, body, subject);
                        MessageBox.Show("El email ha sido enviado ");
                    }
                    else
                    {
                        MessageBox.Show("Error al introducir los datos, vuelva a intentarlo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("La operación se ha detenido");
                }
            }catch(ArgumentNullException)
            {
                MessageBox.Show("La operación se ha detenido, alguno de los datos no están bien");
            }
                       
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
