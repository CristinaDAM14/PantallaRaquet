﻿
namespace RaquetZone.formularios.Rol2
{
    partial class EditarClientes
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
            this.buttonEditar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonVolver = new MaterialSkin.Controls.MaterialRaisedButton();
            this.emailText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.telText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.numText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.passText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.nomText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dniText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dniLabel = new MaterialSkin.Controls.MaterialLabel();
            this.passLabel = new MaterialSkin.Controls.MaterialLabel();
            this.telLabel = new MaterialSkin.Controls.MaterialLabel();
            this.nomLabel = new MaterialSkin.Controls.MaterialLabel();
            this.emailLabel = new MaterialSkin.Controls.MaterialLabel();
            this.horasLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.SuspendLayout();
            // 
            // buttonEditar
            // 
            this.buttonEditar.Depth = 0;
            this.buttonEditar.Location = new System.Drawing.Point(418, 356);
            this.buttonEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Primary = true;
            this.buttonEditar.Size = new System.Drawing.Size(123, 38);
            this.buttonEditar.TabIndex = 24;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Depth = 0;
            this.buttonVolver.Location = new System.Drawing.Point(198, 356);
            this.buttonVolver.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Primary = true;
            this.buttonVolver.Size = new System.Drawing.Size(123, 38);
            this.buttonVolver.TabIndex = 25;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // emailText
            // 
            this.emailText.Depth = 0;
            this.emailText.Hint = "Email";
            this.emailText.Location = new System.Drawing.Point(491, 215);
            this.emailText.MouseState = MaterialSkin.MouseState.HOVER;
            this.emailText.Name = "emailText";
            this.emailText.PasswordChar = '\0';
            this.emailText.SelectedText = "";
            this.emailText.SelectionLength = 0;
            this.emailText.SelectionStart = 0;
            this.emailText.Size = new System.Drawing.Size(239, 23);
            this.emailText.TabIndex = 21;
            this.emailText.UseSystemPasswordChar = false;
            // 
            // telText
            // 
            this.telText.Depth = 0;
            this.telText.Hint = "Teléfono";
            this.telText.Location = new System.Drawing.Point(152, 274);
            this.telText.MouseState = MaterialSkin.MouseState.HOVER;
            this.telText.Name = "telText";
            this.telText.PasswordChar = '\0';
            this.telText.SelectedText = "";
            this.telText.SelectionLength = 0;
            this.telText.SelectionStart = 0;
            this.telText.Size = new System.Drawing.Size(169, 23);
            this.telText.TabIndex = 22;
            this.telText.UseSystemPasswordChar = false;
            // 
            // numText
            // 
            this.numText.Depth = 0;
            this.numText.Hint = "Número de horas";
            this.numText.Location = new System.Drawing.Point(491, 270);
            this.numText.MouseState = MaterialSkin.MouseState.HOVER;
            this.numText.Name = "numText";
            this.numText.PasswordChar = '\0';
            this.numText.SelectedText = "";
            this.numText.SelectionLength = 0;
            this.numText.SelectionStart = 0;
            this.numText.Size = new System.Drawing.Size(142, 23);
            this.numText.TabIndex = 23;
            this.numText.UseSystemPasswordChar = false;
            // 
            // passText
            // 
            this.passText.Depth = 0;
            this.passText.Hint = "Contraseña";
            this.passText.Location = new System.Drawing.Point(152, 215);
            this.passText.MouseState = MaterialSkin.MouseState.HOVER;
            this.passText.Name = "passText";
            this.passText.PasswordChar = '\0';
            this.passText.SelectedText = "";
            this.passText.SelectionLength = 0;
            this.passText.SelectionStart = 0;
            this.passText.Size = new System.Drawing.Size(169, 23);
            this.passText.TabIndex = 20;
            this.passText.UseSystemPasswordChar = false;
            // 
            // nomText
            // 
            this.nomText.Depth = 0;
            this.nomText.Hint = "Nombre";
            this.nomText.Location = new System.Drawing.Point(491, 124);
            this.nomText.MouseState = MaterialSkin.MouseState.HOVER;
            this.nomText.Name = "nomText";
            this.nomText.PasswordChar = '\0';
            this.nomText.SelectedText = "";
            this.nomText.SelectionLength = 0;
            this.nomText.SelectionStart = 0;
            this.nomText.Size = new System.Drawing.Size(239, 23);
            this.nomText.TabIndex = 19;
            this.nomText.UseSystemPasswordChar = false;
            // 
            // dniText
            // 
            this.dniText.Depth = 0;
            this.dniText.Enabled = false;
            this.dniText.Hint = "DNI";
            this.dniText.Location = new System.Drawing.Point(152, 124);
            this.dniText.MouseState = MaterialSkin.MouseState.HOVER;
            this.dniText.Name = "dniText";
            this.dniText.PasswordChar = '\0';
            this.dniText.SelectedText = "";
            this.dniText.SelectionLength = 0;
            this.dniText.SelectionStart = 0;
            this.dniText.Size = new System.Drawing.Size(169, 23);
            this.dniText.TabIndex = 18;
            this.dniText.UseSystemPasswordChar = false;
            // 
            // dniLabel
            // 
            this.dniLabel.AutoSize = true;
            this.dniLabel.Depth = 0;
            this.dniLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.dniLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dniLabel.Location = new System.Drawing.Point(112, 124);
            this.dniLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.dniLabel.Name = "dniLabel";
            this.dniLabel.Size = new System.Drawing.Size(34, 19);
            this.dniLabel.TabIndex = 26;
            this.dniLabel.Text = "DNI";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Depth = 0;
            this.passLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.passLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.passLabel.Location = new System.Drawing.Point(60, 215);
            this.passLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(86, 19);
            this.passLabel.TabIndex = 27;
            this.passLabel.Text = "Contraseña";
            // 
            // telLabel
            // 
            this.telLabel.AutoSize = true;
            this.telLabel.Depth = 0;
            this.telLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.telLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.telLabel.Location = new System.Drawing.Point(77, 274);
            this.telLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.telLabel.Name = "telLabel";
            this.telLabel.Size = new System.Drawing.Size(69, 19);
            this.telLabel.TabIndex = 28;
            this.telLabel.Text = "Teléfono";
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Depth = 0;
            this.nomLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.nomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nomLabel.Location = new System.Drawing.Point(422, 124);
            this.nomLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(63, 19);
            this.nomLabel.TabIndex = 29;
            this.nomLabel.Text = "Nombre";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Depth = 0;
            this.emailLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.emailLabel.Location = new System.Drawing.Point(438, 215);
            this.emailLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(47, 19);
            this.emailLabel.TabIndex = 30;
            this.emailLabel.Text = "Email";
            // 
            // horasLabel
            // 
            this.horasLabel.AutoSize = true;
            this.horasLabel.Depth = 0;
            this.horasLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.horasLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.horasLabel.Location = new System.Drawing.Point(435, 270);
            this.horasLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.horasLabel.Name = "horasLabel";
            this.horasLabel.Size = new System.Drawing.Size(50, 19);
            this.horasLabel.TabIndex = 31;
            this.horasLabel.Text = "Horas";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = null;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(21, 174);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(732, 10);
            this.materialTabSelector1.TabIndex = 43;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabSelector2
            // 
            this.materialTabSelector2.BaseTabControl = null;
            this.materialTabSelector2.Depth = 0;
            this.materialTabSelector2.Location = new System.Drawing.Point(-3, 174);
            this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            this.materialTabSelector2.Size = new System.Drawing.Size(782, 10);
            this.materialTabSelector2.TabIndex = 44;
            this.materialTabSelector2.Text = "materialTabSelector2";
            // 
            // EditarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialTabSelector2);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.horasLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nomLabel);
            this.Controls.Add(this.telLabel);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.dniLabel);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.telText);
            this.Controls.Add(this.numText);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.nomText);
            this.Controls.Add(this.dniText);
            this.Name = "EditarClientes";
            this.Text = "Editar Clientes";
            this.Load += new System.EventHandler(this.EditarClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton buttonEditar;
        private MaterialSkin.Controls.MaterialRaisedButton buttonVolver;
        private MaterialSkin.Controls.MaterialSingleLineTextField emailText;
        private MaterialSkin.Controls.MaterialSingleLineTextField telText;
        private MaterialSkin.Controls.MaterialSingleLineTextField numText;
        private MaterialSkin.Controls.MaterialSingleLineTextField passText;
        private MaterialSkin.Controls.MaterialSingleLineTextField nomText;
        private MaterialSkin.Controls.MaterialSingleLineTextField dniText;
        private MaterialSkin.Controls.MaterialLabel dniLabel;
        private MaterialSkin.Controls.MaterialLabel passLabel;
        private MaterialSkin.Controls.MaterialLabel telLabel;
        private MaterialSkin.Controls.MaterialLabel nomLabel;
        private MaterialSkin.Controls.MaterialLabel emailLabel;
        private MaterialSkin.Controls.MaterialLabel horasLabel;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
    }
}