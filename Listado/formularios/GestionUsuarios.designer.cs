namespace RaquetZone.formularios
{
    partial class GestionUsuarios
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
            this.buttonAU = new System.Windows.Forms.Button();
            this.buttonLU = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAU
            // 
            this.buttonAU.Location = new System.Drawing.Point(196, 98);
            this.buttonAU.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAU.Name = "buttonAU";
            this.buttonAU.Size = new System.Drawing.Size(210, 48);
            this.buttonAU.TabIndex = 1;
            this.buttonAU.Text = "Añadir Usuario";
            this.buttonAU.UseVisualStyleBackColor = true;
            this.buttonAU.Click += new System.EventHandler(this.buttonAU_Click);
            // 
            // buttonLU
            // 
            this.buttonLU.Location = new System.Drawing.Point(196, 206);
            this.buttonLU.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLU.Name = "buttonLU";
            this.buttonLU.Size = new System.Drawing.Size(210, 48);
            this.buttonLU.TabIndex = 2;
            this.buttonLU.Text = "Listado de Usuarios";
            this.buttonLU.UseVisualStyleBackColor = true;
            this.buttonLU.Click += new System.EventHandler(this.buttonLU_Click);
            // 
            // GestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.buttonLU);
            this.Controls.Add(this.buttonAU);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GestionUsuarios";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.GestionUsuarios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAU;
        private System.Windows.Forms.Button buttonLU;
    }
}