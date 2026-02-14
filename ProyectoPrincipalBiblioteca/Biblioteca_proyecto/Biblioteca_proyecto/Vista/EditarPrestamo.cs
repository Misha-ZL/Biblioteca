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
    /// Esta clase representa un formulario que permite editar los detalles de un préstamo existente en la biblioteca. 
    /// permitiendo modificar el ibro o usuarios asociados en un prestamo asi como las fechas de inicio y fin.
    /// eEl formulario se carga con los datos actuales del préstamo seleccionado.
    /// </summary>
    public partial class EditarPrestamo : Form
    {
        /// <summary>
        /// formulario para editar un préstamo existente. Permite modificar el libro, usuario, fecha de inicio y fecha de fin del préstamo seleccionado.
        /// </summary>

        public Controlador.MiControlador ControladorEditarPrestamo = new MiControlador();

        public int idPrestamo;
        private int IdLibro;
        private int IdUsuario;


        /// <summary>
        /// Cuando se crea una instancia de EditarPrestamo, se inicializan los componentes del formulario y se asigna el evento Load 
        /// para cargar los datos del préstamo actual y configurar los eventos de selección en los DataGridView correspondientes a libros y usuarios.
        /// </summary>
        public EditarPrestamo()
        {
            InitializeComponent();
            this.Load += EditarPrestamo_Load;
           

           
        }




        /// <summary>
        /// CargarDatos() se encarga de cargar los datos de los libros disponibles y los usuarios en los DataGridView correspondientes.
        /// </summary>
        public void CargarDatos()
        {
            DgvLibros.AutoGenerateColumns = true;
            DgvLibros.DataSource = ControladorEditarPrestamo.CargarLibros();


            DgvLibros.Columns["Disponible"].Visible = true;
            DgvLibros.Columns["ID"].Visible = false;
            DgvLibros.Columns["Titulo"].Visible = true;
            DgvLibros.Columns["Escritor"].Visible = true;
            DgvLibros.Columns["Ano_Edicion"].Visible = true;
            DgvLibros.Columns["Sinopsis"].Visible = false;

            DgvUsuarios.AutoGenerateColumns = true;
            DgvUsuarios.DataSource = ControladorEditarPrestamo.CargarUsuarios();


            DgvUsuarios.Columns["ID"].Visible = false;
            DgvUsuarios.Columns["Nombre"].Visible = true;
            DgvUsuarios.Columns["Apellido_1"].Visible = true;
            DgvUsuarios.Columns["Apellido_2"].Visible = true;
            DgvUsuarios.Columns["Telefono"].Visible = true;

           


        }

        /// <summary>
        /// CargarPrestamoActual() se encarga de cargar los detalles del préstamo actual en los controles de texto correspondientes a las fechas de inicio y fin,
        /// </summary>
        public void CargarPrestamoActual()
        {

            DataTable data = ControladorEditarPrestamo.BuscarPrestamoPorID(idPrestamo);

            ///Se guardan el ID del libro y usuario asociados al préstamo actual en las variables IdLibro e IdUsuario respectivamente,
            ///y se muestran las fechas de inicio y fin en los controles de texto correspondientes.
            IdLibro = Convert.ToInt32(data.Rows[0]["ID_Libro"]);
            IdUsuario = Convert.ToInt32(data.Rows[0]["ID_Usuario"]);
            TbIncio.Text = data.Rows[0]["Fecha_Inicio"].ToString();
            TbFin.Text = data.Rows[0]["Fecha_Fin"].ToString();


            ///Se recorre cada fila del DataGridView de libros y usuarios para seleccionar la fila que corresponde al libro y
            ///usuario asociados al préstamo actual, utilizando los ID almacenados en las variables IdLibro e IdUsuario.
            foreach (DataGridViewRow row in DgvLibros.Rows)
            {
                if (Convert.ToInt32(row.Cells["ID"].Value) == IdLibro)
                {
                    DgvLibros.ClearSelection();
                    DgvLibros.CurrentCell = row.Cells[1];
                    row.Selected = true;
                    DgvLibros.CurrentCell = row.Cells["Titulo"];
                    break;
                }
            }

            
            foreach (DataGridViewRow fila in DgvUsuarios.Rows)
            {
                if (Convert.ToInt32(fila.Cells["ID"].Value) == IdUsuario)
                {
                    DgvUsuarios.ClearSelection();
                    DgvUsuarios.CurrentCell = fila.Cells[1];
                    fila.Selected = true;
                    DgvUsuarios.CurrentCell = fila.Cells["Nombre"];
                    break;

                }
            }

        }



        /// <summary>
        /// Cuando se carga el formulario, se llama a los métodos CargarDatos(), que carga los datos de  los libros y usuarios en los DataGridView correspondientes.
        /// y CargarPrestamoActual(), que carga los detalles del préstamo actual en los controles de texto y selecciona el libro y usuario correspondientes en los DataGridView.
        /// para mostrar la información del préstamo actual en los controles correspondientes.

        private void EditarPrestamo_Load(object sender, EventArgs e)
        {
            
            
            CargarDatos();
            CargarPrestamoActual();

            DgvLibros.SelectionChanged += DgvLibros_SelectionChanged;
            DgvUsuarios.SelectionChanged += DgvUsuarios_SelectionChanged;

        }

        private void RecargarLibrosYUsuarios()
        {
            //Borrar datos
            DgvLibros.DataSource = null;

            //se cargan los datos
            DgvLibros.DataSource = ControladorEditarPrestamo.CargarLibrosDisponibles();

            DgvUsuarios.DataSource = null;
            DgvUsuarios.DataSource = ControladorEditarPrestamo.CargarUsuarios();
        }

        //Cuando se vuelve a activar la ventana  hace estos
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            RecargarLibrosYUsuarios();
        }

        /// <summary>
        /// En el evento BtnAddReserva_Click, se verifica que las fechas de inicio y fin no estén vacías. Si están vacías, se lanza una excepción con un mensaje de error.
        /// </summary>
        private void BtnAddReserva_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (TbIncio.Text == "" || TbFin.Text == "")
                {
                    throw new Exception("Debes introducir las fechas de prestamo y devolucion.");
                } else
                {
                    ControladorEditarPrestamo.ModificarPrestamo(idPrestamo, IdLibro, IdUsuario, TbIncio.Text, TbFin.Text);

                    MessageBox.Show("Prestamo editado correctamente.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


        /// <summary>
        /// Al haber una fila seleccionada recoge el ID de esa fila y lo guarda en la variable IdLibro.
        /// </summary>
         private void DgvLibros_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvLibros.CurrentRow == null)
            {
                return;
            }


            IdLibro = Convert.ToInt32(DgvLibros.CurrentRow.Cells["ID"].Value);


        }


        /// <summary>
        /// Al haber una fila seleccionada recoge el ID de esa fila y lo guarda en la variable IdUsuario.
        /// </summary>>


        private void DgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvUsuarios.CurrentRow == null)
            {
                return;
            }


            IdUsuario = Convert.ToInt32(DgvUsuarios.CurrentRow.Cells["ID"].Value);

        }
    }
}
