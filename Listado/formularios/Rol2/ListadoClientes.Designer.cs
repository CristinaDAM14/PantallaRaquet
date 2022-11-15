
namespace RaquetZone.formularios.Rol2
{
    partial class ListadoClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoClientes));
            this.buttonVolver = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.listaClientes = new System.Windows.Forms.DataGridView();
            this.editarProductos = new System.Windows.Forms.Button();
            this.buscarDNI = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buscadorButton = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.listaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVolver
            // 
            this.buttonVolver.Depth = 0;
            this.buttonVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolver.Location = new System.Drawing.Point(13, 556);
            this.buttonVolver.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Primary = true;
            this.buttonVolver.Size = new System.Drawing.Size(73, 39);
            this.buttonVolver.TabIndex = 50;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Depth = 0;
            this.buttonEliminar.Location = new System.Drawing.Point(336, 519);
            this.buttonEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Primary = true;
            this.buttonEliminar.Size = new System.Drawing.Size(157, 64);
            this.buttonEliminar.TabIndex = 49;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // listaClientes
            // 
            this.listaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaClientes.Location = new System.Drawing.Point(49, 143);
            this.listaClientes.Name = "listaClientes";
            this.listaClientes.Size = new System.Drawing.Size(767, 360);
            this.listaClientes.TabIndex = 46;
            // 
            // editarProductos
            // 
            this.editarProductos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editarProductos.BackgroundImage")));
            this.editarProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarProductos.Location = new System.Drawing.Point(838, 143);
            this.editarProductos.Name = "editarProductos";
            this.editarProductos.Size = new System.Drawing.Size(39, 34);
            this.editarProductos.TabIndex = 47;
            this.editarProductos.UseVisualStyleBackColor = true;
            this.editarProductos.Click += new System.EventHandler(this.editarProductos_Click);
            // 
            // buscarDNI
            // 
            this.buscarDNI.Depth = 0;
            this.buscarDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarDNI.Hint = " DNI";
            this.buscarDNI.Location = new System.Drawing.Point(49, 98);
            this.buscarDNI.MouseState = MaterialSkin.MouseState.HOVER;
            this.buscarDNI.Name = "buscarDNI";
            this.buscarDNI.PasswordChar = '\0';
            this.buscarDNI.SelectedText = "";
            this.buscarDNI.SelectionLength = 0;
            this.buscarDNI.SelectionStart = 0;
            this.buscarDNI.Size = new System.Drawing.Size(166, 23);
            this.buscarDNI.TabIndex = 51;
            this.buscarDNI.UseSystemPasswordChar = false;
            // 
            // buscadorButton
            // 
            this.buscadorButton.Depth = 0;
            this.buscadorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscadorButton.Location = new System.Drawing.Point(235, 98);
            this.buscadorButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.buscadorButton.Name = "buscadorButton";
            this.buscadorButton.Primary = true;
            this.buscadorButton.Size = new System.Drawing.Size(61, 23);
            this.buscadorButton.TabIndex = 53;
            this.buscadorButton.Text = "Buscar";
            this.buscadorButton.UseVisualStyleBackColor = true;
            this.buscadorButton.Click += new System.EventHandler(this.buscadorButton_Click);
            // 
            // ListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 610);
            this.Controls.Add(this.buscadorButton);
            this.Controls.Add(this.buscarDNI);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.editarProductos);
            this.Controls.Add(this.listaClientes);
            this.Name = "ListadoClientes";
            this.Text = "Listado de Clientes";
            this.Load += new System.EventHandler(this.ListadoClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton buttonVolver;
        private MaterialSkin.Controls.MaterialRaisedButton buttonEliminar;
        private System.Windows.Forms.Button editarProductos;
        private MaterialSkin.Controls.MaterialSingleLineTextField buscarDNI;
        private MaterialSkin.Controls.MaterialRaisedButton buscadorButton;
        public System.Windows.Forms.DataGridView listaClientes;
    }
}