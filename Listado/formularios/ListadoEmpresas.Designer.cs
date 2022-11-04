
namespace RaquetZone.formularios
{
    partial class RaquetZoneEmpresas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaquetZoneEmpresas));
            this.mostrarListaEmpresas = new System.Windows.Forms.Button();
            this.listaDatosEmpresas = new System.Windows.Forms.DataGridView();
            this.editar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.eliminarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaDatosEmpresas)).BeginInit();
            this.SuspendLayout();
            // 
            // mostrarListaEmpresas
            // 
            this.mostrarListaEmpresas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrarListaEmpresas.Location = new System.Drawing.Point(214, 404);
            this.mostrarListaEmpresas.Name = "mostrarListaEmpresas";
            this.mostrarListaEmpresas.Size = new System.Drawing.Size(189, 56);
            this.mostrarListaEmpresas.TabIndex = 3;
            this.mostrarListaEmpresas.Text = "Mostrar Lista";
            this.mostrarListaEmpresas.UseVisualStyleBackColor = true;
            this.mostrarListaEmpresas.Click += new System.EventHandler(this.mostrarListaEmpresas_Click);
            // 
            // listaDatosEmpresas
            // 
            this.listaDatosEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaDatosEmpresas.Location = new System.Drawing.Point(36, 24);
            this.listaDatosEmpresas.Name = "listaDatosEmpresas";
            this.listaDatosEmpresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaDatosEmpresas.Size = new System.Drawing.Size(765, 360);
            this.listaDatosEmpresas.TabIndex = 2;
             // 
            // editar
            // 
            this.editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editar.BackgroundImage")));
            this.editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editar.Location = new System.Drawing.Point(818, 33);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(39, 33);
            this.editar.TabIndex = 4;
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 446);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // eliminarButton
            // 
            this.eliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarButton.Location = new System.Drawing.Point(444, 404);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(189, 56);
            this.eliminarButton.TabIndex = 34;
            this.eliminarButton.Text = "Eliminar";
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // RaquetZoneEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 481);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.mostrarListaEmpresas);
            this.Controls.Add(this.listaDatosEmpresas);
            this.Name = "RaquetZoneEmpresas";
            this.Text = "RaquetZoneEmpresas";
            ((System.ComponentModel.ISupportInitialize)(this.listaDatosEmpresas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mostrarListaEmpresas;
        private System.Windows.Forms.DataGridView listaDatosEmpresas;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button eliminarButton;
    }
}