
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
            this.fechaLabel = new MaterialSkin.Controls.MaterialLabel();
            this.horaLabel = new MaterialSkin.Controls.MaterialLabel();
            this.fechaText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.horaText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.bVolver = new System.Windows.Forms.Button();
            this.editarB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(120, 132);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(23, 19);
            this.materialLabel1.TabIndex = 49;
            this.materialLabel1.Text = "ID";
            // 
            // idText
            // 
            this.idText.Depth = 0;
            this.idText.Enabled = false;
            this.idText.Hint = "ID";
            this.idText.Location = new System.Drawing.Point(149, 132);
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
            // fechaLabel
            // 
            this.fechaLabel.AutoSize = true;
            this.fechaLabel.Depth = 0;
            this.fechaLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.fechaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fechaLabel.Location = new System.Drawing.Point(426, 202);
            this.fechaLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.fechaLabel.Name = "fechaLabel";
            this.fechaLabel.Size = new System.Drawing.Size(49, 19);
            this.fechaLabel.TabIndex = 47;
            this.fechaLabel.Text = "Fecha";
            // 
            // horaLabel
            // 
            this.horaLabel.AutoSize = true;
            this.horaLabel.Depth = 0;
            this.horaLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.horaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.horaLabel.Location = new System.Drawing.Point(101, 202);
            this.horaLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.horaLabel.Name = "horaLabel";
            this.horaLabel.Size = new System.Drawing.Size(42, 19);
            this.horaLabel.TabIndex = 46;
            this.horaLabel.Text = "Hora";
            // 
            // fechaText
            // 
            this.fechaText.Depth = 0;
            this.fechaText.Hint = "Fecha";
            this.fechaText.Location = new System.Drawing.Point(481, 202);
            this.fechaText.MouseState = MaterialSkin.MouseState.HOVER;
            this.fechaText.Name = "fechaText";
            this.fechaText.PasswordChar = '\0';
            this.fechaText.SelectedText = "";
            this.fechaText.SelectionLength = 0;
            this.fechaText.SelectionStart = 0;
            this.fechaText.Size = new System.Drawing.Size(157, 23);
            this.fechaText.TabIndex = 43;
            this.fechaText.UseSystemPasswordChar = false;
            // 
            // horaText
            // 
            this.horaText.Depth = 0;
            this.horaText.Hint = "Hora";
            this.horaText.Location = new System.Drawing.Point(149, 202);
            this.horaText.MouseState = MaterialSkin.MouseState.HOVER;
            this.horaText.Name = "horaText";
            this.horaText.PasswordChar = '\0';
            this.horaText.SelectedText = "";
            this.horaText.SelectionLength = 0;
            this.horaText.SelectionStart = 0;
            this.horaText.Size = new System.Drawing.Size(166, 23);
            this.horaText.TabIndex = 42;
            this.horaText.UseSystemPasswordChar = false;
            // 
            // bVolver
            // 
            this.bVolver.BackColor = System.Drawing.Color.Transparent;
            this.bVolver.BackgroundImage = global::Listado.Properties.Resources.icono_volver;
            this.bVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bVolver.FlatAppearance.BorderSize = 0;
            this.bVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVolver.Location = new System.Drawing.Point(270, 358);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(45, 40);
            this.bVolver.TabIndex = 66;
            this.bVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // editarB
            // 
            this.editarB.BackColor = System.Drawing.Color.Transparent;
            this.editarB.BackgroundImage = global::Listado.Properties.Resources.actualizar;
            this.editarB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editarB.FlatAppearance.BorderSize = 0;
            this.editarB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarB.Location = new System.Drawing.Point(430, 359);
            this.editarB.Name = "editarB";
            this.editarB.Size = new System.Drawing.Size(45, 40);
            this.editarB.TabIndex = 73;
            this.editarB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.editarB.UseVisualStyleBackColor = true;
            this.editarB.Click += new System.EventHandler(this.editarB_Click);
            // 
            // EditarCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editarB);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.fechaLabel);
            this.Controls.Add(this.horaLabel);
            this.Controls.Add(this.fechaText);
            this.Controls.Add(this.horaText);
            this.Name = "EditarCompras";
            this.Text = "Editar Compras";
            this.Load += new System.EventHandler(this.EditarCompras_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField idText;
        private MaterialSkin.Controls.MaterialLabel fechaLabel;
        private MaterialSkin.Controls.MaterialLabel horaLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField fechaText;
        private MaterialSkin.Controls.MaterialSingleLineTextField horaText;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Button editarB;
    }
}