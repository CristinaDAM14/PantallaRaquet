
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
            this.edgeButton = new System.Windows.Forms.Button();
            this.chromeButton = new System.Windows.Forms.Button();
            this.noteButton = new System.Windows.Forms.Button();
            this.buttonGU = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonGC = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonGP = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonCompras = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // edgeButton
            // 
            this.edgeButton.BackgroundImage = global::Listado.Properties.Resources.medge;
            this.edgeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.edgeButton.Location = new System.Drawing.Point(552, 336);
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
            this.chromeButton.Location = new System.Drawing.Point(510, 336);
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
            this.noteButton.Location = new System.Drawing.Point(468, 336);
            this.noteButton.Name = "noteButton";
            this.noteButton.Size = new System.Drawing.Size(36, 32);
            this.noteButton.TabIndex = 9;
            this.noteButton.UseVisualStyleBackColor = true;
            this.noteButton.Click += new System.EventHandler(this.noteButton_Click);
            // 
            // buttonGU
            // 
            this.buttonGU.Depth = 0;
            this.buttonGU.Location = new System.Drawing.Point(49, 152);
            this.buttonGU.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonGU.Name = "buttonGU";
            this.buttonGU.Primary = true;
            this.buttonGU.Size = new System.Drawing.Size(210, 53);
            this.buttonGU.TabIndex = 19;
            this.buttonGU.Text = "Gestionar Empleados";
            this.buttonGU.UseVisualStyleBackColor = true;
            this.buttonGU.Click += new System.EventHandler(this.buttonGU_Click);
            // 
            // buttonGC
            // 
            this.buttonGC.Depth = 0;
            this.buttonGC.Location = new System.Drawing.Point(49, 252);
            this.buttonGC.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonGC.Name = "buttonGC";
            this.buttonGC.Primary = true;
            this.buttonGC.Size = new System.Drawing.Size(210, 53);
            this.buttonGC.TabIndex = 18;
            this.buttonGC.Text = "Gestionar Clientes";
            this.buttonGC.UseVisualStyleBackColor = true;
            this.buttonGC.Click += new System.EventHandler(this.buttonGC_Click);
            // 
            // buttonGP
            // 
            this.buttonGP.Depth = 0;
            this.buttonGP.Location = new System.Drawing.Point(323, 152);
            this.buttonGP.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonGP.Name = "buttonGP";
            this.buttonGP.Primary = true;
            this.buttonGP.Size = new System.Drawing.Size(210, 53);
            this.buttonGP.TabIndex = 21;
            this.buttonGP.Text = "Gestionar Productos";
            this.buttonGP.UseVisualStyleBackColor = true;
            this.buttonGP.Click += new System.EventHandler(this.buttonGP_Click);
            // 
            // buttonCompras
            // 
            this.buttonCompras.Depth = 0;
            this.buttonCompras.Location = new System.Drawing.Point(323, 252);
            this.buttonCompras.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonCompras.Name = "buttonCompras";
            this.buttonCompras.Primary = true;
            this.buttonCompras.Size = new System.Drawing.Size(210, 53);
            this.buttonCompras.TabIndex = 22;
            this.buttonCompras.Text = "Gestionar Compras";
            this.buttonCompras.UseVisualStyleBackColor = true;
            this.buttonCompras.Click += new System.EventHandler(this.buttonCompras_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogin.BackgroundImage = global::Listado.Properties.Resources.cerrar_sesion;
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Location = new System.Drawing.Point(554, 71);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(34, 32);
            this.buttonLogin.TabIndex = 60;
            this.buttonLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click_1);
            // 
            // PantallaPrincipalRol2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 380);
            this.ControlBox = false;
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
    }
}