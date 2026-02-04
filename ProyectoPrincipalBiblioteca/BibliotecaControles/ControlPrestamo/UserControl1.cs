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

        //Se guardan los ID reales para usarlos en los eventos de borrar y editar
        private int prestamoID;
        private int LibroID;
        private int UsuarioID;

        //

        
        public int ID
        {  //get devuelve el valor en prestamoID
            get => prestamoID;
            set
            {
                //set cuando alguien cambia el valor de prestamoID  actualiza la etiqueta LAB_ID para que muestre el nuevo valor
                prestamoID = value;
                LAB_ID.Text = prestamoID.ToString();
            }
        }

        public int ISBN
        {
            //get devuelve el valor en LibroID
            get => LibroID;
            set
            {   //set cuando alguien cambia el valor de LibroID  actualiza la etiqueta LAB_ISBN para que muestre el nuevo valor
                LibroID = value;
                LAB_ISBN.Text = LibroID.ToString(); 
            }
        }

        public int DNI
        {
            //get devuelve el valor en UsuarioID
            get => UsuarioID;
            set
            {
                //set cuando alguien cambia el valor de UsuarioID  actualiza la etiqueta LAB_DNI para que muestre el nuevo valor
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

            //Mensaje de confirmación antes de borrar

            DialogResult resultado = MessageBox.Show(
                  "¿Estás seguro?",
                  "Eliminar",
                  MessageBoxButtons.OKCancel,
                  MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                BorrarPrestamo?.Invoke(this, new ClickarBotonIdEventArgs(prestamoID));
            }
            else
            {
                // lleavar a inicio si se hace IDK
            }


            }

        private void btnEditar_Click(object sender, EventArgs e)
        {
           

                EditarPrestamo?.Invoke(this, new ClickarBotonIdEventArgs(prestamoID));
          
        }

        public event EventHandler<ClickarBotonIdEventArgs> BorrarPrestamo;

        public event EventHandler<ClickarBotonIdEventArgs> EditarPrestamo;

        public class ClickarBotonIdEventArgs : EventArgs
        {
            // Propiedad para almacenar el ID asociado al evento
            public int Id { get; }
            //al clickar el boton se crea una nueva instancia de ClickarBotonIdEventArgs con el ID proporcionado
            public ClickarBotonIdEventArgs(int id)
            {
                Id = id;
            }
        }


       
        








    }
}

