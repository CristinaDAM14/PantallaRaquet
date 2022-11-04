
namespace RaquetZone.formularios
{
    partial class Login
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
            this.dniText = new System.Windows.Forms.TextBox();
            this.passwText = new System.Windows.Forms.TextBox();
            this.dniLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iniciarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dniText
            // 
            this.dniText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dniText.Location = new System.Drawing.Point(126, 90);
            this.dniText.Name = "dniText";
            this.dniText.Size = new System.Drawing.Size(140, 31);
            this.dniText.TabIndex = 0;
            // 
            // passwText
            // 
            this.passwText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwText.Location = new System.Drawing.Point(126, 187);
            this.passwText.Name = "passwText";
            this.passwText.Size = new System.Drawing.Size(140, 31);
            this.passwText.TabIndex = 1;
            // 
            // dniLabel
            // 
            this.dniLabel.AutoSize = true;
            this.dniLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dniLabel.Location = new System.Drawing.Point(121, 62);
            this.dniLabel.Name = "dniLabel";
            this.dniLabel.Size = new System.Drawing.Size(44, 25);
            this.dniLabel.TabIndex = 2;
            this.dniLabel.Text = "Dni";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contraseña";
            // 
            // iniciarButton
            // 
            this.iniciarButton.BackColor = System.Drawing.SystemColors.Menu;
            this.iniciarButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iniciarButton.FlatAppearance.BorderSize = 0;
            this.iniciarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciarButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iniciarButton.Location = new System.Drawing.Point(126, 254);
            this.iniciarButton.Name = "iniciarButton";
            this.iniciarButton.Size = new System.Drawing.Size(140, 49);
            this.iniciarButton.TabIndex = 4;
            this.iniciarButton.Text = "Iniciar Sesión";
            this.iniciarButton.UseVisualStyleBackColor = false;
            this.iniciarButton.Click += new System.EventHandler(this.iniciarButton_Click);
            // 
            // Login
            // 
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(389, 386);
            this.Controls.Add(this.iniciarButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dniLabel);
            this.Controls.Add(this.passwText);
            this.Controls.Add(this.dniText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox dniText;
        private System.Windows.Forms.TextBox passwText;
        private System.Windows.Forms.Label dniLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button iniciarButton;
    }
}