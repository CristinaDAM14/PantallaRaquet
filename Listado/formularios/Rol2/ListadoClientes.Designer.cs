
namespace RaquetZone.formularios.Rol2
{
    partial class ListadoClientes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoClientes));
            this.buttonEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.listaClientes = new System.Windows.Forms.DataGridView();
            this.buscarDNI = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buscadorButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.emailButton = new System.Windows.Forms.Button();
            this.bVolver = new System.Windows.Forms.Button();
            this.editarProductos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bReservas = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TextoCIFC = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.anyadirCompra = new MaterialSkin.Controls.MaterialRaisedButton();
            this.botonInactivo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.radioActivos = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioInactivos = new MaterialSkin.Controls.MaterialRadioButton();
            this.limpiarB = new MaterialSkin.Controls.MaterialRaisedButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.listaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEliminar.Depth = 0;
            this.buttonEliminar.Location = new System.Drawing.Point(453, 520);
            this.buttonEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Primary = true;
            this.buttonEliminar.Size = new System.Drawing.Size(157, 64);
            this.buttonEliminar.TabIndex = 49;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // listaClientes
            // 
            this.listaClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaClientes.Location = new System.Drawing.Point(49, 143);
            this.listaClientes.Name = "listaClientes";
            this.listaClientes.RowTemplate.ReadOnly = true;
            this.listaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaClientes.Size = new System.Drawing.Size(944, 360);
            this.listaClientes.TabIndex = 46;
            // 
            // buscarDNI
            // 
            this.buscarDNI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarDNI.Depth = 0;
            this.buscarDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarDNI.Hint = " DNI";
            this.buscarDNI.Location = new System.Drawing.Point(49, 98);
            this.buscarDNI.MouseState = MaterialSkin.MouseState.HOVER;
            this.buscarDNI.Name = "buscarDNI";
            this.buscarDNI.PasswordChar = '\0';
            this.buscarDNI.SelectedText = "";
            this.buscarDNI.SelectionLength = 0;
            this.buscarDNI.SelectionStart = 0;
            this.buscarDNI.Size = new System.Drawing.Size(166, 23);
            this.buscarDNI.TabIndex = 1;
            this.buscarDNI.UseSystemPasswordChar = false;
            // 
            // buscadorButton
            // 
            this.buscadorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscadorButton.Depth = 0;
            this.buscadorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscadorButton.Location = new System.Drawing.Point(221, 98);
            this.buscadorButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.buscadorButton.Name = "buscadorButton";
            this.buscadorButton.Primary = true;
            this.buscadorButton.Size = new System.Drawing.Size(61, 23);
            this.buscadorButton.TabIndex = 2;
            this.buscadorButton.Text = "Buscar";
            this.buscadorButton.UseVisualStyleBackColor = true;
            this.buscadorButton.Click += new System.EventHandler(this.buscadorButton_Click);
            // 
            // emailButton
            // 
            this.emailButton.BackgroundImage = global::Listado.Properties.Resources.emailClientes;
            this.emailButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.emailButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emailButton.FlatAppearance.BorderSize = 0;
            this.emailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emailButton.Location = new System.Drawing.Point(999, 223);
            this.emailButton.Name = "emailButton";
            this.emailButton.Size = new System.Drawing.Size(39, 34);
            this.emailButton.TabIndex = 65;
            this.toolTip1.SetToolTip(this.emailButton, "Enviar correo a un cliente");
            this.emailButton.UseVisualStyleBackColor = true;
            this.emailButton.Click += new System.EventHandler(this.emailButton_Click);
            // 
            // bVolver
            // 
            this.bVolver.BackColor = System.Drawing.Color.Transparent;
            this.bVolver.BackgroundImage = global::Listado.Properties.Resources.icono_volver;
            this.bVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bVolver.FlatAppearance.BorderSize = 0;
            this.bVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVolver.Location = new System.Drawing.Point(12, 558);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(45, 40);
            this.bVolver.TabIndex = 64;
            this.bVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // editarProductos
            // 
            this.editarProductos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editarProductos.BackgroundImage")));
            this.editarProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editarProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarProductos.Location = new System.Drawing.Point(999, 143);
            this.editarProductos.Name = "editarProductos";
            this.editarProductos.Size = new System.Drawing.Size(39, 34);
            this.editarProductos.TabIndex = 47;
            this.toolTip1.SetToolTip(this.editarProductos, "Editar clientes");
            this.editarProductos.UseVisualStyleBackColor = true;
            this.editarProductos.Click += new System.EventHandler(this.editarProductos_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Listado.Properties.Resources.BAnyadir;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(999, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 34);
            this.button1.TabIndex = 66;
            this.toolTip1.SetToolTip(this.button1, "Añadir clientes");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bReservas
            // 
            this.bReservas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bReservas.Depth = 0;
            this.bReservas.Location = new System.Drawing.Point(453, 520);
            this.bReservas.MouseState = MaterialSkin.MouseState.HOVER;
            this.bReservas.Name = "bReservas";
            this.bReservas.Primary = true;
            this.bReservas.Size = new System.Drawing.Size(157, 64);
            this.bReservas.TabIndex = 67;
            this.bReservas.Text = "Añadir a la Reserva";
            this.bReservas.UseVisualStyleBackColor = true;
            this.bReservas.Click += new System.EventHandler(this.bReservas_Click);
            // 
            // TextoCIFC
            // 
            this.TextoCIFC.Depth = 0;
            this.TextoCIFC.Enabled = false;
            this.TextoCIFC.Hint = "";
            this.TextoCIFC.Location = new System.Drawing.Point(147, 98);
            this.TextoCIFC.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextoCIFC.Name = "TextoCIFC";
            this.TextoCIFC.PasswordChar = '\0';
            this.TextoCIFC.SelectedText = "";
            this.TextoCIFC.SelectionLength = 0;
            this.TextoCIFC.SelectionStart = 0;
            this.TextoCIFC.Size = new System.Drawing.Size(48, 23);
            this.TextoCIFC.TabIndex = 70;
            this.TextoCIFC.UseSystemPasswordChar = false;
            this.TextoCIFC.Visible = false;
            // 
            // anyadirCompra
            // 
            this.anyadirCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anyadirCompra.Depth = 0;
            this.anyadirCompra.Location = new System.Drawing.Point(453, 520);
            this.anyadirCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.anyadirCompra.Name = "anyadirCompra";
            this.anyadirCompra.Primary = true;
            this.anyadirCompra.Size = new System.Drawing.Size(157, 64);
            this.anyadirCompra.TabIndex = 71;
            this.anyadirCompra.Text = "Añadir a la Compra";
            this.anyadirCompra.UseVisualStyleBackColor = true;
            this.anyadirCompra.Click += new System.EventHandler(this.anyadirCompra_Click);
            // 
            // botonInactivo
            // 
            this.botonInactivo.Depth = 0;
            this.botonInactivo.Location = new System.Drawing.Point(716, 117);
            this.botonInactivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.botonInactivo.Name = "botonInactivo";
            this.botonInactivo.Primary = true;
            this.botonInactivo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.botonInactivo.Size = new System.Drawing.Size(92, 23);
            this.botonInactivo.TabIndex = 81;
            this.botonInactivo.Text = "Actualizar";
            this.botonInactivo.UseVisualStyleBackColor = true;
            this.botonInactivo.Click += new System.EventHandler(this.botonInactivo_Click);
            // 
            // radioActivos
            // 
            this.radioActivos.Checked = true;
            this.radioActivos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioActivos.Depth = 0;
            this.radioActivos.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioActivos.Location = new System.Drawing.Point(811, 114);
            this.radioActivos.Margin = new System.Windows.Forms.Padding(0);
            this.radioActivos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioActivos.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioActivos.Name = "radioActivos";
            this.radioActivos.Ripple = true;
            this.radioActivos.Size = new System.Drawing.Size(89, 26);
            this.radioActivos.TabIndex = 80;
            this.radioActivos.TabStop = true;
            this.radioActivos.Text = "Activos";
            this.radioActivos.UseVisualStyleBackColor = true;
            // 
            // radioInactivos
            // 
            this.radioInactivos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioInactivos.Depth = 0;
            this.radioInactivos.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioInactivos.Location = new System.Drawing.Point(900, 114);
            this.radioInactivos.Margin = new System.Windows.Forms.Padding(0);
            this.radioInactivos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioInactivos.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioInactivos.Name = "radioInactivos";
            this.radioInactivos.Ripple = true;
            this.radioInactivos.Size = new System.Drawing.Size(93, 26);
            this.radioInactivos.TabIndex = 79;
            this.radioInactivos.Text = "Inactivos";
            this.radioInactivos.UseVisualStyleBackColor = true;
            // 
            // limpiarB
            // 
            this.limpiarB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.limpiarB.Depth = 0;
            this.limpiarB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiarB.Location = new System.Drawing.Point(288, 98);
            this.limpiarB.MouseState = MaterialSkin.MouseState.HOVER;
            this.limpiarB.Name = "limpiarB";
            this.limpiarB.Primary = true;
            this.limpiarB.Size = new System.Drawing.Size(61, 23);
            this.limpiarB.TabIndex = 82;
            this.limpiarB.Text = "Limpiar";
            this.toolTip1.SetToolTip(this.limpiarB, "Limpiar búsquedas");
            this.limpiarB.UseVisualStyleBackColor = true;
            this.limpiarB.Click += new System.EventHandler(this.limpiarB_Click);
            // 
            // ListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 610);
            this.Controls.Add(this.limpiarB);
            this.Controls.Add(this.botonInactivo);
            this.Controls.Add(this.radioActivos);
            this.Controls.Add(this.radioInactivos);
            this.Controls.Add(this.anyadirCompra);
            this.Controls.Add(this.TextoCIFC);
            this.Controls.Add(this.bReservas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.emailButton);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.buscadorButton);
            this.Controls.Add(this.buscarDNI);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.editarProductos);
            this.Controls.Add(this.listaClientes);
            this.MaximizeBox = false;
            this.Name = "ListadoClientes";
            this.Text = "Listado de Clientes";
            this.Load += new System.EventHandler(this.ListadoClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton buttonEliminar;
        private System.Windows.Forms.Button editarProductos;
        private MaterialSkin.Controls.MaterialSingleLineTextField buscarDNI;
        private MaterialSkin.Controls.MaterialRaisedButton buscadorButton;
        public System.Windows.Forms.DataGridView listaClientes;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Button emailButton;
        private System.Windows.Forms.Button button1;
        private MaterialSkin.Controls.MaterialRaisedButton bReservas;
        public MaterialSkin.Controls.MaterialSingleLineTextField TextoCIFC;
        private MaterialSkin.Controls.MaterialRaisedButton anyadirCompra;
        private MaterialSkin.Controls.MaterialRaisedButton botonInactivo;
        private MaterialSkin.Controls.MaterialRadioButton radioActivos;
        private MaterialSkin.Controls.MaterialRadioButton radioInactivos;
        private MaterialSkin.Controls.MaterialRaisedButton limpiarB;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}