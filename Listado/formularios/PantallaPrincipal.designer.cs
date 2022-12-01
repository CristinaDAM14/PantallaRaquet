namespace RaquetZone.formularios
{
    partial class PantallaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGE = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonGU = new MaterialSkin.Controls.MaterialRaisedButton();
            this.empresaLabel = new System.Windows.Forms.Label();
            this.usuariosLabel = new System.Windows.Forms.Label();
            this.loginBotton = new System.Windows.Forms.Button();
            this.noteButton = new System.Windows.Forms.Button();
            this.edgeButton = new System.Windows.Forms.Button();
            this.chromeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGE
            // 
            this.buttonGE.Depth = 0;
            this.buttonGE.Location = new System.Drawing.Point(202, 157);
            this.buttonGE.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonGE.Name = "buttonGE";
            this.buttonGE.Primary = true;
            this.buttonGE.Size = new System.Drawing.Size(179, 29);
            this.buttonGE.TabIndex = 15;
            this.buttonGE.Text = "Empresas";
            this.buttonGE.UseVisualStyleBackColor = true;
            this.buttonGE.Click += new System.EventHandler(this.buttonGE_Click);
            // 
            // buttonGU
            // 
            this.buttonGU.Depth = 0;
            this.buttonGU.Location = new System.Drawing.Point(202, 280);
            this.buttonGU.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonGU.Name = "buttonGU";
            this.buttonGU.Primary = true;
            this.buttonGU.Size = new System.Drawing.Size(179, 29);
            this.buttonGU.TabIndex = 16;
            this.buttonGU.Text = "Usuarios";
            this.buttonGU.UseVisualStyleBackColor = true;
            this.buttonGU.Click += new System.EventHandler(this.buttonGU_Click);
            // 
            // empresaLabel
            // 
            this.empresaLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empresaLabel.Image = global::Listado.Properties.Resources.empresa;
            this.empresaLabel.Location = new System.Drawing.Point(260, 99);
            this.empresaLabel.Name = "empresaLabel";
            this.empresaLabel.Size = new System.Drawing.Size(57, 55);
            this.empresaLabel.TabIndex = 67;
            // 
            // usuariosLabel
            // 
            this.usuariosLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usuariosLabel.Image = global::Listado.Properties.Resources.usuarios;
            this.usuariosLabel.Location = new System.Drawing.Point(260, 222);
            this.usuariosLabel.Name = "usuariosLabel";
            this.usuariosLabel.Size = new System.Drawing.Size(57, 55);
            this.usuariosLabel.TabIndex = 66;
            // 
            // loginBotton
            // 
            this.loginBotton.BackColor = System.Drawing.Color.Transparent;
            this.loginBotton.BackgroundImage = global::Listado.Properties.Resources.cerrar_sesion;
            this.loginBotton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.loginBotton.FlatAppearance.BorderSize = 0;
            this.loginBotton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBotton.Location = new System.Drawing.Point(556, 73);
            this.loginBotton.Name = "loginBotton";
            this.loginBotton.Size = new System.Drawing.Size(34, 32);
            this.loginBotton.TabIndex = 59;
            this.loginBotton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.loginBotton.UseVisualStyleBackColor = true;
            this.loginBotton.Click += new System.EventHandler(this.loginBotton_Click_1);
            // 
            // noteButton
            // 
            this.noteButton.BackgroundImage = global::Listado.Properties.Resources.notepad;
            this.noteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.noteButton.FlatAppearance.BorderSize = 0;
            this.noteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noteButton.Location = new System.Drawing.Point(552, 259);
            this.noteButton.Name = "noteButton";
            this.noteButton.Size = new System.Drawing.Size(36, 32);
            this.noteButton.TabIndex = 18;
            this.noteButton.UseVisualStyleBackColor = true;
            // 
            // edgeButton
            // 
            this.edgeButton.BackgroundImage = global::Listado.Properties.Resources.medge;
            this.edgeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.edgeButton.FlatAppearance.BorderSize = 0;
            this.edgeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edgeButton.Location = new System.Drawing.Point(552, 335);
            this.edgeButton.Name = "edgeButton";
            this.edgeButton.Size = new System.Drawing.Size(36, 32);
            this.edgeButton.TabIndex = 14;
            this.edgeButton.UseVisualStyleBackColor = true;
            // 
            // chromeButton
            // 
            this.chromeButton.BackgroundImage = global::Listado.Properties.Resources.chrome;
            this.chromeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chromeButton.FlatAppearance.BorderSize = 0;
            this.chromeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chromeButton.Location = new System.Drawing.Point(552, 297);
            this.chromeButton.Name = "chromeButton";
            this.chromeButton.Size = new System.Drawing.Size(36, 32);
            this.chromeButton.TabIndex = 13;
            this.chromeButton.UseVisualStyleBackColor = true;
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 380);
            this.ControlBox = false;
            this.Controls.Add(this.empresaLabel);
            this.Controls.Add(this.usuariosLabel);
            this.Controls.Add(this.loginBotton);
            this.Controls.Add(this.noteButton);
            this.Controls.Add(this.buttonGU);
            this.Controls.Add(this.buttonGE);
            this.Controls.Add(this.edgeButton);
            this.Controls.Add(this.chromeButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PantallaPrincipal";
            this.Load += new System.EventHandler(this.PantallaPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button edgeButton;
        private System.Windows.Forms.Button chromeButton;
        private MaterialSkin.Controls.MaterialRaisedButton buttonGE;
        private MaterialSkin.Controls.MaterialRaisedButton buttonGU;
        private System.Windows.Forms.Button noteButton;
        private System.Windows.Forms.Button loginBotton;
        private System.Windows.Forms.Label usuariosLabel;
        private System.Windows.Forms.Label empresaLabel;
    }
}

