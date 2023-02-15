
namespace RaquetZone.formularios.Rol2
{
    partial class EditarCompras
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.idText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.minLabel = new MaterialSkin.Controls.MaterialLabel();
            this.minNum = new System.Windows.Forms.NumericUpDown();
            this.horaNum = new System.Windows.Forms.NumericUpDown();
            this.anyoLabel = new MaterialSkin.Controls.MaterialLabel();
            this.mesLabel = new MaterialSkin.Controls.MaterialLabel();
            this.diaLabel = new MaterialSkin.Controls.MaterialLabel();
            this.diaNum = new System.Windows.Forms.NumericUpDown();
            this.mesNum = new System.Windows.Forms.NumericUpDown();
            this.anyoNum = new System.Windows.Forms.NumericUpDown();
            this.horaLabel = new MaterialSkin.Controls.MaterialLabel();
            this.editarB = new System.Windows.Forms.Button();
            this.bVolver = new System.Windows.Forms.Button();
            this.TextoCIFAnyadir = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dniText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.minNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horaNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anyoNum)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(152, 128);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(23, 19);
            this.materialLabel1.TabIndex = 49;
            this.materialLabel1.Text = "ID";
            // 
            // idText
            // 
            this.idText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.idText.Depth = 0;
            this.idText.Enabled = false;
            this.idText.Hint = "ID";
            this.idText.Location = new System.Drawing.Point(181, 128);
            this.idText.MouseState = MaterialSkin.MouseState.HOVER;
            this.idText.Name = "idText";
            this.idText.PasswordChar = '\0';
            this.idText.SelectedText = "";
            this.idText.SelectionLength = 0;
            this.idText.SelectionStart = 0;
            this.idText.Size = new System.Drawing.Size(73, 23);
            this.idText.TabIndex = 48;
            this.idText.UseSystemPasswordChar = false;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Depth = 0;
            this.minLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.minLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.minLabel.Location = new System.Drawing.Point(251, 206);
            this.minLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(56, 19);
            this.minLabel.TabIndex = 84;
            this.minLabel.Text = "Minuto";
            // 
            // minNum
            // 
            this.minNum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minNum.Location = new System.Drawing.Point(245, 228);
            this.minNum.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minNum.Name = "minNum";
            this.minNum.Size = new System.Drawing.Size(57, 20);
            this.minNum.TabIndex = 2;
            // 
            // horaNum
            // 
            this.horaNum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.horaNum.Location = new System.Drawing.Point(171, 228);
            this.horaNum.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.horaNum.Name = "horaNum";
            this.horaNum.Size = new System.Drawing.Size(57, 20);
            this.horaNum.TabIndex = 1;
            // 
            // anyoLabel
            // 
            this.anyoLabel.AutoSize = true;
            this.anyoLabel.Depth = 0;
            this.anyoLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.anyoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.anyoLabel.Location = new System.Drawing.Point(568, 206);
            this.anyoLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.anyoLabel.Name = "anyoLabel";
            this.anyoLabel.Size = new System.Drawing.Size(36, 19);
            this.anyoLabel.TabIndex = 83;
            this.anyoLabel.Text = "Año";
            // 
            // mesLabel
            // 
            this.mesLabel.AutoSize = true;
            this.mesLabel.Depth = 0;
            this.mesLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.mesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mesLabel.Location = new System.Drawing.Point(497, 206);
            this.mesLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mesLabel.Name = "mesLabel";
            this.mesLabel.Size = new System.Drawing.Size(38, 19);
            this.mesLabel.TabIndex = 82;
            this.mesLabel.Text = "Mes";
            // 
            // diaLabel
            // 
            this.diaLabel.AutoSize = true;
            this.diaLabel.Depth = 0;
            this.diaLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.diaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.diaLabel.Location = new System.Drawing.Point(426, 206);
            this.diaLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.diaLabel.Name = "diaLabel";
            this.diaLabel.Size = new System.Drawing.Size(31, 19);
            this.diaLabel.TabIndex = 81;
            this.diaLabel.Text = "Día";
            // 
            // diaNum
            // 
            this.diaNum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.diaNum.Location = new System.Drawing.Point(416, 228);
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
            // mesNum
            // 
            this.mesNum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mesNum.Location = new System.Drawing.Point(487, 228);
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
            // anyoNum
            // 
            this.anyoNum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anyoNum.Location = new System.Drawing.Point(561, 228);
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
            // horaLabel
            // 
            this.horaLabel.AutoSize = true;
            this.horaLabel.Depth = 0;
            this.horaLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.horaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.horaLabel.Location = new System.Drawing.Point(177, 206);
            this.horaLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.horaLabel.Name = "horaLabel";
            this.horaLabel.Size = new System.Drawing.Size(42, 19);
            this.horaLabel.TabIndex = 80;
            this.horaLabel.Text = "Hora";
            // 
            // editarB
            // 
            this.editarB.BackColor = System.Drawing.Color.Transparent;
            this.editarB.BackgroundImage = global::Listado.Properties.Resources.actualizar;
            this.editarB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editarB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editarB.FlatAppearance.BorderSize = 0;
            this.editarB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarB.Location = new System.Drawing.Point(430, 359);
            this.editarB.Name = "editarB";
            this.editarB.Size = new System.Drawing.Size(45, 40);
            this.editarB.TabIndex = 6;
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
            this.bVolver.Location = new System.Drawing.Point(270, 358);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(45, 40);
            this.bVolver.TabIndex = 7;
            this.bVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // TextoCIFAnyadir
            // 
            this.TextoCIFAnyadir.Depth = 0;
            this.TextoCIFAnyadir.Enabled = false;
            this.TextoCIFAnyadir.Hint = "";
            this.TextoCIFAnyadir.Location = new System.Drawing.Point(202, 128);
            this.TextoCIFAnyadir.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextoCIFAnyadir.Name = "TextoCIFAnyadir";
            this.TextoCIFAnyadir.PasswordChar = '\0';
            this.TextoCIFAnyadir.SelectedText = "";
            this.TextoCIFAnyadir.SelectionLength = 0;
            this.TextoCIFAnyadir.SelectionStart = 0;
            this.TextoCIFAnyadir.Size = new System.Drawing.Size(52, 23);
            this.TextoCIFAnyadir.TabIndex = 85;
            this.TextoCIFAnyadir.UseSystemPasswordChar = false;
            this.TextoCIFAnyadir.Visible = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(401, 128);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(34, 19);
            this.materialLabel2.TabIndex = 87;
            this.materialLabel2.Text = "DNI";
            // 
            // dniText
            // 
            this.dniText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dniText.Depth = 0;
            this.dniText.Enabled = false;
            this.dniText.Hint = "DNI";
            this.dniText.Location = new System.Drawing.Point(441, 128);
            this.dniText.MouseState = MaterialSkin.MouseState.HOVER;
            this.dniText.Name = "dniText";
            this.dniText.PasswordChar = '\0';
            this.dniText.SelectedText = "";
            this.dniText.SelectionLength = 0;
            this.dniText.SelectionStart = 0;
            this.dniText.Size = new System.Drawing.Size(177, 23);
            this.dniText.TabIndex = 86;
            this.dniText.UseSystemPasswordChar = false;
            // 
            // EditarCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialLabel2);
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
            this.Controls.Add(this.horaLabel);
            this.Controls.Add(this.editarB);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.idText);
            this.MaximizeBox = false;
            this.Name = "EditarCompras";
            this.Text = "Editar Compras";
            this.Load += new System.EventHandler(this.EditarCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horaNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anyoNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField idText;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Button editarB;
        private MaterialSkin.Controls.MaterialLabel minLabel;
        private System.Windows.Forms.NumericUpDown minNum;
        private System.Windows.Forms.NumericUpDown horaNum;
        private MaterialSkin.Controls.MaterialLabel anyoLabel;
        private MaterialSkin.Controls.MaterialLabel mesLabel;
        private MaterialSkin.Controls.MaterialLabel diaLabel;
        private System.Windows.Forms.NumericUpDown diaNum;
        private System.Windows.Forms.NumericUpDown mesNum;
        private System.Windows.Forms.NumericUpDown anyoNum;
        private MaterialSkin.Controls.MaterialLabel horaLabel;
        public MaterialSkin.Controls.MaterialSingleLineTextField TextoCIFAnyadir;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField dniText;
    }
}