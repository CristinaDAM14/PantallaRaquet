
namespace RaquetZone.formularios.Rol2
{
    partial class EmailClientes
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
            this.destinatarioText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.asuntoText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.bodyText = new System.Windows.Forms.RichTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.bVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // destinatarioText
            // 
            this.destinatarioText.Depth = 0;
            this.destinatarioText.Enabled = false;
            this.destinatarioText.Hint = "";
            this.destinatarioText.Location = new System.Drawing.Point(59, 116);
            this.destinatarioText.MouseState = MaterialSkin.MouseState.HOVER;
            this.destinatarioText.Name = "destinatarioText";
            this.destinatarioText.PasswordChar = '\0';
            this.destinatarioText.SelectedText = "";
            this.destinatarioText.SelectionLength = 0;
            this.destinatarioText.SelectionStart = 0;
            this.destinatarioText.Size = new System.Drawing.Size(492, 23);
            this.destinatarioText.TabIndex = 0;
            this.destinatarioText.UseSystemPasswordChar = false;
            // 
            // asuntoText
            // 
            this.asuntoText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.asuntoText.Depth = 0;
            this.asuntoText.Hint = "";
            this.asuntoText.Location = new System.Drawing.Point(59, 190);
            this.asuntoText.MouseState = MaterialSkin.MouseState.HOVER;
            this.asuntoText.Name = "asuntoText";
            this.asuntoText.PasswordChar = '\0';
            this.asuntoText.SelectedText = "";
            this.asuntoText.SelectionLength = 0;
            this.asuntoText.SelectionStart = 0;
            this.asuntoText.Size = new System.Drawing.Size(492, 23);
            this.asuntoText.TabIndex = 1;
            this.asuntoText.UseSystemPasswordChar = false;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = null;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-10, 245);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(721, 10);
            this.materialTabSelector1.TabIndex = 2;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // bodyText
            // 
            this.bodyText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bodyText.Location = new System.Drawing.Point(59, 282);
            this.bodyText.Name = "bodyText";
            this.bodyText.Size = new System.Drawing.Size(492, 177);
            this.bodyText.TabIndex = 2;
            this.bodyText.Text = "";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(55, 94);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(91, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Destinatario";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(55, 168);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(57, 19);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "Asunto";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(584, 355);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(77, 36);
            this.materialRaisedButton1.TabIndex = 3;
            this.materialRaisedButton1.Text = "Enviar";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // bVolver
            // 
            this.bVolver.BackColor = System.Drawing.Color.Transparent;
            this.bVolver.BackgroundImage = global::Listado.Properties.Resources.icono_volver;
            this.bVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bVolver.FlatAppearance.BorderSize = 0;
            this.bVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVolver.Location = new System.Drawing.Point(12, 457);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(29, 24);
            this.bVolver.TabIndex = 4;
            this.bVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // EmailClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 493);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.bodyText);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.asuntoText);
            this.Controls.Add(this.destinatarioText);
            this.MaximizeBox = false;
            this.Name = "EmailClientes";
            this.Text = "Enviar email a un cliente";
            this.Load += new System.EventHandler(this.EmailClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField destinatarioText;
        private MaterialSkin.Controls.MaterialSingleLineTextField asuntoText;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.RichTextBox bodyText;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.Button bVolver;
    }
}