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
    /// <summary>
    /// Clase que representa un control de usuario personalizado para mostrar información de un préstamo en una biblioteca.
    /// </summary>
    public partial class UserControl1: UserControl
    {
        /// <summary>
        /// Se inicializa un nuevo UserControl1 con los componentes del control, estableciendo su diseño y funcionalidad para mostrar los detalles de un préstamo,
        /// como el ID del préstamo, el ISBN del libro, el DNI del usuario, la fecha de préstamo y la fecha de devolución. 
        /// Además, se configuran eventos para manejar acciones como editar o eliminar el préstamo mostrado en el control.
        /// </summary>
        public UserControl1()
        {
            InitializeComponent();
        }
        public override Size MinimumSize
        {
            get => base.MinimumSize; 
            set => base.MinimumSize = new Size(800, 30);
        }

        /// <summary>
        /// Se guardan los valores de ID del préstamo, ISBN del libro y DNI del usuario en variables privadas para su uso interno en el control,
        /// </summary>
        private int prestamoID;
      


        /// <summary>
        /// Esta propiedad permite acceder y modificar el ID del préstamo asociado a este control. Al establecer un nuevo valor para el ID,
        /// </summary>
        public int ID
        {  ///get devuelve el valor en prestamoID
            get => prestamoID;
            set
            {
                ///set cuando alguien cambia el valor de prestamoID  actualiza la etiqueta LAB_ID para que muestre el nuevo valor
                prestamoID = value;
                LAB_ID.Text = prestamoID.ToString();
            }
        }

        /// <summary>
        /// Esta propiedad permite acceder y modificar el ISBN del libro asociado a este préstamo. Al establecer un nuevo valor para el ISBN,
        /// </summary>
        public string ISBN
        {
            ///get devuelve el valor en LibroID
            get => LAB_ISBN.Text;
            set => LAB_ISBN.Text = value;
            
        }

        /// <summary>
        /// Esta propiedad permite acceder y modificar el DNI del usuario asociado a este préstamo. Al establecer un nuevo valor para el DNI,
        /// </summary>
        public string DNI
        {
            ///get devuelve el valor en UsuarioID
            get =>LAB_DNI.Text;
            set => LAB_DNI.Text = value;
           
        }

        /// <summary>
        /// Propiedad para acceder y modificar la fecha de préstamo mostrada en el control. Al establecer un nuevo valor para la fecha de préstamo,
        /// </summary>
        public string Prestamo
        {
            get => LAB_FPrestamo.Text;
            set => LAB_FPrestamo.Text = value;
        }

        /// <summary>
        /// Propiedad para acceder y modificar la fecha de devolución mostrada en el control. Al establecer un nuevo valor para la fecha de devolución,
        /// </summary>
        public string Devolucion
        {
            get => LAB_FDevolucion.Text;
            set => LAB_FDevolucion.Text = value;
        }



        /// <summary>
        /// Este método maneja el evento de clic en el botón "Eliminar". Al hacer clic en este botón, 
        /// se muestra un mensaje de confirmación para asegurarse de que el usuario desea eliminar el préstamo.
        /// </summary>
        /// 
        public void SetBotonesVisibles(bool visibles)
        {
            btnEditar.Visible = visibles;
            btnEliminar.Visible = visibles;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            ///El mensaje de confirmacion
            ///



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

        /// <summary>
        /// Este método maneja el evento de clic en el botón "Editar". Al hacer clic en este botón, 
        /// se invoca el evento EditarPrestamo, pasando el ID del préstamo asociado a este control.
        /// </summary>
        private void btnEditar_Click(object sender, EventArgs e)
        {
           

                EditarPrestamo?.Invoke(this, new ClickarBotonIdEventArgs(prestamoID));
          
        }
        /// <summary>
        /// Este evento se invoca cuando se hace clic en el botón "Eliminar" del control. Al hacer clic en este botón, 
        /// se muestra un mensaje de confirmación, si se confirma se invoca a BorarPrestamo
        /// </summary>
        public event EventHandler<ClickarBotonIdEventArgs> BorrarPrestamo;

        /// <summary>
        /// Este evento se invoca cuando se hace clic en el botón "Editar" del control. Al hacer clic en este botón, se invoca a EditarPrestamo
        /// </summary>
        public event EventHandler<ClickarBotonIdEventArgs> EditarPrestamo;

        /// <summary>
        /// Esta clase representa los argumentos del evento que se pasan al hacer clic en los botones "Editar" o "Eliminar" en el control de usuario.
        /// </summary>
        public class ClickarBotonIdEventArgs : EventArgs
        {
            /// <summary>
            /// Propiedad que almacena el ID del préstamo asociado al evento de clic.
            /// </summary>
            public int Id { get; }
            /// <summary>
            /// Este constructor inicializa una nueva instancia de la clase ClickarBotonIdEventArgs con el ID del préstamo asociado al evento de clic.
            /// </summary>
            /// <param name="id">Es el id que proporcionamos</param>
            public ClickarBotonIdEventArgs(int id)
            {
                Id = id;
            }
        }


       
        








    }
}

