namespace VerLibros
{
    partial class VerLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerLibros));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LAB_Escritor = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.LAB_Titulo = new System.Windows.Forms.Label();
            this.LAB_AnoEdicion = new System.Windows.Forms.Label();
            this.LAB_ID = new System.Windows.Forms.Label();
            this.Chk_Disponible = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel2.ColumnCount = 9;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.76627F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.76627F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.76627F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.70119F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.LAB_Escritor, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnEliminar, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnEditar, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.LAB_Titulo, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.LAB_AnoEdicion, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.LAB_ID, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Chk_Disponible, 5, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(796, 50);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // LAB_Escritor
            // 
            this.LAB_Escritor.AutoSize = true;
            this.LAB_Escritor.BackColor = System.Drawing.SystemColors.Control;
            this.LAB_Escritor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAB_Escritor.Location = new System.Drawing.Point(313, 0);
            this.LAB_Escritor.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LAB_Escritor.Name = "LAB_Escritor";
            this.LAB_Escritor.Size = new System.Drawing.Size(144, 48);
            this.LAB_Escritor.TabIndex = 0;
            this.LAB_Escritor.Text = "Escritor";
            this.LAB_Escritor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(692, 1);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(1);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(38, 46);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(732, 1);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(1);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(33, 46);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // LAB_Titulo
            // 
            this.LAB_Titulo.AutoSize = true;
            this.LAB_Titulo.BackColor = System.Drawing.SystemColors.Control;
            this.LAB_Titulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAB_Titulo.Location = new System.Drawing.Point(169, 0);
            this.LAB_Titulo.Name = "LAB_Titulo";
            this.LAB_Titulo.Size = new System.Drawing.Size(140, 48);
            this.LAB_Titulo.TabIndex = 5;
            this.LAB_Titulo.Text = "Titulo";
            this.LAB_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LAB_AnoEdicion
            // 
            this.LAB_AnoEdicion.AutoSize = true;
            this.LAB_AnoEdicion.BackColor = System.Drawing.SystemColors.Control;
            this.LAB_AnoEdicion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAB_AnoEdicion.Location = new System.Drawing.Point(460, 0);
            this.LAB_AnoEdicion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LAB_AnoEdicion.Name = "LAB_AnoEdicion";
            this.LAB_AnoEdicion.Size = new System.Drawing.Size(148, 48);
            this.LAB_AnoEdicion.TabIndex = 6;
            this.LAB_AnoEdicion.Text = "Año Edicion";
            this.LAB_AnoEdicion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LAB_ID
            // 
            this.LAB_ID.AutoSize = true;
            this.LAB_ID.BackColor = System.Drawing.SystemColors.Control;
            this.LAB_ID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAB_ID.Location = new System.Drawing.Point(23, 0);
            this.LAB_ID.Name = "LAB_ID";
            this.LAB_ID.Size = new System.Drawing.Size(140, 48);
            this.LAB_ID.TabIndex = 7;
            this.LAB_ID.Text = "ID";
            this.LAB_ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Chk_Disponible
            // 
            this.Chk_Disponible.AutoCheck = false;
            this.Chk_Disponible.AutoSize = true;
            this.Chk_Disponible.BackColor = System.Drawing.SystemColors.Control;
            this.Chk_Disponible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Chk_Disponible.Location = new System.Drawing.Point(613, 3);
            this.Chk_Disponible.Name = "Chk_Disponible";
            this.Chk_Disponible.Size = new System.Drawing.Size(75, 42);
            this.Chk_Disponible.TabIndex = 8;
            this.Chk_Disponible.Text = "Disponible";
            this.Chk_Disponible.UseVisualStyleBackColor = false;
            // 
            // VerLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.MinimumSize = new System.Drawing.Size(796, 50);
            this.Name = "VerLibros";
            this.Size = new System.Drawing.Size(796, 50);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label LAB_Escritor;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label LAB_Titulo;
        private System.Windows.Forms.Label LAB_AnoEdicion;
        private System.Windows.Forms.Label LAB_ID;
        private System.Windows.Forms.CheckBox Chk_Disponible;
    }
}
