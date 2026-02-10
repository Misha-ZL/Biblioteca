using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaControles
{
    /// <summary>
    /// Base de un control de usuario personalizado para mostrar información de un usuario en una biblioteca.
    /// </summary>
    public partial class verUsuario : UserControl
    {
        /// <summary>
        /// Una nueva instancia de verUsuario se inicializa con los componentes del control, estableciendo su diseño y funcionalidad para mostrar los detalles de un usuario,
        /// </summary>
        public verUsuario()
        {
            InitializeComponent();
        }

        public override Size MinimumSize {
            get => base.MinimumSize;
            set => base.MinimumSize = new Size(1060, 40);
        }

        /// <summary>
        /// Esta propiedad permite acceder y modificar el ID del usuario asociado a este control.
        public int idUsuario
        {
            /// get devuelve el valor en id
            get => id;
            set
            {   /// set cuando alguien cambia el valor de id  actualiza la etiqueta lblUserid para que muestre el nuevo valor
                id = value;
                lblUserid.Text = id.ToString();
            }
        }

        /// <summary>
        /// Esta propiedad permite acceder y modificar el primer apellido del usuario asociado a este control.
        /// </summary>
        public string Apellido1
        {
            get => lblApell1.Text;
            set => lblApell1.Text = value;
        }

        /// <summary>
        /// Esta propiedad permite acceder y modificar el segundo apellido del usuario asociado a este control.
        /// </summary>
        public string Apellido2
        {
            get => lblApell2.Text;
            set => lblApell2.Text = value;
        }

        /// <summary>
        /// Esta propiedad permite acceder y modificar el nombre del usuario asociado a este control.
        /// </summary>
        public string Nombre
        {
            get => lblNombre.Text;
            set => lblNombre.Text = value;
        }

        /// <summary>
        /// Esta propiedad permite acceder y modificar el telefono del usuario asociado a este control.
        /// </summary>
        public int Telefono
        {
            get => tel;
            set
            {
                tel = value;
                lblTelefono.Text = tel.ToString();
            }

        }

        private int id;
        private int tel;


        /// <summary>
        /// Este evento se dispara cuando se hace clic en el botón de eliminar usuario. El evento BorrarUsuario envía el ID del usuario a través de ClickarBotonIdEventArgs.
        /// </summary>
        public event EventHandler<ClickarBotonIdEventArgs> BorrarUsuario;
        /// <summary>
        /// Este evento se dispara cuando se hace clic en el botón de editar usuario. El evento EditarUsuario envía el ID del usuario a través de ClickarBotonIdEventArgs.
        /// </summary>
        public event EventHandler<ClickarBotonIdEventArgs> EditarUsuario;

        /// <summary>
        /// Dispara el evento EditarUsuario cuando se hace clic en el botón de editar, pasando el ID del usuario para que el formulario pueda cargar los detalles del usuario a editar.
        /// </summary>
        private void btnEditar_Click(object sender, EventArgs e)
      
        {
            EditarUsuario?.Invoke(this, new ClickarBotonIdEventArgs(id));
        }

        public void SetBotonesVisibles(bool visibles)
        {
            btnEditar.Visible = visibles;
            btnEliminar.Visible = visibles;
        }

        /// <summary>
        /// Este método se ejecuta cuando se hace clic en el botón de eliminar usuario. Muestra un cuadro de diálogo de confirmación y,
        /// si el usuario confirma, dispara el evento BorrarUsuario con el ID del usuario para que el formulario pueda eliminarlo. 
        /// Si el usuario cancela, no se realiza ninguna acción.
        /// </summary>
        private void btnEliminar_Click(object sender, EventArgs e) { 
        DialogResult resultado = MessageBox.Show(
               "¿Estás seguro?",
               "Eliminar",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question);

            /// Si el usuario hace clic en "OK", se dispara el evento BorrarUsuario con el ID del usuario para que el formulario pueda eliminarlo.
            if (resultado == DialogResult.OK)
            {
            
                
            BorrarUsuario?.Invoke(this, new ClickarBotonIdEventArgs(id));
            }else{

                // lleavar a inicio si se hace IDK

            }

        }

        /// <summary>
        /// La clase ClickarBotonIdEventArgs es una clase personalizada que se utiliza para pasar el ID del usuario asociado a los eventos de edición y eliminación.
        /// </summary>
        public class ClickarBotonIdEventArgs : EventArgs
        {
            
            /// Propiedad para obtener el ID asociado al evento
            public int Id { get; }

            /// al clcikar el boton se crea una instancia de ClickarBotonIdEventArgs pasando el id del usuario
            public ClickarBotonIdEventArgs(int id)
            {
                Id = id;
            }
        }
    }
}
