namespace Biblioteca_proyecto.Vista
{
    partial class NuevoLibro
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
            this.lTitulo = new System.Windows.Forms.Label();
            this.lAnoEdicion = new System.Windows.Forms.Label();
            this.lSinopsis = new System.Windows.Forms.Label();
            this.TbTitulo = new System.Windows.Forms.TextBox();
            this.TbAnoEdicion = new System.Windows.Forms.TextBox();
            this.TbSinopsis = new System.Windows.Forms.TextBox();
            this.BtnAddUsuario = new System.Windows.Forms.Button();
            this.lEscritor = new System.Windows.Forms.Label();
            this.TbEscritor = new System.Windows.Forms.TextBox();
            this.ChkDisponible = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Controls.Add(this.lTitulo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lAnoEdicion, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lSinopsis, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.TbTitulo, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.TbAnoEdicion, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.TbSinopsis, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.BtnAddUsuario, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.lEscritor, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TbEscritor, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.ChkDisponible, 2, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(851, 573);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lTitulo
            // 
            this.lTitulo.AutoSize = true;
            this.lTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lTitulo.Location = new System.Drawing.Point(43, 148);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(67, 26);
            this.lTitulo.TabIndex = 0;
            this.lTitulo.Text = "Titulo";
            this.lTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lAnoEdicion
            // 
            this.lAnoEdicion.AutoSize = true;
            this.lAnoEdicion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lAnoEdicion.Location = new System.Drawing.Point(43, 200);
            this.lAnoEdicion.Name = "lAnoEdicion";
            this.lAnoEdicion.Size = new System.Drawing.Size(67, 26);
            this.lAnoEdicion.TabIndex = 1;
            this.lAnoEdicion.Text = "Año_Edicion";
            this.lAnoEdicion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSinopsis
            // 
            this.lSinopsis.AutoSize = true;
            this.lSinopsis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lSinopsis.Location = new System.Drawing.Point(43, 226);
            this.lSinopsis.Name = "lSinopsis";
            this.lSinopsis.Size = new System.Drawing.Size(67, 26);
            this.lSinopsis.TabIndex = 2;
            this.lSinopsis.Text = "Sinopsis";
            this.lSinopsis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TbTitulo
            // 
            this.TbTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbTitulo.Location = new System.Drawing.Point(116, 151);
            this.TbTitulo.Name = "TbTitulo";
            this.TbTitulo.Size = new System.Drawing.Size(692, 20);
            this.TbTitulo.TabIndex = 4;
            // 
            // TbAnoEdicion
            // 
            this.TbAnoEdicion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbAnoEdicion.Location = new System.Drawing.Point(116, 203);
            this.TbAnoEdicion.Name = "TbAnoEdicion";
            this.TbAnoEdicion.Size = new System.Drawing.Size(692, 20);
            this.TbAnoEdicion.TabIndex = 5;
            // 
            // TbSinopsis
            // 
            this.TbSinopsis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbSinopsis.Location = new System.Drawing.Point(116, 229);
            this.TbSinopsis.Name = "TbSinopsis";
            this.TbSinopsis.Size = new System.Drawing.Size(692, 20);
            this.TbSinopsis.TabIndex = 6;
            // 
            // BtnAddUsuario
            // 
            this.BtnAddUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAddUsuario.Location = new System.Drawing.Point(116, 278);
            this.BtnAddUsuario.Name = "BtnAddUsuario";
            this.BtnAddUsuario.Size = new System.Drawing.Size(692, 142);
            this.BtnAddUsuario.TabIndex = 8;
            this.BtnAddUsuario.Text = "AÑADIR";
            this.BtnAddUsuario.UseVisualStyleBackColor = true;
            this.BtnAddUsuario.Click += new System.EventHandler(this.BtnAddUsuario_Click);
            // 
            // lEscritor
            // 
            this.lEscritor.AutoSize = true;
            this.lEscritor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lEscritor.Location = new System.Drawing.Point(43, 174);
            this.lEscritor.Name = "lEscritor";
            this.lEscritor.Size = new System.Drawing.Size(67, 26);
            this.lEscritor.TabIndex = 9;
            this.lEscritor.Text = "Escritor";
            this.lEscritor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TbEscritor
            // 
            this.TbEscritor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbEscritor.Location = new System.Drawing.Point(116, 177);
            this.TbEscritor.Name = "TbEscritor";
            this.TbEscritor.Size = new System.Drawing.Size(692, 20);
            this.TbEscritor.TabIndex = 10;
            // 
            // ChkDisponible
            // 
            this.ChkDisponible.AutoSize = true;
            this.ChkDisponible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChkDisponible.Location = new System.Drawing.Point(116, 255);
            this.ChkDisponible.Name = "ChkDisponible";
            this.ChkDisponible.Size = new System.Drawing.Size(692, 17);
            this.ChkDisponible.TabIndex = 12;
            this.ChkDisponible.Text = "Disponible";
            this.ChkDisponible.UseVisualStyleBackColor = true;
            // 
            // NuevoLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 573);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(438, 257);
            this.Name = "NuevoLibro";
            this.Text = "NuevoLibro";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.Label lAnoEdicion;
        private System.Windows.Forms.Label lSinopsis;
        private System.Windows.Forms.TextBox TbTitulo;
        private System.Windows.Forms.TextBox TbAnoEdicion;
        private System.Windows.Forms.TextBox TbSinopsis;
        private System.Windows.Forms.Button BtnAddUsuario;
        private System.Windows.Forms.Label lEscritor;
        private System.Windows.Forms.TextBox TbEscritor;
        private System.Windows.Forms.CheckBox ChkDisponible;
    }
}