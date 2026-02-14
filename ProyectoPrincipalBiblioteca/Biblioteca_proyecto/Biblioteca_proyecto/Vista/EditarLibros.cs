using Biblioteca_proyecto.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_proyecto.Vista
{
    /// <summary>
    /// Representael formulario para editar los detalles de un libro existente en la biblioteca, 
    /// permitiendo modificar el título, escritor, año de edición, sinopsis y disponibilidad del libro seleccionado.
    /// </summary>
    public partial class EditarLibros : Form
    {
        /// <summary>
        /// Instancia de MiControlador para gestionar las operaciones relacionadas con los libros, 
        /// como cargar los datos del libro a editar y modificar el libro en la base de datos.
        /// </summary>

        public MiControlador ControladorModLibro = new MiControlador();

        public int id;

        /// <summary>
        /// El constructor de la clase EditarLibros llama al método InitializeComponent para configurar los componentes del formulario y 
        /// asigna el evento Load para cargar los datos del libro a editar cuando se cargue el formulario.
        /// </summary>
        public EditarLibros()
        {
            InitializeComponent();
            this.Load += EditarLibro_Load;
        }

        /// <summary>
        /// Manega el evento de load del form para mostrar y cargar la informacion de un libro a editar.
        /// </summary>
        private void EditarLibro_Load(object sender, EventArgs e)
        {
            ///Se carga la informacion del libro
            DataTable data = ControladorModLibro.BuscarLibroPorID(id);
            /// Si no se encuentra el libro, se muestra un mensaje de error y se cierra el formulario
            if (data.Rows.Count == 0)
            {
                MessageBox.Show("No se encontró el libro con ID: " + id);
                this.Close();
                return;
            }

            TbTitulo.Text = data.Rows[0]["Titulo"].ToString();
            TbEscritor.Text = data.Rows[0]["Escritor"].ToString();
            TbAnoEdicion.Text = data.Rows[0]["Ano_Edicion"].ToString();
            TbSinopsis.Text = data.Rows[0]["Sinopsis"].ToString();

            ///Se obtiene el valor de disponibilidad del libro y se asigna al CheckBox correspondiente,
            ///manejando tanto el caso en que el valor sea un booleano como un entero (1 para disponible, 0 para no disponible).
            object dispObj = data.Rows[0]["Disponible"];
            bool disponible = (dispObj is bool b) ? b : Convert.ToInt32(dispObj) == 1;
            ChkDisponible.Checked = disponible;
        }

        /// <summary>
        /// Maneja el evento de clic del botón "Editar Libro". Recoge los datos ingresados por el usuario, 
        /// llama al método ModificarLibro del controlador para actualizar la información del libro en la base de datos, 
        /// muestra un mensaje de confirmación y cierra el formulario. Si ocurre algún error durante el proceso, se muestra un mensaje de error.
        /// </summary>
        private void BtnEditarLibro_Click(object sender, EventArgs e)
        {
            try
            {
                int ano = Convert.ToInt32(TbAnoEdicion.Text);
                bool disponible = ChkDisponible.Checked;

                ControladorModLibro.ModificarLibro( id, TbTitulo.Text, TbEscritor.Text, ano,  TbSinopsis.Text, disponible
                );

                MessageBox.Show("Editando libro ID: " + id);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void TbAnoEdicion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
