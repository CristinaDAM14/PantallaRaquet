namespace RaquetZone.formularios
{
    partial class AnyadirUsuario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.anyadirButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dniText = new System.Windows.Forms.TextBox();
            this.passText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rolCombo = new System.Windows.Forms.ComboBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nombreText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.telText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.direccText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // anyadirButton
            // 
            this.anyadirButton.Location = new System.Drawing.Point(341, 380);
            this.anyadirButton.Name = "anyadirButton";
            this.anyadirButton.Size = new System.Drawing.Size(75, 23);
            this.anyadirButton.TabIndex = 8;
            this.anyadirButton.Text = "Añadir";
            this.anyadirButton.UseVisualStyleBackColor = true;
            this.anyadirButton.Click += new System.EventHandler(this.anyadirButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DNI:";
            // 
            // dniText
            // 
            this.dniText.Location = new System.Drawing.Point(350, 80);
            this.dniText.Name = "dniText";
            this.dniText.Size = new System.Drawing.Size(100, 20);
            this.dniText.TabIndex = 1;
            // 
            // passText
            // 
            this.passText.Location = new System.Drawing.Point(350, 136);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(100, 20);
            this.passText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rol:";
            // 
            // rolCombo
            // 
            this.rolCombo.FormattingEnabled = true;
            this.rolCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.rolCombo.Location = new System.Drawing.Point(350, 162);
            this.rolCombo.Name = "rolCombo";
            this.rolCombo.Size = new System.Drawing.Size(121, 21);
            this.rolCombo.TabIndex = 4;
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(351, 228);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(100, 20);
            this.emailText.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email:";
            // 
            // nombreText
            // 
            this.nombreText.Location = new System.Drawing.Point(350, 107);
            this.nombreText.Name = "nombreText";
            this.nombreText.Size = new System.Drawing.Size(100, 20);
            this.nombreText.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nombre:";
            // 
            // telText
            // 
            this.telText.Location = new System.Drawing.Point(350, 192);
            this.telText.Name = "telText";
            this.telText.Size = new System.Drawing.Size(100, 20);
            this.telText.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Teléfono:";
            // 
            // direccText
            // 
            this.direccText.Location = new System.Drawing.Point(351, 257);
            this.direccText.Name = "direccText";
            this.direccText.Size = new System.Drawing.Size(100, 20);
            this.direccText.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(296, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Dirección:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AnyadirUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.direccText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.telText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nombreText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rolCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dniText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.anyadirButton);
            this.Name = "AnyadirUsuario";
            this.Text = "Anyadir Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button anyadirButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dniText;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox rolCombo;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nombreText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox telText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox direccText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
    }
}

