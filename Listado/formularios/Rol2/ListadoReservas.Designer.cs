
namespace RaquetZone.formularios.Rol2
{
    partial class ListadoReservas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoReservas));
            this.buscadorButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buscarFecha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.listaReservas = new System.Windows.Forms.DataGridView();
            this.radioPista = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioFecha = new MaterialSkin.Controls.MaterialRadioButton();
            this.Anyadir = new System.Windows.Forms.Button();
            this.bVolver = new System.Windows.Forms.Button();
            this.editarReservas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // buscadorButton
            // 
            this.buscadorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscadorButton.Depth = 0;
            this.buscadorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscadorButton.Location = new System.Drawing.Point(230, 111);
            this.buscadorButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.buscadorButton.Name = "buscadorButton";
            this.buscadorButton.Primary = true;
            this.buscadorButton.Size = new System.Drawing.Size(61, 23);
            this.buscadorButton.TabIndex = 65;
            this.buscadorButton.Text = "Buscar";
            this.buscadorButton.UseVisualStyleBackColor = true;
            this.buscadorButton.Click += new System.EventHandler(this.buscadorButton_Click);
            // 
            // buscarFecha
            // 
            this.buscarFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarFecha.Depth = 0;
            this.buscarFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarFecha.Hint = "Escribe la Pista";
            this.buscarFecha.Location = new System.Drawing.Point(44, 111);
            this.buscarFecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.buscarFecha.Name = "buscarFecha";
            this.buscarFecha.PasswordChar = '\0';
            this.buscarFecha.SelectedText = "";
            this.buscarFecha.SelectionLength = 0;
            this.buscarFecha.SelectionStart = 0;
            this.buscarFecha.Size = new System.Drawing.Size(166, 23);
            this.buscarFecha.TabIndex = 64;
            this.buscarFecha.UseSystemPasswordChar = false;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEliminar.Depth = 0;
            this.buttonEliminar.Location = new System.Drawing.Point(469, 526);
            this.buttonEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Primary = true;
            this.buttonEliminar.Size = new System.Drawing.Size(157, 64);
            this.buttonEliminar.TabIndex = 68;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // listaReservas
            // 
            this.listaReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaReservas.Location = new System.Drawing.Point(44, 149);
            this.listaReservas.Name = "listaReservas";
            this.listaReservas.Size = new System.Drawing.Size(945, 360);
            this.listaReservas.TabIndex = 66;
            // 
            // radioPista
            // 
            this.radioPista.Checked = true;
            this.radioPista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioPista.Depth = 0;
            this.radioPista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioPista.Location = new System.Drawing.Point(309, 111);
            this.radioPista.Margin = new System.Windows.Forms.Padding(0);
            this.radioPista.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioPista.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioPista.Name = "radioPista";
            this.radioPista.Ripple = true;
            this.radioPista.Size = new System.Drawing.Size(75, 26);
            this.radioPista.TabIndex = 75;
            this.radioPista.TabStop = true;
            this.radioPista.Text = "Pista";
            this.radioPista.UseVisualStyleBackColor = true;
            // 
            // radioFecha
            // 
            this.radioFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioFecha.Depth = 0;
            this.radioFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioFecha.Location = new System.Drawing.Point(384, 111);
            this.radioFecha.Margin = new System.Windows.Forms.Padding(0);
            this.radioFecha.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioFecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioFecha.Name = "radioFecha";
            this.radioFecha.Ripple = true;
            this.radioFecha.Size = new System.Drawing.Size(75, 26);
            this.radioFecha.TabIndex = 74;
            this.radioFecha.Text = "Fecha";
            this.radioFecha.UseVisualStyleBackColor = true;
            // 
            // Anyadir
            // 
            this.Anyadir.BackgroundImage = global::Listado.Properties.Resources.BAnyadir;
            this.Anyadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Anyadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Anyadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Anyadir.Location = new System.Drawing.Point(995, 189);
            this.Anyadir.Name = "Anyadir";
            this.Anyadir.Size = new System.Drawing.Size(39, 34);
            this.Anyadir.TabIndex = 70;
            this.Anyadir.UseVisualStyleBackColor = true;
            // 
            // bVolver
            // 
            this.bVolver.BackColor = System.Drawing.Color.Transparent;
            this.bVolver.BackgroundImage = global::Listado.Properties.Resources.icono_volver;
            this.bVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bVolver.FlatAppearance.BorderSize = 0;
            this.bVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVolver.Location = new System.Drawing.Point(12, 558);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(45, 40);
            this.bVolver.TabIndex = 69;
            this.bVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // editarReservas
            // 
            this.editarReservas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editarReservas.BackgroundImage")));
            this.editarReservas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editarReservas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editarReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarReservas.Location = new System.Drawing.Point(995, 149);
            this.editarReservas.Name = "editarReservas";
            this.editarReservas.Size = new System.Drawing.Size(39, 34);
            this.editarReservas.TabIndex = 67;
            this.editarReservas.UseVisualStyleBackColor = true;
            // 
            // ListadoReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 610);
            this.Controls.Add(this.radioPista);
            this.Controls.Add(this.radioFecha);
            this.Controls.Add(this.Anyadir);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.buscadorButton);
            this.Controls.Add(this.buscarFecha);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.editarReservas);
            this.Controls.Add(this.listaReservas);
            this.Name = "ListadoReservas";
            this.Text = "Listado de Reservas";
            this.Load += new System.EventHandler(this.ListadoReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaReservas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Anyadir;
        private System.Windows.Forms.Button bVolver;
        private MaterialSkin.Controls.MaterialRaisedButton buscadorButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField buscarFecha;
        private MaterialSkin.Controls.MaterialRaisedButton buttonEliminar;
        private System.Windows.Forms.Button editarReservas;
        private System.Windows.Forms.DataGridView listaReservas;
        private MaterialSkin.Controls.MaterialRadioButton radioPista;
        private MaterialSkin.Controls.MaterialRadioButton radioFecha;
    }
}