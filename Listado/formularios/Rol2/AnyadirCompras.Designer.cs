
namespace RaquetZone.formularios.Rol2
{
    partial class AnyadirCompras
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
            this.horaLabel = new MaterialSkin.Controls.MaterialLabel();
            this.bVolver = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.anyoNum = new System.Windows.Forms.NumericUpDown();
            this.mesNum = new System.Windows.Forms.NumericUpDown();
            this.diaNum = new System.Windows.Forms.NumericUpDown();
            this.diaLabel = new MaterialSkin.Controls.MaterialLabel();
            this.mesLabel = new MaterialSkin.Controls.MaterialLabel();
            this.anyoLabel = new MaterialSkin.Controls.MaterialLabel();
            this.horaNum = new System.Windows.Forms.NumericUpDown();
            this.minNum = new System.Windows.Forms.NumericUpDown();
            this.minLabel = new MaterialSkin.Controls.MaterialLabel();
            this.TextoCIFAnyadir = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.crearB = new MaterialSkin.Controls.MaterialRaisedButton();
            this.bCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dniLabel = new MaterialSkin.Controls.MaterialLabel();
            this.dniText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.anyoNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horaNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNum)).BeginInit();
            this.SuspendLayout();
            // 
            // horaLabel
            // 
            this.horaLabel.AutoSize = true;
            this.horaLabel.Depth = 0;
            this.horaLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.horaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.horaLabel.Location = new System.Drawing.Point(164, 212);
            this.horaLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.horaLabel.Name = "horaLabel";
            this.horaLabel.Size = new System.Drawing.Size(42, 19);
            this.horaLabel.TabIndex = 54;
            this.horaLabel.Text = "Hora";
            // 
            // bVolver
            // 
            this.bVolver.BackColor = System.Drawing.Color.Transparent;
            this.bVolver.BackgroundImage = global::Listado.Properties.Resources.icono_volver;
            this.bVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bVolver.FlatAppearance.BorderSize = 0;
            this.bVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVolver.Location = new System.Drawing.Point(264, 357);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(45, 40);
            this.bVolver.TabIndex = 7;
            this.bVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Listado.Properties.Resources.añadir_blanco;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(424, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 40);
            this.button1.TabIndex = 6;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // anyoNum
            // 
            this.anyoNum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anyoNum.Location = new System.Drawing.Point(548, 234);
            this.anyoNum.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.anyoNum.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.anyoNum.Name = "anyoNum";
            this.anyoNum.Size = new System.Drawing.Size(57, 20);
            this.anyoNum.TabIndex = 5;
            this.anyoNum.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // mesNum
            // 
            this.mesNum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mesNum.Location = new System.Drawing.Point(474, 234);
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
            this.mesNum.TabIndex = 4;
            this.mesNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // diaNum
            // 
            this.diaNum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.diaNum.Location = new System.Drawing.Point(403, 234);
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
            this.diaNum.TabIndex = 3;
            this.diaNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // diaLabel
            // 
            this.diaLabel.AutoSize = true;
            this.diaLabel.Depth = 0;
            this.diaLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.diaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.diaLabel.Location = new System.Drawing.Point(413, 212);
            this.diaLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.diaLabel.Name = "diaLabel";
            this.diaLabel.Size = new System.Drawing.Size(31, 19);
            this.diaLabel.TabIndex = 69;
            this.diaLabel.Text = "Día";
            // 
            // mesLabel
            // 
            this.mesLabel.AutoSize = true;
            this.mesLabel.Depth = 0;
            this.mesLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.mesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mesLabel.Location = new System.Drawing.Point(484, 212);
            this.mesLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mesLabel.Name = "mesLabel";
            this.mesLabel.Size = new System.Drawing.Size(38, 19);
            this.mesLabel.TabIndex = 70;
            this.mesLabel.Text = "Mes";
            // 
            // anyoLabel
            // 
            this.anyoLabel.AutoSize = true;
            this.anyoLabel.Depth = 0;
            this.anyoLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.anyoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.anyoLabel.Location = new System.Drawing.Point(555, 212);
            this.anyoLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.anyoLabel.Name = "anyoLabel";
            this.anyoLabel.Size = new System.Drawing.Size(36, 19);
            this.anyoLabel.TabIndex = 71;
            this.anyoLabel.Text = "Año";
            // 
            // horaNum
            // 
            this.horaNum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.horaNum.Location = new System.Drawing.Point(158, 234);
            this.horaNum.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.horaNum.Name = "horaNum";
            this.horaNum.Size = new System.Drawing.Size(57, 20);
            this.horaNum.TabIndex = 1;
            // 
            // minNum
            // 
            this.minNum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minNum.Location = new System.Drawing.Point(232, 234);
            this.minNum.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minNum.Name = "minNum";
            this.minNum.Size = new System.Drawing.Size(57, 20);
            this.minNum.TabIndex = 2;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Depth = 0;
            this.minLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.minLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.minLabel.Location = new System.Drawing.Point(238, 212);
            this.minLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(56, 19);
            this.minLabel.TabIndex = 74;
            this.minLabel.Text = "Minuto";
            // 
            // TextoCIFAnyadir
            // 
            this.TextoCIFAnyadir.Depth = 0;
            this.TextoCIFAnyadir.Enabled = false;
            this.TextoCIFAnyadir.Hint = "";
            this.TextoCIFAnyadir.Location = new System.Drawing.Point(116, 374);
            this.TextoCIFAnyadir.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextoCIFAnyadir.Name = "TextoCIFAnyadir";
            this.TextoCIFAnyadir.PasswordChar = '\0';
            this.TextoCIFAnyadir.SelectedText = "";
            this.TextoCIFAnyadir.SelectionLength = 0;
            this.TextoCIFAnyadir.SelectionStart = 0;
            this.TextoCIFAnyadir.Size = new System.Drawing.Size(64, 23);
            this.TextoCIFAnyadir.TabIndex = 75;
            this.TextoCIFAnyadir.UseSystemPasswordChar = false;
            this.TextoCIFAnyadir.Visible = false;
            // 
            // crearB
            // 
            this.crearB.Depth = 0;
            this.crearB.Location = new System.Drawing.Point(528, 127);
            this.crearB.MouseState = MaterialSkin.MouseState.HOVER;
            this.crearB.Name = "crearB";
            this.crearB.Primary = true;
            this.crearB.Size = new System.Drawing.Size(69, 23);
            this.crearB.TabIndex = 138;
            this.crearB.Text = "Crear";
            this.crearB.UseVisualStyleBackColor = true;
            this.crearB.Click += new System.EventHandler(this.crearB_Click);
            // 
            // bCliente
            // 
            this.bCliente.Depth = 0;
            this.bCliente.Location = new System.Drawing.Point(453, 127);
            this.bCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.bCliente.Name = "bCliente";
            this.bCliente.Primary = true;
            this.bCliente.Size = new System.Drawing.Size(69, 23);
            this.bCliente.TabIndex = 137;
            this.bCliente.Text = "Buscar";
            this.bCliente.UseVisualStyleBackColor = true;
            this.bCliente.Click += new System.EventHandler(this.bCliente_Click);
            // 
            // dniLabel
            // 
            this.dniLabel.AutoSize = true;
            this.dniLabel.Depth = 0;
            this.dniLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.dniLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dniLabel.Location = new System.Drawing.Point(142, 127);
            this.dniLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.dniLabel.Name = "dniLabel";
            this.dniLabel.Size = new System.Drawing.Size(85, 19);
            this.dniLabel.TabIndex = 136;
            this.dniLabel.Text = "DNI Cliente";
            // 
            // dniText
            // 
            this.dniText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dniText.Depth = 0;
            this.dniText.Enabled = false;
            this.dniText.Hint = "DNI Cliente";
            this.dniText.Location = new System.Drawing.Point(233, 127);
            this.dniText.MouseState = MaterialSkin.MouseState.HOVER;
            this.dniText.Name = "dniText";
            this.dniText.PasswordChar = '\0';
            this.dniText.SelectedText = "";
            this.dniText.SelectionLength = 0;
            this.dniText.SelectionStart = 0;
            this.dniText.Size = new System.Drawing.Size(211, 23);
            this.dniText.TabIndex = 135;
            this.dniText.UseSystemPasswordChar = false;
            // 
            // AnyadirCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crearB);
            this.Controls.Add(this.bCliente);
            this.Controls.Add(this.dniLabel);
            this.Controls.Add(this.dniText);
            this.Controls.Add(this.TextoCIFAnyadir);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.minNum);
            this.Controls.Add(this.horaNum);
            this.Controls.Add(this.anyoLabel);
            this.Controls.Add(this.mesLabel);
            this.Controls.Add(this.diaLabel);
            this.Controls.Add(this.diaNum);
            this.Controls.Add(this.mesNum);
            this.Controls.Add(this.anyoNum);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.horaLabel);
            this.MaximizeBox = false;
            this.Name = "AnyadirCompras";
            this.Text = "Añadir Compras";
            this.Load += new System.EventHandler(this.AnyadirCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.anyoNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horaNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel horaLabel;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown anyoNum;
        private System.Windows.Forms.NumericUpDown mesNum;
        private System.Windows.Forms.NumericUpDown diaNum;
        private MaterialSkin.Controls.MaterialLabel diaLabel;
        private MaterialSkin.Controls.MaterialLabel mesLabel;
        private MaterialSkin.Controls.MaterialLabel anyoLabel;
        private System.Windows.Forms.NumericUpDown horaNum;
        private System.Windows.Forms.NumericUpDown minNum;
        private MaterialSkin.Controls.MaterialLabel minLabel;
        public MaterialSkin.Controls.MaterialSingleLineTextField TextoCIFAnyadir;
        private MaterialSkin.Controls.MaterialRaisedButton crearB;
        private MaterialSkin.Controls.MaterialRaisedButton bCliente;
        private MaterialSkin.Controls.MaterialLabel dniLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField dniText;
    }
}