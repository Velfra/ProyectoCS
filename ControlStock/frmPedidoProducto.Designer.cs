namespace ControlStock
{
    partial class frmPedidoProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidoProducto));
            this.tbcPedido = new System.Windows.Forms.TabControl();
            this.tbpPedidos = new System.Windows.Forms.TabPage();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaLlegada = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.tbpConsulta = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgDetallePedido = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbcPedido.SuspendLayout();
            this.tbpPedidos.SuspendLayout();
            this.tbpConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetallePedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcPedido
            // 
            this.tbcPedido.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbcPedido.Controls.Add(this.tbpPedidos);
            this.tbcPedido.Controls.Add(this.tbpConsulta);
            this.tbcPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcPedido.Location = new System.Drawing.Point(0, 0);
            this.tbcPedido.Margin = new System.Windows.Forms.Padding(2);
            this.tbcPedido.Name = "tbcPedido";
            this.tbcPedido.SelectedIndex = 0;
            this.tbcPedido.Size = new System.Drawing.Size(581, 345);
            this.tbcPedido.TabIndex = 0;
            // 
            // tbpPedidos
            // 
            this.tbpPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(211)))), ((int)(((byte)(146)))));
            this.tbpPedidos.Controls.Add(this.pictureBox1);
            this.tbpPedidos.Controls.Add(this.label6);
            this.tbpPedidos.Controls.Add(this.btnModificar);
            this.tbpPedidos.Controls.Add(this.label4);
            this.tbpPedidos.Controls.Add(this.btnGuardar);
            this.tbpPedidos.Controls.Add(this.btnEliminar);
            this.tbpPedidos.Controls.Add(this.btnAgregar);
            this.tbpPedidos.Controls.Add(this.lblProducto);
            this.tbpPedidos.Controls.Add(this.cmbProducto);
            this.tbpPedidos.Controls.Add(this.label3);
            this.tbpPedidos.Controls.Add(this.txtCantidad);
            this.tbpPedidos.Controls.Add(this.label2);
            this.tbpPedidos.Controls.Add(this.dtpFechaLlegada);
            this.tbpPedidos.Controls.Add(this.label1);
            this.tbpPedidos.Controls.Add(this.cmbProveedor);
            this.tbpPedidos.Location = new System.Drawing.Point(4, 25);
            this.tbpPedidos.Margin = new System.Windows.Forms.Padding(2);
            this.tbpPedidos.Name = "tbpPedidos";
            this.tbpPedidos.Padding = new System.Windows.Forms.Padding(2);
            this.tbpPedidos.Size = new System.Drawing.Size(573, 316);
            this.tbpPedidos.TabIndex = 0;
            this.tbpPedidos.Text = "Pedidos";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Location = new System.Drawing.Point(337, 210);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(86, 30);
            this.btnModificar.TabIndex = 26;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(218, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Datos Pedido";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(184)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Location = new System.Drawing.Point(475, 272);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(77, 27);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Location = new System.Drawing.Point(234, 210);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 30);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(233)))), ((int)(((byte)(146)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Location = new System.Drawing.Point(127, 210);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(91, 30);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(219, 148);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(58, 13);
            this.lblProducto.TabIndex = 21;
            this.lblProducto.Text = "Producto";
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Items.AddRange(new object[] {
            "Vacuna",
            "Porcina"});
            this.cmbProducto.Location = new System.Drawing.Point(283, 146);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(140, 21);
            this.cmbProducto.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(176, 145);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(27, 20);
            this.txtCantidad.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Fecha Llegada";
            // 
            // dtpFechaLlegada
            // 
            this.dtpFechaLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaLlegada.Location = new System.Drawing.Point(185, 67);
            this.dtpFechaLlegada.Name = "dtpFechaLlegada";
            this.dtpFechaLlegada.Size = new System.Drawing.Size(103, 20);
            this.dtpFechaLlegada.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Proveedor";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(185, 103);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(236, 21);
            this.cmbProveedor.TabIndex = 16;
            // 
            // tbpConsulta
            // 
            this.tbpConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(211)))), ((int)(((byte)(146)))));
            this.tbpConsulta.Controls.Add(this.label5);
            this.tbpConsulta.Controls.Add(this.dtgDetallePedido);
            this.tbpConsulta.Location = new System.Drawing.Point(4, 25);
            this.tbpConsulta.Margin = new System.Windows.Forms.Padding(2);
            this.tbpConsulta.Name = "tbpConsulta";
            this.tbpConsulta.Padding = new System.Windows.Forms.Padding(2);
            this.tbpConsulta.Size = new System.Drawing.Size(573, 316);
            this.tbpConsulta.TabIndex = 1;
            this.tbpConsulta.Text = "Consulta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Detalle Pedidos";
            // 
            // dtgDetallePedido
            // 
            this.dtgDetallePedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetallePedido.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgDetallePedido.Location = new System.Drawing.Point(2, 58);
            this.dtgDetallePedido.Name = "dtgDetallePedido";
            this.dtgDetallePedido.Size = new System.Drawing.Size(569, 256);
            this.dtgDetallePedido.TabIndex = 5;
            this.dtgDetallePedido.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDetallePedido_CellDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 277);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "SALAMANDRA ÁGIL";
            // 
            // frmPedidoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 345);
            this.Controls.Add(this.tbcPedido);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPedidoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PedidoProducto";
            this.Load += new System.EventHandler(this.frmPedido_Load);
            this.tbcPedido.ResumeLayout(false);
            this.tbpPedidos.ResumeLayout(false);
            this.tbpPedidos.PerformLayout();
            this.tbpConsulta.ResumeLayout(false);
            this.tbpConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetallePedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcPedido;
        private System.Windows.Forms.TabPage tbpPedidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaLlegada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.TabPage tbpConsulta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgDetallePedido;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
    }
}