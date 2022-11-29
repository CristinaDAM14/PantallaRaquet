
namespace RaquetZone.formularios.Rol2
{
    partial class AnyadirProductos
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
            this.preText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.desText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.categoriaText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.nomText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.button1 = new System.Windows.Forms.Button();
            this.bVolver = new System.Windows.Forms.Button();
            this.stockNumeric = new System.Windows.Forms.NumericUpDown();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.ivaBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.stockNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // preText
            // 
            this.preText.Depth = 0;
            this.preText.Hint = "Precio";
            this.preText.Location = new System.Drawing.Point(232, 244);
            this.preText.MouseState = MaterialSkin.MouseState.HOVER;
            this.preText.Name = "preText";
            this.preText.PasswordChar = '\0';
            this.preText.SelectedText = "";
            this.preText.SelectionLength = 0;
            this.preText.SelectionStart = 0;
            this.preText.Size = new System.Drawing.Size(110, 23);
            this.preText.TabIndex = 5;
            this.preText.UseSystemPasswordChar = false;
            // 
            // desText
            // 
            this.desText.Depth = 0;
            this.desText.Hint = "Descuento";
            this.desText.Location = new System.Drawing.Point(84, 244);
            this.desText.MouseState = MaterialSkin.MouseState.HOVER;
            this.desText.Name = "desText";
            this.desText.PasswordChar = '\0';
            this.desText.SelectedText = "";
            this.desText.SelectionLength = 0;
            this.desText.SelectionStart = 0;
            this.desText.Size = new System.Drawing.Size(99, 23);
            this.desText.TabIndex = 3;
            this.desText.UseSystemPasswordChar = false;
            // 
            // categoriaText
            // 
            this.categoriaText.Depth = 0;
            this.categoriaText.Hint = "Categoría";
            this.categoriaText.Location = new System.Drawing.Point(424, 129);
            this.categoriaText.MouseState = MaterialSkin.MouseState.HOVER;
            this.categoriaText.Name = "categoriaText";
            this.categoriaText.PasswordChar = '\0';
            this.categoriaText.SelectedText = "";
            this.categoriaText.SelectionLength = 0;
            this.categoriaText.SelectionStart = 0;
            this.categoriaText.Size = new System.Drawing.Size(312, 23);
            this.categoriaText.TabIndex = 2;
            this.categoriaText.UseSystemPasswordChar = false;
            // 
            // nomText
            // 
            this.nomText.Depth = 0;
            this.nomText.Hint = "Nombre";
            this.nomText.Location = new System.Drawing.Point(84, 129);
            this.nomText.MouseState = MaterialSkin.MouseState.HOVER;
            this.nomText.Name = "nomText";
            this.nomText.PasswordChar = '\0';
            this.nomText.SelectedText = "";
            this.nomText.SelectionLength = 0;
            this.nomText.SelectionStart = 0;
            this.nomText.Size = new System.Drawing.Size(258, 23);
            this.nomText.TabIndex = 1;
            this.nomText.UseSystemPasswordChar = false;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = null;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(22, 176);
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
            this.materialTabSelector2.Location = new System.Drawing.Point(-6, 176);
            this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            this.materialTabSelector2.Size = new System.Drawing.Size(812, 10);
            this.materialTabSelector2.TabIndex = 44;
            this.materialTabSelector2.Text = "materialTabSelector2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Listado.Properties.Resources.añadir_blanco;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(424, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 40);
            this.button1.TabIndex = 66;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bVolver
            // 
            this.bVolver.BackColor = System.Drawing.Color.Transparent;
            this.bVolver.BackgroundImage = global::Listado.Properties.Resources.icono_volver;
            this.bVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bVolver.FlatAppearance.BorderSize = 0;
            this.bVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVolver.Location = new System.Drawing.Point(282, 360);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(45, 40);
            this.bVolver.TabIndex = 65;
            this.bVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // stockNumeric
            // 
            this.stockNumeric.Location = new System.Drawing.Point(687, 247);
            this.stockNumeric.Name = "stockNumeric";
            this.stockNumeric.Size = new System.Drawing.Size(49, 20);
            this.stockNumeric.TabIndex = 67;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(633, 248);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(48, 19);
            this.materialLabel1.TabIndex = 68;
            this.materialLabel1.Text = "Stock";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(421, 248);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(33, 19);
            this.materialLabel2.TabIndex = 69;
            this.materialLabel2.Text = "IVA";
            // 
            // ivaBox
            // 
            this.ivaBox.FormattingEnabled = true;
            this.ivaBox.Items.AddRange(new object[] {
            "4%",
            "10%",
            "21%"});
            this.ivaBox.Location = new System.Drawing.Point(460, 246);
            this.ivaBox.Name = "ivaBox";
            this.ivaBox.Size = new System.Drawing.Size(121, 21);
            this.ivaBox.TabIndex = 70;
            this.ivaBox.Text = "4%";
            // 
            // AnyadirProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ivaBox);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.stockNumeric);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.materialTabSelector2);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.preText);
            this.Controls.Add(this.desText);
            this.Controls.Add(this.categoriaText);
            this.Controls.Add(this.nomText);
            this.Name = "AnyadirProductos";
            this.Text = "Añadir Productos";
            this.Load += new System.EventHandler(this.AnyadirProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField preText;
        private MaterialSkin.Controls.MaterialSingleLineTextField desText;
        private MaterialSkin.Controls.MaterialSingleLineTextField categoriaText;
        private MaterialSkin.Controls.MaterialSingleLineTextField nomText;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown stockNumeric;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ComboBox ivaBox;
    }
}