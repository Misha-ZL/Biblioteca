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
    /// Representa el formulario para crear un nuevo prestamo en la biblioteca, asi como gestionar la interaccion con los usuarios y 
    /// libros disponibles, en la interfaz grafica.
    /// </summary>
    public partial class NuevoPrestamo : Form
    {
        /// <summary>
        /// Maneja la creacion de nuevos prestamos
        /// </summary>
        public Controlador.MiControlador ControladorReserva = new MiControlador();
        public NuevoPrestamo()
        {
            InitializeComponent();
            this.Load += NuevoPrestamo_Load;
          
        }

        /// <summary>
        /// Contiene una referencia a NuevoPrestamos para crear una nueva reserva
        /// </summary>
        private static NuevoPrestamo FormNuevaReserva;
        public static NuevoPrestamo GetInstance()
        {
            if (FormNuevaReserva == null || FormNuevaReserva.IsDisposed)
            {
                FormNuevaReserva = new NuevoPrestamo();
            }
            return FormNuevaReserva;
        }
        /// <summary>
        /// Carga y muestra los datos de los libros disponibles y los usuarios en los respectivos DataGridViews.
        /// </summary>
        public void CargarDatos()
        {
            
            DgvLibro.DataSource = null;
            DgvLibro.AutoGenerateColumns = true;
            DgvLibro.DataSource = ControladorReserva.CargarLibrosDisponibles();
            DgvLibro.Columns["Disponible"].Visible = true;
            DgvLibro.Columns["ID"].Visible = false;
            DgvLibro.Columns["Titulo"].Visible = true;
            DgvLibro.Columns["Escritor"].Visible = true;
            DgvLibro.Columns["Ano_Edicion"].Visible = true;
            DgvLibro.Columns["Sinopsis"].Visible = false;
          
            
            DgvUsuarios.DataSource = null;
            DgvUsuarios.AutoGenerateColumns = true;
            DgvUsuarios.DataSource = ControladorReserva.CargarUsuarios();
            DgvUsuarios.Columns["ID"].Visible = false;
            DgvUsuarios.Columns["Nombre"].Visible = true;
            DgvUsuarios.Columns["Apellido_1"].Visible = true;
            DgvUsuarios.Columns["Apellido_2"].Visible = true;
            DgvUsuarios.Columns["Telefono"].Visible = true;


        }

        private void RecargarLibrosYUsuarios()
        {
            //Borrar datos
            DgvLibro.DataSource = null;

            //se cargan los datos
            DgvLibro.DataSource = ControladorReserva.CargarLibrosDisponibles();   

            DgvUsuarios.DataSource = null;
            DgvUsuarios.DataSource = ControladorReserva.CargarUsuarios(); 
        }    
        
        
        
        /// <summary>
        /// Se encarga de cargar y visualizar los datos en el form.
        /// </summary>
        /// <param name="sender">Origen del evento.</param>
        /// <param name="e">Datos del evento.</param>
        private void NuevoPrestamo_Load(object sender, EventArgs e)
        {
            CargarDatos();
       
        }


        //Cuando se vuelve a activar la ventana  hace estos
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            RecargarLibrosYUsuarios();
        }


        /// <summary>
        /// Maneja el boton de agregar nueva reserva, creando un nuevo prestamo con los datos seleccionados 
        /// del libro y usuario, ademas de refrescar el form y mostrar un mensaje de confirmacion
        /// </summary>
        /// <param name="sender">Origen del evento.</param>
        /// <param name="e">Datos del evento.</param>
        private void BtnAddReserva_Click(object sender, EventArgs e)
        {

            try
            {
                ControladorReserva.NuevoPrestamo(
                       Convert.ToInt32(DgvLibro.CurrentRow.Cells["ID"].Value),
                       Convert.ToInt32(DgvUsuarios.CurrentRow.Cells["ID"].Value),
                       TbFin.Text,
                       TbIncio.Text
                       );
                MessageBox.Show("Reserva realizada con éxito.");

                LimpiarFormulario();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
            LimpiarFormulario();
        }
        /// <summary>
        /// Limpia los campos del formulario despues de agregar una nueva reserva, y deselecciona cualquier fila seleccionada en los DataGridViews.
        /// </summary>
        private void LimpiarFormulario()
        {
            TbIncio.Clear();
            TbFin.Clear();
            DgvLibro.ClearSelection();
            DgvUsuarios.ClearSelection();

        }
    }

}
