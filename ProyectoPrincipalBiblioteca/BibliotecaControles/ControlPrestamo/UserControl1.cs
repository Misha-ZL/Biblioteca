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
        private int prestamoID;
        private int LibroID;
        private int UsuarioID;
        public int ID
        {  
            get => prestamoID;
            set
            {
                prestamoID = value;
                LAB_ID.Text = prestamoID.ToString();
            }
        }

        public int ISBN
        {
           get => LibroID;
            set
            {
                LibroID = value;
                LAB_ISBN.Text = LibroID.ToString(); 
            }
        }

        public int DNI
        {
            get => UsuarioID;
            set
            {
                UsuarioID = value;
                LAB_DNI.Text = UsuarioID.ToString();
            }
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




        private void btnEliminar_Click(object sender, EventArgs e)
        {
            BorrarPrestamo?.Invoke(this, new ClickarBotonIdEventArgs(prestamoID));


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                   "¿Estás seguro?",
                   "Eliminar",
                   MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {

                EditarPrestamo?.Invoke(this, new ClickarBotonIdEventArgs(prestamoID));
            }
            else {
                // lleavar a inicio si se hace IDK
            }
        }

        public event EventHandler<ClickarBotonIdEventArgs> BorrarPrestamo;

        public event EventHandler<ClickarBotonIdEventArgs> EditarPrestamo;

        public class ClickarBotonIdEventArgs : EventArgs
        {
            public int Id { get; }
            public ClickarBotonIdEventArgs(int id)
            {
                Id = id;
            }
        }


       
        








    }
}

