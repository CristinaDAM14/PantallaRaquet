
namespace RaquetZone.formularios.Rol2
{
    partial class GestionCompras
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
            this.buttonAC = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonLFC = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // buttonAC
            // 
            this.buttonAC.Depth = 0;
            this.buttonAC.Location = new System.Drawing.Point(210, 131);
            this.buttonAC.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAC.Name = "buttonAC";
            this.buttonAC.Primary = true;
            this.buttonAC.Size = new System.Drawing.Size(210, 54);
            this.buttonAC.TabIndex = 10;
            this.buttonAC.Text = "Añadir Compra";
            this.buttonAC.UseVisualStyleBackColor = true;
            this.buttonAC.Click += new System.EventHandler(this.buttonAC_Click);
            // 
            // buttonLFC
            // 
            this.buttonLFC.Depth = 0;
            this.buttonLFC.Location = new System.Drawing.Point(210, 239);
            this.buttonLFC.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonLFC.Name = "buttonLFC";
            this.buttonLFC.Primary = true;
            this.buttonLFC.Size = new System.Drawing.Size(210, 54);
            this.buttonLFC.TabIndex = 9;
            this.buttonLFC.Text = "Listado y facturas de compras";
            this.buttonLFC.UseVisualStyleBackColor = true;
            this.buttonLFC.Click += new System.EventHandler(this.buttonLFC_Click);
            // 
            // GestionCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.buttonAC);
            this.Controls.Add(this.buttonLFC);
            this.MaximizeBox = false;
            this.Name = "GestionCompras";
            this.Text = "Gestion de Compras";
            this.Load += new System.EventHandler(this.GestionCompras_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton buttonAC;
        private MaterialSkin.Controls.MaterialRaisedButton buttonLFC;
    }
}