﻿using System;
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
using System.Configuration;

namespace RaquetZone.formularios.Rol2
{
    public partial class ListadoClientes : MaterialForm
    {
        public ListadoClientes()
        {
            InitializeComponent();
            
        }

        private void ListadoClientes_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);

            MostrarClientes();

            Form existe1 = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "AnyadirCompras").SingleOrDefault<Form>();
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "AnyadirReservas").SingleOrDefault<Form>();
            if (existe != null)

            {
                buttonEliminar.Visible = false;
                buttonEliminar.Enabled = false;
                editarProductos.Visible = false;
                editarProductos.Enabled = false;
                button1.Visible = false;
                button1.Enabled = false;
                emailButton.Visible = false;
                emailButton.Enabled = false;
                anyadirCompra.Visible = false;
                anyadirCompra.Enabled = false;
                bReservas.Visible = true;
                bReservas.Enabled = true;
                verActivos();

            }
            else if (existe1 != null)

            {
                buttonEliminar.Visible = false;
                buttonEliminar.Enabled = false;
                editarProductos.Visible = false;
                editarProductos.Enabled = false;
                button1.Visible = false;
                button1.Enabled = false;
                emailButton.Visible = false;
                emailButton.Enabled = false;
                buttonEliminar.Visible = false;
                buttonEliminar.Enabled = false;
                anyadirCompra.Visible = true;
                anyadirCompra.Enabled = true;
                bReservas.Visible = false;
                bReservas.Enabled = false;
                verActivos();

            }
            else
            {
                anyadirCompra.Visible = false;
                anyadirCompra.Enabled = false;
                bReservas.Visible = false;
                bReservas.Enabled = false;
                verActivos();
            }

        }

        private void editarProductos_Click(object sender, EventArgs e)
        {
            if (listaClientes.CurrentRow != null)
            {

            string dniText = listaClientes.CurrentRow.Cells[0].Value.ToString();
            string nomText = listaClientes.CurrentRow.Cells[1].Value.ToString();
            string passText = listaClientes.CurrentRow.Cells[2].Value.ToString();
            string numText = listaClientes.CurrentRow.Cells[3].Value.ToString();
            string telText = listaClientes.CurrentRow.Cells[4].Value.ToString();
            string emailText = listaClientes.CurrentRow.Cells[5].Value.ToString();
            string activo = listaClientes.CurrentRow.Cells[6].Value.ToString();

            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "EditarClientes").SingleOrDefault<Form>();
            if (existe != null)

            {
                MessageBox.Show("Esa ventana ya está abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                EditarClientes EC = new EditarClientes(dniText, nomText, passText, numText, telText, emailText, activo);
                EC.TextoCIFAnyadir.Text = TextoCIFC.Text;
                EC.Show();
                this.Close();
            }

            }
            else
            {
                MessageBox.Show("Selecciona un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void MostrarClientes()
        {
            if (funciones.funciones.mostrarCliP(TextoCIFC.Text) == null)
            {
                MessageBox.Show("No tienes ningún dato de Clientes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listaClientes.DataSource = funciones.funciones.mostrarCliP(TextoCIFC.Text);

                listaClientes.Columns[2].Visible = false;
            }

            

        }

        private void buscadorButton_Click(object sender, EventArgs e)
        {
            bool supervisorClientes = false;

            foreach (DataGridViewRow Row in listaClientes.Rows)
            {
                String strFila = Row.Index.ToString();
                string Valor = Convert.ToString(Row.Cells["dnicli"].Value);

                if (Valor == this.buscarDNI.Text)
                {
                    listaClientes.Rows[Convert.ToInt32(strFila)].DefaultCellStyle.BackColor = Color.ForestGreen;
                    listaClientes.CurrentCell = listaClientes[0, Convert.ToInt32(strFila)];
                    supervisorClientes = true;
                }
            }

            if (supervisorClientes == false)
            {
                MessageBox.Show("DNI Inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (listaClientes.CurrentRow != null)
            {

                 String dni = listaClientes.CurrentRow.Cells[0].Value.ToString();

                if (MessageBox.Show("¿Quieres eliminar el cliente con DNI " + dni + "?", "Eliminar", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    string dniText = listaClientes.CurrentRow.Cells[0].Value.ToString();
                    string nomText = listaClientes.CurrentRow.Cells[1].Value.ToString();
                    string passText = listaClientes.CurrentRow.Cells[2].Value.ToString();
                    string numText = listaClientes.CurrentRow.Cells[3].Value.ToString();
                    string telText = listaClientes.CurrentRow.Cells[4].Value.ToString();
                    string emailText = listaClientes.CurrentRow.Cells[5].Value.ToString();
                    string activo = listaClientes.CurrentRow.Cells[6].Value.ToString();


                    String url = ConfigurationManager.AppSettings["AccesoBD"] + "cliente/modify/" + dniText;

                    funciones.conexion r = new funciones.conexion(url, "PUT");

                    String datos = @"{
                    " + "\n" +
        @"        ""dnicli"": """ + dniText + "\"," + "\n" +
        @"        ""nombrecli"": """ + nomText + "\"," + "\n" +
        @"        ""passwordcli"": """ + passText + "\"," + "\n" +
        @"        ""numhorascli"": " + Int32.Parse(numText) + "," + "\n" +
        @"        ""telefonocli"": """ + telText + "\"," + "\n" +
        @"        ""emailcli"": """ + emailText + "\"," + "\n" +
        @"        ""activo"": """ + false + "\"" + "\n" +
                    @"    }";

                    r.putItem(url, datos);

                    MessageBox.Show("Eliminado");

                    listaClientes.DataSource = RaquetZone.funciones.funciones.mostrarCliP(TextoCIFC.Text);
                    verActivos();
                }
                else
                {
                    MessageBox.Show("La operación se ha detenido, no se ha eliminado al cliente");
                }
            }
            else
            {
                MessageBox.Show("Selecciona un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void emailButton_Click(object sender, EventArgs e)
        {
            if (listaClientes.CurrentRow != null)
            {
            string emailText = listaClientes.CurrentRow.Cells[5].Value.ToString();

            EmailClientes EC = new EmailClientes(emailText);
            EC.Show();

            }
            else
            {
                MessageBox.Show("Selecciona un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "AnyadirCliente").SingleOrDefault<Form>();
            if (existe != null)

            {
                this.Close();

            }
            else
            {
                AnyadirCliente GC1 = new AnyadirCliente();
                GC1.TextoCIFAnyadir.Text = TextoCIFC.Text;
                GC1.Show();
                this.Close();
            }
        }

        private void bReservas_Click(object sender, EventArgs e)
        {
            if (listaClientes.CurrentRow != null)
            {
                string dni = listaClientes.CurrentRow.Cells[0].Value.ToString();

                AnyadirReservas AR = (AnyadirReservas)Application.OpenForms["AnyadirReservas"];
                if (Application.OpenForms.OfType<AnyadirReservas>().Any())
                {
                    AR.conseguirDNI(dni);
                }

                this.Close();

            }
            else
            {
                MessageBox.Show("Selecciona un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void anyadirCompra_Click(object sender, EventArgs e)
        {
            if (listaClientes.CurrentRow != null)
            {

            string dni = listaClientes.CurrentRow.Cells[0].Value.ToString();

            AnyadirCompras AR = (AnyadirCompras)Application.OpenForms["AnyadirCompras"];
            if (Application.OpenForms.OfType<AnyadirCompras>().Any())
            {
                AR.conseguirDNI(dni);
            }

            this.Close();
            }
            else
            {
                MessageBox.Show("Selecciona un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        public void verActivos()
        {
            listaClientes.ClearSelection();

            if (radioActivos.Checked == true)
            {


                foreach (DataGridViewRow row in listaClientes.Rows)
                {

                    string codigo = Convert.ToString(row.Cells["activo"].Value);

                    if (codigo.Equals("false"))
                    {

                        listaClientes.CurrentCell = null;
                        row.Visible = false;

                        if (listaClientes.CurrentRow != null)
                        {

                            int fila = listaClientes.CurrentRow.Index;

                            listaClientes.CurrentCell = null;

                            row.Visible = false;
                        }
                    }
                    else
                    {
                        row.Visible = true;
                    }

                }
            }
        }

        public void verInactivos()
        {
            foreach (DataGridViewRow row in listaClientes.Rows)
            {

                string codigo = Convert.ToString(row.Cells["activo"].Value);

                if (codigo.Equals("true"))
                {

                    listaClientes.CurrentCell = null;
                    row.Visible = false;

                    if (listaClientes.CurrentRow != null)
                    {

                        int fila = listaClientes.CurrentRow.Index;

                        listaClientes.CurrentCell = null;

                        row.Visible = false;
                    }
                }
                else
                {
                    row.Visible = true;
                }
            }
        }

        private void botonInactivo_Click(object sender, EventArgs e)
        {
            if (radioActivos.Checked == true)
            {
                verActivos();
            }
            else
            {
                verInactivos();
            }
        }

        private void limpiarB_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Row in listaClientes.Rows)
            {
                String strFila = Row.Index.ToString();
                listaClientes.Rows[Convert.ToInt32(strFila)].DefaultCellStyle.BackColor = Color.White;
            }
        }
    }
}
