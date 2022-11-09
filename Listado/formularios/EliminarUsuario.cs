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
    public partial class EliminarUsuario : Form
    {
        public EliminarUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String dni = elimiText.Text;

            String url = "http://localhost:8081/usuario/delete" + dni;

            RaquetZone.funciones.conexion r = new RaquetZone.funciones.conexion(url, "DELETE");

            r.deleteItem(url);

            MessageBox.Show("Has eliminado el usuario con el dni " + dni);
        }
    }
}
