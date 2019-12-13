namespace ControlStock
{
    partial class frmEntradaSalida
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
            this.tbcLista = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.lblStoockActual = new System.Windows.Forms.Label();
            this.lblAccion = new System.Windows.Forms.Label();
            this.rbnSalida = new System.Windows.Forms.RadioButton();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.rbnEntrada = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvMovimiento = new System.Windows.Forms.DataGridView();
            this.tbcLista.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcLista
            // 
            this.tbcLista.Controls.Add(this.tabPage1);
            this.tbcLista.Controls.Add(this.tabPage2);
            this.tbcLista.Location = new System.Drawing.Point(0, 0);
            this.tbcLista.Name = "tbcLista";
            this.tbcLista.SelectedIndex = 0;
            this.tbcLista.Size = new System.Drawing.Size(576, 360);
            this.tbcLista.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(568, 334);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Control";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Location = new System.Drawing.Point(77, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 70);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Procesos";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(175, 21);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(61, 28);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(266, 21);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(61, 28);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(89, 21);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(61, 28);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudStock);
            this.groupBox1.Controls.Add(this.lblStoockActual);
            this.groupBox1.Controls.Add(this.lblAccion);
            this.groupBox1.Controls.Add(this.rbnSalida);
            this.groupBox1.Controls.Add(this.lblCantidad);
            this.groupBox1.Controls.Add(this.nudCantidad);
            this.groupBox1.Controls.Add(this.rbnEntrada);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.lblProducto);
            this.groupBox1.Controls.Add(this.cboProducto);
            this.groupBox1.Location = new System.Drawing.Point(77, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 179);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Productos";
            // 
            // nudStock
            // 
            this.nudStock.Location = new System.Drawing.Point(97, 59);
            this.nudStock.Maximum = new decimal(new int[] {
            1241513983,
            370409800,
            542101,
            0});
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(68, 20);
            this.nudStock.TabIndex = 18;
            // 
            // lblStoockActual
            // 
            this.lblStoockActual.AutoSize = true;
            this.lblStoockActual.Location = new System.Drawing.Point(23, 61);
            this.lblStoockActual.Name = "lblStoockActual";
            this.lblStoockActual.Size = new System.Drawing.Size(68, 13);
            this.lblStoockActual.TabIndex = 17;
            this.lblStoockActual.Text = "Stock Actual";
            // 
            // lblAccion
            // 
            this.lblAccion.AutoSize = true;
            this.lblAccion.Location = new System.Drawing.Point(23, 98);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(40, 13);
            this.lblAccion.TabIndex = 16;
            this.lblAccion.Text = "Accion";
            // 
            // rbnSalida
            // 
            this.rbnSalida.AutoSize = true;
            this.rbnSalida.Location = new System.Drawing.Point(175, 98);
            this.rbnSalida.Name = "rbnSalida";
            this.rbnSalida.Size = new System.Drawing.Size(54, 17);
            this.rbnSalida.TabIndex = 15;
            this.rbnSalida.Text = "Salida";
            this.rbnSalida.UseVisualStyleBackColor = true;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(23, 137);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(95, 135);
            this.nudCantidad.Maximum = new decimal(new int[] {
            1241513983,
            370409800,
            542101,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(68, 20);
            this.nudCantidad.TabIndex = 6;
            // 
            // rbnEntrada
            // 
            this.rbnEntrada.AutoSize = true;
            this.rbnEntrada.Checked = true;
            this.rbnEntrada.Location = new System.Drawing.Point(101, 98);
            this.rbnEntrada.Name = "rbnEntrada";
            this.rbnEntrada.Size = new System.Drawing.Size(62, 17);
            this.rbnEntrada.TabIndex = 14;
            this.rbnEntrada.TabStop = true;
            this.rbnEntrada.Text = "Entrada";
            this.rbnEntrada.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(323, 112);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(61, 28);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(323, 70);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(61, 28);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(323, 22);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(61, 28);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(23, 30);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(50, 13);
            this.lblProducto.TabIndex = 2;
            this.lblProducto.Text = "Producto";
            // 
            // cboProducto
            // 
            this.cboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(95, 22);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(184, 21);
            this.cboProducto.TabIndex = 4;
            this.cboProducto.SelectedValueChanged += new System.EventHandler(this.cboProducto_SelectedValueChanged_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvMovimiento);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(568, 334);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvMovimiento
            // 
            this.dgvMovimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimiento.Location = new System.Drawing.Point(0, 61);
            this.dgvMovimiento.Name = "dgvMovimiento";
            this.dgvMovimiento.Size = new System.Drawing.Size(572, 277);
            this.dgvMovimiento.TabIndex = 0;
            this.dgvMovimiento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmEntradaSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 359);
            this.Controls.Add(this.tbcLista);
            this.Name = "frmEntradaSalida";
            this.Text = "frmEntradaSalida";
            this.Load += new System.EventHandler(this.frmEntradaSalida_Load);
            this.tbcLista.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimiento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcLista;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.Label lblStoockActual;
        private System.Windows.Forms.Label lblAccion;
        private System.Windows.Forms.RadioButton rbnSalida;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.RadioButton rbnEntrada;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvMovimiento;
    }
}