namespace Biblioteca_proyecto.Vista
{
    partial class EditarPrestamo
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
            this.lFechaInicio = new System.Windows.Forms.Label();
            this.lFechaFin = new System.Windows.Forms.Label();
            this.TbIncio = new System.Windows.Forms.TextBox();
            this.TbFin = new System.Windows.Forms.TextBox();
            this.BtnAddReserva = new System.Windows.Forms.Button();
            this.Llibros = new System.Windows.Forms.Label();
            this.lUsuario = new System.Windows.Forms.Label();
            this.DgvLibros = new System.Windows.Forms.DataGridView();
            this.DgvUsuarios = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lFechaInicio, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lFechaFin, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TbIncio, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.TbFin, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnAddReserva, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.Llibros, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lUsuario, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.DgvLibros, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.DgvUsuarios, 2, 4);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(780, 388);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lFechaInicio
            // 
            this.lFechaInicio.AutoSize = true;
            this.lFechaInicio.BackColor = System.Drawing.SystemColors.Control;
            this.lFechaInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFechaInicio.Location = new System.Drawing.Point(23, 31);
            this.lFechaInicio.Name = "lFechaInicio";
            this.lFechaInicio.Size = new System.Drawing.Size(87, 26);
            this.lFechaInicio.TabIndex = 4;
            this.lFechaInicio.Text = "Fecha_Inicio";
            this.lFechaInicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lFechaFin
            // 
            this.lFechaFin.AutoSize = true;
            this.lFechaFin.BackColor = System.Drawing.SystemColors.Control;
            this.lFechaFin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFechaFin.Location = new System.Drawing.Point(23, 57);
            this.lFechaFin.Name = "lFechaFin";
            this.lFechaFin.Size = new System.Drawing.Size(87, 26);
            this.lFechaFin.TabIndex = 5;
            this.lFechaFin.Text = "lFecha_Fin";
            this.lFechaFin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TbIncio
            // 
            this.TbIncio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbIncio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbIncio.Location = new System.Drawing.Point(116, 34);
            this.TbIncio.Name = "TbIncio";
            this.TbIncio.Size = new System.Drawing.Size(641, 20);
            this.TbIncio.TabIndex = 6;
            // 
            // TbFin
            // 
            this.TbFin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbFin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbFin.Location = new System.Drawing.Point(116, 60);
            this.TbFin.Name = "TbFin";
            this.TbFin.Size = new System.Drawing.Size(641, 20);
            this.TbFin.TabIndex = 7;
            // 
            // BtnAddReserva
            // 
            this.BtnAddReserva.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnAddReserva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAddReserva.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAddReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddReserva.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAddReserva.Location = new System.Drawing.Point(116, 274);
            this.BtnAddReserva.Name = "BtnAddReserva";
            this.BtnAddReserva.Size = new System.Drawing.Size(641, 111);
            this.BtnAddReserva.TabIndex = 8;
            this.BtnAddReserva.Text = "EDITAR";
            this.BtnAddReserva.UseVisualStyleBackColor = false;
            this.BtnAddReserva.Click += new System.EventHandler(this.BtnAddReserva_Click);
            // 
            // Llibros
            // 
            this.Llibros.AutoSize = true;
            this.Llibros.BackColor = System.Drawing.SystemColors.Control;
            this.Llibros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Llibros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Llibros.Location = new System.Drawing.Point(23, 83);
            this.Llibros.Name = "Llibros";
            this.Llibros.Size = new System.Drawing.Size(87, 94);
            this.Llibros.TabIndex = 10;
            this.Llibros.Text = "Libros";
            this.Llibros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lUsuario
            // 
            this.lUsuario.AutoSize = true;
            this.lUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.lUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsuario.Location = new System.Drawing.Point(23, 177);
            this.lUsuario.Name = "lUsuario";
            this.lUsuario.Size = new System.Drawing.Size(87, 94);
            this.lUsuario.TabIndex = 11;
            this.lUsuario.Text = "Usuarios";
            this.lUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DgvLibros
            // 
            this.DgvLibros.AllowUserToAddRows = false;
            this.DgvLibros.AllowUserToDeleteRows = false;
            this.DgvLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLibros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvLibros.Location = new System.Drawing.Point(116, 86);
            this.DgvLibros.MultiSelect = false;
            this.DgvLibros.Name = "DgvLibros";
            this.DgvLibros.ReadOnly = true;
            this.DgvLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLibros.Size = new System.Drawing.Size(641, 88);
            this.DgvLibros.TabIndex = 12;
            // 
            // DgvUsuarios
            // 
            this.DgvUsuarios.AllowUserToAddRows = false;
            this.DgvUsuarios.AllowUserToDeleteRows = false;
            this.DgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvUsuarios.Location = new System.Drawing.Point(116, 180);
            this.DgvUsuarios.MultiSelect = false;
            this.DgvUsuarios.Name = "DgvUsuarios";
            this.DgvUsuarios.ReadOnly = true;
            this.DgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvUsuarios.Size = new System.Drawing.Size(641, 88);
            this.DgvUsuarios.TabIndex = 13;
            // 
            // EditarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 388);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(609, 344);
            this.Name = "EditarPrestamo";
            this.Text = "EditarPrestamo";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lFechaInicio;
        private System.Windows.Forms.Label lFechaFin;
        private System.Windows.Forms.TextBox TbIncio;
        private System.Windows.Forms.TextBox TbFin;
        private System.Windows.Forms.Button BtnAddReserva;
        private System.Windows.Forms.Label Llibros;
        private System.Windows.Forms.Label lUsuario;
        private System.Windows.Forms.DataGridView DgvLibros;
        private System.Windows.Forms.DataGridView DgvUsuarios;
    }
}