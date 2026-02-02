using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlPrestamo2
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public override Size MinimumSize
        {
            get => base.MinimumSize; 
            set => base.MinimumSize = new Size(800, 30);
        }

        public string ID
        {  
            get => LAB_ID.Text;
            set => LAB_ID.Text = value; 
        }

        public string ISBN
        {
            get => LAB_ISBN.Text;
            set => LAB_ISBN.Text = value;
        }

        public string DNI
        {
            get => LAB_DNI.Text;
            set => LAB_DNI.Text = value;
        }



        public string Prestamo
        {
            get => LAB_FPrestamo.Text;
            set => LAB_FPrestamo.Text = value;
        }

        public string Devolucion
        {
            get => LAB_FDevolucion.Text;
            set => LAB_FDevolucion.Text = value;
        }

        public event EventHandler<string> eliminarPrestamo;
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarPrestamo?.Invoke(this, ID);
        }

        public event EventHandler<string> editarPrestamo;
        private void btnEditar_Click(object sender, EventArgs e)
        {
            editarPrestamo?.Invoke(this, ID);
        }
    }
}

