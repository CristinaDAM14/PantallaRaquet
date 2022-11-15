namespace RaquetZone.formularios
{
    partial class AnyadirUsuario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonEditar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonVolver = new MaterialSkin.Controls.MaterialRaisedButton();
            this.direccText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.emailText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.telText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.passText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.nombreText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dniText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.rolCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonEditar
            // 
            this.buttonEditar.Depth = 0;
            this.buttonEditar.Location = new System.Drawing.Point(386, 361);
            this.buttonEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Primary = true;
            this.buttonEditar.Size = new System.Drawing.Size(123, 38);
            this.buttonEditar.TabIndex = 8;
            this.buttonEditar.Text = "Añadir";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Depth = 0;
            this.buttonVolver.Location = new System.Drawing.Point(166, 361);
            this.buttonVolver.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Primary = true;
            this.buttonVolver.Size = new System.Drawing.Size(123, 38);
            this.buttonVolver.TabIndex = 9;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // direccText
            // 
            this.direccText.Depth = 0;
            this.direccText.Hint = "Dirección";
            this.direccText.Location = new System.Drawing.Point(416, 192);
            this.direccText.MouseState = MaterialSkin.MouseState.HOVER;
            this.direccText.Name = "direccText";
            this.direccText.PasswordChar = '\0';
            this.direccText.SelectedText = "";
            this.direccText.SelectionLength = 0;
            this.direccText.SelectionStart = 0;
            this.direccText.Size = new System.Drawing.Size(282, 23);
            this.direccText.TabIndex = 4;
            this.direccText.UseSystemPasswordChar = false;
            // 
            // emailText
            // 
            this.emailText.Depth = 0;
            this.emailText.Hint = "Email";
            this.emailText.Location = new System.Drawing.Point(114, 259);
            this.emailText.MouseState = MaterialSkin.MouseState.HOVER;
            this.emailText.Name = "emailText";
            this.emailText.PasswordChar = '\0';
            this.emailText.SelectedText = "";
            this.emailText.SelectionLength = 0;
            this.emailText.SelectionStart = 0;
            this.emailText.Size = new System.Drawing.Size(175, 23);
            this.emailText.TabIndex = 5;
            this.emailText.UseSystemPasswordChar = false;
            // 
            // telText
            // 
            this.telText.Depth = 0;
            this.telText.Hint = "Teléfono";
            this.telText.Location = new System.Drawing.Point(416, 259);
            this.telText.MouseState = MaterialSkin.MouseState.HOVER;
            this.telText.Name = "telText";
            this.telText.PasswordChar = '\0';
            this.telText.SelectedText = "";
            this.telText.SelectionLength = 0;
            this.telText.SelectionStart = 0;
            this.telText.Size = new System.Drawing.Size(128, 23);
            this.telText.TabIndex = 6;
            this.telText.UseSystemPasswordChar = false;
            // 
            // passText
            // 
            this.passText.Depth = 0;
            this.passText.Hint = "Contraseña";
            this.passText.Location = new System.Drawing.Point(114, 192);
            this.passText.MouseState = MaterialSkin.MouseState.HOVER;
            this.passText.Name = "passText";
            this.passText.PasswordChar = '\0';
            this.passText.SelectedText = "";
            this.passText.SelectionLength = 0;
            this.passText.SelectionStart = 0;
            this.passText.Size = new System.Drawing.Size(175, 23);
            this.passText.TabIndex = 3;
            this.passText.UseSystemPasswordChar = false;
            // 
            // nombreText
            // 
            this.nombreText.Depth = 0;
            this.nombreText.Hint = "Nombre";
            this.nombreText.Location = new System.Drawing.Point(416, 129);
            this.nombreText.MouseState = MaterialSkin.MouseState.HOVER;
            this.nombreText.Name = "nombreText";
            this.nombreText.PasswordChar = '\0';
            this.nombreText.SelectedText = "";
            this.nombreText.SelectionLength = 0;
            this.nombreText.SelectionStart = 0;
            this.nombreText.Size = new System.Drawing.Size(282, 23);
            this.nombreText.TabIndex = 2;
            this.nombreText.UseSystemPasswordChar = false;
            // 
            // dniText
            // 
            this.dniText.Depth = 0;
            this.dniText.Enabled = false;
            this.dniText.Hint = "DNI";
            this.dniText.Location = new System.Drawing.Point(114, 129);
            this.dniText.MouseState = MaterialSkin.MouseState.HOVER;
            this.dniText.Name = "dniText";
            this.dniText.PasswordChar = '\0';
            this.dniText.SelectedText = "";
            this.dniText.SelectionLength = 0;
            this.dniText.SelectionStart = 0;
            this.dniText.Size = new System.Drawing.Size(175, 23);
            this.dniText.TabIndex = 1;
            this.dniText.UseSystemPasswordChar = false;
            // 
            // rolCombo
            // 
            this.rolCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolCombo.FormattingEnabled = true;
            this.rolCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.rolCombo.Location = new System.Drawing.Point(594, 259);
            this.rolCombo.Name = "rolCombo";
            this.rolCombo.Size = new System.Drawing.Size(104, 23);
            this.rolCombo.TabIndex = 7;
            this.rolCombo.Text = "Rol";
            // 
            // AnyadirUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.direccText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.telText);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.nombreText);
            this.Controls.Add(this.dniText);
            this.Controls.Add(this.rolCombo);
            this.Name = "AnyadirUsuario";
            this.Text = "Añadir Usuario";
            this.Load += new System.EventHandler(this.AnyadirUsuario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton buttonEditar;
        private MaterialSkin.Controls.MaterialRaisedButton buttonVolver;
        private MaterialSkin.Controls.MaterialSingleLineTextField direccText;
        private MaterialSkin.Controls.MaterialSingleLineTextField emailText;
        private MaterialSkin.Controls.MaterialSingleLineTextField telText;
        private MaterialSkin.Controls.MaterialSingleLineTextField passText;
        private MaterialSkin.Controls.MaterialSingleLineTextField nombreText;
        private MaterialSkin.Controls.MaterialSingleLineTextField dniText;
        private System.Windows.Forms.ComboBox rolCombo;
    }
}

