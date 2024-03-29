﻿namespace RaquetZone.formularios
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
            this.TextoCIFAnyadir = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.activo = new MaterialSkin.Controls.MaterialLabel();
            this.actiBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // rolCombo
            // 
            this.rolCombo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rolCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rolCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolCombo.FormattingEnabled = true;
            this.rolCombo.Items.AddRange(new object[] {
            "Empleado",
            "Administrador",
            "SuperAdmin"});
            this.rolCombo.Location = new System.Drawing.Point(413, 282);
            this.rolCombo.Name = "rolCombo";
            this.rolCombo.Size = new System.Drawing.Size(123, 23);
            this.rolCombo.TabIndex = 7;
            // 
            // dniText
            // 
            this.dniText.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.nomText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nomText.Depth = 0;
            this.nomText.Hint = "Nombre";
            this.nomText.Location = new System.Drawing.Point(413, 130);
            this.nomText.MouseState = MaterialSkin.MouseState.HOVER;
            this.nomText.Name = "nomText";
            this.nomText.PasswordChar = '\0';
            this.nomText.SelectedText = "";
            this.nomText.SelectionLength = 0;
            this.nomText.SelectionStart = 0;
            this.nomText.Size = new System.Drawing.Size(341, 23);
            this.nomText.TabIndex = 2;
            this.nomText.UseSystemPasswordChar = false;
            // 
            // passText
            // 
            this.passText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passText.Depth = 0;
            this.passText.Enabled = false;
            this.passText.Hint = "Contraseña";
            this.passText.Location = new System.Drawing.Point(143, 220);
            this.passText.MouseState = MaterialSkin.MouseState.HOVER;
            this.passText.Name = "passText";
            this.passText.PasswordChar = '*';
            this.passText.SelectedText = "";
            this.passText.SelectionLength = 0;
            this.passText.SelectionStart = 0;
            this.passText.Size = new System.Drawing.Size(142, 23);
            this.passText.TabIndex = 3;
            this.passText.UseSystemPasswordChar = false;
            // 
            // telText
            // 
            this.telText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.telText.Depth = 0;
            this.telText.Hint = "Teléfono";
            this.telText.Location = new System.Drawing.Point(631, 220);
            this.telText.MouseState = MaterialSkin.MouseState.HOVER;
            this.telText.Name = "telText";
            this.telText.PasswordChar = '\0';
            this.telText.SelectedText = "";
            this.telText.SelectionLength = 0;
            this.telText.SelectionStart = 0;
            this.telText.Size = new System.Drawing.Size(123, 23);
            this.telText.TabIndex = 6;
            this.telText.UseSystemPasswordChar = false;
            // 
            // emailText
            // 
            this.emailText.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.direccText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.direccText.Depth = 0;
            this.direccText.Hint = "Dirección";
            this.direccText.Location = new System.Drawing.Point(413, 220);
            this.direccText.MouseState = MaterialSkin.MouseState.HOVER;
            this.direccText.Name = "direccText";
            this.direccText.PasswordChar = '\0';
            this.direccText.SelectedText = "";
            this.direccText.SelectionLength = 0;
            this.direccText.SelectionStart = 0;
            this.direccText.Size = new System.Drawing.Size(123, 23);
            this.direccText.TabIndex = 4;
            this.direccText.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(366, 284);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(31, 19);
            this.materialLabel1.TabIndex = 45;
            this.materialLabel1.Text = "Rol";
            // 
            // horasLabel
            // 
            this.horasLabel.AutoSize = true;
            this.horasLabel.Depth = 0;
            this.horasLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.horasLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.horasLabel.Location = new System.Drawing.Point(552, 220);
            this.horasLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.horasLabel.Name = "horasLabel";
            this.horasLabel.Size = new System.Drawing.Size(69, 19);
            this.horasLabel.TabIndex = 44;
            this.horasLabel.Text = "Teléfono";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Depth = 0;
            this.emailLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.emailLabel.Location = new System.Drawing.Point(330, 220);
            this.emailLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(73, 19);
            this.emailLabel.TabIndex = 43;
            this.emailLabel.Text = "Dirección";
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Depth = 0;
            this.nomLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.nomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nomLabel.Location = new System.Drawing.Point(340, 130);
            this.nomLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(63, 19);
            this.nomLabel.TabIndex = 42;
            this.nomLabel.Text = "Nombre";
            // 
            // telLabel
            // 
            this.telLabel.AutoSize = true;
            this.telLabel.Depth = 0;
            this.telLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.telLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.telLabel.Location = new System.Drawing.Point(77, 286);
            this.telLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.telLabel.Name = "telLabel";
            this.telLabel.Size = new System.Drawing.Size(47, 19);
            this.telLabel.TabIndex = 41;
            this.telLabel.Text = "Email";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Depth = 0;
            this.passLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.passLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.passLabel.Location = new System.Drawing.Point(38, 220);
            this.passLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(86, 19);
            this.passLabel.TabIndex = 40;
            this.passLabel.Text = "Contraseña";
            // 
            // dniLabel
            // 
            this.dniLabel.AutoSize = true;
            this.dniLabel.Depth = 0;
            this.dniLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.dniLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dniLabel.Location = new System.Drawing.Point(90, 130);
            this.dniLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.dniLabel.Name = "dniLabel";
            this.dniLabel.Size = new System.Drawing.Size(34, 19);
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
            this.bVolver.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.editarB.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // TextoCIFAnyadir
            // 
            this.TextoCIFAnyadir.Depth = 0;
            this.TextoCIFAnyadir.Enabled = false;
            this.TextoCIFAnyadir.Hint = "";
            this.TextoCIFAnyadir.Location = new System.Drawing.Point(207, 287);
            this.TextoCIFAnyadir.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextoCIFAnyadir.Name = "TextoCIFAnyadir";
            this.TextoCIFAnyadir.PasswordChar = '\0';
            this.TextoCIFAnyadir.SelectedText = "";
            this.TextoCIFAnyadir.SelectionLength = 0;
            this.TextoCIFAnyadir.SelectionStart = 0;
            this.TextoCIFAnyadir.Size = new System.Drawing.Size(64, 23);
            this.TextoCIFAnyadir.TabIndex = 72;
            this.TextoCIFAnyadir.UseSystemPasswordChar = false;
            this.TextoCIFAnyadir.Visible = false;
            // 
            // activo
            // 
            this.activo.AutoSize = true;
            this.activo.Depth = 0;
            this.activo.Font = new System.Drawing.Font("Roboto", 11F);
            this.activo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.activo.Location = new System.Drawing.Point(573, 284);
            this.activo.MouseState = MaterialSkin.MouseState.HOVER;
            this.activo.Name = "activo";
            this.activo.Size = new System.Drawing.Size(52, 19);
            this.activo.TabIndex = 74;
            this.activo.Text = "Activo";
            // 
            // actiBox
            // 
            this.actiBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.actiBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actiBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actiBox.FormattingEnabled = true;
            this.actiBox.Items.AddRange(new object[] {
            "Activo",
            "No Activo"});
            this.actiBox.Location = new System.Drawing.Point(631, 283);
            this.actiBox.Name = "actiBox";
            this.actiBox.Size = new System.Drawing.Size(123, 23);
            this.actiBox.TabIndex = 73;
            // 
            // EditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.activo);
            this.Controls.Add(this.actiBox);
            this.Controls.Add(this.TextoCIFAnyadir);
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
            this.MaximizeBox = false;
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
        public MaterialSkin.Controls.MaterialSingleLineTextField TextoCIFAnyadir;
        private MaterialSkin.Controls.MaterialLabel activo;
        private System.Windows.Forms.ComboBox actiBox;
    }
}