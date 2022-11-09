
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
            this.ivaText.Location = new System.Drawing.Point(424, 275);
            this.ivaText.MouseState = MaterialSkin.MouseState.HOVER;
            this.ivaText.Name = "ivaText";
            this.ivaText.PasswordChar = '\0';
            this.ivaText.SelectedText = "";
            this.ivaText.SelectionLength = 0;
            this.ivaText.SelectionStart = 0;
            this.ivaText.Size = new System.Drawing.Size(142, 23);
            this.ivaText.TabIndex = 29;
            this.ivaText.UseSystemPasswordChar = false;
            // 
            // stockText
            // 
            this.stockText.Depth = 0;
            this.stockText.Hint = "Stock";
            this.stockText.Location = new System.Drawing.Point(424, 195);
            this.stockText.MouseState = MaterialSkin.MouseState.HOVER;
            this.stockText.Name = "stockText";
            this.stockText.PasswordChar = '\0';
            this.stockText.SelectedText = "";
            this.stockText.SelectionLength = 0;
            this.stockText.SelectionStart = 0;
            this.stockText.Size = new System.Drawing.Size(312, 23);
            this.stockText.TabIndex = 30;
            this.stockText.UseSystemPasswordChar = false;
            // 
            // preText
            // 
            this.preText.Depth = 0;
            this.preText.Hint = "Precio";
            this.preText.Location = new System.Drawing.Point(109, 275);
            this.preText.MouseState = MaterialSkin.MouseState.HOVER;
            this.preText.Name = "preText";
            this.preText.PasswordChar = '\0';
            this.preText.SelectedText = "";
            this.preText.SelectionLength = 0;
            this.preText.SelectionStart = 0;
            this.preText.Size = new System.Drawing.Size(142, 23);
            this.preText.TabIndex = 31;
            this.preText.UseSystemPasswordChar = false;
            // 
            // desText
            // 
            this.desText.Depth = 0;
            this.desText.Hint = "Descuento";
            this.desText.Location = new System.Drawing.Point(109, 195);
            this.desText.MouseState = MaterialSkin.MouseState.HOVER;
            this.desText.Name = "desText";
            this.desText.PasswordChar = '\0';
            this.desText.SelectedText = "";
            this.desText.SelectionLength = 0;
            this.desText.SelectionStart = 0;
            this.desText.Size = new System.Drawing.Size(218, 23);
            this.desText.TabIndex = 28;
            this.desText.UseSystemPasswordChar = false;
            // 
            // categoriaText
            // 
            this.categoriaText.Depth = 0;
            this.categoriaText.Hint = "Categoría";
            this.categoriaText.Location = new System.Drawing.Point(424, 132);
            this.categoriaText.MouseState = MaterialSkin.MouseState.HOVER;
            this.categoriaText.Name = "categoriaText";
            this.categoriaText.PasswordChar = '\0';
            this.categoriaText.SelectedText = "";
            this.categoriaText.SelectionLength = 0;
            this.categoriaText.SelectionStart = 0;
            this.categoriaText.Size = new System.Drawing.Size(312, 23);
            this.categoriaText.TabIndex = 27;
            this.categoriaText.UseSystemPasswordChar = false;
            // 
            // nomText
            // 
            this.nomText.Depth = 0;
            this.nomText.Hint = "Nombre";
            this.nomText.Location = new System.Drawing.Point(109, 132);
            this.nomText.MouseState = MaterialSkin.MouseState.HOVER;
            this.nomText.Name = "nomText";
            this.nomText.PasswordChar = '\0';
            this.nomText.SelectedText = "";
            this.nomText.SelectionLength = 0;
            this.nomText.SelectionStart = 0;
            this.nomText.Size = new System.Drawing.Size(218, 23);
            this.nomText.TabIndex = 26;
            this.nomText.UseSystemPasswordChar = false;
            // 
            // EditarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}