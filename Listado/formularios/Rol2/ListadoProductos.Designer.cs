
namespace RaquetZone.formularios.Rol2
{
    partial class ListadoProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoProductos));
            this.buttonEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.listaProductos = new System.Windows.Forms.DataGridView();
            this.editarProductos = new System.Windows.Forms.Button();
            this.buscadorButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buscarNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.bVolver = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TextoCIFP = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.limpiarB = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEliminar.Depth = 0;
            this.buttonEliminar.Location = new System.Drawing.Point(473, 518);
            this.buttonEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Primary = true;
            this.buttonEliminar.Size = new System.Drawing.Size(157, 64);
            this.buttonEliminar.TabIndex = 44;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // listaProductos
            // 
            this.listaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaProductos.Location = new System.Drawing.Point(48, 141);
            this.listaProductos.Name = "listaProductos";
            this.listaProductos.RowTemplate.ReadOnly = true;
            this.listaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaProductos.Size = new System.Drawing.Size(945, 360);
            this.listaProductos.TabIndex = 41;
            // 
            // editarProductos
            // 
            this.editarProductos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editarProductos.BackgroundImage")));
            this.editarProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editarProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarProductos.Location = new System.Drawing.Point(999, 141);
            this.editarProductos.Name = "editarProductos";
            this.editarProductos.Size = new System.Drawing.Size(39, 34);
            this.editarProductos.TabIndex = 42;
            this.editarProductos.UseVisualStyleBackColor = true;
            this.editarProductos.Click += new System.EventHandler(this.editarProductos_Click);
            // 
            // buscadorButton
            // 
            this.buscadorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscadorButton.Depth = 0;
            this.buscadorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscadorButton.Location = new System.Drawing.Point(220, 93);
            this.buscadorButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.buscadorButton.Name = "buscadorButton";
            this.buscadorButton.Primary = true;
            this.buscadorButton.Size = new System.Drawing.Size(61, 23);
            this.buscadorButton.TabIndex = 2;
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
            this.buscarNombre.Location = new System.Drawing.Point(48, 93);
            this.buscarNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.buscarNombre.Name = "buscarNombre";
            this.buscarNombre.PasswordChar = '\0';
            this.buscarNombre.SelectedText = "";
            this.buscarNombre.SelectionLength = 0;
            this.buscarNombre.SelectionStart = 0;
            this.buscarNombre.Size = new System.Drawing.Size(166, 23);
            this.buscarNombre.TabIndex = 1;
            this.buscarNombre.UseSystemPasswordChar = false;
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
            this.bVolver.TabIndex = 62;
            this.bVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Listado.Properties.Resources.BAnyadir;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(999, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 34);
            this.button1.TabIndex = 63;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextoCIFP
            // 
            this.TextoCIFP.Depth = 0;
            this.TextoCIFP.Enabled = false;
            this.TextoCIFP.Hint = "";
            this.TextoCIFP.Location = new System.Drawing.Point(157, 93);
            this.TextoCIFP.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextoCIFP.Name = "TextoCIFP";
            this.TextoCIFP.PasswordChar = '\0';
            this.TextoCIFP.SelectedText = "";
            this.TextoCIFP.SelectionLength = 0;
            this.TextoCIFP.SelectionStart = 0;
            this.TextoCIFP.Size = new System.Drawing.Size(30, 23);
            this.TextoCIFP.TabIndex = 70;
            this.TextoCIFP.UseSystemPasswordChar = false;
            this.TextoCIFP.Visible = false;
            // 
            // limpiarB
            // 
            this.limpiarB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.limpiarB.Depth = 0;
            this.limpiarB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiarB.Location = new System.Drawing.Point(287, 93);
            this.limpiarB.MouseState = MaterialSkin.MouseState.HOVER;
            this.limpiarB.Name = "limpiarB";
            this.limpiarB.Primary = true;
            this.limpiarB.Size = new System.Drawing.Size(61, 23);
            this.limpiarB.TabIndex = 80;
            this.limpiarB.Text = "Limpiar";
            this.limpiarB.UseVisualStyleBackColor = true;
            this.limpiarB.Click += new System.EventHandler(this.limpiarB_Click);
            // 
            // ListadoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 610);
            this.Controls.Add(this.limpiarB);
            this.Controls.Add(this.TextoCIFP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.buscadorButton);
            this.Controls.Add(this.buscarNombre);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.editarProductos);
            this.Controls.Add(this.listaProductos);
            this.MaximizeBox = false;
            this.Name = "ListadoProductos";
            this.Text = "Listado de Productos";
            this.Load += new System.EventHandler(this.ListadoProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton buttonEliminar;
        private System.Windows.Forms.Button editarProductos;
        private System.Windows.Forms.DataGridView listaProductos;
        private MaterialSkin.Controls.MaterialRaisedButton buscadorButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField buscarNombre;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Button button1;
        public MaterialSkin.Controls.MaterialSingleLineTextField TextoCIFP;
        private MaterialSkin.Controls.MaterialRaisedButton limpiarB;
    }
}