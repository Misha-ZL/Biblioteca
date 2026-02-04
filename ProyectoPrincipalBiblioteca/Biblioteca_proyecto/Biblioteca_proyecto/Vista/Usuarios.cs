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
        public FUsuarios()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Activated += FUsuarios_Load;
        }

    
        MiControlador ControladorUsuario= new MiControlador();


        private void FUsuarios_Load(object sender, EventArgs e)
        {
            
            Cargar(ControladorUsuario.CargarUsuarios());

        }

        public void Cargar(DataTable datos) {


            //Limia lo que habia antes en el TableLayoutPanel
            tlpUsuarios.Controls.Clear();

            int NuevaFila = 0;
            // Recorre las filas del DataTable y crea un verUsuarios por cada fila
            foreach (DataRow fila in datos.Rows)
            {
                verUsuario usuario= new verUsuario();

                usuario.idUsuario = Convert.ToInt32(fila["ID"]);
                usuario.Nombre = fila.Field<string>("Nombre");
                usuario.Apellido1 = fila.Field<string>("Apellido_1");
                usuario.Apellido2 = fila.Field<string>("Apellido_2");
                usuario.Telefono = Convert.ToInt32(fila["Telefono"]);

                //Se añaden los eventos de borrar y editar a los Botones de verUsuario
                usuario.EditarUsuario += Control_EditarUsuario;
                usuario.BorrarUsuario += Control_borrarEmpleado;

                usuario.Dock = DockStyle.Fill;
                tlpUsuarios.RowCount = tlpUsuarios.RowCount + 1;
                tlpUsuarios.RowStyles.Insert(NuevaFila, new RowStyle(SizeType.AutoSize));
                //se añade el usuario al TableLayoutPanel como una nueva fila
                tlpUsuarios.Controls.Add(usuario, 0, NuevaFila);
                NuevaFila++;


            }
        

        }
        private void Control_EditarUsuario(object sender, verUsuario.ClickarBotonIdEventArgs e)
        {
            //creacion del formulario EditarUsuario
            Vista.EditarUsuario editarUsuarioForm = new Vista.EditarUsuario();
            //le pasamos el id del usuario que queremos editar al formulario EditarUsuario
            editarUsuarioForm.id = e.Id;
            //Hay que poner en EditarUsuario el controlador nuevo que se genera en public para acceder a el
            //le pasamos el controlador al formulario de editar usuario para que pueda usar sus metodos
            editarUsuarioForm.ControladorModUsuario = ControladorUsuario;
            //mostramos el formulario de editar usuario
            editarUsuarioForm.ShowDialog();
            //Despues de cerrar el formulario de editar usuario recargamos la lista de usuarios
            Cargar(ControladorUsuario.CargarUsuarios());

        }

        

        private void Control_borrarEmpleado(object sender, ClickarBotonIdEventArgs e)
        {
            ControladorUsuario.EliminarUsuario(e.Id);
            Cargar(ControladorUsuario.CargarUsuarios());
        }




        private static FUsuarios formularioUsuario;

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
