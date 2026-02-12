namespace Biblioteca_proyecto.Vista
{
    partial class NuevoPrestamo
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DgvUsuarios = new System.Windows.Forms.DataGridView();
            this.lFechaInicio = new System.Windows.Forms.Label();
            this.lFechaFin = new System.Windows.Forms.Label();
            this.TbIncio = new System.Windows.Forms.TextBox();
            this.TbFin = new System.Windows.Forms.TextBox();
            this.BtnEditarPrestamo = new System.Windows.Forms.Button();
            this.DgvLibro = new System.Windows.Forms.DataGridView();
            this.Llibros = new System.Windows.Forms.Label();
            this.lUsuario = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.DgvUsuarios, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lFechaInicio, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lFechaFin, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TbIncio, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.TbFin, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnEditarPrestamo, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.DgvLibro, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.Llibros, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lUsuario, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DgvUsuarios
            // 
            this.DgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvUsuarios.Location = new System.Drawing.Point(99, 227);
            this.DgvUsuarios.MultiSelect = false;
            this.DgvUsuarios.Name = "DgvUsuarios";
            this.DgvUsuarios.ReadOnly = true;
            this.DgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvUsuarios.Size = new System.Drawing.Size(678, 123);
            this.DgvUsuarios.TabIndex = 3;
            // 
            // lFechaInicio
            // 
            this.lFechaInicio.AutoSize = true;
            this.lFechaInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lFechaInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lFechaInicio.Location = new System.Drawing.Point(23, 43);
            this.lFechaInicio.Name = "lFechaInicio";
            this.lFechaInicio.Size = new System.Drawing.Size(70, 26);
            this.lFechaInicio.TabIndex = 4;
            this.lFechaInicio.Text = "Fecha_Inicio";
            this.lFechaInicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lFechaFin
            // 
            this.lFechaFin.AutoSize = true;
            this.lFechaFin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lFechaFin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lFechaFin.Location = new System.Drawing.Point(23, 69);
            this.lFechaFin.Name = "lFechaFin";
            this.lFechaFin.Size = new System.Drawing.Size(70, 26);
            this.lFechaFin.TabIndex = 5;
            this.lFechaFin.Text = "lFecha_Fin";
            this.lFechaFin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TbIncio
            // 
            this.TbIncio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbIncio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbIncio.Location = new System.Drawing.Point(99, 46);
            this.TbIncio.Name = "TbIncio";
            this.TbIncio.Size = new System.Drawing.Size(678, 20);
            this.TbIncio.TabIndex = 6;
            // 
            // TbFin
            // 
            this.TbFin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbFin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbFin.Location = new System.Drawing.Point(99, 72);
            this.TbFin.Name = "TbFin";
            this.TbFin.Size = new System.Drawing.Size(678, 20);
            this.TbFin.TabIndex = 7;
            // 
            // BtnEditarPrestamo
            // 
            this.BtnEditarPrestamo.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnEditarPrestamo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnEditarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEditarPrestamo.Location = new System.Drawing.Point(99, 356);
            this.BtnEditarPrestamo.Name = "BtnEditarPrestamo";
            this.BtnEditarPrestamo.Size = new System.Drawing.Size(678, 91);
            this.BtnEditarPrestamo.TabIndex = 8;
            this.BtnEditarPrestamo.Text = "AÑADIR";
            this.BtnEditarPrestamo.UseVisualStyleBackColor = false;
            this.BtnEditarPrestamo.Click += new System.EventHandler(this.BtnAddReserva_Click);
            // 
            // DgvLibro
            // 
            this.DgvLibro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLibro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvLibro.Location = new System.Drawing.Point(99, 98);
            this.DgvLibro.MultiSelect = false;
            this.DgvLibro.Name = "DgvLibro";
            this.DgvLibro.ReadOnly = true;
            this.DgvLibro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLibro.Size = new System.Drawing.Size(678, 123);
            this.DgvLibro.TabIndex = 9;
            // 
            // Llibros
            // 
            this.Llibros.AutoSize = true;
            this.Llibros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Llibros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Llibros.Location = new System.Drawing.Point(23, 95);
            this.Llibros.Name = "Llibros";
            this.Llibros.Size = new System.Drawing.Size(70, 129);
            this.Llibros.TabIndex = 10;
            this.Llibros.Text = "Libros";
            this.Llibros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lUsuario
            // 
            this.lUsuario.AutoSize = true;
            this.lUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lUsuario.Location = new System.Drawing.Point(23, 224);
            this.lUsuario.Name = "lUsuario";
            this.lUsuario.Size = new System.Drawing.Size(70, 129);
            this.lUsuario.TabIndex = 11;
            this.lUsuario.Text = "Usuarios";
            this.lUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NuevoPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoPrestamo";
            this.Text = "NuevaReserve";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLibro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView DgvUsuarios;
        private System.Windows.Forms.Label lFechaInicio;
        private System.Windows.Forms.Label lFechaFin;
        private System.Windows.Forms.TextBox TbIncio;
        private System.Windows.Forms.TextBox TbFin;
        private System.Windows.Forms.Button BtnEditarPrestamo;
        private System.Windows.Forms.DataGridView DgvLibro;
        private System.Windows.Forms.Label Llibros;
        private System.Windows.Forms.Label lUsuario;
    }
}