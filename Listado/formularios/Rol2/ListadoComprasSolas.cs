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

namespace RaquetZone.formularios.Rol2
{
    public partial class ListadoComprasSolas : MaterialForm
    {
        public ListadoComprasSolas()
        {
            InitializeComponent();
        }

        private void ListadoComprasSolas_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);

            MostrarCompras();

            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "AnyadirComprasProd").SingleOrDefault<Form>();
            if (existe != null)

            {
                buttonEliminar.Visible = false;
                buttonEliminar.Enabled = false;
                editarCompras.Visible = false;
                editarCompras.Enabled = false;
                button1.Visible = false;
                button1.Enabled = false;
                butonAnyadir2.Visible = true;
                butonAnyadir2.Enabled = true;

            }
            else
            {
                buttonEliminar.Visible = true;
                buttonEliminar.Enabled = true;
                editarCompras.Visible = true;
                editarCompras.Enabled = true;
                button1.Visible = true;
                button1.Enabled = true;
                butonAnyadir2.Visible = false;
                butonAnyadir2.Enabled = false;
            }
        }

        private void MostrarCompras()
        {
            if (funciones.funciones.mostrarComp() == null)
            {
                MessageBox.Show("No tienes ningún dato de Compras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listaCompras.DataSource = RaquetZone.funciones.funciones.mostrarComp();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "AnyadirCompras").SingleOrDefault<Form>();
            if (existe != null)

            {
                this.Close();

            }
            else
            {
                AnyadirCompras P23 = new AnyadirCompras();
                P23.Show();
                this.Close();
            }
        }

        private void editarCompras_Click(object sender, EventArgs e)
        {
            string id = listaCompras.CurrentRow.Cells[0].Value.ToString();
            string fecha = listaCompras.CurrentRow.Cells[1].Value.ToString();
            string hora;

            if (listaCompras.CurrentRow.Cells[2].Value == null)
            {
                hora = "0";
            }
            else
            {
                hora = listaCompras.CurrentRow.Cells[2].Value.ToString();
            }



            EditarCompras EC = new EditarCompras(id, fecha, hora);
            EC.Show();
            this.Close();
        }

        private void buscadorButton_Click(object sender, EventArgs e)
        {
            bool supervisorClientes = false;

            foreach (DataGridViewRow Row in listaCompras.Rows)
            {
                String strFila = Row.Index.ToString();
                string Valor = Convert.ToString(Row.Cells["idcomp"].Value);

                if (Valor == this.buscarID.Text)
                {
                    listaCompras.Rows[Convert.ToInt32(strFila)].DefaultCellStyle.BackColor = Color.ForestGreen;
                    listaCompras.CurrentCell = listaCompras[0, Convert.ToInt32(strFila)];
                    supervisorClientes = true;
                }
            }

            if (supervisorClientes == false)
            {
                MessageBox.Show("ID Inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarComprasPorFecha()
        {
            listaCompras.DataSource = RaquetZone.funciones.funciones.mostrarCompFecha();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            String id = listaCompras.CurrentRow.Cells[0].Value.ToString();

            if (MessageBox.Show("¿Quieres eliminar la compra con ID " + id + "?", "Eliminar", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {


                String url = "http://localhost:8081/compra/delete/" + id;

                funciones.conexion r = new funciones.conexion(url, "DELETE");

                r.deleteItem(url);

                MessageBox.Show("Eliminado");

                if (radioID.Checked == true)
                {
                    radioFecha.Checked = false;
                    MostrarCompras();
                }
                else if (radioFecha.Checked == true)
                {
                    radioID.Checked = false;
                    MostrarComprasPorFecha();
                }
                else
                {
                    MostrarCompras();
                }
            }
            else
            {
                MessageBox.Show("La operación se ha detenido, no se ha eliminado la compra");
            }
        }

        private void facturaB_Click(object sender, EventArgs e)
        {

            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "ListadoCompras").SingleOrDefault<Form>();
            if (existe != null)

            {
                this.Close();

            }
            else
            {
               ListadoCompras LC = new ListadoCompras();
            LC.Show();
            this.Close();
            }
            
        }
    }
}
