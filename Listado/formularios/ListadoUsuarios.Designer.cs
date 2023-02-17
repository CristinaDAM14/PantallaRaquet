
namespace RaquetZone.formularios
{
    partial class RaquetZoneUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaquetZoneUsuarios));
            this.listaDatos = new System.Windows.Forms.DataGridView();
            this.buttonEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.editar = new System.Windows.Forms.Button();
            this.buscadorButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buscarDNI = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.anyadir = new System.Windows.Forms.Button();
            this.TextoCIFC = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.bvacaciones = new System.Windows.Forms.Button();
            this.bReservas = new MaterialSkin.Controls.MaterialRaisedButton();
            this.radioActivos = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioInactivos = new MaterialSkin.Controls.MaterialRadioButton();
            this.botonInactivo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.limpiarB = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.listaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // listaDatos
            // 
            this.listaDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaDatos.Location = new System.Drawing.Point(50, 145);
            this.listaDatos.Name = "listaDatos";
            this.listaDatos.RowTemplate.ReadOnly = true;
            this.listaDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaDatos.Size = new System.Drawing.Size(943, 360);
            this.listaDatos.TabIndex = 0;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEliminar.Depth = 0;
            this.buttonEliminar.Location = new System.Drawing.Point(465, 523);
            this.buttonEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Primary = true;
            this.buttonEliminar.Size = new System.Drawing.Size(157, 64);
            this.buttonEliminar.TabIndex = 39;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // editar
            // 
            this.editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editar.BackgroundImage")));
            this.editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editar.Location = new System.Drawing.Point(999, 145);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(39, 34);
            this.editar.TabIndex = 2;
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // buscadorButton
            // 
            this.buscadorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscadorButton.Depth = 0;
            this.buscadorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscadorButton.Location = new System.Drawing.Point(222, 96);
            this.buscadorButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.buscadorButton.Name = "buscadorButton";
            this.buscadorButton.Primary = true;
            this.buscadorButton.Size = new System.Drawing.Size(61, 23);
            this.buscadorButton.TabIndex = 2;
            this.buscadorButton.Text = "Buscar";
            this.buscadorButton.UseVisualStyleBackColor = true;
            this.buscadorButton.Click += new System.EventHandler(this.buscadorButton_Click);
            // 
            // buscarDNI
            // 
            this.buscarDNI.Depth = 0;
            this.buscarDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarDNI.Hint = " DNI";
            this.buscarDNI.Location = new System.Drawing.Point(50, 96);
            this.buscarDNI.MouseState = MaterialSkin.MouseState.HOVER;
            this.buscarDNI.Name = "buscarDNI";
            this.buscarDNI.PasswordChar = '\0';
            this.buscarDNI.SelectedText = "";
            this.buscarDNI.SelectionLength = 0;
            this.buscarDNI.SelectionStart = 0;
            this.buscarDNI.Size = new System.Drawing.Size(166, 23);
            this.buscarDNI.TabIndex = 1;
            this.buscarDNI.UseSystemPasswordChar = false;
            // 
            // buttonVolver
            // 
            this.buttonVolver.BackColor = System.Drawing.Color.Transparent;
            this.buttonVolver.BackgroundImage = global::Listado.Properties.Resources.icono_volver;
            this.buttonVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVolver.FlatAppearance.BorderSize = 0;
            this.buttonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVolver.Location = new System.Drawing.Point(12, 558);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(45, 40);
            this.buttonVolver.TabIndex = 58;
            this.buttonVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click_1);
            // 
            // anyadir
            // 
            this.anyadir.BackgroundImage = global::Listado.Properties.Resources.BAnyadir;
            this.anyadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.anyadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anyadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anyadir.Location = new System.Drawing.Point(999, 185);
            this.anyadir.Name = "anyadir";
            this.anyadir.Size = new System.Drawing.Size(39, 34);
            this.anyadir.TabIndex = 60;
            this.anyadir.UseVisualStyleBackColor = true;
            this.anyadir.Click += new System.EventHandler(this.anyadir_Click);
            // 
            // TextoCIFC
            // 
            this.TextoCIFC.Depth = 0;
            this.TextoCIFC.Enabled = false;
            this.TextoCIFC.Hint = "";
            this.TextoCIFC.Location = new System.Drawing.Point(176, 96);
            this.TextoCIFC.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextoCIFC.Name = "TextoCIFC";
            this.TextoCIFC.PasswordChar = '\0';
            this.TextoCIFC.SelectedText = "";
            this.TextoCIFC.SelectionLength = 0;
            this.TextoCIFC.SelectionStart = 0;
            this.TextoCIFC.Size = new System.Drawing.Size(40, 23);
            this.TextoCIFC.TabIndex = 71;
            this.TextoCIFC.UseSystemPasswordChar = false;
            this.TextoCIFC.Visible = false;
            // 
            // bvacaciones
            // 
            this.bvacaciones.BackgroundImage = global::Listado.Properties.Resources.calendario;
            this.bvacaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bvacaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bvacaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bvacaciones.Location = new System.Drawing.Point(999, 225);
            this.bvacaciones.Name = "bvacaciones";
            this.bvacaciones.Size = new System.Drawing.Size(39, 34);
            this.bvacaciones.TabIndex = 72;
            this.bvacaciones.UseVisualStyleBackColor = true;
            this.bvacaciones.Click += new System.EventHandler(this.bvacaciones_Click);
            // 
            // bReservas
            // 
            this.bReservas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bReservas.Depth = 0;
            this.bReservas.Location = new System.Drawing.Point(465, 523);
            this.bReservas.MouseState = MaterialSkin.MouseState.HOVER;
            this.bReservas.Name = "bReservas";
            this.bReservas.Primary = true;
            this.bReservas.Size = new System.Drawing.Size(157, 64);
            this.bReservas.TabIndex = 73;
            this.bReservas.Text = "Añadir a Reservas";
            this.bReservas.UseVisualStyleBackColor = true;
            this.bReservas.Click += new System.EventHandler(this.bReservas_Click);
            // 
            // radioActivos
            // 
            this.radioActivos.Checked = true;
            this.radioActivos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioActivos.Depth = 0;
            this.radioActivos.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioActivos.Location = new System.Drawing.Point(811, 113);
            this.radioActivos.Margin = new System.Windows.Forms.Padding(0);
            this.radioActivos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioActivos.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioActivos.Name = "radioActivos";
            this.radioActivos.Ripple = true;
            this.radioActivos.Size = new System.Drawing.Size(89, 26);
            this.radioActivos.TabIndex = 77;
            this.radioActivos.TabStop = true;
            this.radioActivos.Text = "Activos";
            this.radioActivos.UseVisualStyleBackColor = true;
            // 
            // radioInactivos
            // 
            this.radioInactivos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioInactivos.Depth = 0;
            this.radioInactivos.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioInactivos.Location = new System.Drawing.Point(900, 113);
            this.radioInactivos.Margin = new System.Windows.Forms.Padding(0);
            this.radioInactivos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioInactivos.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioInactivos.Name = "radioInactivos";
            this.radioInactivos.Ripple = true;
            this.radioInactivos.Size = new System.Drawing.Size(93, 26);
            this.radioInactivos.TabIndex = 76;
            this.radioInactivos.Text = "Inactivos";
            this.radioInactivos.UseVisualStyleBackColor = true;
            // 
            // botonInactivo
            // 
            this.botonInactivo.Depth = 0;
            this.botonInactivo.Location = new System.Drawing.Point(716, 116);
            this.botonInactivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.botonInactivo.Name = "botonInactivo";
            this.botonInactivo.Primary = true;
            this.botonInactivo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.botonInactivo.Size = new System.Drawing.Size(92, 23);
            this.botonInactivo.TabIndex = 78;
            this.botonInactivo.Text = "Actualizar";
            this.botonInactivo.UseVisualStyleBackColor = true;
            this.botonInactivo.Click += new System.EventHandler(this.botonInactivo_Click);
            // 
            // limpiarB
            // 
            this.limpiarB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.limpiarB.Depth = 0;
            this.limpiarB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiarB.Location = new System.Drawing.Point(289, 96);
            this.limpiarB.MouseState = MaterialSkin.MouseState.HOVER;
            this.limpiarB.Name = "limpiarB";
            this.limpiarB.Primary = true;
            this.limpiarB.Size = new System.Drawing.Size(61, 23);
            this.limpiarB.TabIndex = 79;
            this.limpiarB.Text = "Limpiar";
            this.limpiarB.UseVisualStyleBackColor = true;
            this.limpiarB.Click += new System.EventHandler(this.limpiarB_Click);
            // 
            // RaquetZoneUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 610);
            this.Controls.Add(this.limpiarB);
            this.Controls.Add(this.botonInactivo);
            this.Controls.Add(this.radioActivos);
            this.Controls.Add(this.radioInactivos);
            this.Controls.Add(this.bReservas);
            this.Controls.Add(this.bvacaciones);
            this.Controls.Add(this.TextoCIFC);
            this.Controls.Add(this.anyadir);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buscadorButton);
            this.Controls.Add(this.buscarDNI);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.listaDatos);
            this.MaximizeBox = false;
            this.Name = "RaquetZoneUsuarios";
            this.Text = "Listado de Usuarios";
            this.Load += new System.EventHandler(this.RaquetZoneUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listaDatos;
        private System.Windows.Forms.Button editar;
        private MaterialSkin.Controls.MaterialRaisedButton buttonEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton buscadorButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField buscarDNI;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button anyadir;
        public MaterialSkin.Controls.MaterialSingleLineTextField TextoCIFC;
        private System.Windows.Forms.Button bvacaciones;
        private MaterialSkin.Controls.MaterialRaisedButton bReservas;
        private MaterialSkin.Controls.MaterialRadioButton radioActivos;
        private MaterialSkin.Controls.MaterialRadioButton radioInactivos;
        private MaterialSkin.Controls.MaterialRaisedButton botonInactivo;
        private MaterialSkin.Controls.MaterialRaisedButton limpiarB;
    }
}