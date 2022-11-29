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

namespace RaquetZone.formularios
{
    public partial class RaquetZoneUsuarios : MaterialForm
    {
     
        public RaquetZoneUsuarios()
        {
            InitializeComponent();
            MostrarUsuarios();
            
        }

        private void editar_Click(object sender, EventArgs e)
        {
            string dni = listaDatos.CurrentRow.Cells[0].Value.ToString();
            string nom = listaDatos.CurrentRow.Cells[1].Value.ToString();
            string pass = listaDatos.CurrentRow.Cells[2].Value.ToString();
            string rol = listaDatos.CurrentRow.Cells[3].Value.ToString();
            string tel = listaDatos.CurrentRow.Cells[4].Value.ToString();
            string email = listaDatos.CurrentRow.Cells[5].Value.ToString();
            string direcc = listaDatos.CurrentRow.Cells[6].Value.ToString();


            EditarUsuario EU1 = new EditarUsuario(dni, nom, pass, rol, tel, email, direcc);
            EU1.Show();
            this.Hide();
        }

        

        private void RaquetZoneUsuarios_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE); 
            
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "PantallaPrincipalRol2").SingleOrDefault<Form>();
            if (existe != null)

            {
                this.Text = "Listado de Empleados";
                EsconderRol3();

            }

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            String dni = listaDatos.CurrentRow.Cells[0].Value.ToString();
            String rol = listaDatos.CurrentRow.Cells[3].Value.ToString();

            if (MessageBox.Show("¿Quieres eliminar el usuario con DNI " + dni + "?", "Eliminar", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
            

                if( rol == "3")
                {
                    MessageBox.Show("No puedes eliminar un SuperAdmin");
                }
                else
                {
                    String url = "http://localhost:8081/usuario/delete" + dni;

                    funciones.conexion r = new funciones.conexion(url, "DELETE");
                    
                    r.deleteItem(url);

                    MessageBox.Show("Eliminado");
                }
              
                listaDatos.DataSource = funciones.funciones.mostrarUsr();
            }
            else
            {
                MessageBox.Show("La operación se ha detenido, no se ha eliminado al usuario");
            }

        }

        private void MostrarUsuarios()
        {
            listaDatos.DataSource = funciones.funciones.mostrarUsr();
        }

        private void EsconderRol3()
        {
            foreach (DataGridViewRow Row in listaDatos.Rows)
            {
                String strFila = Row.Index.ToString();
                string Valor = Convert.ToString(Row.Cells["rolusr"].Value);

                if (Valor == "3")
                {
                    listaDatos.CurrentCell = null;
                    listaDatos.Rows[Convert.ToInt32(strFila)].Visible = false;
                }
                   
            }
            
        }

        private void buscadorButton_Click(object sender, EventArgs e)
        {
            bool supervisor = false;

            foreach (DataGridViewRow Row in listaDatos.Rows)
            {
                String strFila = Row.Index.ToString();
                string Valor = Convert.ToString(Row.Cells["dniusr"].Value);

                if (Valor == this.buscarDNI.Text)
                {
                    listaDatos.Rows[Convert.ToInt32(strFila)].DefaultCellStyle.BackColor = Color.ForestGreen;
                    listaDatos.CurrentCell = listaDatos[0, Convert.ToInt32(strFila)];
                    supervisor = true;
                }
              
            }

            if(supervisor == false)
            {
                MessageBox.Show("DNI Inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void buttonVolver_Click_1(object sender, EventArgs e)
        {
            GestionUsuarios GU1 = new GestionUsuarios();
            GU1.Show();
            this.Close();
        }
    }
}
