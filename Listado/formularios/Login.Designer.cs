
namespace RaquetZone.formularios
{
    partial class Login
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
            this.dniText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.passwText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.iniciarButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.contraOlvidada = new MaterialSkin.Controls.MaterialRaisedButton();
            this.empresaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dniText
            // 
            this.dniText.Depth = 0;
            this.dniText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dniText.Hint = "DNI";
            this.dniText.Location = new System.Drawing.Point(67, 111);
            this.dniText.MouseState = MaterialSkin.MouseState.HOVER;
            this.dniText.Name = "dniText";
            this.dniText.PasswordChar = '\0';
            this.dniText.SelectedText = "";
            this.dniText.SelectionLength = 0;
            this.dniText.SelectionStart = 0;
            this.dniText.Size = new System.Drawing.Size(262, 23);
            this.dniText.TabIndex = 1;
            this.dniText.UseSystemPasswordChar = false;
            // 
            // passwText
            // 
            this.passwText.BackColor = System.Drawing.Color.White;
            this.passwText.Depth = 0;
            this.passwText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwText.Hint = "Contraseña";
            this.passwText.Location = new System.Drawing.Point(67, 163);
            this.passwText.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwText.Name = "passwText";
            this.passwText.PasswordChar = '*';
            this.passwText.SelectedText = "";
            this.passwText.SelectionLength = 0;
            this.passwText.SelectionStart = 0;
            this.passwText.Size = new System.Drawing.Size(262, 23);
            this.passwText.TabIndex = 2;
            this.passwText.UseSystemPasswordChar = false;
            // 
            // iniciarButton
            // 
            this.iniciarButton.Depth = 0;
            this.iniciarButton.Location = new System.Drawing.Point(206, 246);
            this.iniciarButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.iniciarButton.Name = "iniciarButton";
            this.iniciarButton.Primary = true;
            this.iniciarButton.Size = new System.Drawing.Size(123, 41);
            this.iniciarButton.TabIndex = 3;
            this.iniciarButton.Text = "Iniciar Sesión";
            this.iniciarButton.UseVisualStyleBackColor = true;
            this.iniciarButton.Click += new System.EventHandler(this.iniciarButton_Click);
            // 
            // contraOlvidada
            // 
            this.contraOlvidada.BackColor = System.Drawing.Color.White;
            this.contraOlvidada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.contraOlvidada.Depth = 0;
            this.contraOlvidada.FlatAppearance.BorderSize = 0;
            this.contraOlvidada.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.contraOlvidada.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraOlvidada.Location = new System.Drawing.Point(67, 192);
            this.contraOlvidada.MouseState = MaterialSkin.MouseState.HOVER;
            this.contraOlvidada.Name = "contraOlvidada";
            this.contraOlvidada.Primary = true;
            this.contraOlvidada.Size = new System.Drawing.Size(130, 21);
            this.contraOlvidada.TabIndex = 4;
            this.contraOlvidada.Text = "¿Has olvidado tu contraseña?";
            this.contraOlvidada.UseVisualStyleBackColor = false;
            this.contraOlvidada.Click += new System.EventHandler(this.contraOlvidada_Click);
            // 
            // empresaLabel
            // 
            this.empresaLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empresaLabel.Image = global::Listado.Properties.Resources.logo_más_fondo;
            this.empresaLabel.Location = new System.Drawing.Point(38, 269);
            this.empresaLabel.Name = "empresaLabel";
            this.empresaLabel.Size = new System.Drawing.Size(79, 97);
            this.empresaLabel.TabIndex = 68;
            // 
            // Login
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(389, 386);
            this.Controls.Add(this.empresaLabel);
            this.Controls.Add(this.contraOlvidada);
            this.Controls.Add(this.iniciarButton);
            this.Controls.Add(this.passwText);
            this.Controls.Add(this.dniText);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(389, 386);
            this.MinimumSize = new System.Drawing.Size(389, 386);
            this.Name = "Login";
            this.Text = "Iniciar Sesión";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField dniText;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwText;
        private MaterialSkin.Controls.MaterialRaisedButton iniciarButton;
        private MaterialSkin.Controls.MaterialRaisedButton contraOlvidada;
        private System.Windows.Forms.Label empresaLabel;
    }
}