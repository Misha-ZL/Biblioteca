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
using BibliotecaControles;
using static BibliotecaControles.verUsuario;

namespace Biblioteca_proyecto
{
    public partial class FUsuarios : Form
    {
        /// <summary>
        /// El constructor de la clase FUsuarios llama al método InitializeComponent
        /// para configurar los componentes del formulario, establece el estado de la ventana a maximizado y 
        /// asigna el evento Activated para cargar los usuarios cuando se active el formulario.
        /// </summary>
        public FUsuarios()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Activated += FUsuarios_Load;
        }

        /// <summary>
        /// El controlador ControladorUsuario es una instancia de MiControlador que se utiliza para gestionar las operaciones relacionadas con los usuarios, 
        /// como cargar, editar y eliminar usuarios en la base de datos.
        /// </summary>
        MiControlador ControladorUsuario = new MiControlador();

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);

            Cargar(ControladorUsuario.CargarUsuarios());
        }

        /// <summary>
        /// Cuando se carga el formulario FUsuarios, se llama al método Cargar para cargar y mostrar los datos de los usuarios en el TableLayoutPanel tlpUsuarios.
        /// </summary>
        private void FUsuarios_Load(object sender, EventArgs e)
        {
            
            Cargar(ControladorUsuario.CargarUsuarios());

        }
        /// <summary>
        /// A continuación, se muestra el método Cargar, que recibe un DataTable con los datos de los usuarios y los muestra en el TableLayoutPanel tlpUsuarios.
        /// </summary>
        /// <param name="datos">Los datos solicitados</param>
        public void Cargar(DataTable datos) {






            ///Limpia el TableLayoutPanel antes de cargar los nuevos datos para evitar duplicados
            tlpUsuarios.Controls.Clear();

            int NuevaFila = 0;



            verUsuario plantilla = new verUsuario();
            plantilla.SetBotonesVisibles(false);

            plantilla.Dock = DockStyle.Fill;
            tlpUsuarios.RowCount = tlpUsuarios.RowCount + 1;
            tlpUsuarios.RowStyles.Insert(NuevaFila, new RowStyle(SizeType.AutoSize));

            ///Se añade el UserControl1 al TableLayoutPanel del formulario en la fila correspondiente.
            tlpUsuarios.Controls.Add(plantilla, 0, NuevaFila);
            NuevaFila++;


            ///Recorre cada fila del DataTable y crea un UserControl1 para cada usuario, asignando los datos correspondientes a las propiedades del UserControl1.
            foreach (DataRow fila in datos.Rows)
            {
                verUsuario usuario= new verUsuario();

                usuario.idUsuario = Convert.ToInt32(fila["ID"]);
                usuario.Nombre = fila.Field<string>("Nombre");
                usuario.Apellido1 = fila.Field<string>("Apellido_1");
                usuario.Apellido2 = fila.Field<string>("Apellido_2");
                usuario.Telefono = Convert.ToInt32(fila["Telefono"]);

                ///Asigna los eventos EditarUsuario y BorrarUsuario del UserControl1 a los métodos Control_EditarUsuario y Control_borrarEmpleado respectivamente, 
                ///para manejar las acciones de editar y eliminar usuarios.
                usuario.EditarUsuario += Control_EditarUsuario;
                usuario.BorrarUsuario += Control_borrarEmpleado;

                usuario.Dock = DockStyle.Fill;
                tlpUsuarios.RowCount = tlpUsuarios.RowCount + 1;
                tlpUsuarios.RowStyles.Insert(NuevaFila, new RowStyle(SizeType.AutoSize));
                ///Se añade el UserControl1 al TableLayoutPanel del formulario en la fila correspondiente.
                tlpUsuarios.Controls.Add(usuario, 0, NuevaFila);
                NuevaFila++;


            }
        

        }
        /// <summary>
        /// El método Control_EditarUsuario se encarga de manejar el evento EditarUsuario del UserControl1. Cuando se hace clic en el botón de editar,
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Control_EditarUsuario(object sender, verUsuario.ClickarBotonIdEventArgs e)
        {
            ///creacion del formulario EditarUsuario
            Vista.EditarUsuario editarUsuarioForm = new Vista.EditarUsuario();
            ///le pasamos el id del usuario que queremos editar al formulario EditarUsuario
            editarUsuarioForm.id = e.Id;
            ///Hay que poner en EditarUsuario el controlador nuevo que se genera en public para acceder a el
            ///le pasamos el controlador al formulario de editar usuario para que pueda usar sus metodos
            editarUsuarioForm.ControladorModUsuario = ControladorUsuario;
            ///mostramos el formulario de editar usuario
            editarUsuarioForm.ShowDialog();
            ///Despues de cerrar el formulario de editar usuario recargamos la lista de usuarios
            Cargar(ControladorUsuario.CargarUsuarios());

        }


        /// <summary>
        /// Control_borrarEmpleado se encarga de manejar el evento BorrarUsuario del UserControl1. Cuando se hace clic en el botón de eliminar,
        /// </summary>
        private void Control_borrarEmpleado(object sender, ClickarBotonIdEventArgs e)
        {
            ControladorUsuario.EliminarUsuario(e.Id);
            Cargar(ControladorUsuario.CargarUsuarios());
        }



        /// <summary>
        /// Este método se ejecuta cuando se hace clic en el botón "Agregar Usuario". Abre el formulario FNuevoUsuario para agregar un nuevo usuario a la biblioteca.
        /// </summary>
        private static FUsuarios formularioUsuario;

        /// <summary>
        /// El método GetInstance se implementa para asegurar que solo exista una instancia del formulario FUsuarios en la aplicación. 
        /// Si no existe una instancia, se crea una nueva; de lo contrario, se devuelve la instancia existente.
        /// </summary>
        /// <returns>El form de Usuarios</returns>
        public static FUsuarios GetInstance()
        {
            if (formularioUsuario == null)
            {
                formularioUsuario = new FUsuarios();
            }
            return formularioUsuario;

        }


      

    }
}
