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
    public partial class EmailClientes : MaterialForm
    {
        public EmailClientes(string email)
        {
            InitializeComponent();

            destinatarioText.Text = email;
        }

        private void EmailClientes_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);

        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            string body = bodyText.Text;
            string asunto = asuntoText.Text;
            string destinatario = destinatarioText.Text;

            if(body.Equals("") || asunto.Equals(""))
            {
                MessageBox.Show("No puedes dejar ninguna de las casillas vacías", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                funciones.funciones.sendEmail(destinatario, body, asunto);
                MessageBox.Show("El email ha sido enviado ");
            }         
        }
    }
}
