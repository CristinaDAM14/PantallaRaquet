
namespace RaquetZone.formularios
{
    partial class ComprobarCorreo
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dniText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.emailText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonEnviar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.bVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(55, 95);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(240, 38);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Escribe tus datos para recuperar la contraseña";
            // 
            // dniText
            // 
            this.dniText.Depth = 0;
            this.dniText.Hint = "DNI";
            this.dniText.Location = new System.Drawing.Point(59, 159);
            this.dniText.MouseState = MaterialSkin.MouseState.HOVER;
            this.dniText.Name = "dniText";
            this.dniText.PasswordChar = '\0';
            this.dniText.SelectedText = "";
            this.dniText.SelectionLength = 0;
            this.dniText.SelectionStart = 0;
            this.dniText.Size = new System.Drawing.Size(269, 23);
            this.dniText.TabIndex = 1;
            this.dniText.UseSystemPasswordChar = false;
            // 
            // emailText
            // 
            this.emailText.Depth = 0;
            this.emailText.Hint = "Email";
            this.emailText.Location = new System.Drawing.Point(59, 205);
            this.emailText.MouseState = MaterialSkin.MouseState.HOVER;
            this.emailText.Name = "emailText";
            this.emailText.PasswordChar = '\0';
            this.emailText.SelectedText = "";
            this.emailText.SelectionLength = 0;
            this.emailText.SelectionStart = 0;
            this.emailText.Size = new System.Drawing.Size(269, 23);
            this.emailText.TabIndex = 3;
            this.emailText.UseSystemPasswordChar = false;
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Depth = 0;
            this.buttonEnviar.Location = new System.Drawing.Point(246, 259);
            this.buttonEnviar.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Primary = true;
            this.buttonEnviar.Size = new System.Drawing.Size(82, 38);
            this.buttonEnviar.TabIndex = 4;
            this.buttonEnviar.Text = "Enviar";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            this.buttonEnviar.Click += new System.EventHandler(this.buttonEnviar_Click);
            // 
            // bVolver
            // 
            this.bVolver.BackColor = System.Drawing.Color.Transparent;
            this.bVolver.BackgroundImage = global::Listado.Properties.Resources.icono_volver;
            this.bVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bVolver.FlatAppearance.BorderSize = 0;
            this.bVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVolver.Location = new System.Drawing.Point(100, 257);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(45, 40);
            this.bVolver.TabIndex = 61;
            this.bVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // ComprobarCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 340);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.buttonEnviar);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.dniText);
            this.Controls.Add(this.materialLabel1);
            this.Name = "ComprobarCorreo";
            this.Text = "Recuperar Contraseña";
            this.Load += new System.EventHandler(this.ComprobarCorreo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField dniText;
        private MaterialSkin.Controls.MaterialSingleLineTextField emailText;
        private MaterialSkin.Controls.MaterialRaisedButton buttonEnviar;
        private System.Windows.Forms.Button bVolver;
    }
}