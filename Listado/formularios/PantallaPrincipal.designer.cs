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
            this.buttonGU = new System.Windows.Forms.Button();
            this.buttonGE = new System.Windows.Forms.Button();
            this.loginBotton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGU
            // 
            this.buttonGU.Location = new System.Drawing.Point(207, 99);
            this.buttonGU.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGU.Name = "buttonGU";
            this.buttonGU.Size = new System.Drawing.Size(210, 48);
            this.buttonGU.TabIndex = 0;
            this.buttonGU.Text = "Gestionar Usuarios";
            this.buttonGU.UseVisualStyleBackColor = true;
            this.buttonGU.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonGE
            // 
            this.buttonGE.Location = new System.Drawing.Point(207, 205);
            this.buttonGE.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGE.Name = "buttonGE";
            this.buttonGE.Size = new System.Drawing.Size(210, 48);
            this.buttonGE.TabIndex = 1;
            this.buttonGE.Text = "Gestionar Empresas";
            this.buttonGE.UseVisualStyleBackColor = true;
            this.buttonGE.Click += new System.EventHandler(this.button2_Click);
            // 
            // loginBotton
            // 
            this.loginBotton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBotton.Location = new System.Drawing.Point(459, 12);
            this.loginBotton.Name = "loginBotton";
            this.loginBotton.Size = new System.Drawing.Size(129, 33);
            this.loginBotton.TabIndex = 4;
            this.loginBotton.Text = "Cerrar sesión";
            this.loginBotton.UseVisualStyleBackColor = true;
            this.loginBotton.Click += new System.EventHandler(this.loginBotton_Click);
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.loginBotton);
            this.Controls.Add(this.buttonGE);
            this.Controls.Add(this.buttonGU);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PantallaPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PantallaPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGU;
        private System.Windows.Forms.Button buttonGE;
        private System.Windows.Forms.Button loginBotton;
    }
}

