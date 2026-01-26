namespace ControlPrestamo2
{
    partial class UserControl1
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LAB_DNI = new System.Windows.Forms.Label();
            this.LAB_FDevolucion = new System.Windows.Forms.Label();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.LAB_ISBN = new System.Windows.Forms.Label();
            this.LAB_FPrestamo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.Controls.Add(this.LAB_DNI, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.LAB_FDevolucion, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkActivo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEliminar, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEditar, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.LAB_ISBN, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.LAB_FPrestamo, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // LAB_DNI
            // 
            this.LAB_DNI.AutoSize = true;
            this.LAB_DNI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAB_DNI.Location = new System.Drawing.Point(206, 0);
            this.LAB_DNI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LAB_DNI.Name = "LAB_DNI";
            this.LAB_DNI.Size = new System.Drawing.Size(166, 30);
            this.LAB_DNI.TabIndex = 0;
            this.LAB_DNI.Text = "DNI";
            this.LAB_DNI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LAB_FDevolucion
            // 
            this.LAB_FDevolucion.AutoSize = true;
            this.LAB_FDevolucion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAB_FDevolucion.Location = new System.Drawing.Point(546, 0);
            this.LAB_FDevolucion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LAB_FDevolucion.Name = "LAB_FDevolucion";
            this.LAB_FDevolucion.Size = new System.Drawing.Size(166, 30);
            this.LAB_FDevolucion.TabIndex = 1;
            this.LAB_FDevolucion.Text = "Fecha Devolucion";
            this.LAB_FDevolucion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkActivo.Location = new System.Drawing.Point(17, 2);
            this.chkActivo.Margin = new System.Windows.Forms.Padding(2);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(15, 26);
            this.chkActivo.TabIndex = 2;
            this.chkActivo.UseVisualStyleBackColor = true;
            this.chkActivo.CheckedChanged += new System.EventHandler(this.chkActivo_CheckedChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(716, 2);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(30, 26);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(750, 2);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(30, 26);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // LAB_ISBN
            // 
            this.LAB_ISBN.AutoSize = true;
            this.LAB_ISBN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAB_ISBN.Location = new System.Drawing.Point(37, 0);
            this.LAB_ISBN.Name = "LAB_ISBN";
            this.LAB_ISBN.Size = new System.Drawing.Size(164, 30);
            this.LAB_ISBN.TabIndex = 5;
            this.LAB_ISBN.Text = "ISBN";
            this.LAB_ISBN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LAB_FPrestamo
            // 
            this.LAB_FPrestamo.AutoSize = true;
            this.LAB_FPrestamo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAB_FPrestamo.Location = new System.Drawing.Point(377, 0);
            this.LAB_FPrestamo.Name = "LAB_FPrestamo";
            this.LAB_FPrestamo.Size = new System.Drawing.Size(164, 30);
            this.LAB_FPrestamo.TabIndex = 6;
            this.LAB_FPrestamo.Text = "Fecha Prestamo";
            this.LAB_FPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LAB_DNI;
        private System.Windows.Forms.Label LAB_FDevolucion;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label LAB_ISBN;
        private System.Windows.Forms.Label LAB_FPrestamo;
    }
}
