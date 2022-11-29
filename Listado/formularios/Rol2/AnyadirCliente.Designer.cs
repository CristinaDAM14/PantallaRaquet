
namespace RaquetZone.formularios.Rol2
{
    partial class AnyadirCliente
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
            this.emailText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.telText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.numText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.passText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.nomText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dniText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.bVolver = new System.Windows.Forms.Button();
            this.buttonAnyadir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailText
            // 
            this.emailText.Depth = 0;
            this.emailText.Hint = "Email";
            this.emailText.Location = new System.Drawing.Point(421, 219);
            this.emailText.MouseState = MaterialSkin.MouseState.HOVER;
            this.emailText.Name = "emailText";
            this.emailText.PasswordChar = '\0';
            this.emailText.SelectedText = "";
            this.emailText.SelectionLength = 0;
            this.emailText.SelectionStart = 0;
            this.emailText.Size = new System.Drawing.Size(312, 23);
            this.emailText.TabIndex = 13;
            this.emailText.UseSystemPasswordChar = false;
            // 
            // telText
            // 
            this.telText.Depth = 0;
            this.telText.Hint = "Teléfono";
            this.telText.Location = new System.Drawing.Point(106, 286);
            this.telText.MouseState = MaterialSkin.MouseState.HOVER;
            this.telText.Name = "telText";
            this.telText.PasswordChar = '\0';
            this.telText.SelectedText = "";
            this.telText.SelectionLength = 0;
            this.telText.SelectionStart = 0;
            this.telText.Size = new System.Drawing.Size(218, 23);
            this.telText.TabIndex = 14;
            this.telText.UseSystemPasswordChar = false;
            // 
            // numText
            // 
            this.numText.Depth = 0;
            this.numText.Hint = "Número de horas";
            this.numText.Location = new System.Drawing.Point(421, 286);
            this.numText.MouseState = MaterialSkin.MouseState.HOVER;
            this.numText.Name = "numText";
            this.numText.PasswordChar = '\0';
            this.numText.SelectedText = "";
            this.numText.SelectionLength = 0;
            this.numText.SelectionStart = 0;
            this.numText.Size = new System.Drawing.Size(142, 23);
            this.numText.TabIndex = 15;
            this.numText.UseSystemPasswordChar = false;
            // 
            // passText
            // 
            this.passText.Depth = 0;
            this.passText.Hint = "Contraseña";
            this.passText.Location = new System.Drawing.Point(106, 219);
            this.passText.MouseState = MaterialSkin.MouseState.HOVER;
            this.passText.Name = "passText";
            this.passText.PasswordChar = '\0';
            this.passText.SelectedText = "";
            this.passText.SelectionLength = 0;
            this.passText.SelectionStart = 0;
            this.passText.Size = new System.Drawing.Size(218, 23);
            this.passText.TabIndex = 12;
            this.passText.UseSystemPasswordChar = false;
            // 
            // nomText
            // 
            this.nomText.Depth = 0;
            this.nomText.Hint = "Nombre";
            this.nomText.Location = new System.Drawing.Point(421, 130);
            this.nomText.MouseState = MaterialSkin.MouseState.HOVER;
            this.nomText.Name = "nomText";
            this.nomText.PasswordChar = '\0';
            this.nomText.SelectedText = "";
            this.nomText.SelectionLength = 0;
            this.nomText.SelectionStart = 0;
            this.nomText.Size = new System.Drawing.Size(312, 23);
            this.nomText.TabIndex = 11;
            this.nomText.UseSystemPasswordChar = false;
            // 
            // dniText
            // 
            this.dniText.Depth = 0;
            this.dniText.Hint = "DNI";
            this.dniText.Location = new System.Drawing.Point(106, 130);
            this.dniText.MouseState = MaterialSkin.MouseState.HOVER;
            this.dniText.Name = "dniText";
            this.dniText.PasswordChar = '\0';
            this.dniText.SelectedText = "";
            this.dniText.SelectionLength = 0;
            this.dniText.SelectionStart = 0;
            this.dniText.Size = new System.Drawing.Size(218, 23);
            this.dniText.TabIndex = 10;
            this.dniText.UseSystemPasswordChar = false;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = null;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-7, 177);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(820, 10);
            this.materialTabSelector1.TabIndex = 43;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // bVolver
            // 
            this.bVolver.BackColor = System.Drawing.Color.Transparent;
            this.bVolver.BackgroundImage = global::Listado.Properties.Resources.icono_volver;
            this.bVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bVolver.FlatAppearance.BorderSize = 0;
            this.bVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVolver.Location = new System.Drawing.Point(279, 360);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(45, 40);
            this.bVolver.TabIndex = 65;
            this.bVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // buttonAnyadir
            // 
            this.buttonAnyadir.BackColor = System.Drawing.Color.Transparent;
            this.buttonAnyadir.BackgroundImage = global::Listado.Properties.Resources.añadir_blanco;
            this.buttonAnyadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAnyadir.FlatAppearance.BorderSize = 0;
            this.buttonAnyadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnyadir.Location = new System.Drawing.Point(421, 362);
            this.buttonAnyadir.Name = "buttonAnyadir";
            this.buttonAnyadir.Size = new System.Drawing.Size(45, 40);
            this.buttonAnyadir.TabIndex = 67;
            this.buttonAnyadir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAnyadir.UseVisualStyleBackColor = true;
            this.buttonAnyadir.Click += new System.EventHandler(this.buttonAnyadir_Click);
            // 
            // AnyadirCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAnyadir);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.telText);
            this.Controls.Add(this.numText);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.nomText);
            this.Controls.Add(this.dniText);
            this.Name = "AnyadirCliente";
            this.Text = "Añadir Cliente";
            this.Load += new System.EventHandler(this.AnyadirCliente_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField emailText;
        private MaterialSkin.Controls.MaterialSingleLineTextField telText;
        private MaterialSkin.Controls.MaterialSingleLineTextField numText;
        private MaterialSkin.Controls.MaterialSingleLineTextField passText;
        private MaterialSkin.Controls.MaterialSingleLineTextField nomText;
        private MaterialSkin.Controls.MaterialSingleLineTextField dniText;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Button buttonAnyadir;
    }
}