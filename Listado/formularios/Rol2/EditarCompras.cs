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
    public partial class EditarCompras : MaterialForm
    {
        public EditarCompras(string id, string fecha, string hora)
        {
            InitializeComponent();
            idText.Text = id;
            fechaText.Text = fecha;
            horaText.Text = hora;

        }

        private void EditarCompras_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);

        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            ListadoCompras LC = new ListadoCompras();
            LC.Show();
            this.Close();
        }

        private void editarB_Click(object sender, EventArgs e)
        {
            String url = "http://localhost:8081/producto/modify" + idText.Text;

            funciones.conexion r = new funciones.conexion(url, "PUT");

            String datos = @"{
" + "\n" +
@"        ""idcomp"": """ + idText.Text + "\"," + "\n" +
@"        ""fechacomp"": """ + fechaText.Text + "\"," + "\n" +
@"        ""horacomp"": """ + horaText.Text + "\"," + "\n" +
@"    }";

            r.putItem(url, datos);

            MessageBox.Show("Editado con éxito");
        }
    }
    }
