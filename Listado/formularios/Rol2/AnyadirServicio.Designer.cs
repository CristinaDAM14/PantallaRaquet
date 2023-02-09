
namespace RaquetZone.formularios.Rol2
{
    partial class AnyadirServicio
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
            this.desNum = new System.Windows.Forms.NumericUpDown();
            this.precioNum = new System.Windows.Forms.NumericUpDown();
            this.telLabel = new MaterialSkin.Controls.MaterialLabel();
            this.passLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ivaBox = new System.Windows.Forms.ComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tiempoNumeric = new System.Windows.Forms.NumericUpDown();
            this.AnyadirButton = new System.Windows.Forms.Button();
            this.bVolver = new System.Windows.Forms.Button();
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.desText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.TextoCIFAnyadir = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.desNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precioNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiempoNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // desNum
            // 
            this.desNum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.desNum.Location = new System.Drawing.Point(245, 245);
            this.desNum.Name = "desNum";
            this.desNum.Size = new System.Drawing.Size(49, 20);
            this.desNum.TabIndex = 85;
            // 
            // precioNum
            // 
            this.precioNum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.precioNum.Location = new System.Drawing.Point(245, 290);
            this.precioNum.Name = "precioNum";
            this.precioNum.Size = new System.Drawing.Size(49, 20);
            this.precioNum.TabIndex = 86;
            // 
            // telLabel
            // 
            this.telLabel.AutoSize = true;
            this.telLabel.Depth = 0;
            this.telLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.telLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.telLabel.Location = new System.Drawing.Point(161, 291);
            this.telLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.telLabel.Name = "telLabel";
            this.telLabel.Size = new System.Drawing.Size(52, 19);
            this.telLabel.TabIndex = 95;
            this.telLabel.Text = "Precio";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Depth = 0;
            this.passLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.passLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.passLabel.Location = new System.Drawing.Point(132, 243);
            this.passLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(81, 19);
            this.passLabel.TabIndex = 94;
            this.passLabel.Text = "Descuento";
            // 
            // ivaBox
            // 
            this.ivaBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ivaBox.FormattingEnabled = true;
            this.ivaBox.Items.AddRange(new object[] {
            "4%",
            "10%",
            "21%"});
            this.ivaBox.Location = new System.Drawing.Point(460, 244);
            this.ivaBox.Name = "ivaBox";
            this.ivaBox.Size = new System.Drawing.Size(121, 21);
            this.ivaBox.TabIndex = 87;
            this.ivaBox.Text = "4%";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(421, 246);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(33, 19);
            this.materialLabel2.TabIndex = 93;
            this.materialLabel2.Text = "IVA";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(422, 291);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(60, 19);
            this.materialLabel1.TabIndex = 92;
            this.materialLabel1.Text = "Tiempo";
            // 
            // tiempoNumeric
            // 
            this.tiempoNumeric.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tiempoNumeric.Location = new System.Drawing.Point(532, 290);
            this.tiempoNumeric.Name = "tiempoNumeric";
            this.tiempoNumeric.Size = new System.Drawing.Size(49, 20);
            this.tiempoNumeric.TabIndex = 88;
            // 
            // AnyadirButton
            // 
            this.AnyadirButton.BackColor = System.Drawing.Color.Transparent;
            this.AnyadirButton.BackgroundImage = global::Listado.Properties.Resources.añadir_blanco;
            this.AnyadirButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AnyadirButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnyadirButton.FlatAppearance.BorderSize = 0;
            this.AnyadirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnyadirButton.Location = new System.Drawing.Point(424, 357);
            this.AnyadirButton.Name = "AnyadirButton";
            this.AnyadirButton.Size = new System.Drawing.Size(45, 40);
            this.AnyadirButton.TabIndex = 89;
            this.AnyadirButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AnyadirButton.UseVisualStyleBackColor = true;
            this.AnyadirButton.Click += new System.EventHandler(this.AnyadirButton_Click);
            // 
            // bVolver
            // 
            this.bVolver.BackColor = System.Drawing.Color.Transparent;
            this.bVolver.BackgroundImage = global::Listado.Properties.Resources.icono_volver;
            this.bVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bVolver.FlatAppearance.BorderSize = 0;
            this.bVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVolver.Location = new System.Drawing.Point(282, 358);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(45, 40);
            this.bVolver.TabIndex = 90;
            this.bVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // materialTabSelector2
            // 
            this.materialTabSelector2.BaseTabControl = null;
            this.materialTabSelector2.Depth = 0;
            this.materialTabSelector2.Location = new System.Drawing.Point(-6, 174);
            this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            this.materialTabSelector2.Size = new System.Drawing.Size(812, 10);
            this.materialTabSelector2.TabIndex = 91;
            this.materialTabSelector2.Text = "materialTabSelector2";
            // 
            // desText
            // 
            this.desText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.desText.Depth = 0;
            this.desText.Hint = "Descripción";
            this.desText.Location = new System.Drawing.Point(227, 123);
            this.desText.MouseState = MaterialSkin.MouseState.HOVER;
            this.desText.Name = "desText";
            this.desText.PasswordChar = '\0';
            this.desText.SelectedText = "";
            this.desText.SelectionLength = 0;
            this.desText.SelectionStart = 0;
            this.desText.Size = new System.Drawing.Size(354, 23);
            this.desText.TabIndex = 83;
            this.desText.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(132, 123);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(89, 19);
            this.materialLabel3.TabIndex = 96;
            this.materialLabel3.Text = "Descripción";
            // 
            // TextoCIFAnyadir
            // 
            this.TextoCIFAnyadir.Depth = 0;
            this.TextoCIFAnyadir.Enabled = false;
            this.TextoCIFAnyadir.Hint = "";
            this.TextoCIFAnyadir.Location = new System.Drawing.Point(121, 375);
            this.TextoCIFAnyadir.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextoCIFAnyadir.Name = "TextoCIFAnyadir";
            this.TextoCIFAnyadir.PasswordChar = '\0';
            this.TextoCIFAnyadir.SelectedText = "";
            this.TextoCIFAnyadir.SelectionLength = 0;
            this.TextoCIFAnyadir.SelectionStart = 0;
            this.TextoCIFAnyadir.Size = new System.Drawing.Size(64, 23);
            this.TextoCIFAnyadir.TabIndex = 97;
            this.TextoCIFAnyadir.UseSystemPasswordChar = false;
            this.TextoCIFAnyadir.Visible = false;
            // 
            // AnyadirServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextoCIFAnyadir);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.desNum);
            this.Controls.Add(this.precioNum);
            this.Controls.Add(this.telLabel);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.ivaBox);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.tiempoNumeric);
            this.Controls.Add(this.AnyadirButton);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.materialTabSelector2);
            this.Controls.Add(this.desText);
            this.Name = "AnyadirServicio";
            this.Text = "Añadir Servicio";
            this.Load += new System.EventHandler(this.AnyadirServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.desNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precioNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiempoNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown desNum;
        private System.Windows.Forms.NumericUpDown precioNum;
        private MaterialSkin.Controls.MaterialLabel telLabel;
        private MaterialSkin.Controls.MaterialLabel passLabel;
        private System.Windows.Forms.ComboBox ivaBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.NumericUpDown tiempoNumeric;
        private System.Windows.Forms.Button AnyadirButton;
        private System.Windows.Forms.Button bVolver;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
        private MaterialSkin.Controls.MaterialSingleLineTextField desText;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        public MaterialSkin.Controls.MaterialSingleLineTextField TextoCIFAnyadir;
    }
}