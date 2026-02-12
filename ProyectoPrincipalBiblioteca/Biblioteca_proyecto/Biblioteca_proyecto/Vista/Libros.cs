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

namespace Biblioteca_proyecto
{
    /// <summary>
    /// Representa el formulario para gestionar los libros disponibles en la biblioteca, permitiendo visualizar, editar y eliminar libros,
    /// utilizando un TableLayoutPanel para mostrar la información de cada libro y botones para realizar las acciones correspondientes.
    /// </summary>
    public partial class FLibros : Form
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase FLibros, configura el estado de la ventana a maximizado y 
        /// asigna el evento Activated para cargar los libros disponibles cuando se active el formulario.
        /// </summary>
        public FLibros()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Activated += FLibros_Load;
        }

        private static FLibros FormLibro;

        /// <summary>
        /// Se define una instancia de MiControlador llamada ControladorLibro, que se utiliza para gestionar las operaciones relacionadas con los libros.
        /// </summary>
        MiControlador ControladorLibro = new MiControlador();

        /// <summary>
        /// Maneja el evento cargando la informacion de cada libro.
        /// </summary>
        /// <param name="e">Objeto con los datos almacenados.</param>
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            Cargar(ControladorLibro.CargarLibrosDisponibles());
        }

        /// <summary>
        /// El método FLibros_Load se ejecuta cuando se carga el formulario FLibros. 
        /// Este método llama al método Cargar para cargar y mostrar los datos de los libros disponibles en el TableLayoutPanel tlpLibros.
        /// </summary>
        private void FLibros_Load(object sender, EventArgs e)
        {
            Cargar(ControladorLibro.CargarLibrosDisponibles());
        }

        /// <summary>
        /// Carga los datos de los libros en el TableLayoutPanel tlpLibros, creando un control personalizado para cada libro y agregándolo al panel.
        /// </summary>
        /// <param name="datos">Datos de los libros a cargar</param>
        public void Cargar(DataTable datos)
        {
            tlpLibros.SuspendLayout();

            tlpLibros.Controls.Clear();
            tlpLibros.RowStyles.Clear();
            tlpLibros.RowCount = 0;

            int nuevaFila = 0;

            ///La cabeceradel panel, con los nombres de cada columna
            VerLibros.VerLibros plantilla = new VerLibros.VerLibros();
            plantilla.SetBotonesVisibles(false);
            plantilla.Dock = DockStyle.Fill;


            tlpLibros.RowCount++;
            tlpLibros.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpLibros.Controls.Add(plantilla, 0, nuevaFila);
            nuevaFila++;

            ///Filas delos libros, con su informacion y botones de editar y eliminar
            foreach (DataRow fila in datos.Rows)
            {
                VerLibros.VerLibros libro = new VerLibros.VerLibros();

                libro.ID = Convert.ToInt32(fila["ID"]);
                libro.Titulo = fila.Field<string>("Titulo");
                libro.Escritor = fila.Field<string>("Escritor");
                libro.Edicion = Convert.ToInt32(fila["Ano_Edicion"]);

                object dispObj = fila["Disponible"];
                bool disponible = (dispObj is bool b) ? b : Convert.ToInt32(dispObj) == 1;
                libro.Disponible = disponible;

                libro.EditarLibro += Control_EditarLibro;
                libro.BorrarLibro += Control_BorrarLibro;

                libro.Dock = DockStyle.Fill;

                tlpLibros.RowCount++;
                tlpLibros.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                tlpLibros.Controls.Add(libro, 0, nuevaFila);
                nuevaFila++;
            }

            tlpLibros.ResumeLayout(true);
            tlpLibros.PerformLayout();
        }


        /// <summary>
        /// Abre el formulario EditarLibros para editar la información de un libro específico, pasando el ID del libro seleccionado y el controlador 
        /// para gestionar las operaciones de edición. Después de cerrar el formulario de edición, se recarga la lista de libros disponibles 
        /// para reflejar los cambios realizados.
        /// </summary>
        private void Control_EditarLibro(object sender, VerLibros.VerLibros.ClickarBotonIdEventArgs e)
        {

            Vista.EditarLibros editar = new Vista.EditarLibros();
            editar.id = e.Id;
            editar.ControladorModLibro = ControladorLibro;
            editar.ShowDialog();

            Cargar(ControladorLibro.CargarLibrosDisponibles());
        }

        /// <summary>
        /// Elimina un libro específico utilizando el ID del libro seleccionado, llamando al método EliminarLibro del controlador para eliminar el libro 
        /// de la base de datos.  Después de eliminar el libro, se recarga la lista de libros disponibles para reflejar los cambios realizados.
        /// </summary>
        private void Control_BorrarLibro(object sender, VerLibros.VerLibros.ClickarBotonIdEventArgs e)
        {
            ControladorLibro.EliminarLibro(e.Id);
            Cargar(ControladorLibro.CargarLibrosDisponibles());
        }

        /// <summary>
        /// Retorna la instancia única de FLibros, asegurando que solo se cree una instancia del formulario para gestionar los libros.
        /// </summary>
        /// <returns>La instancia de Flibros.</returns>
        public static FLibros GetInstance()
        {
            if (FormLibro == null)
            {
                FormLibro = new FLibros();
            }
            return FormLibro;
        }
    }
}
