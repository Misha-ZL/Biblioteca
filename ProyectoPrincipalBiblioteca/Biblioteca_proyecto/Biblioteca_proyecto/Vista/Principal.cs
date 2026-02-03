using System;
using Biblioteca_proyecto.Controlador;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca_proyecto.Vista;


namespace Biblioteca_proyecto
{
    /// <summary>
    /// Este es el main principal de la aplicaccion desde donde se provee la navegacion y manejo
    /// de los formularios de usuarios, libros y prestamos.
    /// </summary>
    public partial class FPrincipal : Form
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase FPrincipal e inicia el componente.
        /// </summary>
        public FPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inserta el formulario especificado como un hijo MDI, oculta el hijo MDI activo actualmente si está presente, 
        /// y muestra el nuevo form con formato dock a fill en el padre
        /// </summary>
        /// <param name="formulario">Form a ser insertado y visualizado como MDI child.</param>
        private void InsertarFormulario(Form formulario)
        {
            
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Hide();
            }
            
            formulario.MdiParent = this;
            formulario.Dock = DockStyle.Fill;
            formulario.Show();
        }

   

      
        /// <summary>
        /// Maneja el evento de click para mostrar la lista de usuarios.
        /// </summary>
        /// <param name="sender">De donde procede el evento.</param>
        /// <param name="e">Datos asociados al evento de click.</param>
        private void smiUsuariosListar_Click(object sender, EventArgs e)
        {
            var form = FUsuarios.GetInstance();
            
            InsertarFormulario(form);
        }
        /// <summary>
        /// Abre el formulario para crear usuario y lo inserta en la app.
        /// </summary>
        /// <param name="sender">Origen del evento.</param>
        /// <param name="e">Datos.</param>
        private void smiUsuariosNuevo_Click(object sender, EventArgs e)
        {
            var form = FNuevoUsuario.GetInstance();
            InsertarFormulario(form);
        }
        /// <summary>
        /// Muestra la lista de libros al producirse el evento de click.
        /// </summary>
        /// <param name="sender">Origen del evento.</param>
        /// <param name="e">Datos asociados al click.</param>
        private void smiLibrosListar_Click(object sender, EventArgs e)
        {
            var form = FLibros.GetInstance();
            InsertarFormulario(form);
        }
        /// <summary>
        /// Abre el menu para crear un nuevo libro e insertarlo en la app.
        /// </summary>
        /// <param name="sender">Origen del evento.</param>
        /// <param name="e">Datos asociados.</param>
        private void smiLibrosNuevo_Click(object sender, EventArgs e)
        {
            var form = NuevoLibro.GetInstance();
            InsertarFormulario(form);
        }
        /// <summary>
        /// Evento para abrir el menu de prestamos.
        /// </summary>
        /// <param name="sender">Origen del evento.</param>
        /// <param name="e">Datos asociados.</param>
        private void smiPrestamosNuevo_Click(object sender, EventArgs e)
        {
            var form = NuevoPrestamo.GetInstance();
            InsertarFormulario(form);
        }

        private void smiPrestamosListar_Click(object sender, EventArgs e)
        {
            var form = Prestamos.GetInstance();
            InsertarFormulario(form);
        }
    }
}
