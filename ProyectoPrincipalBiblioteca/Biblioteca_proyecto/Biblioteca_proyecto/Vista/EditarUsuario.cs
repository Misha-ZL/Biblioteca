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
using Biblioteca_proyecto.Modelo;

namespace Biblioteca_proyecto.Vista
{
    /// <summary>
    /// La clase EditarUsuario representa un formulario que permite editar la información de un usuario existente en el sistema.
    /// </summary>
    public partial class EditarUsuario : Form
    {
        /// <summary>
        /// La variable ControladorModUsuario es una instancia de MiControlador que se utiliza para gestionar las operaciones relacionadas con la modificación de usuarios.
        /// lo he tenido que poner public para acceder desde Usuarios.cs 
        /// </summary>
        public MiControlador ControladorModUsuario = new MiControlador();

        /// <summary>
        /// El constructor de la clase EditarUsuario se encarga de inicializar los componentes del formulario y asignar el evento Load para cargar la información del usuario que se va a editar.
        /// </summary>
        public EditarUsuario()
        {
            InitializeComponent();
            this.Load += EditarUsuario_Load;
        }

        public int id;

        /// <summary>
        /// La función EditarUsuario_Load se ejecuta cuando se carga el formulario EditarUsuario. Esta función se encarga de cargar la información del usuario que se va a editar en los campos correspondientes
        /// del formulario, utilizando el ID del usuario para obtener los datos de la base de datos a través del controlador ControladorModUsuario.
        /// </summary>
        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            
            DataTable data = ControladorModUsuario.BuscarUsuarioPorID(id);
            if (data.Rows.Count == 0)
            {
                MessageBox.Show("No se encontró el libro con ID: " + id);
                this.Close();
                return;
            }

            ///Se carga la informacion del usuario en los textbox correspondientes
            
            TbNombre.Text = data.Rows[0]["Nombre"].ToString();
            TbAppellido1.Text = data.Rows[0]["Apellido_1"].ToString();
            TbApellido2.Text = data.Rows[0]["Apellido_2"].ToString();
            TbTelefono.Text = data.Rows[0]["Telefono"].ToString();


        }

        /// <summary>
        /// A continuación, se muestra el método BtnEditarUsuario_Click, que se ejecuta cuando se hace clic en el botón de editar usuario.
        /// Este método intenta modificar la información del usuario utilizando los datos ingresados en los campos del formulario y el ID del usuario.
        /// </summary>
        private void BtnEditarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
              
                ControladorModUsuario.ModificarUsuario(id, TbNombre.Text, TbAppellido1.Text, TbApellido2.Text, Convert.ToInt32(TbTelefono.Text));
                MessageBox.Show("Editando ID: " + id);
                

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    
    
    }
