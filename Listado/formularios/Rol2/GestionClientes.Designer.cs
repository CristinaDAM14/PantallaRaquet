
namespace RaquetZone.formularios.Rol2
{
    partial class GestionClientes
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
            this.buttonAE = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonLE = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // buttonAE
            // 
            this.buttonAE.Depth = 0;
            this.buttonAE.Location = new System.Drawing.Point(206, 121);
            this.buttonAE.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAE.Name = "buttonAE";
            this.buttonAE.Primary = true;
            this.buttonAE.Size = new System.Drawing.Size(210, 54);
            this.buttonAE.TabIndex = 8;
            this.buttonAE.Text = "Añadir Cliente";
            this.buttonAE.UseVisualStyleBackColor = true;
            this.buttonAE.Click += new System.EventHandler(this.buttonAE_Click);
            // 
            // buttonLE
            // 
            this.buttonLE.Depth = 0;
            this.buttonLE.Location = new System.Drawing.Point(206, 229);
            this.buttonLE.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonLE.Name = "buttonLE";
            this.buttonLE.Primary = true;
            this.buttonLE.Size = new System.Drawing.Size(210, 54);
            this.buttonLE.TabIndex = 7;
            this.buttonLE.Text = "Listado de Clientes";
            this.buttonLE.UseVisualStyleBackColor = true;
            this.buttonLE.Click += new System.EventHandler(this.buttonLE_Click);
            // 
            // GestionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.buttonAE);
            this.Controls.Add(this.buttonLE);
            this.Name = "GestionClientes";
            this.Text = "Gestión de Clientes";
            this.Load += new System.EventHandler(this.GestionClientes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton buttonAE;
        private MaterialSkin.Controls.MaterialRaisedButton buttonLE;
    }
}