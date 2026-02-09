namespace Biblioteca_proyecto
{
    partial class FUsuarios
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpUsuarios = new System.Windows.Forms.TableLayoutPanel();
            this.userControl11 = new ControlPrestamo2.UserControl1();
            this.tlpUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpUsuarios
            // 
            this.tlpUsuarios.ColumnCount = 1;
            this.tlpUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpUsuarios.Controls.Add(this.userControl11, 0, 0);
            this.tlpUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUsuarios.Location = new System.Drawing.Point(0, 0);
            this.tlpUsuarios.Name = "tlpUsuarios";
            this.tlpUsuarios.RowCount = 1;
            this.tlpUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 494F));
            this.tlpUsuarios.Size = new System.Drawing.Size(1091, 494);
            this.tlpUsuarios.TabIndex = 0;
            // 
            // userControl11
            // 
            this.userControl11.Devolucion = "Fecha Devolucion";
            this.userControl11.ID = 0;
            this.userControl11.Location = new System.Drawing.Point(3, 3);
            this.userControl11.MinimumSize = new System.Drawing.Size(800, 30);
            this.userControl11.Name = "userControl11";
            this.userControl11.Prestamo = "Fecha Prestamo";
            this.userControl11.Size = new System.Drawing.Size(800, 30);
            this.userControl11.TabIndex = 0;
            // 
            // FUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 494);
            this.Controls.Add(this.tlpUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(709, 316);
            this.Name = "FUsuarios";
            this.Text = "Usuarios";
            this.tlpUsuarios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpUsuarios;
        private ControlPrestamo2.UserControl1 userControl11;
    }
}

