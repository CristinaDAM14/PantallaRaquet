
namespace RaquetZone.formularios.Rol2
{
    partial class AnyadirCliente
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
            this.emailText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.telText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.passText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.nomText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dniText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.bVolver = new System.Windows.Forms.Button();
            this.buttonAnyadir = new System.Windows.Forms.Button();
            this.emailLabel = new MaterialSkin.Controls.MaterialLabel();
            this.nomLabel = new MaterialSkin.Controls.MaterialLabel();
            this.telLabel = new MaterialSkin.Controls.MaterialLabel();
            this.passLabel = new MaterialSkin.Controls.MaterialLabel();
            this.dniLabel = new MaterialSkin.Controls.MaterialLabel();
            this.TextoCIFAnyadir = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // emailText
            // 
            this.emailText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emailText.Depth = 0;
            this.emailText.Hint = "Email";
            this.emailText.Location = new System.Drawing.Point(472, 219);
            this.emailText.MouseState = MaterialSkin.MouseState.HOVER;
            this.emailText.Name = "emailText";
            this.emailText.PasswordChar = '\0';
            this.emailText.SelectedText = "";
            this.emailText.SelectionLength = 0;
            this.emailText.SelectionStart = 0;
            this.emailText.Size = new System.Drawing.Size(261, 23);
            this.emailText.TabIndex = 13;
            this.emailText.UseSystemPasswordChar = false;
            // 
            // telText
            // 
            this.telText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.telText.Depth = 0;
            this.telText.Hint = "Teléfono";
            this.telText.Location = new System.Drawing.Point(133, 286);
            this.telText.MouseState = MaterialSkin.MouseState.HOVER;
            this.telText.Name = "telText";
            this.telText.PasswordChar = '\0';
            this.telText.SelectedText = "";
            this.telText.SelectionLength = 0;
            this.telText.SelectionStart = 0;
            this.telText.Size = new System.Drawing.Size(191, 23);
            this.telText.TabIndex = 14;
            this.telText.UseSystemPasswordChar = false;
            // 
            // passText
            // 
            this.passText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passText.Depth = 0;
            this.passText.Hint = "Contraseña";
            this.passText.Location = new System.Drawing.Point(133, 219);
            this.passText.MouseState = MaterialSkin.MouseState.HOVER;
            this.passText.Name = "passText";
            this.passText.PasswordChar = '\0';
            this.passText.SelectedText = "";
            this.passText.SelectionLength = 0;
            this.passText.SelectionStart = 0;
            this.passText.Size = new System.Drawing.Size(191, 23);
            this.passText.TabIndex = 12;
            this.passText.UseSystemPasswordChar = false;
            // 
            // nomText
            // 
            this.nomText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nomText.Depth = 0;
            this.nomText.Hint = "Nombre";
            this.nomText.Location = new System.Drawing.Point(472, 130);
            this.nomText.MouseState = MaterialSkin.MouseState.HOVER;
            this.nomText.Name = "nomText";
            this.nomText.PasswordChar = '\0';
            this.nomText.SelectedText = "";
            this.nomText.SelectionLength = 0;
            this.nomText.SelectionStart = 0;
            this.nomText.Size = new System.Drawing.Size(261, 23);
            this.nomText.TabIndex = 11;
            this.nomText.UseSystemPasswordChar = false;
            // 
            // dniText
            // 
            this.dniText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dniText.Depth = 0;
            this.dniText.Hint = "DNI";
            this.dniText.Location = new System.Drawing.Point(133, 130);
            this.dniText.MouseState = MaterialSkin.MouseState.HOVER;
            this.dniText.Name = "dniText";
            this.dniText.PasswordChar = '\0';
            this.dniText.SelectedText = "";
            this.dniText.SelectionLength = 0;
            this.dniText.SelectionStart = 0;
            this.dniText.Size = new System.Drawing.Size(191, 23);
            this.dniText.TabIndex = 10;
            this.dniText.UseSystemPasswordChar = false;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = null;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-7, 177);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(820, 10);
            this.materialTabSelector1.TabIndex = 43;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // bVolver
            // 
            this.bVolver.BackColor = System.Drawing.Color.Transparent;
            this.bVolver.BackgroundImage = global::Listado.Properties.Resources.icono_volver;
            this.bVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bVolver.FlatAppearance.BorderSize = 0;
            this.bVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVolver.Location = new System.Drawing.Point(279, 360);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(45, 40);
            this.bVolver.TabIndex = 17;
            this.bVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // buttonAnyadir
            // 
            this.buttonAnyadir.BackColor = System.Drawing.Color.Transparent;
            this.buttonAnyadir.BackgroundImage = global::Listado.Properties.Resources.añadir_blanco;
            this.buttonAnyadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAnyadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAnyadir.FlatAppearance.BorderSize = 0;
            this.buttonAnyadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnyadir.Location = new System.Drawing.Point(421, 362);
            this.buttonAnyadir.Name = "buttonAnyadir";
            this.buttonAnyadir.Size = new System.Drawing.Size(45, 40);
            this.buttonAnyadir.TabIndex = 16;
            this.buttonAnyadir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAnyadir.UseVisualStyleBackColor = true;
            this.buttonAnyadir.Click += new System.EventHandler(this.buttonAnyadir_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Depth = 0;
            this.emailLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.emailLabel.Location = new System.Drawing.Point(419, 219);
            this.emailLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(47, 19);
            this.emailLabel.TabIndex = 79;
            this.emailLabel.Text = "Email";
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Depth = 0;
            this.nomLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.nomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nomLabel.Location = new System.Drawing.Point(403, 132);
            this.nomLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(63, 19);
            this.nomLabel.TabIndex = 78;
            this.nomLabel.Text = "Nombre";
            // 
            // telLabel
            // 
            this.telLabel.AutoSize = true;
            this.telLabel.Depth = 0;
            this.telLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.telLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.telLabel.Location = new System.Drawing.Point(58, 286);
            this.telLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.telLabel.Name = "telLabel";
            this.telLabel.Size = new System.Drawing.Size(69, 19);
            this.telLabel.TabIndex = 77;
            this.telLabel.Text = "Teléfono";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Depth = 0;
            this.passLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.passLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.passLabel.Location = new System.Drawing.Point(41, 219);
            this.passLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(86, 19);
            this.passLabel.TabIndex = 76;
            this.passLabel.Text = "Contraseña";
            // 
            // dniLabel
            // 
            this.dniLabel.AutoSize = true;
            this.dniLabel.Depth = 0;
            this.dniLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.dniLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dniLabel.Location = new System.Drawing.Point(93, 132);
            this.dniLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.dniLabel.Name = "dniLabel";
            this.dniLabel.Size = new System.Drawing.Size(34, 19);
            this.dniLabel.TabIndex = 75;
            this.dniLabel.Text = "DNI";
            // 
            // TextoCIFAnyadir
            // 
            this.TextoCIFAnyadir.Depth = 0;
            this.TextoCIFAnyadir.Enabled = false;
            this.TextoCIFAnyadir.Hint = "";
            this.TextoCIFAnyadir.Location = new System.Drawing.Point(423, 286);
            this.TextoCIFAnyadir.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextoCIFAnyadir.Name = "TextoCIFAnyadir";
            this.TextoCIFAnyadir.PasswordChar = '\0';
            this.TextoCIFAnyadir.SelectedText = "";
            this.TextoCIFAnyadir.SelectionLength = 0;
            this.TextoCIFAnyadir.SelectionStart = 0;
            this.TextoCIFAnyadir.Size = new System.Drawing.Size(64, 23);
            this.TextoCIFAnyadir.TabIndex = 80;
            this.TextoCIFAnyadir.UseSystemPasswordChar = false;
            this.TextoCIFAnyadir.Visible = false;
            // 
            // AnyadirCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextoCIFAnyadir);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nomLabel);
            this.Controls.Add(this.telLabel);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.dniLabel);
            this.Controls.Add(this.buttonAnyadir);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.telText);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.nomText);
            this.Controls.Add(this.dniText);
            this.MaximizeBox = false;
            this.Name = "AnyadirCliente";
            this.Text = "Añadir Cliente";
            this.Load += new System.EventHandler(this.AnyadirCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField emailText;
        private MaterialSkin.Controls.MaterialSingleLineTextField telText;
        private MaterialSkin.Controls.MaterialSingleLineTextField passText;
        private MaterialSkin.Controls.MaterialSingleLineTextField nomText;
        private MaterialSkin.Controls.MaterialSingleLineTextField dniText;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Button buttonAnyadir;
        private MaterialSkin.Controls.MaterialLabel emailLabel;
        private MaterialSkin.Controls.MaterialLabel nomLabel;
        private MaterialSkin.Controls.MaterialLabel telLabel;
        private MaterialSkin.Controls.MaterialLabel passLabel;
        private MaterialSkin.Controls.MaterialLabel dniLabel;
        public MaterialSkin.Controls.MaterialSingleLineTextField TextoCIFAnyadir;
    }
}