
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
            this.fechaLabel = new MaterialSkin.Controls.MaterialLabel();
            this.horaLabel = new MaterialSkin.Controls.MaterialLabel();
            this.fechaText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.horaText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.bVolver = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fechaLabel
            // 
            this.fechaLabel.AutoSize = true;
            this.fechaLabel.Depth = 0;
            this.fechaLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.fechaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fechaLabel.Location = new System.Drawing.Point(420, 201);
            this.fechaLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.fechaLabel.Name = "fechaLabel";
            this.fechaLabel.Size = new System.Drawing.Size(49, 19);
            this.fechaLabel.TabIndex = 55;
            this.fechaLabel.Text = "Fecha";
            // 
            // horaLabel
            // 
            this.horaLabel.AutoSize = true;
            this.horaLabel.Depth = 0;
            this.horaLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.horaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.horaLabel.Location = new System.Drawing.Point(95, 201);
            this.horaLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.horaLabel.Name = "horaLabel";
            this.horaLabel.Size = new System.Drawing.Size(42, 19);
            this.horaLabel.TabIndex = 54;
            this.horaLabel.Text = "Hora";
            // 
            // fechaText
            // 
            this.fechaText.Depth = 0;
            this.fechaText.Hint = "Fecha";
            this.fechaText.Location = new System.Drawing.Point(475, 201);
            this.fechaText.MouseState = MaterialSkin.MouseState.HOVER;
            this.fechaText.Name = "fechaText";
            this.fechaText.PasswordChar = '\0';
            this.fechaText.SelectedText = "";
            this.fechaText.SelectionLength = 0;
            this.fechaText.SelectionStart = 0;
            this.fechaText.Size = new System.Drawing.Size(157, 23);
            this.fechaText.TabIndex = 51;
            this.fechaText.UseSystemPasswordChar = false;
            // 
            // horaText
            // 
            this.horaText.Depth = 0;
            this.horaText.Hint = "Hora";
            this.horaText.Location = new System.Drawing.Point(143, 201);
            this.horaText.MouseState = MaterialSkin.MouseState.HOVER;
            this.horaText.Name = "horaText";
            this.horaText.PasswordChar = '\0';
            this.horaText.SelectedText = "";
            this.horaText.SelectionLength = 0;
            this.horaText.SelectionStart = 0;
            this.horaText.Size = new System.Drawing.Size(166, 23);
            this.horaText.TabIndex = 50;
            this.horaText.UseSystemPasswordChar = false;
            // 
            // bVolver
            // 
            this.bVolver.BackColor = System.Drawing.Color.Transparent;
            this.bVolver.BackgroundImage = global::Listado.Properties.Resources.icono_volver;
            this.bVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bVolver.FlatAppearance.BorderSize = 0;
            this.bVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVolver.Location = new System.Drawing.Point(264, 357);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(45, 40);
            this.bVolver.TabIndex = 64;
            this.bVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Listado.Properties.Resources.añadir_blanco;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(424, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 40);
            this.button1.TabIndex = 65;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnyadirCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.fechaLabel);
            this.Controls.Add(this.horaLabel);
            this.Controls.Add(this.fechaText);
            this.Controls.Add(this.horaText);
            this.Name = "AnyadirCompras";
            this.Text = "Añadir Compras";
            this.Load += new System.EventHandler(this.AnyadirCompras_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel fechaLabel;
        private MaterialSkin.Controls.MaterialLabel horaLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField fechaText;
        private MaterialSkin.Controls.MaterialSingleLineTextField horaText;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Button button1;
    }
}