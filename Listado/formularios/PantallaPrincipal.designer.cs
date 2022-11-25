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
            this.edgeButton = new System.Windows.Forms.Button();
            this.chromeButton = new System.Windows.Forms.Button();
            this.buttonGE = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonGU = new MaterialSkin.Controls.MaterialRaisedButton();
            this.loginBotton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.noteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // edgeButton
            // 
            this.edgeButton.BackgroundImage = global::Listado.Properties.Resources.medge;
            this.edgeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.edgeButton.Location = new System.Drawing.Point(545, 336);
            this.edgeButton.Name = "edgeButton";
            this.edgeButton.Size = new System.Drawing.Size(36, 32);
            this.edgeButton.TabIndex = 14;
            this.edgeButton.UseVisualStyleBackColor = true;
            // 
            // chromeButton
            // 
            this.chromeButton.BackgroundImage = global::Listado.Properties.Resources.chrome;
            this.chromeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chromeButton.Location = new System.Drawing.Point(503, 336);
            this.chromeButton.Name = "chromeButton";
            this.chromeButton.Size = new System.Drawing.Size(36, 32);
            this.chromeButton.TabIndex = 13;
            this.chromeButton.UseVisualStyleBackColor = true;
            // 
            // buttonGE
            // 
            this.buttonGE.Depth = 0;
            this.buttonGE.Location = new System.Drawing.Point(191, 226);
            this.buttonGE.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonGE.Name = "buttonGE";
            this.buttonGE.Primary = true;
            this.buttonGE.Size = new System.Drawing.Size(210, 53);
            this.buttonGE.TabIndex = 15;
            this.buttonGE.Text = "Gestionar Empresa";
            this.buttonGE.UseVisualStyleBackColor = true;
            this.buttonGE.Click += new System.EventHandler(this.buttonGE_Click);
            // 
            // buttonGU
            // 
            this.buttonGU.Depth = 0;
            this.buttonGU.Location = new System.Drawing.Point(191, 133);
            this.buttonGU.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonGU.Name = "buttonGU";
            this.buttonGU.Primary = true;
            this.buttonGU.Size = new System.Drawing.Size(210, 53);
            this.buttonGU.TabIndex = 16;
            this.buttonGU.Text = "Gestionar Usuarios";
            this.buttonGU.UseVisualStyleBackColor = true;
            this.buttonGU.Click += new System.EventHandler(this.buttonGU_Click);
            // 
            // loginBotton
            // 
            this.loginBotton.Depth = 0;
            this.loginBotton.Location = new System.Drawing.Point(474, 76);
            this.loginBotton.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginBotton.Name = "loginBotton";
            this.loginBotton.Primary = true;
            this.loginBotton.Size = new System.Drawing.Size(114, 32);
            this.loginBotton.TabIndex = 17;
            this.loginBotton.Text = "Cerrar Sesión";
            this.loginBotton.UseVisualStyleBackColor = true;
            this.loginBotton.Click += new System.EventHandler(this.loginBotton_Click);
            // 
            // noteButton
            // 
            this.noteButton.BackgroundImage = global::Listado.Properties.Resources.notepad;
            this.noteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.noteButton.Location = new System.Drawing.Point(461, 336);
            this.noteButton.Name = "noteButton";
            this.noteButton.Size = new System.Drawing.Size(36, 32);
            this.noteButton.TabIndex = 18;
            this.noteButton.UseVisualStyleBackColor = true;
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 380);
            this.ControlBox = false;
            this.Controls.Add(this.noteButton);
            this.Controls.Add(this.loginBotton);
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
        private MaterialSkin.Controls.MaterialRaisedButton loginBotton;
        private System.Windows.Forms.Button noteButton;
    }
}

