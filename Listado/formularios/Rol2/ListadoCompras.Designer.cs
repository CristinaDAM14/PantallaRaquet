
namespace RaquetZone.formularios.Rol2
{
    partial class ListadoCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoCompras));
            this.buttonVolver = new MaterialSkin.Controls.MaterialRaisedButton();
            this.listaCompras = new System.Windows.Forms.DataGridView();
            this.buttonFactura = new MaterialSkin.Controls.MaterialRaisedButton();
            this.radioFecha = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioID = new MaterialSkin.Controls.MaterialRadioButton();
            this.labelOrdenar = new MaterialSkin.Controls.MaterialLabel();
            this.buttonEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.editarCompras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVolver
            // 
            this.buttonVolver.Depth = 0;
            this.buttonVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolver.Location = new System.Drawing.Point(15, 555);
            this.buttonVolver.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Primary = true;
            this.buttonVolver.Size = new System.Drawing.Size(73, 39);
            this.buttonVolver.TabIndex = 52;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // listaCompras
            // 
            this.listaCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaCompras.Location = new System.Drawing.Point(51, 140);
            this.listaCompras.Name = "listaCompras";
            this.listaCompras.Size = new System.Drawing.Size(917, 362);
            this.listaCompras.TabIndex = 51;
            // 
            // buttonFactura
            // 
            this.buttonFactura.Depth = 0;
            this.buttonFactura.Location = new System.Drawing.Point(577, 530);
            this.buttonFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonFactura.Name = "buttonFactura";
            this.buttonFactura.Primary = true;
            this.buttonFactura.Size = new System.Drawing.Size(157, 64);
            this.buttonFactura.TabIndex = 53;
            this.buttonFactura.Text = "Crear Factura";
            this.buttonFactura.UseVisualStyleBackColor = true;
            this.buttonFactura.Click += new System.EventHandler(this.buttonFactura_Click);
            // 
            // radioFecha
            // 
            this.radioFecha.Depth = 0;
            this.radioFecha.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioFecha.Location = new System.Drawing.Point(893, 111);
            this.radioFecha.Margin = new System.Windows.Forms.Padding(0);
            this.radioFecha.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioFecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioFecha.Name = "radioFecha";
            this.radioFecha.Ripple = true;
            this.radioFecha.Size = new System.Drawing.Size(75, 26);
            this.radioFecha.TabIndex = 54;
            this.radioFecha.TabStop = true;
            this.radioFecha.Text = "Fecha";
            this.radioFecha.UseVisualStyleBackColor = true;
            // 
            // radioID
            // 
            this.radioID.Depth = 0;
            this.radioID.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioID.Location = new System.Drawing.Point(818, 111);
            this.radioID.Margin = new System.Windows.Forms.Padding(0);
            this.radioID.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioID.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioID.Name = "radioID";
            this.radioID.Ripple = true;
            this.radioID.Size = new System.Drawing.Size(75, 26);
            this.radioID.TabIndex = 55;
            this.radioID.Text = "ID";
            this.radioID.UseVisualStyleBackColor = true;
            // 
            // labelOrdenar
            // 
            this.labelOrdenar.AutoSize = true;
            this.labelOrdenar.Depth = 0;
            this.labelOrdenar.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelOrdenar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelOrdenar.Location = new System.Drawing.Point(724, 114);
            this.labelOrdenar.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelOrdenar.Name = "labelOrdenar";
            this.labelOrdenar.Size = new System.Drawing.Size(91, 19);
            this.labelOrdenar.TabIndex = 56;
            this.labelOrdenar.Text = "Ordenar por:";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Depth = 0;
            this.buttonEliminar.Location = new System.Drawing.Point(342, 530);
            this.buttonEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Primary = true;
            this.buttonEliminar.Size = new System.Drawing.Size(157, 64);
            this.buttonEliminar.TabIndex = 57;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // editarCompras
            // 
            this.editarCompras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editarCompras.BackgroundImage")));
            this.editarCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editarCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarCompras.Location = new System.Drawing.Point(986, 149);
            this.editarCompras.Name = "editarCompras";
            this.editarCompras.Size = new System.Drawing.Size(39, 34);
            this.editarCompras.TabIndex = 58;
            this.editarCompras.UseVisualStyleBackColor = true;
            this.editarCompras.Click += new System.EventHandler(this.editarCompras_Click);
            // 
            // ListadoCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 610);
            this.Controls.Add(this.editarCompras);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.labelOrdenar);
            this.Controls.Add(this.radioID);
            this.Controls.Add(this.radioFecha);
            this.Controls.Add(this.buttonFactura);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.listaCompras);
            this.Name = "ListadoCompras";
            this.Text = "Listado de Compras";
            this.Load += new System.EventHandler(this.ListadoCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton buttonVolver;
        public System.Windows.Forms.DataGridView listaCompras;
        private MaterialSkin.Controls.MaterialRaisedButton buttonFactura;
        private MaterialSkin.Controls.MaterialRadioButton radioFecha;
        private MaterialSkin.Controls.MaterialRadioButton radioID;
        private MaterialSkin.Controls.MaterialLabel labelOrdenar;
        private MaterialSkin.Controls.MaterialRaisedButton buttonEliminar;
        private System.Windows.Forms.Button editarCompras;
    }
}