namespace Biblioteca_proyecto
{
    partial class FPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.smiUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.smiUsuariosListar = new System.Windows.Forms.ToolStripMenuItem();
            this.smiUsuariosNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.smiLibros = new System.Windows.Forms.ToolStripMenuItem();
            this.smiLibrosListar = new System.Windows.Forms.ToolStripMenuItem();
            this.smiLibrosNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.smiPrestamos = new System.Windows.Forms.ToolStripMenuItem();
            this.smiPrestamosListar = new System.Windows.Forms.ToolStripMenuItem();
            this.smiPrestamosNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(7, 4, 0, 7);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.smiUsuarios,
            this.smiLibros,
            this.smiPrestamos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 5, 0, 5);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1054, 39);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // smiUsuarios
            // 
            this.smiUsuarios.BackColor = System.Drawing.Color.LimeGreen;
            this.smiUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiUsuariosListar,
            this.smiUsuariosNuevo});
            this.smiUsuarios.ForeColor = System.Drawing.Color.White;
            this.smiUsuarios.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.smiUsuarios.Name = "smiUsuarios";
            this.smiUsuarios.Size = new System.Drawing.Size(83, 29);
            this.smiUsuarios.Text = "Usuarios";
            // 
            // smiUsuariosListar
            // 
            this.smiUsuariosListar.BackColor = System.Drawing.Color.LimeGreen;
            this.smiUsuariosListar.ForeColor = System.Drawing.Color.White;
            this.smiUsuariosListar.Name = "smiUsuariosListar";
            this.smiUsuariosListar.Size = new System.Drawing.Size(183, 26);
            this.smiUsuariosListar.Text = "Listar Usuarios";
            this.smiUsuariosListar.Click += new System.EventHandler(this.smiUsuariosListar_Click);
            // 
            // smiUsuariosNuevo
            // 
            this.smiUsuariosNuevo.BackColor = System.Drawing.Color.LimeGreen;
            this.smiUsuariosNuevo.ForeColor = System.Drawing.Color.White;
            this.smiUsuariosNuevo.Name = "smiUsuariosNuevo";
            this.smiUsuariosNuevo.Size = new System.Drawing.Size(183, 26);
            this.smiUsuariosNuevo.Text = "Nuevo";
            this.smiUsuariosNuevo.Click += new System.EventHandler(this.smiUsuariosNuevo_Click);
            // 
            // smiLibros
            // 
            this.smiLibros.BackColor = System.Drawing.Color.LimeGreen;
            this.smiLibros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiLibrosListar,
            this.smiLibrosNuevo});
            this.smiLibros.ForeColor = System.Drawing.Color.White;
            this.smiLibros.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.smiLibros.Name = "smiLibros";
            this.smiLibros.Size = new System.Drawing.Size(65, 29);
            this.smiLibros.Text = "Libros";
            // 
            // smiLibrosListar
            // 
            this.smiLibrosListar.BackColor = System.Drawing.Color.LimeGreen;
            this.smiLibrosListar.ForeColor = System.Drawing.Color.White;
            this.smiLibrosListar.Name = "smiLibrosListar";
            this.smiLibrosListar.Size = new System.Drawing.Size(180, 26);
            this.smiLibrosListar.Text = "Listar Libros";
            this.smiLibrosListar.Click += new System.EventHandler(this.smiLibrosListar_Click);
            // 
            // smiLibrosNuevo
            // 
            this.smiLibrosNuevo.BackColor = System.Drawing.Color.LimeGreen;
            this.smiLibrosNuevo.ForeColor = System.Drawing.Color.White;
            this.smiLibrosNuevo.Name = "smiLibrosNuevo";
            this.smiLibrosNuevo.Size = new System.Drawing.Size(180, 26);
            this.smiLibrosNuevo.Text = "Nuevo";
            this.smiLibrosNuevo.Click += new System.EventHandler(this.smiLibrosNuevo_Click);
            // 
            // smiPrestamos
            // 
            this.smiPrestamos.BackColor = System.Drawing.Color.LimeGreen;
            this.smiPrestamos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiPrestamosListar,
            this.smiPrestamosNuevo});
            this.smiPrestamos.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.smiPrestamos.ForeColor = System.Drawing.Color.White;
            this.smiPrestamos.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.smiPrestamos.Name = "smiPrestamos";
            this.smiPrestamos.Size = new System.Drawing.Size(95, 29);
            this.smiPrestamos.Text = "Prestamos";
            // 
            // smiPrestamosListar
            // 
            this.smiPrestamosListar.BackColor = System.Drawing.Color.LimeGreen;
            this.smiPrestamosListar.ForeColor = System.Drawing.Color.White;
            this.smiPrestamosListar.Name = "smiPrestamosListar";
            this.smiPrestamosListar.Size = new System.Drawing.Size(195, 26);
            this.smiPrestamosListar.Text = "Listar Prestamos";
            this.smiPrestamosListar.Click += new System.EventHandler(this.smiPrestamosListar_Click);
            // 
            // smiPrestamosNuevo
            // 
            this.smiPrestamosNuevo.BackColor = System.Drawing.Color.LimeGreen;
            this.smiPrestamosNuevo.ForeColor = System.Drawing.Color.White;
            this.smiPrestamosNuevo.Name = "smiPrestamosNuevo";
            this.smiPrestamosNuevo.Size = new System.Drawing.Size(195, 26);
            this.smiPrestamosNuevo.Text = "Nuevo";
            this.smiPrestamosNuevo.Click += new System.EventHandler(this.smiPrestamosNuevo_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripTextBox1.ForeColor = System.Drawing.Color.White;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(131, 29);
            this.toolStripTextBox1.Text = "Vitoria-Gasteiz";
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 561);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1070, 600);
            this.Name = "FPrincipal";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem smiUsuarios;
        private System.Windows.Forms.ToolStripMenuItem smiUsuariosListar;
        private System.Windows.Forms.ToolStripMenuItem smiLibros;
        private System.Windows.Forms.ToolStripMenuItem smiLibrosListar;
        private System.Windows.Forms.ToolStripMenuItem smiPrestamos;
        private System.Windows.Forms.ToolStripMenuItem smiUsuariosNuevo;
        private System.Windows.Forms.ToolStripMenuItem smiLibrosNuevo;
        private System.Windows.Forms.ToolStripMenuItem smiPrestamosListar;
        private System.Windows.Forms.ToolStripMenuItem smiPrestamosNuevo;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    }
}