
namespace RaquetZone.formularios.Rol2
{
    partial class PantallaPrincipalRol2
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
            this.buttonGU = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonGC = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonGP = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonCompras = new MaterialSkin.Controls.MaterialRaisedButton();
            this.productosLabel = new System.Windows.Forms.Label();
            this.clientesLabel = new System.Windows.Forms.Label();
            this.comprasLabel = new System.Windows.Forms.Label();
            this.empleadosLabel = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.edgeButton = new System.Windows.Forms.Button();
            this.chromeButton = new System.Windows.Forms.Button();
            this.noteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Servicios = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // buttonGU
            // 
            this.buttonGU.Depth = 0;
            this.buttonGU.Location = new System.Drawing.Point(66, 291);
            this.buttonGU.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonGU.Name = "buttonGU";
            this.buttonGU.Primary = true;
            this.buttonGU.Size = new System.Drawing.Size(179, 29);
            this.buttonGU.TabIndex = 19;
            this.buttonGU.Text = "Empleados";
            this.buttonGU.UseVisualStyleBackColor = true;
            this.buttonGU.Click += new System.EventHandler(this.buttonGU_Click);
            // 
            // buttonGC
            // 
            this.buttonGC.Depth = 0;
            this.buttonGC.Location = new System.Drawing.Point(66, 176);
            this.buttonGC.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonGC.Name = "buttonGC";
            this.buttonGC.Primary = true;
            this.buttonGC.Size = new System.Drawing.Size(179, 29);
            this.buttonGC.TabIndex = 18;
            this.buttonGC.Text = "Clientes";
            this.buttonGC.UseVisualStyleBackColor = true;
            this.buttonGC.Click += new System.EventHandler(this.buttonGC_Click);
            // 
            // buttonGP
            // 
            this.buttonGP.Depth = 0;
            this.buttonGP.Location = new System.Drawing.Point(323, 176);
            this.buttonGP.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonGP.Name = "buttonGP";
            this.buttonGP.Primary = true;
            this.buttonGP.Size = new System.Drawing.Size(179, 29);
            this.buttonGP.TabIndex = 21;
            this.buttonGP.Text = "Productos";
            this.buttonGP.UseVisualStyleBackColor = true;
            this.buttonGP.Click += new System.EventHandler(this.buttonGP_Click);
            // 
            // buttonCompras
            // 
            this.buttonCompras.Depth = 0;
            this.buttonCompras.Location = new System.Drawing.Point(323, 291);
            this.buttonCompras.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonCompras.Name = "buttonCompras";
            this.buttonCompras.Primary = true;
            this.buttonCompras.Size = new System.Drawing.Size(179, 29);
            this.buttonCompras.TabIndex = 22;
            this.buttonCompras.Text = "Compras";
            this.buttonCompras.UseVisualStyleBackColor = true;
            this.buttonCompras.Click += new System.EventHandler(this.buttonCompras_Click);
            // 
            // productosLabel
            // 
            this.productosLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productosLabel.Image = global::Listado.Properties.Resources.producto;
            this.productosLabel.Location = new System.Drawing.Point(386, 118);
            this.productosLabel.Name = "productosLabel";
            this.productosLabel.Size = new System.Drawing.Size(57, 55);
            this.productosLabel.TabIndex = 64;
            // 
            // clientesLabel
            // 
            this.clientesLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientesLabel.Image = global::Listado.Properties.Resources.clientes;
            this.clientesLabel.Location = new System.Drawing.Point(123, 118);
            this.clientesLabel.Name = "clientesLabel";
            this.clientesLabel.Size = new System.Drawing.Size(57, 55);
            this.clientesLabel.TabIndex = 63;
            // 
            // comprasLabel
            // 
            this.comprasLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comprasLabel.Image = global::Listado.Properties.Resources.compras;
            this.comprasLabel.Location = new System.Drawing.Point(386, 233);
            this.comprasLabel.Name = "comprasLabel";
            this.comprasLabel.Size = new System.Drawing.Size(57, 55);
            this.comprasLabel.TabIndex = 62;
            // 
            // empleadosLabel
            // 
            this.empleadosLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empleadosLabel.Image = global::Listado.Properties.Resources.empleados1;
            this.empleadosLabel.Location = new System.Drawing.Point(123, 233);
            this.empleadosLabel.Name = "empleadosLabel";
            this.empleadosLabel.Size = new System.Drawing.Size(57, 55);
            this.empleadosLabel.TabIndex = 61;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogin.BackgroundImage = global::Listado.Properties.Resources.cerrar_sesion;
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Location = new System.Drawing.Point(744, 73);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(34, 32);
            this.buttonLogin.TabIndex = 60;
            this.buttonLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click_1);
            // 
            // edgeButton
            // 
            this.edgeButton.BackgroundImage = global::Listado.Properties.Resources.medge;
            this.edgeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.edgeButton.FlatAppearance.BorderSize = 0;
            this.edgeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edgeButton.Location = new System.Drawing.Point(744, 332);
            this.edgeButton.Name = "edgeButton";
            this.edgeButton.Size = new System.Drawing.Size(36, 32);
            this.edgeButton.TabIndex = 11;
            this.edgeButton.UseVisualStyleBackColor = true;
            this.edgeButton.Click += new System.EventHandler(this.edgeButton_Click);
            // 
            // chromeButton
            // 
            this.chromeButton.BackgroundImage = global::Listado.Properties.Resources.chrome;
            this.chromeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chromeButton.FlatAppearance.BorderSize = 0;
            this.chromeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chromeButton.Location = new System.Drawing.Point(744, 294);
            this.chromeButton.Name = "chromeButton";
            this.chromeButton.Size = new System.Drawing.Size(36, 32);
            this.chromeButton.TabIndex = 10;
            this.chromeButton.UseVisualStyleBackColor = true;
            this.chromeButton.Click += new System.EventHandler(this.chromeButton_Click);
            // 
            // noteButton
            // 
            this.noteButton.BackgroundImage = global::Listado.Properties.Resources.notepad;
            this.noteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.noteButton.FlatAppearance.BorderSize = 0;
            this.noteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noteButton.Location = new System.Drawing.Point(744, 256);
            this.noteButton.Name = "noteButton";
            this.noteButton.Size = new System.Drawing.Size(36, 32);
            this.noteButton.TabIndex = 9;
            this.noteButton.UseVisualStyleBackColor = true;
            this.noteButton.Click += new System.EventHandler(this.noteButton_Click);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Image = global::Listado.Properties.Resources.producto;
            this.label1.Location = new System.Drawing.Point(636, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 55);
            this.label1.TabIndex = 67;
            // 
            // Servicios
            // 
            this.Servicios.Depth = 0;
            this.Servicios.Location = new System.Drawing.Point(573, 176);
            this.Servicios.MouseState = MaterialSkin.MouseState.HOVER;
            this.Servicios.Name = "Servicios";
            this.Servicios.Primary = true;
            this.Servicios.Size = new System.Drawing.Size(179, 29);
            this.Servicios.TabIndex = 66;
            this.Servicios.Text = "Servicios";
            this.Servicios.UseVisualStyleBackColor = true;
            this.Servicios.Click += new System.EventHandler(this.Servicios_Click);
            // 
            // PantallaPrincipalRol2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 380);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Servicios);
            this.Controls.Add(this.productosLabel);
            this.Controls.Add(this.clientesLabel);
            this.Controls.Add(this.comprasLabel);
            this.Controls.Add(this.empleadosLabel);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonCompras);
            this.Controls.Add(this.buttonGP);
            this.Controls.Add(this.buttonGU);
            this.Controls.Add(this.buttonGC);
            this.Controls.Add(this.edgeButton);
            this.Controls.Add(this.chromeButton);
            this.Controls.Add(this.noteButton);
            this.Name = "PantallaPrincipalRol2";
            this.Load += new System.EventHandler(this.PantallaPrincipalRol2_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button noteButton;
        private System.Windows.Forms.Button chromeButton;
        private System.Windows.Forms.Button edgeButton;
        private MaterialSkin.Controls.MaterialRaisedButton buttonGU;
        private MaterialSkin.Controls.MaterialRaisedButton buttonGC;
        private MaterialSkin.Controls.MaterialRaisedButton buttonGP;
        private MaterialSkin.Controls.MaterialRaisedButton buttonCompras;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label empleadosLabel;
        private System.Windows.Forms.Label comprasLabel;
        private System.Windows.Forms.Label clientesLabel;
        private System.Windows.Forms.Label productosLabel;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton Servicios;
    }
}