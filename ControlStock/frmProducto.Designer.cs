namespace ControlStock
{
    partial class frmProducto
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
            this.tbcProducto = new System.Windows.Forms.TabControl();
            this.tbpProducto = new System.Windows.Forms.TabPage();
            this.tbpMantenimientoProducto = new System.Windows.Forms.TabPage();
            this.tbcProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcProducto
            // 
            this.tbcProducto.Controls.Add(this.tbpProducto);
            this.tbcProducto.Controls.Add(this.tbpMantenimientoProducto);
            this.tbcProducto.Location = new System.Drawing.Point(0, 1);
            this.tbcProducto.Name = "tbcProducto";
            this.tbcProducto.SelectedIndex = 0;
            this.tbcProducto.Size = new System.Drawing.Size(656, 475);
            this.tbcProducto.TabIndex = 0;
            // 
            // tbpProducto
            // 
            this.tbpProducto.Location = new System.Drawing.Point(4, 22);
            this.tbpProducto.Name = "tbpProducto";
            this.tbpProducto.Padding = new System.Windows.Forms.Padding(3);
            this.tbpProducto.Size = new System.Drawing.Size(648, 449);
            this.tbpProducto.TabIndex = 0;
            this.tbpProducto.Text = "Productos";
            this.tbpProducto.UseVisualStyleBackColor = true;
            // 
            // tbpMantenimientoProducto
            // 
            this.tbpMantenimientoProducto.Location = new System.Drawing.Point(4, 22);
            this.tbpMantenimientoProducto.Name = "tbpMantenimientoProducto";
            this.tbpMantenimientoProducto.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMantenimientoProducto.Size = new System.Drawing.Size(648, 449);
            this.tbpMantenimientoProducto.TabIndex = 1;
            this.tbpMantenimientoProducto.Text = "Mantenimiento";
            this.tbpMantenimientoProducto.UseVisualStyleBackColor = true;
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 474);
            this.Controls.Add(this.tbcProducto);
            this.Name = "frmProducto";
            this.Text = "frmProducto";
            this.tbcProducto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcProducto;
        private System.Windows.Forms.TabPage tbpProducto;
        private System.Windows.Forms.TabPage tbpMantenimientoProducto;
    }
}