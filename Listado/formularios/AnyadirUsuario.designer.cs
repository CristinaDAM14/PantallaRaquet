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
            this.direccText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.emailText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.telText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.passText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.rolCombo = new System.Windows.Forms.ComboBox();
            this.dniText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.bVolver = new System.Windows.Forms.Button();
            this.nombreText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.horasLabel = new MaterialSkin.Controls.MaterialLabel();
            this.emailLabel = new MaterialSkin.Controls.MaterialLabel();
            this.nomLabel = new MaterialSkin.Controls.MaterialLabel();
            this.telLabel = new MaterialSkin.Controls.MaterialLabel();
            this.passLabel = new MaterialSkin.Controls.MaterialLabel();
            this.dniLabel = new MaterialSkin.Controls.MaterialLabel();
            this.TextoCIFAnyadir = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.bEmpresa = new MaterialSkin.Controls.MaterialRaisedButton();
            this.labelEmpresa = new MaterialSkin.Controls.MaterialLabel();
            this.textEmpresa = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // direccText
            // 
            this.direccText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.direccText.Depth = 0;
            this.direccText.Hint = "Dirección";
            this.direccText.Location = new System.Drawing.Point(416, 215);
            this.direccText.MouseState = MaterialSkin.MouseState.HOVER;
            this.direccText.Name = "direccText";
            this.direccText.PasswordChar = '\0';
            this.direccText.SelectedText = "";
            this.direccText.SelectionLength = 0;
            this.direccText.SelectionStart = 0;
            this.direccText.Size = new System.Drawing.Size(128, 23);
            this.direccText.TabIndex = 4;
            this.direccText.UseSystemPasswordChar = false;
            // 
            // emailText
            // 
            this.emailText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emailText.Depth = 0;
            this.emailText.Hint = "Email";
            this.emailText.Location = new System.Drawing.Point(119, 282);
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
            this.telText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.telText.Depth = 0;
            this.telText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.telText.Hint = "Teléfono";
            this.telText.Location = new System.Drawing.Point(632, 215);
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
            this.passText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passText.Depth = 0;
            this.passText.Hint = "Contraseña";
            this.passText.Location = new System.Drawing.Point(119, 215);
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
            this.rolCombo.Location = new System.Drawing.Point(374, 283);
            this.rolCombo.Name = "rolCombo";
            this.rolCombo.Size = new System.Drawing.Size(110, 23);
            this.rolCombo.TabIndex = 7;
            // 
            // dniText
            // 
            this.dniText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dniText.Depth = 0;
            this.dniText.Hint = "DNI";
            this.dniText.Location = new System.Drawing.Point(114, 129);
            this.dniText.MouseState = MaterialSkin.MouseState.HOVER;
            this.dniText.Name = "dniText";
            this.dniText.PasswordChar = '\0';
            this.dniText.SelectedText = "";
            this.dniText.SelectionLength = 0;
            this.dniText.SelectionStart = 0;
            this.dniText.Size = new System.Drawing.Size(175, 23);
            this.dniText.TabIndex = 0;
            this.dniText.UseSystemPasswordChar = false;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = null;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(23, 176);
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
            this.materialTabSelector2.Location = new System.Drawing.Point(-5, 176);
            this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            this.materialTabSelector2.Size = new System.Drawing.Size(814, 10);
            this.materialTabSelector2.TabIndex = 44;
            this.materialTabSelector2.Text = "materialTabSelector2";
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.Transparent;
            this.buttonEditar.BackgroundImage = global::Listado.Properties.Resources.añadir_blanco;
            this.buttonEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditar.FlatAppearance.BorderSize = 0;
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditar.Location = new System.Drawing.Point(416, 359);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(45, 40);
            this.buttonEditar.TabIndex = 8;
            this.buttonEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click_1);
            // 
            // bVolver
            // 
            this.bVolver.BackColor = System.Drawing.Color.Transparent;
            this.bVolver.BackgroundImage = global::Listado.Properties.Resources.icono_volver;
            this.bVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bVolver.FlatAppearance.BorderSize = 0;
            this.bVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVolver.Location = new System.Drawing.Point(244, 359);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(45, 40);
            this.bVolver.TabIndex = 9;
            this.bVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // nombreText
            // 
            this.nombreText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nombreText.Depth = 0;
            this.nombreText.Hint = "Nombre";
            this.nombreText.Location = new System.Drawing.Point(416, 129);
            this.nombreText.MouseState = MaterialSkin.MouseState.HOVER;
            this.nombreText.Name = "nombreText";
            this.nombreText.PasswordChar = '\0';
            this.nombreText.SelectedText = "";
            this.nombreText.SelectionLength = 0;
            this.nombreText.SelectionStart = 0;
            this.nombreText.Size = new System.Drawing.Size(344, 23);
            this.nombreText.TabIndex = 1;
            this.nombreText.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(337, 281);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(31, 19);
            this.materialLabel1.TabIndex = 52;
            this.materialLabel1.Text = "Rol";
            // 
            // horasLabel
            // 
            this.horasLabel.AutoSize = true;
            this.horasLabel.Depth = 0;
            this.horasLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.horasLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.horasLabel.Location = new System.Drawing.Point(557, 215);
            this.horasLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.horasLabel.Name = "horasLabel";
            this.horasLabel.Size = new System.Drawing.Size(69, 19);
            this.horasLabel.TabIndex = 51;
            this.horasLabel.Text = "Teléfono";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Depth = 0;
            this.emailLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.emailLabel.Location = new System.Drawing.Point(337, 215);
            this.emailLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(73, 19);
            this.emailLabel.TabIndex = 50;
            this.emailLabel.Text = "Dirección";
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Depth = 0;
            this.nomLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.nomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nomLabel.Location = new System.Drawing.Point(337, 129);
            this.nomLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(63, 19);
            this.nomLabel.TabIndex = 49;
            this.nomLabel.Text = "Nombre";
            // 
            // telLabel
            // 
            this.telLabel.AutoSize = true;
            this.telLabel.Depth = 0;
            this.telLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.telLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.telLabel.Location = new System.Drawing.Point(66, 281);
            this.telLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.telLabel.Name = "telLabel";
            this.telLabel.Size = new System.Drawing.Size(47, 19);
            this.telLabel.TabIndex = 48;
            this.telLabel.Text = "Email";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Depth = 0;
            this.passLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.passLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.passLabel.Location = new System.Drawing.Point(27, 215);
            this.passLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(86, 19);
            this.passLabel.TabIndex = 47;
            this.passLabel.Text = "Contraseña";
            // 
            // dniLabel
            // 
            this.dniLabel.AutoSize = true;
            this.dniLabel.Depth = 0;
            this.dniLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.dniLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dniLabel.Location = new System.Drawing.Point(74, 129);
            this.dniLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.dniLabel.Name = "dniLabel";
            this.dniLabel.Size = new System.Drawing.Size(34, 19);
            this.dniLabel.TabIndex = 46;
            this.dniLabel.Text = "DNI";
            // 
            // TextoCIFAnyadir
            // 
            this.TextoCIFAnyadir.Depth = 0;
            this.TextoCIFAnyadir.Enabled = false;
            this.TextoCIFAnyadir.Hint = "";
            this.TextoCIFAnyadir.Location = new System.Drawing.Point(213, 283);
            this.TextoCIFAnyadir.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextoCIFAnyadir.Name = "TextoCIFAnyadir";
            this.TextoCIFAnyadir.PasswordChar = '\0';
            this.TextoCIFAnyadir.SelectedText = "";
            this.TextoCIFAnyadir.SelectionLength = 0;
            this.TextoCIFAnyadir.SelectionStart = 0;
            this.TextoCIFAnyadir.Size = new System.Drawing.Size(64, 23);
            this.TextoCIFAnyadir.TabIndex = 73;
            this.TextoCIFAnyadir.UseSystemPasswordChar = false;
            this.TextoCIFAnyadir.Visible = false;
            // 
            // bEmpresa
            // 
            this.bEmpresa.Depth = 0;
            this.bEmpresa.Location = new System.Drawing.Point(691, 283);
            this.bEmpresa.MouseState = MaterialSkin.MouseState.HOVER;
            this.bEmpresa.Name = "bEmpresa";
            this.bEmpresa.Primary = true;
            this.bEmpresa.Size = new System.Drawing.Size(69, 23);
            this.bEmpresa.TabIndex = 140;
            this.bEmpresa.Text = "Buscar";
            this.bEmpresa.UseVisualStyleBackColor = true;
            this.bEmpresa.Click += new System.EventHandler(this.bEmpresa_Click);
            // 
            // labelEmpresa
            // 
            this.labelEmpresa.AutoSize = true;
            this.labelEmpresa.Depth = 0;
            this.labelEmpresa.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelEmpresa.Location = new System.Drawing.Point(499, 284);
            this.labelEmpresa.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelEmpresa.Name = "labelEmpresa";
            this.labelEmpresa.Size = new System.Drawing.Size(68, 19);
            this.labelEmpresa.TabIndex = 139;
            this.labelEmpresa.Text = "Empresa";
            // 
            // textEmpresa
            // 
            this.textEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textEmpresa.Depth = 0;
            this.textEmpresa.Enabled = false;
            this.textEmpresa.Hint = "CIF Empresa";
            this.textEmpresa.Location = new System.Drawing.Point(573, 283);
            this.textEmpresa.MouseState = MaterialSkin.MouseState.HOVER;
            this.textEmpresa.Name = "textEmpresa";
            this.textEmpresa.PasswordChar = '\0';
            this.textEmpresa.SelectedText = "";
            this.textEmpresa.SelectionLength = 0;
            this.textEmpresa.SelectionStart = 0;
            this.textEmpresa.Size = new System.Drawing.Size(112, 23);
            this.textEmpresa.TabIndex = 138;
            this.textEmpresa.UseSystemPasswordChar = false;
            // 
            // AnyadirUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bEmpresa);
            this.Controls.Add(this.labelEmpresa);
            this.Controls.Add(this.textEmpresa);
            this.Controls.Add(this.TextoCIFAnyadir);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.horasLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nomLabel);
            this.Controls.Add(this.telLabel);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.dniLabel);
            this.Controls.Add(this.nombreText);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.materialTabSelector2);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.dniText);
            this.Controls.Add(this.direccText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.telText);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.rolCombo);
            this.MaximizeBox = false;
            this.Name = "AnyadirUsuario";
            this.Text = "Añadir Usuario";
            this.Load += new System.EventHandler(this.AnyadirUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField direccText;
        private MaterialSkin.Controls.MaterialSingleLineTextField emailText;
        private MaterialSkin.Controls.MaterialSingleLineTextField telText;
        private MaterialSkin.Controls.MaterialSingleLineTextField passText;
        private System.Windows.Forms.ComboBox rolCombo;
        private MaterialSkin.Controls.MaterialSingleLineTextField dniText;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Button buttonEditar;
        private MaterialSkin.Controls.MaterialSingleLineTextField nombreText;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel horasLabel;
        private MaterialSkin.Controls.MaterialLabel emailLabel;
        private MaterialSkin.Controls.MaterialLabel nomLabel;
        private MaterialSkin.Controls.MaterialLabel telLabel;
        private MaterialSkin.Controls.MaterialLabel passLabel;
        private MaterialSkin.Controls.MaterialLabel dniLabel;
        public MaterialSkin.Controls.MaterialSingleLineTextField TextoCIFAnyadir;
        private MaterialSkin.Controls.MaterialRaisedButton bEmpresa;
        private MaterialSkin.Controls.MaterialLabel labelEmpresa;
        private MaterialSkin.Controls.MaterialSingleLineTextField textEmpresa;
    }
}

