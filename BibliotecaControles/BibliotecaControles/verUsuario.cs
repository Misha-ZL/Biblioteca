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

        public string idUsuario
        {
            get => lblUserid.Text;
            set => lblUserid.Text = value;
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

        public string Email
        {
            get => lblEmail.Text;
            set => lblEmail.Text = value;
        }

        public event EventHandler<string> editarUsuario;

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editarUsuario?.Invoke(this, idUsuario);
        }

        public event EventHandler<string> eliminarUsuario;
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarUsuario?.Invoke(this, idUsuario);
        }
    }
}
