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
            this.buttonLU = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonAU = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // buttonLU
            // 
            this.buttonLU.Depth = 0;
            this.buttonLU.Location = new System.Drawing.Point(197, 232);
            this.buttonLU.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonLU.Name = "buttonLU";
            this.buttonLU.Primary = true;
            this.buttonLU.Size = new System.Drawing.Size(210, 54);
            this.buttonLU.TabIndex = 3;
            this.buttonLU.Text = "Listado de Usuarios";
            this.buttonLU.UseVisualStyleBackColor = true;
            this.buttonLU.Click += new System.EventHandler(this.buttonLU_Click_1);
            // 
            // buttonAU
            // 
            this.buttonAU.Depth = 0;
            this.buttonAU.Location = new System.Drawing.Point(197, 124);
            this.buttonAU.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAU.Name = "buttonAU";
            this.buttonAU.Primary = true;
            this.buttonAU.Size = new System.Drawing.Size(210, 54);
            this.buttonAU.TabIndex = 4;
            this.buttonAU.Text = "Añadir Usuario";
            this.buttonAU.UseVisualStyleBackColor = true;
            this.buttonAU.Click += new System.EventHandler(this.buttonAU_Click_1);
            // 
            // GestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.buttonAU);
            this.Controls.Add(this.buttonLU);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "GestionUsuarios";
            this.Text = "Gestión de Usuarios";
            this.Load += new System.EventHandler(this.GestionUsuarios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton buttonLU;
        private MaterialSkin.Controls.MaterialRaisedButton buttonAU;
    }
}