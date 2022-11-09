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
            this.buttonVolver = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonEditar = new MaterialSkin.Controls.MaterialRaisedButton();
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
            this.rolCombo.Location = new System.Drawing.Point(573, 259);
            this.rolCombo.Name = "rolCombo";
            this.rolCombo.Size = new System.Drawing.Size(121, 23);
            this.rolCombo.TabIndex = 7;
            this.rolCombo.Text = "Rol";
            // 
            // dniText
            // 
            this.dniText.Depth = 0;
            this.dniText.Hint = "DNI";
            this.dniText.Location = new System.Drawing.Point(67, 130);
            this.dniText.MouseState = MaterialSkin.MouseState.HOVER;
            this.dniText.Name = "dniText";
            this.dniText.PasswordChar = '\0';
            this.dniText.SelectedText = "";
            this.dniText.SelectionLength = 0;
            this.dniText.SelectionStart = 0;
            this.dniText.Size = new System.Drawing.Size(218, 23);
            this.dniText.TabIndex = 1;
            this.dniText.UseSystemPasswordChar = false;
            // 
            // nomText
            // 
            this.nomText.Depth = 0;
            this.nomText.Hint = "Nombre";
            this.nomText.Location = new System.Drawing.Point(382, 130);
            this.nomText.MouseState = MaterialSkin.MouseState.HOVER;
            this.nomText.Name = "nomText";
            this.nomText.PasswordChar = '\0';
            this.nomText.SelectedText = "";
            this.nomText.SelectionLength = 0;
            this.nomText.SelectionStart = 0;
            this.nomText.Size = new System.Drawing.Size(312, 23);
            this.nomText.TabIndex = 2;
            this.nomText.UseSystemPasswordChar = false;
            // 
            // passText
            // 
            this.passText.Depth = 0;
            this.passText.Hint = "Contraseña";
            this.passText.Location = new System.Drawing.Point(67, 193);
            this.passText.MouseState = MaterialSkin.MouseState.HOVER;
            this.passText.Name = "passText";
            this.passText.PasswordChar = '\0';
            this.passText.SelectedText = "";
            this.passText.SelectionLength = 0;
            this.passText.SelectionStart = 0;
            this.passText.Size = new System.Drawing.Size(218, 23);
            this.passText.TabIndex = 3;
            this.passText.UseSystemPasswordChar = false;
            // 
            // telText
            // 
            this.telText.Depth = 0;
            this.telText.Hint = "Teléfono";
            this.telText.Location = new System.Drawing.Point(382, 260);
            this.telText.MouseState = MaterialSkin.MouseState.HOVER;
            this.telText.Name = "telText";
            this.telText.PasswordChar = '\0';
            this.telText.SelectedText = "";
            this.telText.SelectionLength = 0;
            this.telText.SelectionStart = 0;
            this.telText.Size = new System.Drawing.Size(142, 23);
            this.telText.TabIndex = 6;
            this.telText.UseSystemPasswordChar = false;
            // 
            // emailText
            // 
            this.emailText.Depth = 0;
            this.emailText.Hint = "Email";
            this.emailText.Location = new System.Drawing.Point(67, 260);
            this.emailText.MouseState = MaterialSkin.MouseState.HOVER;
            this.emailText.Name = "emailText";
            this.emailText.PasswordChar = '\0';
            this.emailText.SelectedText = "";
            this.emailText.SelectionLength = 0;
            this.emailText.SelectionStart = 0;
            this.emailText.Size = new System.Drawing.Size(218, 23);
            this.emailText.TabIndex = 5;
            this.emailText.UseSystemPasswordChar = false;
            // 
            // direccText
            // 
            this.direccText.Depth = 0;
            this.direccText.Hint = "Dirección";
            this.direccText.Location = new System.Drawing.Point(382, 193);
            this.direccText.MouseState = MaterialSkin.MouseState.HOVER;
            this.direccText.Name = "direccText";
            this.direccText.PasswordChar = '\0';
            this.direccText.SelectedText = "";
            this.direccText.SelectionLength = 0;
            this.direccText.SelectionStart = 0;
            this.direccText.Size = new System.Drawing.Size(312, 23);
            this.direccText.TabIndex = 4;
            this.direccText.UseSystemPasswordChar = false;
            // 
            // buttonVolver
            // 
            this.buttonVolver.Depth = 0;
            this.buttonVolver.Location = new System.Drawing.Point(162, 362);
            this.buttonVolver.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Primary = true;
            this.buttonVolver.Size = new System.Drawing.Size(123, 38);
            this.buttonVolver.TabIndex = 9;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Depth = 0;
            this.buttonEditar.Location = new System.Drawing.Point(382, 362);
            this.buttonEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Primary = true;
            this.buttonEditar.Size = new System.Drawing.Size(123, 38);
            this.buttonEditar.TabIndex = 8;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // EditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonVolver);
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

        }

        #endregion
        private System.Windows.Forms.ComboBox rolCombo;
        private MaterialSkin.Controls.MaterialSingleLineTextField dniText;
        private MaterialSkin.Controls.MaterialSingleLineTextField nomText;
        private MaterialSkin.Controls.MaterialSingleLineTextField passText;
        private MaterialSkin.Controls.MaterialSingleLineTextField telText;
        private MaterialSkin.Controls.MaterialSingleLineTextField emailText;
        private MaterialSkin.Controls.MaterialSingleLineTextField direccText;
        private MaterialSkin.Controls.MaterialRaisedButton buttonVolver;
        private MaterialSkin.Controls.MaterialRaisedButton buttonEditar;
    }
}