
namespace RaquetZone.formularios.Rol2
{
    partial class AnyadirComprasProd
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
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.cantidadNum = new System.Windows.Forms.NumericUpDown();
            this.passLabel = new MaterialSkin.Controls.MaterialLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.bVolver = new System.Windows.Forms.Button();
            this.idcompraText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.crearB = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cifEmpresa = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.boxProducto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNum)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(172, 142);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(62, 19);
            this.materialLabel4.TabIndex = 100;
            this.materialLabel4.Text = "Compra";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(136, 273);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(70, 19);
            this.materialLabel3.TabIndex = 99;
            this.materialLabel3.Text = "Producto";
            // 
            // cantidadNum
            // 
            this.cantidadNum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cantidadNum.Location = new System.Drawing.Point(575, 272);
            this.cantidadNum.Name = "cantidadNum";
            this.cantidadNum.Size = new System.Drawing.Size(49, 20);
            this.cantidadNum.TabIndex = 89;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Depth = 0;
            this.passLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.passLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.passLabel.Location = new System.Drawing.Point(501, 273);
            this.passLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(68, 19);
            this.passLabel.TabIndex = 97;
            this.passLabel.Text = "Cantidad";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Listado.Properties.Resources.añadir_blanco;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(413, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 40);
            this.button1.TabIndex = 93;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bVolver
            // 
            this.bVolver.BackColor = System.Drawing.Color.Transparent;
            this.bVolver.BackgroundImage = global::Listado.Properties.Resources.icono_volver;
            this.bVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bVolver.FlatAppearance.BorderSize = 0;
            this.bVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVolver.Location = new System.Drawing.Point(271, 373);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(45, 40);
            this.bVolver.TabIndex = 94;
            this.bVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // idcompraText
            // 
            this.idcompraText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.idcompraText.Depth = 0;
            this.idcompraText.Enabled = false;
            this.idcompraText.Hint = "ID Compra";
            this.idcompraText.Location = new System.Drawing.Point(240, 142);
            this.idcompraText.MouseState = MaterialSkin.MouseState.HOVER;
            this.idcompraText.Name = "idcompraText";
            this.idcompraText.PasswordChar = '\0';
            this.idcompraText.SelectedText = "";
            this.idcompraText.SelectionLength = 0;
            this.idcompraText.SelectionStart = 0;
            this.idcompraText.Size = new System.Drawing.Size(206, 23);
            this.idcompraText.TabIndex = 87;
            this.idcompraText.UseSystemPasswordChar = false;
            // 
            // materialTabSelector2
            // 
            this.materialTabSelector2.BaseTabControl = null;
            this.materialTabSelector2.Depth = 0;
            this.materialTabSelector2.Location = new System.Drawing.Point(-9, 219);
            this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            this.materialTabSelector2.Size = new System.Drawing.Size(812, 10);
            this.materialTabSelector2.TabIndex = 103;
            this.materialTabSelector2.Text = "materialTabSelector2";
            // 
            // crearB
            // 
            this.crearB.Depth = 0;
            this.crearB.Location = new System.Drawing.Point(555, 142);
            this.crearB.MouseState = MaterialSkin.MouseState.HOVER;
            this.crearB.Name = "crearB";
            this.crearB.Primary = true;
            this.crearB.Size = new System.Drawing.Size(69, 23);
            this.crearB.TabIndex = 136;
            this.crearB.Text = "Crear";
            this.crearB.UseVisualStyleBackColor = true;
            this.crearB.Click += new System.EventHandler(this.crearB_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(468, 142);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(69, 23);
            this.materialRaisedButton1.TabIndex = 135;
            this.materialRaisedButton1.Text = "Buscar";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // cifEmpresa
            // 
            this.cifEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cifEmpresa.Depth = 0;
            this.cifEmpresa.Enabled = false;
            this.cifEmpresa.Hint = "";
            this.cifEmpresa.Location = new System.Drawing.Point(331, 142);
            this.cifEmpresa.MouseState = MaterialSkin.MouseState.HOVER;
            this.cifEmpresa.Name = "cifEmpresa";
            this.cifEmpresa.PasswordChar = '\0';
            this.cifEmpresa.SelectedText = "";
            this.cifEmpresa.SelectionLength = 0;
            this.cifEmpresa.SelectionStart = 0;
            this.cifEmpresa.Size = new System.Drawing.Size(115, 23);
            this.cifEmpresa.TabIndex = 137;
            this.cifEmpresa.UseSystemPasswordChar = false;
            this.cifEmpresa.Visible = false;
            // 
            // boxProducto
            // 
            this.boxProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxProducto.FormattingEnabled = true;
            this.boxProducto.Location = new System.Drawing.Point(212, 271);
            this.boxProducto.Name = "boxProducto";
            this.boxProducto.Size = new System.Drawing.Size(193, 21);
            this.boxProducto.TabIndex = 138;
            // 
            // AnyadirComprasProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boxProducto);
            this.Controls.Add(this.cifEmpresa);
            this.Controls.Add(this.crearB);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialTabSelector2);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.cantidadNum);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.idcompraText);
            this.Name = "AnyadirComprasProd";
            this.Text = "Añadir la compra de un producto";
            this.Load += new System.EventHandler(this.AnyadirComprasProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.NumericUpDown cantidadNum;
        private MaterialSkin.Controls.MaterialLabel passLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bVolver;
        private MaterialSkin.Controls.MaterialSingleLineTextField idcompraText;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
        private MaterialSkin.Controls.MaterialRaisedButton crearB;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        public MaterialSkin.Controls.MaterialSingleLineTextField cifEmpresa;
        public System.Windows.Forms.ComboBox boxProducto;
    }
}