
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
            this.buttonVolver = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.listaProductos = new System.Windows.Forms.DataGridView();
            this.editarProductos = new System.Windows.Forms.Button();
            this.buscadorButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buscarID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVolver
            // 
            this.buttonVolver.Depth = 0;
            this.buttonVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolver.Location = new System.Drawing.Point(12, 554);
            this.buttonVolver.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Primary = true;
            this.buttonVolver.Size = new System.Drawing.Size(73, 39);
            this.buttonVolver.TabIndex = 45;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Depth = 0;
            this.buttonEliminar.Location = new System.Drawing.Point(346, 520);
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
            this.listaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaProductos.Location = new System.Drawing.Point(48, 141);
            this.listaProductos.Name = "listaProductos";
            this.listaProductos.Size = new System.Drawing.Size(767, 360);
            this.listaProductos.TabIndex = 41;
            // 
            // editarProductos
            // 
            this.editarProductos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editarProductos.BackgroundImage")));
            this.editarProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarProductos.Location = new System.Drawing.Point(837, 141);
            this.editarProductos.Name = "editarProductos";
            this.editarProductos.Size = new System.Drawing.Size(39, 34);
            this.editarProductos.TabIndex = 42;
            this.editarProductos.UseVisualStyleBackColor = true;
            this.editarProductos.Click += new System.EventHandler(this.editarProductos_Click);
            // 
            // buscadorButton
            // 
            this.buscadorButton.Depth = 0;
            this.buscadorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscadorButton.Location = new System.Drawing.Point(234, 93);
            this.buscadorButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.buscadorButton.Name = "buscadorButton";
            this.buscadorButton.Primary = true;
            this.buscadorButton.Size = new System.Drawing.Size(61, 23);
            this.buscadorButton.TabIndex = 55;
            this.buscadorButton.Text = "Buscar";
            this.buscadorButton.UseVisualStyleBackColor = true;
            this.buscadorButton.Click += new System.EventHandler(this.buscadorButton_Click);
            // 
            // buscarID
            // 
            this.buscarID.Depth = 0;
            this.buscarID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarID.Hint = " ID";
            this.buscarID.Location = new System.Drawing.Point(48, 93);
            this.buscarID.MouseState = MaterialSkin.MouseState.HOVER;
            this.buscarID.Name = "buscarID";
            this.buscarID.PasswordChar = '\0';
            this.buscarID.SelectedText = "";
            this.buscarID.SelectionLength = 0;
            this.buscarID.SelectionStart = 0;
            this.buscarID.Size = new System.Drawing.Size(166, 23);
            this.buscarID.TabIndex = 54;
            this.buscarID.UseSystemPasswordChar = false;
            // 
            // ListadoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 610);
            this.Controls.Add(this.buscadorButton);
            this.Controls.Add(this.buscarID);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.editarProductos);
            this.Controls.Add(this.listaProductos);
            this.Name = "ListadoProductos";
            this.Text = "Listado de Productos";
            this.Load += new System.EventHandler(this.ListadoProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton buttonVolver;
        private MaterialSkin.Controls.MaterialRaisedButton buttonEliminar;
        private System.Windows.Forms.Button editarProductos;
        private System.Windows.Forms.DataGridView listaProductos;
        private MaterialSkin.Controls.MaterialRaisedButton buscadorButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField buscarID;
    }
}