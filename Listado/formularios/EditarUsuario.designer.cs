namespace RaquetZone.formularios
{
    partial class EditarUsuario
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
            this.rolCombo = new System.Windows.Forms.ComboBox();
            this.dniText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.nomText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.passText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.telText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.emailText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.direccText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.horasLabel = new MaterialSkin.Controls.MaterialLabel();
            this.emailLabel = new MaterialSkin.Controls.MaterialLabel();
            this.nomLabel = new MaterialSkin.Controls.MaterialLabel();
            this.telLabel = new MaterialSkin.Controls.MaterialLabel();
            this.passLabel = new MaterialSkin.Controls.MaterialLabel();
            this.dniLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.bVolver = new System.Windows.Forms.Button();
            this.editarB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rolCombo
            // 
            this.rolCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolCombo.FormattingEnabled = true;
            this.rolCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.rolCombo.Location = new System.Drawing.Point(603, 285);
            this.rolCombo.Name = "rolCombo";
            this.rolCombo.Size = new System.Drawing.Size(91, 23);
            this.rolCombo.TabIndex = 7;
            this.rolCombo.Text = "Rol";
            // 
            // dniText
            // 
            this.dniText.Depth = 0;
            this.dniText.Enabled = false;
            this.dniText.Hint = "DNI";
            this.dniText.Location = new System.Drawing.Point(143, 130);
            this.dniText.MouseState = MaterialSkin.MouseState.HOVER;
            this.dniText.Name = "dniText";
            this.dniText.PasswordChar = '\0';
            this.dniText.SelectedText = "";
            this.dniText.SelectionLength = 0;
            this.dniText.SelectionStart = 0;
            this.dniText.Size = new System.Drawing.Size(142, 23);
            this.dniText.TabIndex = 1;
            this.dniText.UseSystemPasswordChar = false;
            // 
            // nomText
            // 
            this.nomText.Depth = 0;
            this.nomText.Hint = "Nombre";
            this.nomText.Location = new System.Drawing.Point(431, 130);
            this.nomText.MouseState = MaterialSkin.MouseState.HOVER;
            this.nomText.Name = "nomText";
            this.nomText.PasswordChar = '\0';
            this.nomText.SelectedText = "";
            this.nomText.SelectionLength = 0;
            this.nomText.SelectionStart = 0;
            this.nomText.Size = new System.Drawing.Size(263, 23);
            this.nomText.TabIndex = 2;
            this.nomText.UseSystemPasswordChar = false;
            // 
            // passText
            // 
            this.passText.Depth = 0;
            this.passText.Hint = "Contraseña";
            this.passText.Location = new System.Drawing.Point(143, 220);
            this.passText.MouseState = MaterialSkin.MouseState.HOVER;
            this.passText.Name = "passText";
            this.passText.PasswordChar = '\0';
            this.passText.SelectedText = "";
            this.passText.SelectionLength = 0;
            this.passText.SelectionStart = 0;
            this.passText.Size = new System.Drawing.Size(142, 23);
            this.passText.TabIndex = 3;
            this.passText.UseSystemPasswordChar = false;
            // 
            // telText
            // 
            this.telText.Depth = 0;
            this.telText.Hint = "Teléfono";
            this.telText.Location = new System.Drawing.Point(431, 286);
            this.telText.MouseState = MaterialSkin.MouseState.HOVER;
            this.telText.Name = "telText";
            this.telText.PasswordChar = '\0';
            this.telText.SelectedText = "";
            this.telText.SelectionLength = 0;
            this.telText.SelectionStart = 0;
            this.telText.Size = new System.Drawing.Size(93, 23);
            this.telText.TabIndex = 6;
            this.telText.UseSystemPasswordChar = false;
            // 
            // emailText
            // 
            this.emailText.Depth = 0;
            this.emailText.Hint = "Email";
            this.emailText.Location = new System.Drawing.Point(143, 287);
            this.emailText.MouseState = MaterialSkin.MouseState.HOVER;
            this.emailText.Name = "emailText";
            this.emailText.PasswordChar = '\0';
            this.emailText.SelectedText = "";
            this.emailText.SelectionLength = 0;
            this.emailText.SelectionStart = 0;
            this.emailText.Size = new System.Drawing.Size(142, 23);
            this.emailText.TabIndex = 5;
            this.emailText.UseSystemPasswordChar = false;
            // 
            // direccText
            // 
            this.direccText.Depth = 0;
            this.direccText.Hint = "Dirección";
            this.direccText.Location = new System.Drawing.Point(431, 220);
            this.direccText.MouseState = MaterialSkin.MouseState.HOVER;
            this.direccText.Name = "direccText";
            this.direccText.PasswordChar = '\0';
            this.direccText.SelectedText = "";
            this.direccText.SelectionLength = 0;
            this.direccText.SelectionStart = 0;
            this.direccText.Size = new System.Drawing.Size(263, 23);
            this.direccText.TabIndex = 4;
            this.direccText.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(556, 287);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(31, 18);
            this.materialLabel1.TabIndex = 45;
            this.materialLabel1.Text = "Rol";
            // 
            // horasLabel
            // 
            this.horasLabel.AutoSize = true;
            this.horasLabel.Depth = 0;
            this.horasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.horasLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.horasLabel.Location = new System.Drawing.Point(352, 286);
            this.horasLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.horasLabel.Name = "horasLabel";
            this.horasLabel.Size = new System.Drawing.Size(66, 18);
            this.horasLabel.TabIndex = 44;
            this.horasLabel.Text = "Teléfono";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Depth = 0;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.emailLabel.Location = new System.Drawing.Point(348, 220);
            this.emailLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(71, 18);
            this.emailLabel.TabIndex = 43;
            this.emailLabel.Text = "Dirección";
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Depth = 0;
            this.nomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nomLabel.Location = new System.Drawing.Point(358, 130);
            this.nomLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(62, 18);
            this.nomLabel.TabIndex = 42;
            this.nomLabel.Text = "Nombre";
            // 
            // telLabel
            // 
            this.telLabel.AutoSize = true;
            this.telLabel.Depth = 0;
            this.telLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.telLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.telLabel.Location = new System.Drawing.Point(77, 286);
            this.telLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.telLabel.Name = "telLabel";
            this.telLabel.Size = new System.Drawing.Size(45, 18);
            this.telLabel.TabIndex = 41;
            this.telLabel.Text = "Email";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Depth = 0;
            this.passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.passLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.passLabel.Location = new System.Drawing.Point(38, 220);
            this.passLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(85, 18);
            this.passLabel.TabIndex = 40;
            this.passLabel.Text = "Contraseña";
            // 
            // dniLabel
            // 
            this.dniLabel.AutoSize = true;
            this.dniLabel.Depth = 0;
            this.dniLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dniLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dniLabel.Location = new System.Drawing.Point(90, 130);
            this.dniLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.dniLabel.Name = "dniLabel";
            this.dniLabel.Size = new System.Drawing.Size(33, 18);
            this.dniLabel.TabIndex = 39;
            this.dniLabel.Text = "DNI";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = null;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(22, 180);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(732, 10);
            this.materialTabSelector1.TabIndex = 46;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabSelector2
            // 
            this.materialTabSelector2.BaseTabControl = null;
            this.materialTabSelector2.Depth = 0;
            this.materialTabSelector2.Location = new System.Drawing.Point(-5, 180);
            this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            this.materialTabSelector2.Size = new System.Drawing.Size(816, 10);
            this.materialTabSelector2.TabIndex = 47;
            this.materialTabSelector2.Text = "materialTabSelector2";
            // 
            // bVolver
            // 
            this.bVolver.BackColor = System.Drawing.Color.Transparent;
            this.bVolver.BackgroundImage = global::Listado.Properties.Resources.icono_volver;
            this.bVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bVolver.FlatAppearance.BorderSize = 0;
            this.bVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVolver.Location = new System.Drawing.Point(240, 360);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(45, 40);
            this.bVolver.TabIndex = 60;
            this.bVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // editarB
            // 
            this.editarB.BackColor = System.Drawing.Color.Transparent;
            this.editarB.BackgroundImage = global::Listado.Properties.Resources.actualizar;
            this.editarB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editarB.FlatAppearance.BorderSize = 0;
            this.editarB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarB.Location = new System.Drawing.Point(431, 360);
            this.editarB.Name = "editarB";
            this.editarB.Size = new System.Drawing.Size(45, 40);
            this.editarB.TabIndex = 71;
            this.editarB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.editarB.UseVisualStyleBackColor = true;
            this.editarB.Click += new System.EventHandler(this.editarB_Click);
            // 
            // EditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editarB);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.materialTabSelector2);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.horasLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nomLabel);
            this.Controls.Add(this.telLabel);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.dniLabel);
            this.Controls.Add(this.direccText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.telText);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.nomText);
            this.Controls.Add(this.dniText);
            this.Controls.Add(this.rolCombo);
            this.Name = "EditarUsuario";
            this.Text = "Editar Usuario";
            this.Load += new System.EventHandler(this.EditarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox rolCombo;
        private MaterialSkin.Controls.MaterialSingleLineTextField dniText;
        private MaterialSkin.Controls.MaterialSingleLineTextField nomText;
        private MaterialSkin.Controls.MaterialSingleLineTextField passText;
        private MaterialSkin.Controls.MaterialSingleLineTextField telText;
        private MaterialSkin.Controls.MaterialSingleLineTextField emailText;
        private MaterialSkin.Controls.MaterialSingleLineTextField direccText;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel horasLabel;
        private MaterialSkin.Controls.MaterialLabel emailLabel;
        private MaterialSkin.Controls.MaterialLabel nomLabel;
        private MaterialSkin.Controls.MaterialLabel telLabel;
        private MaterialSkin.Controls.MaterialLabel passLabel;
        private MaterialSkin.Controls.MaterialLabel dniLabel;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Button editarB;
    }
}