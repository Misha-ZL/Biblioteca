namespace BibliotecaControles
{
    partial class verUsuario
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
            this.tlpUsuario = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblApell1 = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblUserid = new System.Windows.Forms.Label();
            this.lblApell2 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tlpUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpUsuario
            // 
            this.tlpUsuario.ColumnCount = 9;
            this.tlpUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.27396F));
            this.tlpUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.54791F));
            this.tlpUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.54791F));
            this.tlpUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.26381F));
            this.tlpUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.3664F));
            this.tlpUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tlpUsuario.Controls.Add(this.btnEditar, 6, 0);
            this.tlpUsuario.Controls.Add(this.btnEliminar, 7, 0);
            this.tlpUsuario.Controls.Add(this.lblApell1, 2, 0);
            this.tlpUsuario.Controls.Add(this.lblTelefono, 5, 0);
            this.tlpUsuario.Controls.Add(this.lblUserid, 1, 0);
            this.tlpUsuario.Controls.Add(this.lblApell2, 3, 0);
            this.tlpUsuario.Controls.Add(this.lblNombre, 4, 0);
            this.tlpUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUsuario.Location = new System.Drawing.Point(0, 0);
            this.tlpUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.tlpUsuario.Name = "tlpUsuario";
            this.tlpUsuario.RowCount = 1;
            this.tlpUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUsuario.Size = new System.Drawing.Size(796, 32);
            this.tlpUsuario.TabIndex = 0;
            // 
            // btnEditar
            // 
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditar.Location = new System.Drawing.Point(699, 2);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(34, 28);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "Ed";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminar.Location = new System.Drawing.Point(737, 2);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(34, 28);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Elim";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblApell1
            // 
            this.lblApell1.AutoSize = true;
            this.lblApell1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblApell1.Location = new System.Drawing.Point(94, 0);
            this.lblApell1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApell1.Name = "lblApell1";
            this.lblApell1.Size = new System.Drawing.Size(150, 32);
            this.lblApell1.TabIndex = 2;
            this.lblApell1.Text = "Apellido1";
            this.lblApell1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTelefono.Location = new System.Drawing.Point(526, 0);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(169, 32);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "Telefono";
            this.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUserid
            // 
            this.lblUserid.AutoSize = true;
            this.lblUserid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserid.Location = new System.Drawing.Point(17, 0);
            this.lblUserid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserid.Name = "lblUserid";
            this.lblUserid.Size = new System.Drawing.Size(73, 32);
            this.lblUserid.TabIndex = 4;
            this.lblUserid.Text = "idUsuario";
            this.lblUserid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblApell2
            // 
            this.lblApell2.AutoSize = true;
            this.lblApell2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblApell2.Location = new System.Drawing.Point(248, 0);
            this.lblApell2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApell2.Name = "lblApell2";
            this.lblApell2.Size = new System.Drawing.Size(150, 32);
            this.lblApell2.TabIndex = 5;
            this.lblApell2.Text = "Apellido2";
            this.lblApell2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombre.Location = new System.Drawing.Point(402, 0);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(120, 32);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // verUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpUsuario);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "verUsuario";
            this.Size = new System.Drawing.Size(796, 32);
            this.tlpUsuario.ResumeLayout(false);
            this.tlpUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpUsuario;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblApell1;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblUserid;
        private System.Windows.Forms.Label lblApell2;
        private System.Windows.Forms.Label lblNombre;
    }
}
