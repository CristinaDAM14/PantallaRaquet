
namespace RaquetZone.formularios.Rol2
{
    partial class ListadoComprasSolas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoComprasSolas));
            this.buscadorButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buscarID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.listaCompras = new System.Windows.Forms.DataGridView();
            this.bVolver = new System.Windows.Forms.Button();
            this.editarCompras = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelOrdenar = new MaterialSkin.Controls.MaterialLabel();
            this.radioID = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioFecha = new MaterialSkin.Controls.MaterialRadioButton();
            this.facturaB = new System.Windows.Forms.Button();
            this.TextoCIFP = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.AnyadirCompra = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.listaCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // buscadorButton
            // 
            this.buscadorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscadorButton.Depth = 0;
            this.buscadorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscadorButton.Location = new System.Drawing.Point(233, 105);
            this.buscadorButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.buscadorButton.Name = "buscadorButton";
            this.buscadorButton.Primary = true;
            this.buscadorButton.Size = new System.Drawing.Size(61, 23);
            this.buscadorButton.TabIndex = 66;
            this.buscadorButton.Text = "Buscar";
            this.buscadorButton.UseVisualStyleBackColor = true;
            this.buscadorButton.Click += new System.EventHandler(this.buscadorButton_Click);
            // 
            // buscarID
            // 
            this.buscarID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarID.Depth = 0;
            this.buscarID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarID.Hint = "ID";
            this.buscarID.Location = new System.Drawing.Point(47, 105);
            this.buscarID.MouseState = MaterialSkin.MouseState.HOVER;
            this.buscarID.Name = "buscarID";
            this.buscarID.PasswordChar = '\0';
            this.buscarID.SelectedText = "";
            this.buscarID.SelectionLength = 0;
            this.buscarID.SelectionStart = 0;
            this.buscarID.Size = new System.Drawing.Size(166, 23);
            this.buscarID.TabIndex = 65;
            this.buscarID.UseSystemPasswordChar = false;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEliminar.Depth = 0;
            this.buttonEliminar.Location = new System.Drawing.Point(422, 521);
            this.buttonEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Primary = true;
            this.buttonEliminar.Size = new System.Drawing.Size(157, 64);
            this.buttonEliminar.TabIndex = 69;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // listaCompras
            // 
            this.listaCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaCompras.Location = new System.Drawing.Point(47, 144);
            this.listaCompras.Name = "listaCompras";
            this.listaCompras.RowTemplate.ReadOnly = true;
            this.listaCompras.Size = new System.Drawing.Size(942, 362);
            this.listaCompras.TabIndex = 67;
            // 
            // bVolver
            // 
            this.bVolver.BackColor = System.Drawing.Color.Transparent;
            this.bVolver.BackgroundImage = global::Listado.Properties.Resources.icono_volver;
            this.bVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bVolver.FlatAppearance.BorderSize = 0;
            this.bVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVolver.Location = new System.Drawing.Point(8, 562);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(45, 40);
            this.bVolver.TabIndex = 71;
            this.bVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // editarCompras
            // 
            this.editarCompras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editarCompras.BackgroundImage")));
            this.editarCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editarCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editarCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarCompras.Location = new System.Drawing.Point(995, 153);
            this.editarCompras.Name = "editarCompras";
            this.editarCompras.Size = new System.Drawing.Size(39, 34);
            this.editarCompras.TabIndex = 70;
            this.editarCompras.UseVisualStyleBackColor = true;
            this.editarCompras.Click += new System.EventHandler(this.editarCompras_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Listado.Properties.Resources.BAnyadir;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(995, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 34);
            this.button1.TabIndex = 72;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelOrdenar
            // 
            this.labelOrdenar.AutoSize = true;
            this.labelOrdenar.Depth = 0;
            this.labelOrdenar.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelOrdenar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelOrdenar.Location = new System.Drawing.Point(745, 118);
            this.labelOrdenar.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelOrdenar.Name = "labelOrdenar";
            this.labelOrdenar.Size = new System.Drawing.Size(91, 19);
            this.labelOrdenar.TabIndex = 75;
            this.labelOrdenar.Text = "Ordenar por:";
            // 
            // radioID
            // 
            this.radioID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioID.Depth = 0;
            this.radioID.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioID.Location = new System.Drawing.Point(839, 115);
            this.radioID.Margin = new System.Windows.Forms.Padding(0);
            this.radioID.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioID.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioID.Name = "radioID";
            this.radioID.Ripple = true;
            this.radioID.Size = new System.Drawing.Size(75, 26);
            this.radioID.TabIndex = 74;
            this.radioID.Text = "ID";
            this.radioID.UseVisualStyleBackColor = true;
            // 
            // radioFecha
            // 
            this.radioFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioFecha.Depth = 0;
            this.radioFecha.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioFecha.Location = new System.Drawing.Point(914, 115);
            this.radioFecha.Margin = new System.Windows.Forms.Padding(0);
            this.radioFecha.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioFecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioFecha.Name = "radioFecha";
            this.radioFecha.Ripple = true;
            this.radioFecha.Size = new System.Drawing.Size(75, 26);
            this.radioFecha.TabIndex = 73;
            this.radioFecha.TabStop = true;
            this.radioFecha.Text = "Fecha";
            this.radioFecha.UseVisualStyleBackColor = true;
            // 
            // facturaB
            // 
            this.facturaB.BackgroundImage = global::Listado.Properties.Resources.BAnyadir;
            this.facturaB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.facturaB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.facturaB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.facturaB.Location = new System.Drawing.Point(995, 233);
            this.facturaB.Name = "facturaB";
            this.facturaB.Size = new System.Drawing.Size(39, 34);
            this.facturaB.TabIndex = 76;
            this.facturaB.UseVisualStyleBackColor = true;
            this.facturaB.Click += new System.EventHandler(this.facturaB_Click);
            // 
            // TextoCIFP
            // 
            this.TextoCIFP.Depth = 0;
            this.TextoCIFP.Enabled = false;
            this.TextoCIFP.Hint = "";
            this.TextoCIFP.Location = new System.Drawing.Point(123, 562);
            this.TextoCIFP.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextoCIFP.Name = "TextoCIFP";
            this.TextoCIFP.PasswordChar = '\0';
            this.TextoCIFP.SelectedText = "";
            this.TextoCIFP.SelectionLength = 0;
            this.TextoCIFP.SelectionStart = 0;
            this.TextoCIFP.Size = new System.Drawing.Size(218, 23);
            this.TextoCIFP.TabIndex = 77;
            this.TextoCIFP.UseSystemPasswordChar = false;
            this.TextoCIFP.Visible = false;
            // 
            // AnyadirCompra
            // 
            this.AnyadirCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnyadirCompra.Depth = 0;
            this.AnyadirCompra.Location = new System.Drawing.Point(422, 521);
            this.AnyadirCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.AnyadirCompra.Name = "AnyadirCompra";
            this.AnyadirCompra.Primary = true;
            this.AnyadirCompra.Size = new System.Drawing.Size(157, 64);
            this.AnyadirCompra.TabIndex = 78;
            this.AnyadirCompra.Text = "Añadir compra";
            this.AnyadirCompra.UseVisualStyleBackColor = true;
            this.AnyadirCompra.Click += new System.EventHandler(this.AnyadirCompra_Click_1);
            // 
            // ListadoComprasSolas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 610);
            this.Controls.Add(this.AnyadirCompra);
            this.Controls.Add(this.TextoCIFP);
            this.Controls.Add(this.facturaB);
            this.Controls.Add(this.labelOrdenar);
            this.Controls.Add(this.radioID);
            this.Controls.Add(this.radioFecha);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buscadorButton);
            this.Controls.Add(this.buscarID);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.editarCompras);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.listaCompras);
            this.Name = "ListadoComprasSolas";
            this.Text = "Listado de Compras";
            this.Load += new System.EventHandler(this.ListadoComprasSolas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton buscadorButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField buscarID;
        private System.Windows.Forms.Button bVolver;
        private MaterialSkin.Controls.MaterialRaisedButton buttonEliminar;
        public System.Windows.Forms.DataGridView listaCompras;
        private System.Windows.Forms.Button editarCompras;
        private System.Windows.Forms.Button button1;
        private MaterialSkin.Controls.MaterialLabel labelOrdenar;
        private MaterialSkin.Controls.MaterialRadioButton radioID;
        private MaterialSkin.Controls.MaterialRadioButton radioFecha;
        private System.Windows.Forms.Button facturaB;
        public MaterialSkin.Controls.MaterialSingleLineTextField TextoCIFP;
        private MaterialSkin.Controls.MaterialRaisedButton AnyadirCompra;
    }
}