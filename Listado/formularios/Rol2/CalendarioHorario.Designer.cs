
namespace RaquetZone.formularios.Rol2
{
    partial class CalendarioHorario
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
            this.sfCalendar1 = new Syncfusion.WinForms.Input.SfCalendar();
            this.TextoCIFAnyadir = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.boxEmpleados = new System.Windows.Forms.ComboBox();
            this.anyadirVaca = new MaterialSkin.Controls.MaterialRaisedButton();
            this.bEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.bTrofeo = new System.Windows.Forms.Button();
            this.bcumple = new System.Windows.Forms.Button();
            this.mMostrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.bVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sfCalendar1
            // 
            this.sfCalendar1.AllowMultipleSelection = true;
            this.sfCalendar1.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.sfCalendar1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.sfCalendar1.Location = new System.Drawing.Point(56, 152);
            this.sfCalendar1.MaxDate = new System.DateTime(2050, 12, 31, 23, 59, 0, 0);
            this.sfCalendar1.MinDate = new System.DateTime(2023, 1, 1, 23, 59, 0, 0);
            this.sfCalendar1.MinimumSize = new System.Drawing.Size(196, 196);
            this.sfCalendar1.Name = "sfCalendar1";
            this.sfCalendar1.Size = new System.Drawing.Size(630, 438);
            this.sfCalendar1.Style.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.sfCalendar1.Style.Cell.BlackoutDatesBackColor = System.Drawing.Color.Maroon;
            this.sfCalendar1.Style.Cell.BlackoutDatesForeColor = System.Drawing.Color.DarkOliveGreen;
            this.sfCalendar1.Style.Cell.CellBackColor = System.Drawing.Color.White;
            this.sfCalendar1.Style.Cell.CellFont = new System.Drawing.Font("Segoe UI", 14F);
            this.sfCalendar1.Style.Cell.CellForeColor = System.Drawing.Color.Green;
            this.sfCalendar1.Style.Cell.CellHoverBorderColor = System.Drawing.Color.Lime;
            this.sfCalendar1.Style.Cell.SelectedCellBackColor = System.Drawing.Color.WhiteSmoke;
            this.sfCalendar1.Style.Cell.SelectedCellBorderColor = System.Drawing.Color.DarkOliveGreen;
            this.sfCalendar1.Style.Cell.SelectedCellFont = new System.Drawing.Font("Segoe UI", 14F);
            this.sfCalendar1.Style.Cell.SelectedCellForeColor = System.Drawing.Color.Black;
            this.sfCalendar1.Style.Cell.SelectedCellHoverBorderColor = System.Drawing.Color.MediumSpringGreen;
            this.sfCalendar1.Style.Cell.TodayFont = new System.Drawing.Font("Segoe UI", 14F);
            this.sfCalendar1.Style.Cell.TrailingCellBackColor = System.Drawing.Color.White;
            this.sfCalendar1.Style.Cell.TrailingCellFont = new System.Drawing.Font("Segoe UI", 12F);
            this.sfCalendar1.Style.Cell.TrailingCellForeColor = System.Drawing.Color.DarkGray;
            this.sfCalendar1.Style.Cell.WeekNumberFont = new System.Drawing.Font("Segoe UI", 14F);
            this.sfCalendar1.Style.Footer.BackColor = System.Drawing.Color.White;
            this.sfCalendar1.Style.Footer.ForeColor = System.Drawing.Color.White;
            this.sfCalendar1.Style.Footer.HoverBackColor = System.Drawing.Color.White;
            this.sfCalendar1.Style.Footer.HoverForeColor = System.Drawing.Color.Gray;
            this.sfCalendar1.Style.Header.BackColor = System.Drawing.Color.PaleGreen;
            this.sfCalendar1.Style.Header.DayNamesBackColor = System.Drawing.Color.PaleGreen;
            this.sfCalendar1.Style.Header.DayNamesFont = new System.Drawing.Font("Segoe UI", 12F);
            this.sfCalendar1.Style.Header.DayNamesForeColor = System.Drawing.Color.Black;
            this.sfCalendar1.Style.Header.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            this.sfCalendar1.Style.Header.HoverForeColor = System.Drawing.Color.White;
            this.sfCalendar1.Style.HorizontalSplitterColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sfCalendar1.TabIndex = 1;
            this.sfCalendar1.Text = "Vacaciones";
            // 
            // TextoCIFAnyadir
            // 
            this.TextoCIFAnyadir.Depth = 0;
            this.TextoCIFAnyadir.Enabled = false;
            this.TextoCIFAnyadir.Hint = "";
            this.TextoCIFAnyadir.Location = new System.Drawing.Point(142, 123);
            this.TextoCIFAnyadir.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextoCIFAnyadir.Name = "TextoCIFAnyadir";
            this.TextoCIFAnyadir.PasswordChar = '\0';
            this.TextoCIFAnyadir.SelectedText = "";
            this.TextoCIFAnyadir.SelectionLength = 0;
            this.TextoCIFAnyadir.SelectionStart = 0;
            this.TextoCIFAnyadir.Size = new System.Drawing.Size(64, 23);
            this.TextoCIFAnyadir.TabIndex = 74;
            this.TextoCIFAnyadir.UseSystemPasswordChar = false;
            this.TextoCIFAnyadir.Visible = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(52, 86);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(84, 19);
            this.materialLabel1.TabIndex = 76;
            this.materialLabel1.Text = "Empleados";
            // 
            // boxEmpleados
            // 
            this.boxEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boxEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxEmpleados.FormattingEnabled = true;
            this.boxEmpleados.Location = new System.Drawing.Point(142, 87);
            this.boxEmpleados.Name = "boxEmpleados";
            this.boxEmpleados.Size = new System.Drawing.Size(142, 21);
            this.boxEmpleados.TabIndex = 77;
            // 
            // anyadirVaca
            // 
            this.anyadirVaca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anyadirVaca.Depth = 0;
            this.anyadirVaca.Location = new System.Drawing.Point(163, 613);
            this.anyadirVaca.MouseState = MaterialSkin.MouseState.HOVER;
            this.anyadirVaca.Name = "anyadirVaca";
            this.anyadirVaca.Primary = true;
            this.anyadirVaca.Size = new System.Drawing.Size(121, 45);
            this.anyadirVaca.TabIndex = 78;
            this.anyadirVaca.Text = "Añadir vacaciones";
            this.anyadirVaca.UseVisualStyleBackColor = true;
            this.anyadirVaca.Click += new System.EventHandler(this.anyadirVaca_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEliminar.Depth = 0;
            this.bEliminar.Location = new System.Drawing.Point(444, 613);
            this.bEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Primary = true;
            this.bEliminar.Size = new System.Drawing.Size(121, 45);
            this.bEliminar.TabIndex = 79;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bTrofeo
            // 
            this.bTrofeo.BackgroundImage = global::Listado.Properties.Resources.trofeo1;
            this.bTrofeo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bTrofeo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bTrofeo.Location = new System.Drawing.Point(602, 111);
            this.bTrofeo.Name = "bTrofeo";
            this.bTrofeo.Size = new System.Drawing.Size(39, 35);
            this.bTrofeo.TabIndex = 80;
            this.bTrofeo.UseVisualStyleBackColor = true;
            this.bTrofeo.Click += new System.EventHandler(this.bTrofeo_Click);
            // 
            // bcumple
            // 
            this.bcumple.BackgroundImage = global::Listado.Properties.Resources.cumple;
            this.bcumple.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bcumple.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bcumple.Location = new System.Drawing.Point(647, 111);
            this.bcumple.Name = "bcumple";
            this.bcumple.Size = new System.Drawing.Size(39, 35);
            this.bcumple.TabIndex = 81;
            this.bcumple.UseVisualStyleBackColor = true;
            this.bcumple.Click += new System.EventHandler(this.bcumple_Click);
            // 
            // mMostrar
            // 
            this.mMostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mMostrar.Depth = 0;
            this.mMostrar.Location = new System.Drawing.Point(290, 86);
            this.mMostrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.mMostrar.Name = "mMostrar";
            this.mMostrar.Primary = true;
            this.mMostrar.Size = new System.Drawing.Size(79, 22);
            this.mMostrar.TabIndex = 82;
            this.mMostrar.Text = "Mostrar";
            this.mMostrar.UseVisualStyleBackColor = true;
            this.mMostrar.Click += new System.EventHandler(this.mMostrar_Click_1);
            // 
            // bVolver
            // 
            this.bVolver.BackColor = System.Drawing.Color.Transparent;
            this.bVolver.BackgroundImage = global::Listado.Properties.Resources.icono_volver;
            this.bVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bVolver.FlatAppearance.BorderSize = 0;
            this.bVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVolver.Location = new System.Drawing.Point(12, 626);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(45, 40);
            this.bVolver.TabIndex = 83;
            this.bVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // CalendarioHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 678);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.mMostrar);
            this.Controls.Add(this.bcumple);
            this.Controls.Add(this.bTrofeo);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.anyadirVaca);
            this.Controls.Add(this.boxEmpleados);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.TextoCIFAnyadir);
            this.Controls.Add(this.sfCalendar1);
            this.Name = "CalendarioHorario";
            this.Text = "Calendario Vacaciones";
            this.Load += new System.EventHandler(this.CalendarioHorario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.Input.SfCalendar sfCalendar1;
        public MaterialSkin.Controls.MaterialSingleLineTextField TextoCIFAnyadir;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        public System.Windows.Forms.ComboBox boxEmpleados;
        private MaterialSkin.Controls.MaterialRaisedButton anyadirVaca;
        private MaterialSkin.Controls.MaterialRaisedButton bEliminar;
        private System.Windows.Forms.Button bTrofeo;
        private System.Windows.Forms.Button bcumple;
        private MaterialSkin.Controls.MaterialRaisedButton mMostrar;
        private System.Windows.Forms.Button bVolver;
    }
}