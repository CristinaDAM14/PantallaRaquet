namespace RaquetZone.formularios
{
    partial class GestionEmpresas
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
            this.buttonAE = new System.Windows.Forms.Button();
            this.buttonLE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAE
            // 
            this.buttonAE.Location = new System.Drawing.Point(196, 96);
            this.buttonAE.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAE.Name = "buttonAE";
            this.buttonAE.Size = new System.Drawing.Size(210, 48);
            this.buttonAE.TabIndex = 1;
            this.buttonAE.Text = "Añadir Empresa";
            this.buttonAE.UseVisualStyleBackColor = true;
            this.buttonAE.Click += new System.EventHandler(this.buttonAE_Click);
            // 
            // buttonLE
            // 
            this.buttonLE.Location = new System.Drawing.Point(196, 205);
            this.buttonLE.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLE.Name = "buttonLE";
            this.buttonLE.Size = new System.Drawing.Size(210, 48);
            this.buttonLE.TabIndex = 2;
            this.buttonLE.Text = "Listado de Empresas";
            this.buttonLE.UseVisualStyleBackColor = true;
            this.buttonLE.Click += new System.EventHandler(this.buttonLE_Click);
            // 
            // GestionEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.buttonLE);
            this.Controls.Add(this.buttonAE);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GestionEmpresas";
            this.Text = "GestionEmpresas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAE;
        private System.Windows.Forms.Button buttonLE;
    }
}