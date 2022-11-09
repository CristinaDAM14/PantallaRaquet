
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
            this.listaDatosEmpresas = new System.Windows.Forms.DataGridView();
            this.editar = new System.Windows.Forms.Button();
            this.buttonMostrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonVolver = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.listaDatosEmpresas)).BeginInit();
            this.SuspendLayout();
            // 
            // listaDatosEmpresas
            // 
            this.listaDatosEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaDatosEmpresas.Location = new System.Drawing.Point(49, 87);
            this.listaDatosEmpresas.Name = "listaDatosEmpresas";
            this.listaDatosEmpresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaDatosEmpresas.Size = new System.Drawing.Size(765, 360);
            this.listaDatosEmpresas.TabIndex = 2;
            // 
            // editar
            // 
            this.editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editar.BackgroundImage")));
            this.editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editar.Location = new System.Drawing.Point(841, 87);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(39, 33);
            this.editar.TabIndex = 4;
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.Depth = 0;
            this.buttonMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMostrar.Location = new System.Drawing.Point(234, 466);
            this.buttonMostrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Primary = true;
            this.buttonMostrar.Size = new System.Drawing.Size(157, 64);
            this.buttonMostrar.TabIndex = 35;
            this.buttonMostrar.Text = "Mostrar Lista";
            this.buttonMostrar.UseVisualStyleBackColor = true;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Depth = 0;
            this.buttonEliminar.Location = new System.Drawing.Point(482, 466);
            this.buttonEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Primary = true;
            this.buttonEliminar.Size = new System.Drawing.Size(157, 64);
            this.buttonEliminar.TabIndex = 36;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Depth = 0;
            this.buttonVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolver.Location = new System.Drawing.Point(12, 501);
            this.buttonVolver.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Primary = true;
            this.buttonVolver.Size = new System.Drawing.Size(73, 39);
            this.buttonVolver.TabIndex = 37;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // RaquetZoneEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 550);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.listaDatosEmpresas);
            this.Name = "RaquetZoneEmpresas";
            this.Text = "Listado de Empresas";
            this.Load += new System.EventHandler(this.RaquetZoneEmpresas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaDatosEmpresas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView listaDatosEmpresas;
        private System.Windows.Forms.Button editar;
        private MaterialSkin.Controls.MaterialRaisedButton buttonMostrar;
        private MaterialSkin.Controls.MaterialRaisedButton buttonEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton buttonVolver;
    }
}