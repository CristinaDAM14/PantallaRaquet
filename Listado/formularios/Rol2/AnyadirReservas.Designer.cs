
namespace RaquetZone.formularios.Rol2
{
    partial class AnyadirReservas
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
            this.anyoLabel = new MaterialSkin.Controls.MaterialLabel();
            this.mesLabel = new MaterialSkin.Controls.MaterialLabel();
            this.diaLabel = new MaterialSkin.Controls.MaterialLabel();
            this.diaNum = new System.Windows.Forms.NumericUpDown();
            this.mesNum = new System.Windows.Forms.NumericUpDown();
            this.anyoNum = new System.Windows.Forms.NumericUpDown();
            this.horaLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.idServi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.pistaNumeric = new System.Windows.Forms.NumericUpDown();
            this.editarB = new System.Windows.Forms.Button();
            this.bVolver = new System.Windows.Forms.Button();
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.dniLabel = new MaterialSkin.Controls.MaterialLabel();
            this.dniText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.bCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TextoCIFAnyadir = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.crearB = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buscarUsuario = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.textUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.crearUsuario = new MaterialSkin.Controls.MaterialRaisedButton();
            this.horaBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.diaNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anyoNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pistaNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // anyoLabel
            // 
            this.anyoLabel.AutoSize = true;
            this.anyoLabel.Depth = 0;
            this.anyoLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.anyoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.anyoLabel.Location = new System.Drawing.Point(494, 268);
            this.anyoLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.anyoLabel.Name = "anyoLabel";
            this.anyoLabel.Size = new System.Drawing.Size(36, 19);
            this.anyoLabel.TabIndex = 129;
            this.anyoLabel.Text = "Año";
            // 
            // mesLabel
            // 
            this.mesLabel.AutoSize = true;
            this.mesLabel.Depth = 0;
            this.mesLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.mesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mesLabel.Location = new System.Drawing.Point(423, 268);
            this.mesLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mesLabel.Name = "mesLabel";
            this.mesLabel.Size = new System.Drawing.Size(38, 19);
            this.mesLabel.TabIndex = 128;
            this.mesLabel.Text = "Mes";
            // 
            // diaLabel
            // 
            this.diaLabel.AutoSize = true;
            this.diaLabel.Depth = 0;
            this.diaLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.diaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.diaLabel.Location = new System.Drawing.Point(352, 268);
            this.diaLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.diaLabel.Name = "diaLabel";
            this.diaLabel.Size = new System.Drawing.Size(31, 19);
            this.diaLabel.TabIndex = 127;
            this.diaLabel.Text = "Día";
            // 
            // diaNum
            // 
            this.diaNum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.diaNum.Location = new System.Drawing.Point(342, 290);
            this.diaNum.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.diaNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.diaNum.Name = "diaNum";
            this.diaNum.Size = new System.Drawing.Size(57, 20);
            this.diaNum.TabIndex = 123;
            this.diaNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // mesNum
            // 
            this.mesNum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mesNum.Location = new System.Drawing.Point(413, 290);
            this.mesNum.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.mesNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mesNum.Name = "mesNum";
            this.mesNum.Size = new System.Drawing.Size(57, 20);
            this.mesNum.TabIndex = 124;
            this.mesNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // anyoNum
            // 
            this.anyoNum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anyoNum.Location = new System.Drawing.Point(487, 290);
            this.anyoNum.Maximum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.anyoNum.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.anyoNum.Name = "anyoNum";
            this.anyoNum.Size = new System.Drawing.Size(57, 20);
            this.anyoNum.TabIndex = 125;
            this.anyoNum.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // horaLabel
            // 
            this.horaLabel.AutoSize = true;
            this.horaLabel.Depth = 0;
            this.horaLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.horaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.horaLabel.Location = new System.Drawing.Point(166, 268);
            this.horaLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.horaLabel.Name = "horaLabel";
            this.horaLabel.Size = new System.Drawing.Size(42, 19);
            this.horaLabel.TabIndex = 126;
            this.horaLabel.Text = "Hora";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(97, 137);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(81, 19);
            this.materialLabel4.TabIndex = 120;
            this.materialLabel4.Text = "ID Servicio";
            // 
            // idServi
            // 
            this.idServi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.idServi.Depth = 0;
            this.idServi.Enabled = false;
            this.idServi.Hint = "ID Servicio";
            this.idServi.Location = new System.Drawing.Point(184, 137);
            this.idServi.MouseState = MaterialSkin.MouseState.HOVER;
            this.idServi.Name = "idServi";
            this.idServi.PasswordChar = '\0';
            this.idServi.SelectedText = "";
            this.idServi.SelectionLength = 0;
            this.idServi.SelectionStart = 0;
            this.idServi.Size = new System.Drawing.Size(82, 23);
            this.idServi.TabIndex = 119;
            this.idServi.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(598, 291);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(100, 19);
            this.materialLabel3.TabIndex = 118;
            this.materialLabel3.Text = "Número pista";
            // 
            // pistaNumeric
            // 
            this.pistaNumeric.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pistaNumeric.Location = new System.Drawing.Point(704, 290);
            this.pistaNumeric.Name = "pistaNumeric";
            this.pistaNumeric.Size = new System.Drawing.Size(49, 20);
            this.pistaNumeric.TabIndex = 117;
            // 
            // editarB
            // 
            this.editarB.BackColor = System.Drawing.Color.Transparent;
            this.editarB.BackgroundImage = global::Listado.Properties.Resources.añadir_blanco;
            this.editarB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editarB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editarB.FlatAppearance.BorderSize = 0;
            this.editarB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarB.Location = new System.Drawing.Point(427, 357);
            this.editarB.Name = "editarB";
            this.editarB.Size = new System.Drawing.Size(45, 40);
            this.editarB.TabIndex = 116;
            this.editarB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.editarB.UseVisualStyleBackColor = true;
            this.editarB.Click += new System.EventHandler(this.editarB_Click);
            // 
            // bVolver
            // 
            this.bVolver.BackColor = System.Drawing.Color.Transparent;
            this.bVolver.BackgroundImage = global::Listado.Properties.Resources.icono_volver;
            this.bVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bVolver.FlatAppearance.BorderSize = 0;
            this.bVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVolver.Location = new System.Drawing.Point(285, 356);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(45, 40);
            this.bVolver.TabIndex = 115;
            this.bVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // materialTabSelector2
            // 
            this.materialTabSelector2.BaseTabControl = null;
            this.materialTabSelector2.Depth = 0;
            this.materialTabSelector2.Location = new System.Drawing.Point(1, 212);
            this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            this.materialTabSelector2.Size = new System.Drawing.Size(812, 10);
            this.materialTabSelector2.TabIndex = 114;
            this.materialTabSelector2.Text = "materialTabSelector2";
            // 
            // dniLabel
            // 
            this.dniLabel.AutoSize = true;
            this.dniLabel.Depth = 0;
            this.dniLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.dniLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dniLabel.Location = new System.Drawing.Point(396, 107);
            this.dniLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.dniLabel.Name = "dniLabel";
            this.dniLabel.Size = new System.Drawing.Size(85, 19);
            this.dniLabel.TabIndex = 111;
            this.dniLabel.Text = "DNI Cliente";
            // 
            // dniText
            // 
            this.dniText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dniText.Depth = 0;
            this.dniText.Enabled = false;
            this.dniText.Hint = "DNI Cliente";
            this.dniText.Location = new System.Drawing.Point(487, 107);
            this.dniText.MouseState = MaterialSkin.MouseState.HOVER;
            this.dniText.Name = "dniText";
            this.dniText.PasswordChar = '\0';
            this.dniText.SelectedText = "";
            this.dniText.SelectionLength = 0;
            this.dniText.SelectionStart = 0;
            this.dniText.Size = new System.Drawing.Size(135, 23);
            this.dniText.TabIndex = 110;
            this.dniText.UseSystemPasswordChar = false;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(272, 137);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(69, 23);
            this.materialRaisedButton1.TabIndex = 131;
            this.materialRaisedButton1.Text = "Buscar";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // bCliente
            // 
            this.bCliente.Depth = 0;
            this.bCliente.Location = new System.Drawing.Point(629, 107);
            this.bCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.bCliente.Name = "bCliente";
            this.bCliente.Primary = true;
            this.bCliente.Size = new System.Drawing.Size(69, 23);
            this.bCliente.TabIndex = 132;
            this.bCliente.Text = "Buscar";
            this.bCliente.UseVisualStyleBackColor = true;
            this.bCliente.Click += new System.EventHandler(this.bCliente_Click);
            // 
            // TextoCIFAnyadir
            // 
            this.TextoCIFAnyadir.Depth = 0;
            this.TextoCIFAnyadir.Enabled = false;
            this.TextoCIFAnyadir.Hint = "";
            this.TextoCIFAnyadir.Location = new System.Drawing.Point(602, 164);
            this.TextoCIFAnyadir.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextoCIFAnyadir.Name = "TextoCIFAnyadir";
            this.TextoCIFAnyadir.PasswordChar = '\0';
            this.TextoCIFAnyadir.SelectedText = "";
            this.TextoCIFAnyadir.SelectionLength = 0;
            this.TextoCIFAnyadir.SelectionStart = 0;
            this.TextoCIFAnyadir.Size = new System.Drawing.Size(15, 23);
            this.TextoCIFAnyadir.TabIndex = 133;
            this.TextoCIFAnyadir.UseSystemPasswordChar = false;
            this.TextoCIFAnyadir.Visible = false;
            // 
            // crearB
            // 
            this.crearB.Depth = 0;
            this.crearB.Location = new System.Drawing.Point(704, 107);
            this.crearB.MouseState = MaterialSkin.MouseState.HOVER;
            this.crearB.Name = "crearB";
            this.crearB.Primary = true;
            this.crearB.Size = new System.Drawing.Size(69, 23);
            this.crearB.TabIndex = 134;
            this.crearB.Text = "Crear";
            this.crearB.UseVisualStyleBackColor = true;
            this.crearB.Click += new System.EventHandler(this.crearB_Click);
            // 
            // buscarUsuario
            // 
            this.buscarUsuario.Depth = 0;
            this.buscarUsuario.Location = new System.Drawing.Point(629, 163);
            this.buscarUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.buscarUsuario.Name = "buscarUsuario";
            this.buscarUsuario.Primary = true;
            this.buscarUsuario.Size = new System.Drawing.Size(69, 23);
            this.buscarUsuario.TabIndex = 137;
            this.buscarUsuario.Text = "Buscar";
            this.buscarUsuario.UseVisualStyleBackColor = true;
            this.buscarUsuario.Click += new System.EventHandler(this.buscarUsuario_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(396, 164);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(90, 19);
            this.materialLabel1.TabIndex = 136;
            this.materialLabel1.Text = "DNI Usuario";
            // 
            // textUsuario
            // 
            this.textUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textUsuario.Depth = 0;
            this.textUsuario.Enabled = false;
            this.textUsuario.Hint = "DNI Usuario";
            this.textUsuario.Location = new System.Drawing.Point(492, 164);
            this.textUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.PasswordChar = '\0';
            this.textUsuario.SelectedText = "";
            this.textUsuario.SelectionLength = 0;
            this.textUsuario.SelectionStart = 0;
            this.textUsuario.Size = new System.Drawing.Size(134, 23);
            this.textUsuario.TabIndex = 135;
            this.textUsuario.UseSystemPasswordChar = false;
            // 
            // crearUsuario
            // 
            this.crearUsuario.Depth = 0;
            this.crearUsuario.Location = new System.Drawing.Point(704, 163);
            this.crearUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.crearUsuario.Name = "crearUsuario";
            this.crearUsuario.Primary = true;
            this.crearUsuario.Size = new System.Drawing.Size(69, 23);
            this.crearUsuario.TabIndex = 138;
            this.crearUsuario.Text = "Crear";
            this.crearUsuario.UseVisualStyleBackColor = true;
            this.crearUsuario.Click += new System.EventHandler(this.crearUsuario_Click);
            // 
            // horaBox
            // 
            this.horaBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.horaBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.horaBox.FormattingEnabled = true;
            this.horaBox.Items.AddRange(new object[] {
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00"});
            this.horaBox.Location = new System.Drawing.Point(127, 291);
            this.horaBox.Name = "horaBox";
            this.horaBox.Size = new System.Drawing.Size(121, 21);
            this.horaBox.TabIndex = 139;
            // 
            // AnyadirReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.horaBox);
            this.Controls.Add(this.crearUsuario);
            this.Controls.Add(this.buscarUsuario);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.crearB);
            this.Controls.Add(this.TextoCIFAnyadir);
            this.Controls.Add(this.bCliente);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.anyoLabel);
            this.Controls.Add(this.mesLabel);
            this.Controls.Add(this.diaLabel);
            this.Controls.Add(this.diaNum);
            this.Controls.Add(this.mesNum);
            this.Controls.Add(this.anyoNum);
            this.Controls.Add(this.horaLabel);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.idServi);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.pistaNumeric);
            this.Controls.Add(this.editarB);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.materialTabSelector2);
            this.Controls.Add(this.dniLabel);
            this.Controls.Add(this.dniText);
            this.Name = "AnyadirReservas";
            this.Text = "Añadir Reservas";
            this.Load += new System.EventHandler(this.AnyadirReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diaNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anyoNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pistaNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel anyoLabel;
        private MaterialSkin.Controls.MaterialLabel mesLabel;
        private MaterialSkin.Controls.MaterialLabel diaLabel;
        private System.Windows.Forms.NumericUpDown diaNum;
        private System.Windows.Forms.NumericUpDown mesNum;
        private System.Windows.Forms.NumericUpDown anyoNum;
        private MaterialSkin.Controls.MaterialLabel horaLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField idServi;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.NumericUpDown pistaNumeric;
        private System.Windows.Forms.Button editarB;
        private System.Windows.Forms.Button bVolver;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
        private MaterialSkin.Controls.MaterialLabel dniLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField dniText;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton bCliente;
        public MaterialSkin.Controls.MaterialSingleLineTextField TextoCIFAnyadir;
        private MaterialSkin.Controls.MaterialRaisedButton crearB;
        private MaterialSkin.Controls.MaterialRaisedButton buscarUsuario;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField textUsuario;
        private MaterialSkin.Controls.MaterialRaisedButton crearUsuario;
        private System.Windows.Forms.ComboBox horaBox;
    }
}