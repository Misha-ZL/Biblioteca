using Biblioteca_proyecto.Controlador;
using Biblioteca_proyecto.Modelo;

using ControlPrestamo2;
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
    /// Clase que representa el formulario de gestión de préstamos en la biblioteca. Este formulario permite visualizar, editar y eliminar los préstamos registrados en el sistema.
    /// </summary>
    public partial class Prestamos : Form
    {

        /// <summary>
        /// Llama al método InitializeComponent para configurar los componentes del formulario.
        /// </summary>
        public Prestamos()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Load += FPrestamos_Load;
        }



        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            Cargar(ControladorPrestamos.CargarPrestamos());
        }
        /// <summary>
        /// Está instancia de MiControlador se utiliza para gestionar las operaciones relacionadas con los préstamos, como cargar la lista de préstamos.
        /// </summary>
        MiControlador ControladorPrestamos = new MiControlador();

        /// <summary>
        /// Cuando se carga el formulario, se llama al método Cargar para obtener la lista de préstamos desde el controlador y mostrarla en el formulario.
        /// </summary>
        private void FPrestamos_Load(object sender, EventArgs e)
        {
            Cargar(ControladorPrestamos.CargarPrestamos());
        }

        /// <summary>
        /// Carga la lista de préstamos en el formulario. Este método recibe un DataTable con los datos de los préstamos y
        /// crea un UserControl1 para cada préstamo, que se añade al TableLayoutPanel del formulario. 
        /// Además, se asignan los eventos de borrar y editar a los botones de cada UserControl1 para permitir la gestión de los préstamos desde el formulario.
        /// </summary>
        /// <param name="datos">Son los datos que cargamos</param>
        public void Cargar(DataTable datos)
        {

            ///Limpia el TableLayoutPanel antes de cargar los nuevos datos para evitar duplicados

            TlpPrestamos.Controls.Clear();

            int NuevaFila = 0;

            UserControl1 plantilla = new UserControl1();

            plantilla.SetBotonesVisibles(false);

            //CAMBIO DE FUENTE PARA LOS LABELS DE LA PRIMERA FILA DE LA TABLA, PARA QUE SEAN MÁS GRANDES Y EN NEGRITA, DISTINGUIÉNDOSE ASÍ DE LOS DEMÁS PRÉSTAMOS.

            foreach (Control c in plantilla.Controls)
            {
                c.Font = new Font(this.Font.FontFamily, 12f, FontStyle.Bold | FontStyle.Underline);

            }


            plantilla.Dock = DockStyle.Fill;


           



           
            TlpPrestamos.RowCount = TlpPrestamos.RowCount + 1;
            TlpPrestamos.RowStyles.Insert(NuevaFila, new RowStyle(SizeType.AutoSize));

            ///Se añade el UserControl1 al TableLayoutPanel del formulario en la fila correspondiente.
            TlpPrestamos.Controls.Add(plantilla, 0, NuevaFila);
            NuevaFila++;


            ///Recorre cada fila del DataTable y crea un UserControl1 para cada préstamo, asignando los datos correspondientes a las propiedades del UserControl1.




            foreach (DataRow fila in datos.Rows)
            {
                UserControl1 prestamo = new UserControl1();

                prestamo.BackColor = Color.White;

                prestamo.ID = Convert.ToInt32(fila["ID_Prestamo"]);
                prestamo.ISBN = fila.Field<string>("Titulo_Libro");
                prestamo.DNI = fila.Field<string>("Nombre_Usuario");
                prestamo.Prestamo = fila.Field<string>("Fecha_Inicio");
                prestamo.Devolucion = fila.Field<string>("Fecha_Fin");

                ///Se añaden los eventos de borrar y editar a los botones de cada UserControl1 para permitir la gestión de los préstamos desde el formulario.
                prestamo.BorrarPrestamo += Control_BorrarPrestamo;
                prestamo.EditarPrestamo += Control_EditarPrestamo;

                prestamo.Dock = DockStyle.Fill;
                TlpPrestamos.RowCount = TlpPrestamos.RowCount + 1;
                TlpPrestamos.RowStyles.Insert(NuevaFila, new RowStyle(SizeType.AutoSize));

                ///Se añade el UserControl1 al TableLayoutPanel del formulario en la fila correspondiente.
                TlpPrestamos.Controls.Add(prestamo, 0, NuevaFila);
                NuevaFila++;

            }
        }


       



        /// <summary>
        /// Este método se ejecuta cuando se hace clic en el botón de editar de un préstamo en el UserControl1. 
        /// Recibe el ID del préstamo seleccionado a través de los argumentos del evento.
        /// </summary>
        private void Control_EditarPrestamo(object sender, UserControl1.ClickarBotonIdEventArgs e)
        {

            ///Se crea una instancia del formulario EditarPrestamo para editar el préstamo seleccionado.
            EditarPrestamo editarPrestamo = new EditarPrestamo();
            ///Se asigna el ID del préstamo seleccionado a la propiedad idPrestamo del formulario EditarPrestamo para que pueda cargar los datos correspondientes al préstamo que se desea editar.
            editarPrestamo.idPrestamo = e.Id;
            ///Se asigna el controlador de préstamos al formulario EditarPrestamo para que pueda acceder a los métodos necesarios para cargar y actualizar los datos del préstamo.
            editarPrestamo.ControladorEditarPrestamo = ControladorPrestamos;
            ///Abre el formulario EditarPrestamo para que el usuario pueda editar los detalles del préstamo seleccionado.
            editarPrestamo.ShowDialog();

            
            ///Después de cerrar el formulario EditarPrestamo, se llama al método Cargar para actualizar la lista de préstamos en el formulario principal con los cambios realizados.
            Cargar(ControladorPrestamos.CargarPrestamos());
        }


        /// <summary>
        /// Este método se ejecuta cuando se hace clic en el botón de eliminar de un préstamo en el UserControl1.
        /// </summary>
        private void Control_BorrarPrestamo(object sender, UserControl1.ClickarBotonIdEventArgs e)
        {
            ControladorPrestamos.EliminarPrestamo(e.Id);
            Cargar(ControladorPrestamos.CargarPrestamos());
        }


        /// <summary>
        /// Formulario para asegurar que solo exista una instancia del formulario de préstamos en la aplicación.
        /// </summary>
        private static Prestamos formularioPrestamos;

        /// <summary>
        /// Devuelve la instancia única del formulario de préstamos. Si no existe una instancia, se crea una nueva. 
        /// Si ya existe, se devuelve la instancia existente. Esto garantiza que solo haya un formulario de préstamos abierto en la aplicación en cualquier momento.
        /// </summary>
        /// <returns>El formulario</returns>
        public static Prestamos GetInstance()
        {
            if (formularioPrestamos == null)
            {
                formularioPrestamos = new Prestamos();
            }
            return formularioPrestamos;

        }
    } 
}
