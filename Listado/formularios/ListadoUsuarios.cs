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


            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "EditarUsuario").SingleOrDefault<Form>();
            if (existe != null)

            {
                MessageBox.Show("Esa ventana ya está abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                EditarUsuario EU1 = new EditarUsuario(dni, nom, pass, rol, tel, email, direcc);
                EU1.TextoCIFAnyadir.Text = TextoCIFC.Text;
                EU1.Show();
                this.Close();
            }
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
                MostrarUsuariosP();
                bvacaciones.Visible = true;
                bvacaciones.Enabled = true;

            }
            else
            {
                MostrarUsuarios();
                bvacaciones.Visible = false;
                bvacaciones.Enabled = false;
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
                    String url = "http://localhost:8081/usuario/delete/" + dni;

                    funciones.conexion r = new funciones.conexion(url, "DELETE");
                    
                    r.deleteItem(url);

                    MessageBox.Show("Eliminado");
                }

                Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "PantallaPrincipalRol2").SingleOrDefault<Form>();
                if (existe != null)

                {
                    this.Text = "Listado de Empleados";
                    MostrarUsuariosP();
                    

                }
                else
                {
                    MostrarUsuarios();
                }
            }
            else
            {
                MessageBox.Show("La operación se ha detenido, no se ha eliminado al usuario");
            }

        }

        private void MostrarUsuarios()
        {
            if (funciones.funciones.mostrarUsr() == null)
            {
                MessageBox.Show("No tienes ningún dato de Usuarios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listaDatos.DataSource = funciones.funciones.mostrarUsr();

                listaDatos.Columns[2].Visible = false;
            }

        }

        private void MostrarUsuariosP()
        {

            if (funciones.funciones.mostrarUsrP(TextoCIFC.Text) == null)
            {
                MessageBox.Show("No tienes ningún dato de Empleados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listaDatos.DataSource = funciones.funciones.mostrarUsrP(TextoCIFC.Text);

                listaDatos.Columns[2].Visible = false;
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
            this.Close();
        }

        private void anyadir_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "AnyadirUsuario").SingleOrDefault<Form>();
            if (existe != null)

            {
                this.Close();

            }
            else
            {
                AnyadirUsuario GU2 = new AnyadirUsuario();
                GU2.TextoCIFAnyadir.Text = TextoCIFC.Text;
                GU2.Show();
                this.Close();
            }
        }


        private void bvacaciones_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "CalendarioHorario").SingleOrDefault<Form>();
            if (existe != null)

            {
                this.Close();

            }
            else
            {
                List<string> dniUser = listaDatos.Rows.Cast<DataGridViewRow>().Select(r => Convert.ToString(r.Cells["dniusr"].Value)).ToArray().ToList();

                Rol2.CalendarioHorario CH = new Rol2.CalendarioHorario();
                
                for (int i = 0; i < dniUser.Count; i++)
                {
                    CH.boxEmpleados.Items.Add(dniUser[i]);
                }

                CH.TextoCIFAnyadir.Text = TextoCIFC.Text;
                CH.Show();
                this.Close();
            }
        }
    }
}
