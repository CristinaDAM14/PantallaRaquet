
namespace RaquetZone.formularios.Rol2
{
    partial class GestionProductos
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
            this.buttonAP = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonLP = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // buttonAP
            // 
            this.buttonAP.Depth = 0;
            this.buttonAP.Location = new System.Drawing.Point(209, 116);
            this.buttonAP.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAP.Name = "buttonAP";
            this.buttonAP.Primary = true;
            this.buttonAP.Size = new System.Drawing.Size(210, 54);
            this.buttonAP.TabIndex = 8;
            this.buttonAP.Text = "Añadir Productos";
            this.buttonAP.UseVisualStyleBackColor = true;
            this.buttonAP.Click += new System.EventHandler(this.buttonAP_Click);
            // 
            // buttonLP
            // 
            this.buttonLP.Depth = 0;
            this.buttonLP.Location = new System.Drawing.Point(209, 224);
            this.buttonLP.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonLP.Name = "buttonLP";
            this.buttonLP.Primary = true;
            this.buttonLP.Size = new System.Drawing.Size(210, 54);
            this.buttonLP.TabIndex = 7;
            this.buttonLP.Text = "Listado de Productos";
            this.buttonLP.UseVisualStyleBackColor = true;
            this.buttonLP.Click += new System.EventHandler(this.buttonLP_Click);
            // 
            // GestionProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.buttonAP);
            this.Controls.Add(this.buttonLP);
            this.Name = "GestionProductos";
            this.Text = "Gestión de Productos";
            this.Load += new System.EventHandler(this.GestionProductos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton buttonAP;
        private MaterialSkin.Controls.MaterialRaisedButton buttonLP;
    }
}