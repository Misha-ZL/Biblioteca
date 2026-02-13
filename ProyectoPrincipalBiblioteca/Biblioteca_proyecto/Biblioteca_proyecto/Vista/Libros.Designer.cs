namespace Biblioteca_proyecto
{
    partial class FLibros
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
            this.tlpLibros = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tlpLibros
            // 
            this.tlpLibros.ColumnCount = 1;
            this.tlpLibros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLibros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpLibros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLibros.Location = new System.Drawing.Point(0, 0);
            this.tlpLibros.Name = "tlpLibros";
            this.tlpLibros.RowCount = 1;
            this.tlpLibros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLibros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 462F));
            this.tlpLibros.Size = new System.Drawing.Size(1088, 629);
            this.tlpLibros.TabIndex = 0;
            // 
            // FLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1088, 629);
            this.Controls.Add(this.tlpLibros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1070, 600);
            this.Name = "FLibros";
            this.Text = "Libros";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpLibros;
    }
}