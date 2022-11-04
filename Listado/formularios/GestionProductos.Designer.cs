
namespace Listado.formularios
{
    partial class GestionProductos
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
            this.listadoProductos = new System.Windows.Forms.Button();
            this.AnyadirProducto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listadoProductos
            // 
            this.listadoProductos.Location = new System.Drawing.Point(215, 220);
            this.listadoProductos.Margin = new System.Windows.Forms.Padding(2);
            this.listadoProductos.Name = "listadoProductos";
            this.listadoProductos.Size = new System.Drawing.Size(210, 48);
            this.listadoProductos.TabIndex = 4;
            this.listadoProductos.Text = "Listado de Productos";
            this.listadoProductos.UseVisualStyleBackColor = true;
            // 
            // AnyadirProducto
            // 
            this.AnyadirProducto.Location = new System.Drawing.Point(215, 112);
            this.AnyadirProducto.Margin = new System.Windows.Forms.Padding(2);
            this.AnyadirProducto.Name = "AnyadirProducto";
            this.AnyadirProducto.Size = new System.Drawing.Size(210, 48);
            this.AnyadirProducto.TabIndex = 3;
            this.AnyadirProducto.Text = "Añadir Producto";
            this.AnyadirProducto.UseVisualStyleBackColor = true;
            // 
            // GestionProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 380);
            this.Controls.Add(this.listadoProductos);
            this.Controls.Add(this.AnyadirProducto);
            this.Name = "GestionProductos";
            this.Text = "GestionProductos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button listadoProductos;
        private System.Windows.Forms.Button AnyadirProducto;
    }
}