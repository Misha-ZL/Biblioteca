namespace ControlPrestamo
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
            this.TabLayPan_Principal = new System.Windows.Forms.TableLayoutPanel();
            this.TabLayPan_CabeceraPrestamo = new System.Windows.Forms.TableLayoutPanel();
            this.TabLayPan_DatosPrestamo = new System.Windows.Forms.TableLayoutPanel();
            this.LAB_ISBN = new System.Windows.Forms.Label();
            this.LAB_DNI = new System.Windows.Forms.Label();
            this.LAB_FPrestamo = new System.Windows.Forms.Label();
            this.LAB_FDevolucion = new System.Windows.Forms.Label();
            this.TXTBOX_ISBN = new System.Windows.Forms.TextBox();
            this.BUT_NuevoPrestamo = new System.Windows.Forms.Button();
            this.TXTBOX_DNI = new System.Windows.Forms.TextBox();
            this.TXTBOX_FPres = new System.Windows.Forms.TextBox();
            this.TXTBOX_FDev = new System.Windows.Forms.TextBox();
            this.BUT_SearchPrestamo = new System.Windows.Forms.Button();
            this.TabLayPan_Principal.SuspendLayout();
            this.TabLayPan_CabeceraPrestamo.SuspendLayout();
            this.TabLayPan_DatosPrestamo.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabLayPan_Principal
            // 
            this.TabLayPan_Principal.ColumnCount = 1;
            this.TabLayPan_Principal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TabLayPan_Principal.Controls.Add(this.BUT_SearchPrestamo, 0, 3);
            this.TabLayPan_Principal.Controls.Add(this.TabLayPan_CabeceraPrestamo, 0, 0);
            this.TabLayPan_Principal.Controls.Add(this.TabLayPan_DatosPrestamo, 0, 1);
            this.TabLayPan_Principal.Controls.Add(this.BUT_NuevoPrestamo, 0, 2);
            this.TabLayPan_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabLayPan_Principal.Location = new System.Drawing.Point(0, 0);
            this.TabLayPan_Principal.Name = "TabLayPan_Principal";
            this.TabLayPan_Principal.RowCount = 5;
            this.TabLayPan_Principal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TabLayPan_Principal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TabLayPan_Principal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TabLayPan_Principal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TabLayPan_Principal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TabLayPan_Principal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TabLayPan_Principal.Size = new System.Drawing.Size(800, 450);
            this.TabLayPan_Principal.TabIndex = 0;
            // 
            // TabLayPan_CabeceraPrestamo
            // 
            this.TabLayPan_CabeceraPrestamo.ColumnCount = 4;
            this.TabLayPan_CabeceraPrestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TabLayPan_CabeceraPrestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TabLayPan_CabeceraPrestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TabLayPan_CabeceraPrestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TabLayPan_CabeceraPrestamo.Controls.Add(this.LAB_ISBN, 0, 0);
            this.TabLayPan_CabeceraPrestamo.Controls.Add(this.LAB_DNI, 1, 0);
            this.TabLayPan_CabeceraPrestamo.Controls.Add(this.LAB_FPrestamo, 2, 0);
            this.TabLayPan_CabeceraPrestamo.Controls.Add(this.LAB_FDevolucion, 3, 0);
            this.TabLayPan_CabeceraPrestamo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabLayPan_CabeceraPrestamo.Location = new System.Drawing.Point(3, 3);
            this.TabLayPan_CabeceraPrestamo.Name = "TabLayPan_CabeceraPrestamo";
            this.TabLayPan_CabeceraPrestamo.RowCount = 1;
            this.TabLayPan_CabeceraPrestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TabLayPan_CabeceraPrestamo.Size = new System.Drawing.Size(794, 50);
            this.TabLayPan_CabeceraPrestamo.TabIndex = 0;
            // 
            // TabLayPan_DatosPrestamo
            // 
            this.TabLayPan_DatosPrestamo.BackColor = System.Drawing.Color.LightBlue;
            this.TabLayPan_DatosPrestamo.ColumnCount = 4;
            this.TabLayPan_DatosPrestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TabLayPan_DatosPrestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TabLayPan_DatosPrestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TabLayPan_DatosPrestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TabLayPan_DatosPrestamo.Controls.Add(this.TXTBOX_FDev, 3, 0);
            this.TabLayPan_DatosPrestamo.Controls.Add(this.TXTBOX_FPres, 2, 0);
            this.TabLayPan_DatosPrestamo.Controls.Add(this.TXTBOX_DNI, 1, 0);
            this.TabLayPan_DatosPrestamo.Controls.Add(this.TXTBOX_ISBN, 0, 0);
            this.TabLayPan_DatosPrestamo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabLayPan_DatosPrestamo.Location = new System.Drawing.Point(3, 59);
            this.TabLayPan_DatosPrestamo.Name = "TabLayPan_DatosPrestamo";
            this.TabLayPan_DatosPrestamo.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TabLayPan_DatosPrestamo.RowCount = 1;
            this.TabLayPan_DatosPrestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TabLayPan_DatosPrestamo.Size = new System.Drawing.Size(794, 40);
            this.TabLayPan_DatosPrestamo.TabIndex = 1;
            // 
            // LAB_ISBN
            // 
            this.LAB_ISBN.AutoSize = true;
            this.LAB_ISBN.BackColor = System.Drawing.Color.White;
            this.LAB_ISBN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAB_ISBN.Location = new System.Drawing.Point(3, 0);
            this.LAB_ISBN.Name = "LAB_ISBN";
            this.LAB_ISBN.Size = new System.Drawing.Size(192, 50);
            this.LAB_ISBN.TabIndex = 0;
            this.LAB_ISBN.Text = "ISBN";
            this.LAB_ISBN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LAB_DNI
            // 
            this.LAB_DNI.AutoSize = true;
            this.LAB_DNI.BackColor = System.Drawing.Color.White;
            this.LAB_DNI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAB_DNI.Location = new System.Drawing.Point(201, 0);
            this.LAB_DNI.Name = "LAB_DNI";
            this.LAB_DNI.Size = new System.Drawing.Size(192, 50);
            this.LAB_DNI.TabIndex = 1;
            this.LAB_DNI.Text = "DNI";
            this.LAB_DNI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LAB_FPrestamo
            // 
            this.LAB_FPrestamo.AutoSize = true;
            this.LAB_FPrestamo.BackColor = System.Drawing.Color.White;
            this.LAB_FPrestamo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAB_FPrestamo.Location = new System.Drawing.Point(399, 0);
            this.LAB_FPrestamo.Name = "LAB_FPrestamo";
            this.LAB_FPrestamo.Size = new System.Drawing.Size(192, 50);
            this.LAB_FPrestamo.TabIndex = 2;
            this.LAB_FPrestamo.Text = "Fecha préstamo";
            this.LAB_FPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LAB_FDevolucion
            // 
            this.LAB_FDevolucion.AutoSize = true;
            this.LAB_FDevolucion.BackColor = System.Drawing.Color.White;
            this.LAB_FDevolucion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAB_FDevolucion.Location = new System.Drawing.Point(597, 0);
            this.LAB_FDevolucion.Name = "LAB_FDevolucion";
            this.LAB_FDevolucion.Size = new System.Drawing.Size(194, 50);
            this.LAB_FDevolucion.TabIndex = 3;
            this.LAB_FDevolucion.Text = "Fecha devolucion";
            this.LAB_FDevolucion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXTBOX_ISBN
            // 
            this.TXTBOX_ISBN.BackColor = System.Drawing.Color.LightGray;
            this.TXTBOX_ISBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTBOX_ISBN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXTBOX_ISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBOX_ISBN.Location = new System.Drawing.Point(13, 8);
            this.TXTBOX_ISBN.Margin = new System.Windows.Forms.Padding(8);
            this.TXTBOX_ISBN.Name = "TXTBOX_ISBN";
            this.TXTBOX_ISBN.Size = new System.Drawing.Size(180, 26);
            this.TXTBOX_ISBN.TabIndex = 0;
            // 
            // BUT_NuevoPrestamo
            // 
            this.BUT_NuevoPrestamo.BackColor = System.Drawing.Color.LightBlue;
            this.BUT_NuevoPrestamo.Dock = System.Windows.Forms.DockStyle.Right;
            this.BUT_NuevoPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUT_NuevoPrestamo.Location = new System.Drawing.Point(747, 105);
            this.BUT_NuevoPrestamo.Name = "BUT_NuevoPrestamo";
            this.BUT_NuevoPrestamo.Size = new System.Drawing.Size(50, 30);
            this.BUT_NuevoPrestamo.TabIndex = 2;
            this.BUT_NuevoPrestamo.Text = "Nuevo";
            this.BUT_NuevoPrestamo.UseVisualStyleBackColor = false;
            // 
            // TXTBOX_DNI
            // 
            this.TXTBOX_DNI.BackColor = System.Drawing.Color.LightGray;
            this.TXTBOX_DNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTBOX_DNI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXTBOX_DNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBOX_DNI.Location = new System.Drawing.Point(209, 8);
            this.TXTBOX_DNI.Margin = new System.Windows.Forms.Padding(8);
            this.TXTBOX_DNI.Name = "TXTBOX_DNI";
            this.TXTBOX_DNI.Size = new System.Drawing.Size(180, 26);
            this.TXTBOX_DNI.TabIndex = 1;
            // 
            // TXTBOX_FPres
            // 
            this.TXTBOX_FPres.BackColor = System.Drawing.Color.LightGray;
            this.TXTBOX_FPres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTBOX_FPres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXTBOX_FPres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBOX_FPres.Location = new System.Drawing.Point(405, 8);
            this.TXTBOX_FPres.Margin = new System.Windows.Forms.Padding(8);
            this.TXTBOX_FPres.Name = "TXTBOX_FPres";
            this.TXTBOX_FPres.Size = new System.Drawing.Size(180, 26);
            this.TXTBOX_FPres.TabIndex = 2;
            // 
            // TXTBOX_FDev
            // 
            this.TXTBOX_FDev.BackColor = System.Drawing.Color.LightGray;
            this.TXTBOX_FDev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTBOX_FDev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXTBOX_FDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBOX_FDev.Location = new System.Drawing.Point(601, 8);
            this.TXTBOX_FDev.Margin = new System.Windows.Forms.Padding(8);
            this.TXTBOX_FDev.Name = "TXTBOX_FDev";
            this.TXTBOX_FDev.Size = new System.Drawing.Size(180, 26);
            this.TXTBOX_FDev.TabIndex = 3;
            // 
            // BUT_SearchPrestamo
            // 
            this.BUT_SearchPrestamo.BackColor = System.Drawing.Color.LightBlue;
            this.BUT_SearchPrestamo.Dock = System.Windows.Forms.DockStyle.Right;
            this.BUT_SearchPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUT_SearchPrestamo.Image = ((System.Drawing.Image)(resources.GetObject("BUT_SearchPrestamo.Image")));
            this.BUT_SearchPrestamo.Location = new System.Drawing.Point(757, 141);
            this.BUT_SearchPrestamo.Name = "BUT_SearchPrestamo";
            this.BUT_SearchPrestamo.Size = new System.Drawing.Size(40, 40);
            this.BUT_SearchPrestamo.TabIndex = 3;
            this.BUT_SearchPrestamo.UseVisualStyleBackColor = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TabLayPan_Principal);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(800, 450);
            this.TabLayPan_Principal.ResumeLayout(false);
            this.TabLayPan_CabeceraPrestamo.ResumeLayout(false);
            this.TabLayPan_CabeceraPrestamo.PerformLayout();
            this.TabLayPan_DatosPrestamo.ResumeLayout(false);
            this.TabLayPan_DatosPrestamo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TabLayPan_Principal;
        private System.Windows.Forms.TableLayoutPanel TabLayPan_CabeceraPrestamo;
        private System.Windows.Forms.Label LAB_ISBN;
        private System.Windows.Forms.Label LAB_DNI;
        private System.Windows.Forms.Label LAB_FPrestamo;
        private System.Windows.Forms.Label LAB_FDevolucion;
        private System.Windows.Forms.TableLayoutPanel TabLayPan_DatosPrestamo;
        private System.Windows.Forms.TextBox TXTBOX_ISBN;
        private System.Windows.Forms.Button BUT_NuevoPrestamo;
        private System.Windows.Forms.TextBox TXTBOX_FDev;
        private System.Windows.Forms.TextBox TXTBOX_FPres;
        private System.Windows.Forms.TextBox TXTBOX_DNI;
        private System.Windows.Forms.Button BUT_SearchPrestamo;
    }
}
