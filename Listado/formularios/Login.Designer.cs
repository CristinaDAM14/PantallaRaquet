
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
            this.dniText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.passwText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iniciarButton = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dniText
            // 
            this.dniText.Depth = 0;
            this.dniText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dniText.Hint = "DNI";
            this.dniText.Location = new System.Drawing.Point(67, 111);
            this.dniText.MouseState = MaterialSkin.MouseState.HOVER;
            this.dniText.Name = "dniText";
            this.dniText.PasswordChar = '\0';
            this.dniText.SelectedText = "";
            this.dniText.SelectionLength = 0;
            this.dniText.SelectionStart = 0;
            this.dniText.Size = new System.Drawing.Size(262, 23);
            this.dniText.TabIndex = 1;
            this.dniText.UseSystemPasswordChar = false;
            // 
            // passwText
            // 
            this.passwText.BackColor = System.Drawing.Color.White;
            this.passwText.Depth = 0;
            this.passwText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwText.Hint = "Contraseña";
            this.passwText.Location = new System.Drawing.Point(67, 163);
            this.passwText.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwText.Name = "passwText";
            this.passwText.PasswordChar = '*';
            this.passwText.SelectedText = "";
            this.passwText.SelectionLength = 0;
            this.passwText.SelectionStart = 0;
            this.passwText.Size = new System.Drawing.Size(262, 23);
            this.passwText.TabIndex = 2;
            this.passwText.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Listado.Properties.Resources.logo_más_fondo;
            this.pictureBox1.Location = new System.Drawing.Point(31, 279);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // iniciarButton
            // 
            this.iniciarButton.Depth = 0;
            this.iniciarButton.Location = new System.Drawing.Point(206, 229);
            this.iniciarButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.iniciarButton.Name = "iniciarButton";
            this.iniciarButton.Primary = true;
            this.iniciarButton.Size = new System.Drawing.Size(123, 41);
            this.iniciarButton.TabIndex = 5;
            this.iniciarButton.Text = "Iniciar Sesión";
            this.iniciarButton.UseVisualStyleBackColor = true;
            this.iniciarButton.Click += new System.EventHandler(this.iniciarButton_Click);
            // 
            // Login
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(389, 386);
            this.Controls.Add(this.iniciarButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passwText);
            this.Controls.Add(this.dniText);
            this.Name = "Login";
            this.Text = "Iniciar Sesión";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField dniText;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialRaisedButton iniciarButton;
    }
}