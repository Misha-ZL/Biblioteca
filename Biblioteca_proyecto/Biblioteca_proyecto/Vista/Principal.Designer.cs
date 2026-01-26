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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiUsuarios,
            this.smiLibros,
            this.smiPrestamos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // smiUsuarios
            // 
            this.smiUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiUsuariosListar,
            this.smiUsuariosNuevo});
            this.smiUsuarios.Name = "smiUsuarios";
            this.smiUsuarios.Size = new System.Drawing.Size(64, 20);
            this.smiUsuarios.Text = "Usuarios";
            // 
            // smiUsuariosListar
            // 
            this.smiUsuariosListar.Name = "smiUsuariosListar";
            this.smiUsuariosListar.Size = new System.Drawing.Size(150, 22);
            this.smiUsuariosListar.Text = "Listar Usuarios";
            this.smiUsuariosListar.Click += new System.EventHandler(this.smiUsuariosListar_Click);
            // 
            // smiUsuariosNuevo
            // 
            this.smiUsuariosNuevo.Name = "smiUsuariosNuevo";
            this.smiUsuariosNuevo.Size = new System.Drawing.Size(150, 22);
            this.smiUsuariosNuevo.Text = "Nuevo";
            this.smiUsuariosNuevo.Click += new System.EventHandler(this.smiUsuariosNuevo_Click);
            // 
            // smiLibros
            // 
            this.smiLibros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiLibrosListar,
            this.smiLibrosNuevo});
            this.smiLibros.Name = "smiLibros";
            this.smiLibros.Size = new System.Drawing.Size(51, 20);
            this.smiLibros.Text = "Libros";
            // 
            // smiLibrosListar
            // 
            this.smiLibrosListar.Name = "smiLibrosListar";
            this.smiLibrosListar.Size = new System.Drawing.Size(180, 22);
            this.smiLibrosListar.Text = "Listar Libros";
            this.smiLibrosListar.Click += new System.EventHandler(this.smiLibrosListar_Click);
            // 
            // smiLibrosNuevo
            // 
            this.smiLibrosNuevo.Name = "smiLibrosNuevo";
            this.smiLibrosNuevo.Size = new System.Drawing.Size(180, 22);
            this.smiLibrosNuevo.Text = "Nuevo";
            this.smiLibrosNuevo.Click += new System.EventHandler(this.smiLibrosNuevo_Click);
            // 
            // smiPrestamos
            // 
            this.smiPrestamos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiPrestamosListar,
            this.smiPrestamosNuevo});
            this.smiPrestamos.Name = "smiPrestamos";
            this.smiPrestamos.Size = new System.Drawing.Size(74, 20);
            this.smiPrestamos.Text = "Prestamos";
            // 
            // smiPrestamosListar
            // 
            this.smiPrestamosListar.Name = "smiPrestamosListar";
            this.smiPrestamosListar.Size = new System.Drawing.Size(160, 22);
            this.smiPrestamosListar.Text = "Listar Prestamos";
            // 
            // smiPrestamosNuevo
            // 
            this.smiPrestamosNuevo.Name = "smiPrestamosNuevo";
            this.smiPrestamosNuevo.Size = new System.Drawing.Size(160, 22);
            this.smiPrestamosNuevo.Text = "Nuevo";
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
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
    }
}