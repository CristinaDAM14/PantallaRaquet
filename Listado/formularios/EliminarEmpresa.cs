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
    public partial class EliminarEmpresa : Form
    {
        public EliminarEmpresa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String cif = elimiText.Text;

            String url = "http://localhost:8081/empresa/" + cif;

            RaquetZone.funciones.conexion r = new RaquetZone.funciones.conexion(url, "DELETE");

            r.deleteItem(url);

            MessageBox.Show("Has eliminado la empresa con cif " + cif);
        }
    }
}
