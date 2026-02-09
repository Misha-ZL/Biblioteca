using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca_proyecto.Controlador;

namespace Biblioteca_proyecto.Vista
{
    /// <summary>
    /// Clase que representa el formulario para agregar un nuevo usuario a la biblioteca. 
    /// Este formulario permite ingresar el nombre, apellidos y teléfono de un nuevo usuario, y luego guarda esta información en la base de datos 
    /// a través del controlador. El formulario también incluye una función para limpiar los campos después de agregar un nuevo usuario.
    /// </summary>
    public partial class FNuevoUsuario : Form
    {
        /// <summary>
        /// ControladorUsuario es una instancia de MiControlador que se utiliza para gestionar las operaciones relacionadas con los usuarios,
        /// </summary>

        public Controlador.MiControlador ControladorUsuario = new Controlador.MiControlador();


        /// <summary>
        /// Se inicializa una nueva instancia de la clase FNuevoUsuario, configurando los componentes del formulario para permitir la entrada de datos de un nuevo usuario,
        /// </summary>
        public FNuevoUsuario()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Nueva instancia de FNuevoUsuario se crea solo si no existe una instancia activa del formulario, o si la instancia anterior ha sido cerrada (disposed).
        /// </summary>
        private static FNuevoUsuario FormNuevoUsuario;


        /// <summary>
        /// Se obtiene la instancia actual de FNuevoUsuario. Si no existe una instancia activa, se crea una nueva. 
        /// Esto asegura que solo haya una ventana de "Nuevo Usuario" abierta en un momento dado.
        /// </summary>
        /// <returns>El formulario de NuevoUsuario</returns>
        public static FNuevoUsuario GetInstance()
        {
            if (FormNuevoUsuario == null || FormNuevoUsuario.IsDisposed)
            {
                FormNuevoUsuario = new FNuevoUsuario();
            }
            return FormNuevoUsuario;
        }
        /// <summary>
        /// Este método se ejecuta cuando se hace clic en el botón "Agregar Usuario". Intenta convertir el texto ingresado en el campo de teléfono a un número entero.
        /// </summary>
        private void BtnAddUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                ///De no ser posible convertir el texto a un número entero, se lanza una excepción con un mensaje de error indicando que el teléfono debe ser numérico.
                bool ok = int.TryParse(TbTelefono.Text, out int TelefonoInt);
               
                if (!ok)
                {
                    throw new Exception("El teléfono debe ser numérico.");
                }

                ControladorUsuario.NuevoUsuario(TbNombre.Text, TbAppellido1.Text, TbApellido2.Text,TelefonoInt);
                
                LimpiarFormularioUsuario();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// Método que se encarga de limpiar los campos del formulario después de agregar un nuevo usuario.
        /// </summary>
        private void LimpiarFormularioUsuario()
        {
            TbNombre.Text = "";
            TbAppellido1.Text = "";
            TbApellido2.Text = "";
            TbTelefono.Text = "";
        }
    }
}
