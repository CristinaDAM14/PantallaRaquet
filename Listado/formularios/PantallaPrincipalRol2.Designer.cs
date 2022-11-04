
namespace RaquetZone.formularios
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
            this.loginBotton = new System.Windows.Forms.Button();
            this.buttonGE = new System.Windows.Forms.Button();
            this.buttonGU = new System.Windows.Forms.Button();
            this.gestionProductos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginBotton
            // 
            this.loginBotton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBotton.Location = new System.Drawing.Point(524, 17);
            this.loginBotton.Name = "loginBotton";
            this.loginBotton.Size = new System.Drawing.Size(129, 33);
            this.loginBotton.TabIndex = 7;
            this.loginBotton.Text = "Cerrar sesión";
            this.loginBotton.UseVisualStyleBackColor = true;
            this.loginBotton.Click += new System.EventHandler(this.loginBotton_Click);
            // 
            // buttonGE
            // 
            this.buttonGE.Location = new System.Drawing.Point(98, 109);
            this.buttonGE.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGE.Name = "buttonGE";
            this.buttonGE.Size = new System.Drawing.Size(210, 48);
            this.buttonGE.TabIndex = 6;
            this.buttonGE.Text = "Gestionar Usuario";
            this.buttonGE.UseVisualStyleBackColor = true;
            this.buttonGE.Click += new System.EventHandler(this.buttonGE_Click);
            // 
            // buttonGU
            // 
            this.buttonGU.Location = new System.Drawing.Point(98, 228);
            this.buttonGU.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGU.Name = "buttonGU";
            this.buttonGU.Size = new System.Drawing.Size(210, 48);
            this.buttonGU.TabIndex = 5;
            this.buttonGU.Text = "Gestionar Clientes";
            this.buttonGU.UseVisualStyleBackColor = true;
            // 
            // gestionProductos
            // 
            this.gestionProductos.Location = new System.Drawing.Point(361, 109);
            this.gestionProductos.Margin = new System.Windows.Forms.Padding(2);
            this.gestionProductos.Name = "gestionProductos";
            this.gestionProductos.Size = new System.Drawing.Size(210, 48);
            this.gestionProductos.TabIndex = 8;
            this.gestionProductos.Text = "Gestionar Productos";
            this.gestionProductos.UseVisualStyleBackColor = true;
            // 
            // PantallaPrincipalRol2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 387);
            this.Controls.Add(this.gestionProductos);
            this.Controls.Add(this.loginBotton);
            this.Controls.Add(this.buttonGE);
            this.Controls.Add(this.buttonGU);
            this.Name = "PantallaPrincipalRol2";
            this.Text = "PantallaPrincipalRol2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loginBotton;
        private System.Windows.Forms.Button buttonGE;
        private System.Windows.Forms.Button buttonGU;
        private System.Windows.Forms.Button gestionProductos;
    }
}