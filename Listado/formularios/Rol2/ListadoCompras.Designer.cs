
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
            this.listaCompras = new System.Windows.Forms.DataGridView();
            this.buttonFactura = new MaterialSkin.Controls.MaterialRaisedButton();
            this.radioFecha = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioID = new MaterialSkin.Controls.MaterialRadioButton();
            this.labelOrdenar = new MaterialSkin.Controls.MaterialLabel();
            this.bVolver = new System.Windows.Forms.Button();
            this.buscadorButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buscarID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.button1 = new System.Windows.Forms.Button();
            this.TextoCIFP = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.listaCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // listaCompras
            // 
            this.listaCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaCompras.Location = new System.Drawing.Point(51, 140);
            this.listaCompras.Name = "listaCompras";
            this.listaCompras.RowTemplate.ReadOnly = true;
            this.listaCompras.Size = new System.Drawing.Size(942, 362);
            this.listaCompras.TabIndex = 51;
            // 
            // buttonFactura
            // 
            this.buttonFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFactura.Depth = 0;
            this.buttonFactura.Location = new System.Drawing.Point(432, 523);
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
            this.radioFecha.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.radioID.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.bVolver.TabIndex = 63;
            this.bVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // buscadorButton
            // 
            this.buscadorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscadorButton.Depth = 0;
            this.buscadorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscadorButton.Location = new System.Drawing.Point(237, 101);
            this.buscadorButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.buscadorButton.Name = "buscadorButton";
            this.buscadorButton.Primary = true;
            this.buscadorButton.Size = new System.Drawing.Size(61, 23);
            this.buscadorButton.TabIndex = 2;
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
            this.buscarID.Location = new System.Drawing.Point(51, 101);
            this.buscarID.MouseState = MaterialSkin.MouseState.HOVER;
            this.buscarID.Name = "buscarID";
            this.buscarID.PasswordChar = '\0';
            this.buscarID.SelectedText = "";
            this.buscarID.SelectionLength = 0;
            this.buscarID.SelectionStart = 0;
            this.buscarID.Size = new System.Drawing.Size(166, 23);
            this.buscarID.TabIndex = 1;
            this.buscarID.UseSystemPasswordChar = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Listado.Properties.Resources.BAnyadir;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(999, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 34);
            this.button1.TabIndex = 64;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextoCIFP
            // 
            this.TextoCIFP.Depth = 0;
            this.TextoCIFP.Enabled = false;
            this.TextoCIFP.Hint = "";
            this.TextoCIFP.Location = new System.Drawing.Point(121, 564);
            this.TextoCIFP.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextoCIFP.Name = "TextoCIFP";
            this.TextoCIFP.PasswordChar = '\0';
            this.TextoCIFP.SelectedText = "";
            this.TextoCIFP.SelectionLength = 0;
            this.TextoCIFP.SelectionStart = 0;
            this.TextoCIFP.Size = new System.Drawing.Size(218, 23);
            this.TextoCIFP.TabIndex = 71;
            this.TextoCIFP.UseSystemPasswordChar = false;
            this.TextoCIFP.Visible = false;
            // 
            // ListadoCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 610);
            this.Controls.Add(this.TextoCIFP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buscadorButton);
            this.Controls.Add(this.buscarID);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.labelOrdenar);
            this.Controls.Add(this.radioID);
            this.Controls.Add(this.radioFecha);
            this.Controls.Add(this.buttonFactura);
            this.Controls.Add(this.listaCompras);
            this.MaximizeBox = false;
            this.Name = "ListadoCompras";
            this.Text = "Listado de compras finalizadas";
            this.Load += new System.EventHandler(this.ListadoCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView listaCompras;
        private MaterialSkin.Controls.MaterialRaisedButton buttonFactura;
        private MaterialSkin.Controls.MaterialRadioButton radioFecha;
        private MaterialSkin.Controls.MaterialRadioButton radioID;
        private MaterialSkin.Controls.MaterialLabel labelOrdenar;
        private System.Windows.Forms.Button bVolver;
        private MaterialSkin.Controls.MaterialRaisedButton buscadorButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField buscarID;
        private System.Windows.Forms.Button button1;
        public MaterialSkin.Controls.MaterialSingleLineTextField TextoCIFP;
    }
}