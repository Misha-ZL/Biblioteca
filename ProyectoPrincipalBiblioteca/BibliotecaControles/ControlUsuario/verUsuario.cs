using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaControles
{
    public partial class verUsuario : UserControl
    {
        public verUsuario()
        {
            InitializeComponent();
        }

        public override Size MinimumSize {
            get => base.MinimumSize;
            set => base.MinimumSize = new Size(1060, 40);
        }

        public int idUsuario
        {
            //get devuelve el valor en id
            get => id;
            set
            {   //set cuando alguien cambia el valor de id  actualiza la etiqueta lblUserid para que muestre el nuevo valor
                id = value;
                lblUserid.Text = id.ToString();
            }
        }


        public string Apellido1
        {
            get => lblApell1.Text;
            set => lblApell1.Text = value;
        }

        public string Apellido2
        {
            get => lblApell2.Text;
            set => lblApell2.Text = value;
        }

        public string Nombre
        {
            get => lblNombre.Text;
            set => lblNombre.Text = value;
        }

        public int Telefono
        {
            get => tel;
            set
            {
                tel = value;
                lblTelefono.Text = tel.ToString();
            }

        }

        private int id;
        private int tel;



        public event EventHandler<ClickarBotonIdEventArgs> BorrarUsuario;

        public event EventHandler<ClickarBotonIdEventArgs> EditarUsuario;

        private void btnEditar_Click(object sender, EventArgs e)
        // Dispara el evento EditarUsuario enviando como sender este UserControl
        // y pasando el ID del usuario (id) dentro de ClickarBotonIdEventArgs para que el formulario sepa qué editar.
        {
            EditarUsuario?.Invoke(this, new ClickarBotonIdEventArgs(id));
        }

        private void btnEliminar_Click(object sender, EventArgs e) { 
        DialogResult resultado = MessageBox.Show(
               "¿Estás seguro?",
               "Eliminar",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
            
                // Dispara el evento BorrarPrestamo enviando como sender este UserControl
                // y pasando el ID del préstamo (prestamoID) dentro de ClickarBotonIdEventArgs para que el formulario sepa qué borrar.
            BorrarUsuario?.Invoke(this, new ClickarBotonIdEventArgs(id));
            }else{

                // lleavar a inicio si se hace IDK

            }

        }

        public class ClickarBotonIdEventArgs : EventArgs
        {
            // Propiedad para obtener el ID asociado al evento
            public int Id { get; }

            //al clcikar el boton se crea una instancia de ClickarBotonIdEventArgs pasando el id del usuario
            public ClickarBotonIdEventArgs(int id)
            {
                Id = id;
            }
        }
    }
}
