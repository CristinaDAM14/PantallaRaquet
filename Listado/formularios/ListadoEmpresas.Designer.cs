
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
            this.buttonEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buscadorButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buscarCIF = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.bVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaDatosEmpresas)).BeginInit();
            this.SuspendLayout();
            // 
            // listaDatosEmpresas
            // 
            this.listaDatosEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaDatosEmpresas.Location = new System.Drawing.Point(47, 142);
            this.listaDatosEmpresas.Name = "listaDatosEmpresas";
            this.listaDatosEmpresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaDatosEmpresas.Size = new System.Drawing.Size(946, 360);
            this.listaDatosEmpresas.TabIndex = 2;
            // 
            // editar
            // 
            this.editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editar.BackgroundImage")));
            this.editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editar.Location = new System.Drawing.Point(999, 142);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(39, 33);
            this.editar.TabIndex = 4;
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Depth = 0;
            this.buttonEliminar.Location = new System.Drawing.Point(457, 522);
            this.buttonEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Primary = true;
            this.buttonEliminar.Size = new System.Drawing.Size(157, 64);
            this.buttonEliminar.TabIndex = 36;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buscadorButton
            // 
            this.buscadorButton.Depth = 0;
            this.buscadorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscadorButton.Location = new System.Drawing.Point(233, 93);
            this.buscadorButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.buscadorButton.Name = "buscadorButton";
            this.buscadorButton.Primary = true;
            this.buscadorButton.Size = new System.Drawing.Size(61, 23);
            this.buscadorButton.TabIndex = 55;
            this.buscadorButton.Text = "Buscar";
            this.buscadorButton.UseVisualStyleBackColor = true;
            this.buscadorButton.Click += new System.EventHandler(this.buscadorButton_Click);
            // 
            // buscarCIF
            // 
            this.buscarCIF.Depth = 0;
            this.buscarCIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarCIF.Hint = " CIF";
            this.buscarCIF.Location = new System.Drawing.Point(47, 93);
            this.buscarCIF.MouseState = MaterialSkin.MouseState.HOVER;
            this.buscarCIF.Name = "buscarCIF";
            this.buscarCIF.PasswordChar = '\0';
            this.buscarCIF.SelectedText = "";
            this.buscarCIF.SelectionLength = 0;
            this.buscarCIF.SelectionStart = 0;
            this.buscarCIF.Size = new System.Drawing.Size(166, 23);
            this.buscarCIF.TabIndex = 54;
            this.buscarCIF.UseSystemPasswordChar = false;
            // 
            // bVolver
            // 
            this.bVolver.BackColor = System.Drawing.Color.Transparent;
            this.bVolver.BackgroundImage = global::Listado.Properties.Resources.icono_volver;
            this.bVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bVolver.FlatAppearance.BorderSize = 0;
            this.bVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVolver.Location = new System.Drawing.Point(12, 558);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(45, 40);
            this.bVolver.TabIndex = 59;
            this.bVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // RaquetZoneEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 610);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.buscadorButton);
            this.Controls.Add(this.buscarCIF);
            this.Controls.Add(this.buttonEliminar);
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
        private MaterialSkin.Controls.MaterialRaisedButton buttonEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton buscadorButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField buscarCIF;
        private System.Windows.Forms.Button bVolver;
    }
}