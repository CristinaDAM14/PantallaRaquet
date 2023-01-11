
namespace RaquetZone.formularios.Rol2
{
    partial class GestionServicios
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
            this.buttonAS = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonLS = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // buttonAS
            // 
            this.buttonAS.Depth = 0;
            this.buttonAS.Location = new System.Drawing.Point(195, 121);
            this.buttonAS.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAS.Name = "buttonAS";
            this.buttonAS.Primary = true;
            this.buttonAS.Size = new System.Drawing.Size(210, 54);
            this.buttonAS.TabIndex = 12;
            this.buttonAS.Text = "Añadir Servicios";
            this.buttonAS.UseVisualStyleBackColor = true;
            this.buttonAS.Click += new System.EventHandler(this.buttonAS_Click);
            // 
            // buttonLS
            // 
            this.buttonLS.Depth = 0;
            this.buttonLS.Location = new System.Drawing.Point(195, 229);
            this.buttonLS.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonLS.Name = "buttonLS";
            this.buttonLS.Primary = true;
            this.buttonLS.Size = new System.Drawing.Size(210, 54);
            this.buttonLS.TabIndex = 11;
            this.buttonLS.Text = "Listado de Servicios";
            this.buttonLS.UseVisualStyleBackColor = true;
            this.buttonLS.Click += new System.EventHandler(this.buttonLS_Click);
            // 
            // GestionServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.buttonAS);
            this.Controls.Add(this.buttonLS);
            this.Name = "GestionServicios";
            this.Text = "Gestion de Servicios";
            this.Load += new System.EventHandler(this.GestionServicios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton buttonAS;
        private MaterialSkin.Controls.MaterialRaisedButton buttonLS;
    }
}