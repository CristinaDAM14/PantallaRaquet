
namespace RaquetZone.formularios.Rol2
{
    partial class ListadoServicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoServicios));
            this.buscadorButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buscarNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ListaServicios = new System.Windows.Forms.DataGridView();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.Anyadir = new System.Windows.Forms.Button();
            this.bReservas = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TextoCIFP = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.ListaServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // buscadorButton
            // 
            this.buscadorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscadorButton.Depth = 0;
            this.buscadorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscadorButton.Location = new System.Drawing.Point(232, 86);
            this.buscadorButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.buscadorButton.Name = "buscadorButton";
            this.buscadorButton.Primary = true;
            this.buscadorButton.Size = new System.Drawing.Size(61, 23);
            this.buscadorButton.TabIndex = 61;
            this.buscadorButton.Text = "Buscar";
            this.buscadorButton.UseVisualStyleBackColor = true;
            this.buscadorButton.Click += new System.EventHandler(this.buscadorButton_Click);
            // 
            // buscarNombre
            // 
            this.buscarNombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarNombre.Depth = 0;
            this.buscarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarNombre.Hint = " Nombre";
            this.buscarNombre.Location = new System.Drawing.Point(46, 86);
            this.buscarNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.buscarNombre.Name = "buscarNombre";
            this.buscarNombre.PasswordChar = '\0';
            this.buscarNombre.SelectedText = "";
            this.buscarNombre.SelectionLength = 0;
            this.buscarNombre.SelectionStart = 0;
            this.buscarNombre.Size = new System.Drawing.Size(166, 23);
            this.buscarNombre.TabIndex = 60;
            this.buscarNombre.UseSystemPasswordChar = false;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEliminar.Depth = 0;
            this.buttonEliminar.Location = new System.Drawing.Point(456, 493);
            this.buttonEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Primary = true;
            this.buttonEliminar.Size = new System.Drawing.Size(157, 64);
            this.buttonEliminar.TabIndex = 63;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // ListaServicios
            // 
            this.ListaServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListaServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaServicios.Location = new System.Drawing.Point(41, 127);
            this.ListaServicios.Name = "ListaServicios";
            this.ListaServicios.RowTemplate.ReadOnly = true;
            this.ListaServicios.Size = new System.Drawing.Size(943, 360);
            this.ListaServicios.TabIndex = 59;
            // 
            // buttonVolver
            // 
            this.buttonVolver.BackColor = System.Drawing.Color.Transparent;
            this.buttonVolver.BackgroundImage = global::Listado.Properties.Resources.icono_volver;
            this.buttonVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVolver.FlatAppearance.BorderSize = 0;
            this.buttonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVolver.Location = new System.Drawing.Point(12, 519);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(45, 40);
            this.buttonVolver.TabIndex = 64;
            this.buttonVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // editar
            // 
            this.editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editar.BackgroundImage")));
            this.editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editar.Location = new System.Drawing.Point(990, 127);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(39, 34);
            this.editar.TabIndex = 62;
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // Anyadir
            // 
            this.Anyadir.BackgroundImage = global::Listado.Properties.Resources.BAnyadir;
            this.Anyadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Anyadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Anyadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Anyadir.Location = new System.Drawing.Point(990, 167);
            this.Anyadir.Name = "Anyadir";
            this.Anyadir.Size = new System.Drawing.Size(39, 34);
            this.Anyadir.TabIndex = 65;
            this.Anyadir.UseVisualStyleBackColor = true;
            this.Anyadir.Click += new System.EventHandler(this.Anyadir_Click);
            // 
            // bReservas
            // 
            this.bReservas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bReservas.Depth = 0;
            this.bReservas.Location = new System.Drawing.Point(456, 493);
            this.bReservas.MouseState = MaterialSkin.MouseState.HOVER;
            this.bReservas.Name = "bReservas";
            this.bReservas.Primary = true;
            this.bReservas.Size = new System.Drawing.Size(157, 64);
            this.bReservas.TabIndex = 68;
            this.bReservas.Text = "Añadir a la Reserva";
            this.bReservas.UseVisualStyleBackColor = true;
            this.bReservas.Click += new System.EventHandler(this.bReservas_Click);
            // 
            // TextoCIFP
            // 
            this.TextoCIFP.Depth = 0;
            this.TextoCIFP.Enabled = false;
            this.TextoCIFP.Hint = "";
            this.TextoCIFP.Location = new System.Drawing.Point(165, 86);
            this.TextoCIFP.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextoCIFP.Name = "TextoCIFP";
            this.TextoCIFP.PasswordChar = '\0';
            this.TextoCIFP.SelectedText = "";
            this.TextoCIFP.SelectionLength = 0;
            this.TextoCIFP.SelectionStart = 0;
            this.TextoCIFP.Size = new System.Drawing.Size(31, 23);
            this.TextoCIFP.TabIndex = 71;
            this.TextoCIFP.UseSystemPasswordChar = false;
            this.TextoCIFP.Visible = false;
            // 
            // ListadoServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 571);
            this.Controls.Add(this.TextoCIFP);
            this.Controls.Add(this.bReservas);
            this.Controls.Add(this.Anyadir);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buscadorButton);
            this.Controls.Add(this.buscarNombre);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.ListaServicios);
            this.Name = "ListadoServicios";
            this.Text = "Listado de Servicios";
            this.Load += new System.EventHandler(this.ListadoServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListaServicios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVolver;
        private MaterialSkin.Controls.MaterialRaisedButton buscadorButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField buscarNombre;
        private MaterialSkin.Controls.MaterialRaisedButton buttonEliminar;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.DataGridView ListaServicios;
        private System.Windows.Forms.Button Anyadir;
        private MaterialSkin.Controls.MaterialRaisedButton bReservas;
        public MaterialSkin.Controls.MaterialSingleLineTextField TextoCIFP;
    }
}