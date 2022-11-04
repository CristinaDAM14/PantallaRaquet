
namespace RaquetZone.formularios
{
    partial class RaquetZoneUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaquetZoneUsuarios));
            this.listaDatos = new System.Windows.Forms.DataGridView();
            this.mostrarLista = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.eliminarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // listaDatos
            // 
            this.listaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaDatos.Location = new System.Drawing.Point(40, 59);
            this.listaDatos.Name = "listaDatos";
            this.listaDatos.Size = new System.Drawing.Size(740, 360);
            this.listaDatos.TabIndex = 0;
            // 
            // mostrarLista
            // 
            this.mostrarLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrarLista.Location = new System.Drawing.Point(205, 437);
            this.mostrarLista.Name = "mostrarLista";
            this.mostrarLista.Size = new System.Drawing.Size(189, 56);
            this.mostrarLista.TabIndex = 1;
            this.mostrarLista.Text = "Mostrar Lista";
            this.mostrarLista.UseVisualStyleBackColor = true;
            this.mostrarLista.Click += new System.EventHandler(this.mostrarLista_Click);
            // 
            // editar
            // 
            this.editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editar.BackgroundImage")));
            this.editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editar.Location = new System.Drawing.Point(796, 59);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(49, 42);
            this.editar.TabIndex = 2;
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 482);
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
            this.eliminarButton.Location = new System.Drawing.Point(423, 437);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(189, 56);
            this.eliminarButton.TabIndex = 34;
            this.eliminarButton.Text = "Eliminar";
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // RaquetZoneUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 517);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.mostrarLista);
            this.Controls.Add(this.listaDatos);
            this.Name = "RaquetZoneUsuarios";
            this.Text = "RaquetZoneUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.listaDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listaDatos;
        private System.Windows.Forms.Button mostrarLista;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button eliminarButton;
    }
}