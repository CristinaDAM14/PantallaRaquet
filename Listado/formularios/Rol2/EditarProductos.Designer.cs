
namespace RaquetZone.formularios.Rol2
{
    partial class EditarProductos
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
            this.ivaText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.stockText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.preText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.desText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.categoriaText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.nomText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.horasLabel = new MaterialSkin.Controls.MaterialLabel();
            this.emailLabel = new MaterialSkin.Controls.MaterialLabel();
            this.nomLabel = new MaterialSkin.Controls.MaterialLabel();
            this.telLabel = new MaterialSkin.Controls.MaterialLabel();
            this.passLabel = new MaterialSkin.Controls.MaterialLabel();
            this.dniLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.idText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.SuspendLayout();
            // 
            // buttonEditar
            // 
            this.buttonEditar.Depth = 0;
            this.buttonEditar.Location = new System.Drawing.Point(424, 364);
            this.buttonEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Primary = true;
            this.buttonEditar.Size = new System.Drawing.Size(123, 38);
            this.buttonEditar.TabIndex = 32;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Depth = 0;
            this.buttonVolver.Location = new System.Drawing.Point(204, 364);
            this.buttonVolver.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Primary = true;
            this.buttonVolver.Size = new System.Drawing.Size(123, 38);
            this.buttonVolver.TabIndex = 33;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // ivaText
            // 
            this.ivaText.Depth = 0;
            this.ivaText.Hint = "IVA";
            this.ivaText.Location = new System.Drawing.Point(652, 223);
            this.ivaText.MouseState = MaterialSkin.MouseState.HOVER;
            this.ivaText.Name = "ivaText";
            this.ivaText.PasswordChar = '\0';
            this.ivaText.SelectedText = "";
            this.ivaText.SelectionLength = 0;
            this.ivaText.SelectionStart = 0;
            this.ivaText.Size = new System.Drawing.Size(88, 23);
            this.ivaText.TabIndex = 29;
            this.ivaText.UseSystemPasswordChar = false;
            // 
            // stockText
            // 
            this.stockText.Depth = 0;
            this.stockText.Hint = "Stock";
            this.stockText.Location = new System.Drawing.Point(161, 289);
            this.stockText.MouseState = MaterialSkin.MouseState.HOVER;
            this.stockText.Name = "stockText";
            this.stockText.PasswordChar = '\0';
            this.stockText.SelectedText = "";
            this.stockText.SelectionLength = 0;
            this.stockText.SelectionStart = 0;
            this.stockText.Size = new System.Drawing.Size(166, 23);
            this.stockText.TabIndex = 30;
            this.stockText.UseSystemPasswordChar = false;
            // 
            // preText
            // 
            this.preText.Depth = 0;
            this.preText.Hint = "Precio";
            this.preText.Location = new System.Drawing.Point(495, 219);
            this.preText.MouseState = MaterialSkin.MouseState.HOVER;
            this.preText.Name = "preText";
            this.preText.PasswordChar = '\0';
            this.preText.SelectedText = "";
            this.preText.SelectionLength = 0;
            this.preText.SelectionStart = 0;
            this.preText.Size = new System.Drawing.Size(81, 23);
            this.preText.TabIndex = 31;
            this.preText.UseSystemPasswordChar = false;
            // 
            // desText
            // 
            this.desText.Depth = 0;
            this.desText.Hint = "Descuento";
            this.desText.Location = new System.Drawing.Point(161, 215);
            this.desText.MouseState = MaterialSkin.MouseState.HOVER;
            this.desText.Name = "desText";
            this.desText.PasswordChar = '\0';
            this.desText.SelectedText = "";
            this.desText.SelectionLength = 0;
            this.desText.SelectionStart = 0;
            this.desText.Size = new System.Drawing.Size(166, 23);
            this.desText.TabIndex = 28;
            this.desText.UseSystemPasswordChar = false;
            // 
            // categoriaText
            // 
            this.categoriaText.Depth = 0;
            this.categoriaText.Hint = "Categoría";
            this.categoriaText.Location = new System.Drawing.Point(580, 117);
            this.categoriaText.MouseState = MaterialSkin.MouseState.HOVER;
            this.categoriaText.Name = "categoriaText";
            this.categoriaText.PasswordChar = '\0';
            this.categoriaText.SelectedText = "";
            this.categoriaText.SelectionLength = 0;
            this.categoriaText.SelectionStart = 0;
            this.categoriaText.Size = new System.Drawing.Size(157, 23);
            this.categoriaText.TabIndex = 27;
            this.categoriaText.UseSystemPasswordChar = false;
            // 
            // nomText
            // 
            this.nomText.Depth = 0;
            this.nomText.Hint = "Nombre";
            this.nomText.Location = new System.Drawing.Point(294, 117);
            this.nomText.MouseState = MaterialSkin.MouseState.HOVER;
            this.nomText.Name = "nomText";
            this.nomText.PasswordChar = '\0';
            this.nomText.SelectedText = "";
            this.nomText.SelectionLength = 0;
            this.nomText.SelectionStart = 0;
            this.nomText.Size = new System.Drawing.Size(166, 23);
            this.nomText.TabIndex = 26;
            this.nomText.UseSystemPasswordChar = false;
            // 
            // horasLabel
            // 
            this.horasLabel.AutoSize = true;
            this.horasLabel.Depth = 0;
            this.horasLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.horasLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.horasLabel.Location = new System.Drawing.Point(603, 223);
            this.horasLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.horasLabel.Name = "horasLabel";
            this.horasLabel.Size = new System.Drawing.Size(33, 19);
            this.horasLabel.TabIndex = 39;
            this.horasLabel.Text = "IVA";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Depth = 0;
            this.emailLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.emailLabel.Location = new System.Drawing.Point(81, 289);
            this.emailLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(48, 19);
            this.emailLabel.TabIndex = 38;
            this.emailLabel.Text = "Stock";
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Depth = 0;
            this.nomLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.nomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nomLabel.Location = new System.Drawing.Point(500, 117);
            this.nomLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(74, 19);
            this.nomLabel.TabIndex = 37;
            this.nomLabel.Text = "Categoría";
            // 
            // telLabel
            // 
            this.telLabel.AutoSize = true;
            this.telLabel.Depth = 0;
            this.telLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.telLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.telLabel.Location = new System.Drawing.Point(420, 219);
            this.telLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.telLabel.Name = "telLabel";
            this.telLabel.Size = new System.Drawing.Size(52, 19);
            this.telLabel.TabIndex = 36;
            this.telLabel.Text = "Precio";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Depth = 0;
            this.passLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.passLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.passLabel.Location = new System.Drawing.Point(48, 215);
            this.passLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(81, 19);
            this.passLabel.TabIndex = 35;
            this.passLabel.Text = "Descuento";
            // 
            // dniLabel
            // 
            this.dniLabel.AutoSize = true;
            this.dniLabel.Depth = 0;
            this.dniLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.dniLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dniLabel.Location = new System.Drawing.Point(225, 117);
            this.dniLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.dniLabel.Name = "dniLabel";
            this.dniLabel.Size = new System.Drawing.Size(63, 19);
            this.dniLabel.TabIndex = 34;
            this.dniLabel.Text = "Nombre";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(75, 117);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(23, 19);
            this.materialLabel1.TabIndex = 41;
            this.materialLabel1.Text = "ID";
            // 
            // idText
            // 
            this.idText.Depth = 0;
            this.idText.Enabled = false;
            this.idText.Hint = "ID";
            this.idText.Location = new System.Drawing.Point(104, 117);
            this.idText.MouseState = MaterialSkin.MouseState.HOVER;
            this.idText.Name = "idText";
            this.idText.PasswordChar = '\0';
            this.idText.SelectedText = "";
            this.idText.SelectionLength = 0;
            this.idText.SelectionStart = 0;
            this.idText.Size = new System.Drawing.Size(73, 23);
            this.idText.TabIndex = 40;
            this.idText.UseSystemPasswordChar = false;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = null;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(25, 176);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(732, 10);
            this.materialTabSelector1.TabIndex = 42;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabSelector2
            // 
            this.materialTabSelector2.BaseTabControl = null;
            this.materialTabSelector2.Depth = 0;
            this.materialTabSelector2.Location = new System.Drawing.Point(-4, 176);
            this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            this.materialTabSelector2.Size = new System.Drawing.Size(782, 10);
            this.materialTabSelector2.TabIndex = 44;
            this.materialTabSelector2.Text = "materialTabSelector2";
            // 
            // EditarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialTabSelector2);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.horasLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nomLabel);
            this.Controls.Add(this.telLabel);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.dniLabel);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.ivaText);
            this.Controls.Add(this.stockText);
            this.Controls.Add(this.preText);
            this.Controls.Add(this.desText);
            this.Controls.Add(this.categoriaText);
            this.Controls.Add(this.nomText);
            this.Name = "EditarProductos";
            this.Text = "Editar Productos";
            this.Load += new System.EventHandler(this.EditarProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton buttonEditar;
        private MaterialSkin.Controls.MaterialRaisedButton buttonVolver;
        private MaterialSkin.Controls.MaterialSingleLineTextField ivaText;
        private MaterialSkin.Controls.MaterialSingleLineTextField stockText;
        private MaterialSkin.Controls.MaterialSingleLineTextField preText;
        private MaterialSkin.Controls.MaterialSingleLineTextField desText;
        private MaterialSkin.Controls.MaterialSingleLineTextField categoriaText;
        private MaterialSkin.Controls.MaterialSingleLineTextField nomText;
        private MaterialSkin.Controls.MaterialLabel horasLabel;
        private MaterialSkin.Controls.MaterialLabel emailLabel;
        private MaterialSkin.Controls.MaterialLabel nomLabel;
        private MaterialSkin.Controls.MaterialLabel telLabel;
        private MaterialSkin.Controls.MaterialLabel passLabel;
        private MaterialSkin.Controls.MaterialLabel dniLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField idText;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
    }
}