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
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUserid = new System.Windows.Forms.Label();
            this.lblApell2 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tlpUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpUsuario
            // 
            this.tlpUsuario.ColumnCount = 9;
            this.tlpUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.27396F));
            this.tlpUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.54791F));
            this.tlpUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.54791F));
            this.tlpUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.26381F));
            this.tlpUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.3664F));
            this.tlpUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpUsuario.Controls.Add(this.btnEditar, 6, 0);
            this.tlpUsuario.Controls.Add(this.btnEliminar, 7, 0);
            this.tlpUsuario.Controls.Add(this.lblApell1, 2, 0);
            this.tlpUsuario.Controls.Add(this.lblEmail, 5, 0);
            this.tlpUsuario.Controls.Add(this.lblUserid, 1, 0);
            this.tlpUsuario.Controls.Add(this.lblApell2, 3, 0);
            this.tlpUsuario.Controls.Add(this.lblNombre, 4, 0);
            this.tlpUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUsuario.Location = new System.Drawing.Point(0, 0);
            this.tlpUsuario.Name = "tlpUsuario";
            this.tlpUsuario.RowCount = 1;
            this.tlpUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUsuario.Size = new System.Drawing.Size(1062, 40);
            this.tlpUsuario.TabIndex = 0;
            // 
            // btnEditar
            // 
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditar.Location = new System.Drawing.Point(941, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(44, 34);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "Ed";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminar.Location = new System.Drawing.Point(991, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(44, 34);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Elim";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblApell1
            // 
            this.lblApell1.AutoSize = true;
            this.lblApell1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblApell1.Location = new System.Drawing.Point(126, 0);
            this.lblApell1.Name = "lblApell1";
            this.lblApell1.Size = new System.Drawing.Size(201, 40);
            this.lblApell1.TabIndex = 2;
            this.lblApell1.Text = "Apellido1";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmail.Location = new System.Drawing.Point(708, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(227, 40);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblUserid
            // 
            this.lblUserid.AutoSize = true;
            this.lblUserid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserid.Location = new System.Drawing.Point(23, 0);
            this.lblUserid.Name = "lblUserid";
            this.lblUserid.Size = new System.Drawing.Size(97, 40);
            this.lblUserid.TabIndex = 4;
            this.lblUserid.Text = "idUsuario";
            // 
            // lblApell2
            // 
            this.lblApell2.AutoSize = true;
            this.lblApell2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblApell2.Location = new System.Drawing.Point(333, 0);
            this.lblApell2.Name = "lblApell2";
            this.lblApell2.Size = new System.Drawing.Size(201, 40);
            this.lblApell2.TabIndex = 5;
            this.lblApell2.Text = "Apellido2";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombre.Location = new System.Drawing.Point(540, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(162, 40);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // verUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpUsuario);
            this.Name = "verUsuario";
            this.Size = new System.Drawing.Size(1062, 40);
            this.tlpUsuario.ResumeLayout(false);
            this.tlpUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpUsuario;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblApell1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUserid;
        private System.Windows.Forms.Label lblApell2;
        private System.Windows.Forms.Label lblNombre;
    }
}
