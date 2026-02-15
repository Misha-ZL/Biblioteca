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
    /// Representa un form para añadir informacion de libros a la biblioteca, permitiendo ingresar el título, escritor, año de edición, sinopsis y disponibilidad
    /// del libro a través de campos de texto y un checkbox.
    /// </summary>
    public partial class NuevoLibro : Form
    {
        /// <summary>
        /// El constructor de la clase NuevoLibro se encarga de inicializar los componentes del formulario, 
        /// configurando los campos necesarios para ingresar la información de un nuevo libro en la biblioteca.
        /// </summary>
        public NuevoLibro()
        {
            InitializeComponent();
        }
        public Controlador.MiControlador ControladorLibro = new Controlador.MiControlador();


        /// <summary>
        /// Crea una instancia estática de NuevoLibro llamada FormNuevoLibro, que se utiliza para 
        /// implementar la nueva instancia asegurandose de que solo se crea una instancia del formualrio.
        /// </summary>
        private static NuevoLibro FormNuevoLibro;


        /// <summary>
        /// Provee una nueva instancia para el formulario de NuevoLibro
        /// </summary>
        /// <returns> La instancia de NuevoLibro.</returns>
        public static NuevoLibro GetInstance()
        {
            if (FormNuevoLibro == null || FormNuevoLibro.IsDisposed)
            {
                FormNuevoLibro = new NuevoLibro();
            }
            return FormNuevoLibro;
        }

        /// <summary>
        /// Añade un nuevo libro a la biblioteca utilizando los datos ingresados en los campos de texto y el checkbox de disponibilidad.
        /// El método intenta convertir el año de edición ingresado a un número entero y, si la conversión es exitosa, llama al método NuevoLibro del 
        /// controlador para agregar el libro a la base de datos.  Si la conversión falla, se muestra un mensaje de error indicando que
        ///  el año de edición debe ser un número entero. Después de agregar el libro, se limpia el formulario para permitir ingresar otro libro si es necesario.
        /// </summary>
        private void BtnAddUsuario_Click(object sender, EventArgs e)
        {
            try
            {
               
                bool ok = int.TryParse(TbAnoEdicion.Text, out int TelefonoInt);
                

                if (!ok)
                {
                    throw new Exception("No tiene que ser la fecha exacta solo el Año (ej.2001).");
                } else
                {
                    ControladorLibro.NuevoLibro(TbTitulo.Text, TbEscritor.Text, TelefonoInt, TbSinopsis.Text, ChkDisponible.Checked);
                    MessageBox.Show("Nuevo libro agregado con éxito.");
                } 
               
                LimpiarFormularioLibro();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// Limpia los campos del formulario de NuevoLibro, estableciendo los campos de texto a cadenas vacías y el checkbox de disponibilidad a falso.
        /// </summary>
        private void LimpiarFormularioLibro()
        {
            TbTitulo.Text = "";
            TbEscritor.Text = "";
            TbAnoEdicion.Text = "";
            TbSinopsis.Text = "";
            ChkDisponible.Checked = false;
        }
    }
}
