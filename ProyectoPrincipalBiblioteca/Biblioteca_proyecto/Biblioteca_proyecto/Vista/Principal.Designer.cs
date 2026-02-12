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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPrincipal));
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
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LimeGreen;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiUsuarios,
            this.smiLibros,
            this.smiPrestamos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1373, 44);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // smiUsuarios
            // 
            this.smiUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiUsuariosListar,
            this.smiUsuariosNuevo});
            this.smiUsuarios.Name = "smiUsuarios";
            this.smiUsuarios.Size = new System.Drawing.Size(124, 36);
            this.smiUsuarios.Text = "Usuarios";
            // 
            // smiUsuariosListar
            // 
            this.smiUsuariosListar.Name = "smiUsuariosListar";
            this.smiUsuariosListar.Size = new System.Drawing.Size(299, 44);
            this.smiUsuariosListar.Text = "Listar Usuarios";
            this.smiUsuariosListar.Click += new System.EventHandler(this.smiUsuariosListar_Click);
            // 
            // smiUsuariosNuevo
            // 
            this.smiUsuariosNuevo.Name = "smiUsuariosNuevo";
            this.smiUsuariosNuevo.Size = new System.Drawing.Size(299, 44);
            this.smiUsuariosNuevo.Text = "Nuevo";
            this.smiUsuariosNuevo.Click += new System.EventHandler(this.smiUsuariosNuevo_Click);
            // 
            // smiLibros
            // 
            this.smiLibros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiLibrosListar,
            this.smiLibrosNuevo});
            this.smiLibros.Name = "smiLibros";
            this.smiLibros.Size = new System.Drawing.Size(97, 36);
            this.smiLibros.Text = "Libros";
            // 
            // smiLibrosListar
            // 
            this.smiLibrosListar.Name = "smiLibrosListar";
            this.smiLibrosListar.Size = new System.Drawing.Size(272, 44);
            this.smiLibrosListar.Text = "Listar Libros";
            this.smiLibrosListar.Click += new System.EventHandler(this.smiLibrosListar_Click);
            // 
            // smiLibrosNuevo
            // 
            this.smiLibrosNuevo.Name = "smiLibrosNuevo";
            this.smiLibrosNuevo.Size = new System.Drawing.Size(272, 44);
            this.smiLibrosNuevo.Text = "Nuevo";
            this.smiLibrosNuevo.Click += new System.EventHandler(this.smiLibrosNuevo_Click);
            // 
            // smiPrestamos
            // 
            this.smiPrestamos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiPrestamosListar,
            this.smiPrestamosNuevo});
            this.smiPrestamos.Name = "smiPrestamos";
            this.smiPrestamos.Size = new System.Drawing.Size(143, 36);
            this.smiPrestamos.Text = "Prestamos";
            // 
            // smiPrestamosListar
            // 
            this.smiPrestamosListar.Name = "smiPrestamosListar";
            this.smiPrestamosListar.Size = new System.Drawing.Size(318, 44);
            this.smiPrestamosListar.Text = "Listar Prestamos";
            this.smiPrestamosListar.Click += new System.EventHandler(this.smiPrestamosListar_Click);
            // 
            // smiPrestamosNuevo
            // 
            this.smiPrestamosNuevo.Name = "smiPrestamosNuevo";
            this.smiPrestamosNuevo.Size = new System.Drawing.Size(318, 44);
            this.smiPrestamosNuevo.Text = "Nuevo";
            this.smiPrestamosNuevo.Click += new System.EventHandler(this.smiPrestamosNuevo_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 44);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1373, 605);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 649);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MinimumSize = new System.Drawing.Size(705, 458);
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
        private System.Windows.Forms.Button button1;
    }
}