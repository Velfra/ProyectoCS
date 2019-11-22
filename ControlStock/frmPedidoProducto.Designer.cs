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
            this.tbcPedido.SuspendLayout();
            this.tbpPedidos.SuspendLayout();
            this.tbpConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetallePedido)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcPedido
            // 
            this.tbcPedido.Controls.Add(this.tbpPedidos);
            this.tbcPedido.Controls.Add(this.tbpConsulta);
            this.tbcPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcPedido.Location = new System.Drawing.Point(0, 0);
            this.tbcPedido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbcPedido.Name = "tbcPedido";
            this.tbcPedido.SelectedIndex = 0;
            this.tbcPedido.Size = new System.Drawing.Size(413, 305);
            this.tbcPedido.TabIndex = 0;
            // 
            // tbpPedidos
            // 
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
            this.tbpPedidos.Location = new System.Drawing.Point(4, 22);
            this.tbpPedidos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbpPedidos.Name = "tbpPedidos";
            this.tbpPedidos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbpPedidos.Size = new System.Drawing.Size(405, 279);
            this.tbpPedidos.TabIndex = 0;
            this.tbpPedidos.Text = "Pedidos";
            this.tbpPedidos.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(196, 195);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(74, 23);
            this.btnModificar.TabIndex = 26;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Datos Pedido";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(335, 241);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(66, 27);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(103, 195);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(16, 195);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(78, 23);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(132, 143);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(50, 13);
            this.lblProducto.TabIndex = 21;
            this.lblProducto.Text = "Producto";
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Items.AddRange(new object[] {
            "Vacuna",
            "Porcina"});
            this.cmbProducto.Location = new System.Drawing.Point(187, 141);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(121, 21);
            this.cmbProducto.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(95, 140);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(24, 20);
            this.txtCantidad.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Fecha Llegada";
            // 
            // dtpFechaLlegada
            // 
            this.dtpFechaLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaLlegada.Location = new System.Drawing.Point(103, 62);
            this.dtpFechaLlegada.Name = "dtpFechaLlegada";
            this.dtpFechaLlegada.Size = new System.Drawing.Size(89, 20);
            this.dtpFechaLlegada.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Proveedor";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(103, 98);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(203, 21);
            this.cmbProveedor.TabIndex = 16;
            // 
            // tbpConsulta
            // 
            this.tbpConsulta.Controls.Add(this.label5);
            this.tbpConsulta.Controls.Add(this.dtgDetallePedido);
            this.tbpConsulta.Location = new System.Drawing.Point(4, 22);
            this.tbpConsulta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbpConsulta.Name = "tbpConsulta";
            this.tbpConsulta.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbpConsulta.Size = new System.Drawing.Size(405, 279);
            this.tbpConsulta.TabIndex = 1;
            this.tbpConsulta.Text = "Consulta";
            this.tbpConsulta.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Detalle Pedidos";
            // 
            // dtgDetallePedido
            // 
            this.dtgDetallePedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetallePedido.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgDetallePedido.Location = new System.Drawing.Point(2, 45);
            this.dtgDetallePedido.Name = "dtgDetallePedido";
            this.dtgDetallePedido.Size = new System.Drawing.Size(401, 232);
            this.dtgDetallePedido.TabIndex = 5;
            this.dtgDetallePedido.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDetallePedido_CellDoubleClick);
            // 
            // frmPedidoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 305);
            this.Controls.Add(this.tbcPedido);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    }
}