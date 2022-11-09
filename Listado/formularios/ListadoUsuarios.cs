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
            EditarUsuario EU1 = new EditarUsuario();
            EU1.Show();
            this.Hide();
        }

        private void RaquetZoneUsuarios_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            EliminarUsuario EU = new EliminarUsuario();
            EU.Show();
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            listaDatos.DataSource = RaquetZone.funciones.funciones.mostrarUsr();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            GestionUsuarios GU1 = new GestionUsuarios();
            GU1.Show();
            this.Hide();
        }

        private void listaDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
