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
            get => id;
            set
            {
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
        
            BorrarUsuario?.Invoke(this, new ClickarBotonIdEventArgs(id));
            }else{

                // lleavar a inicio si se hace IDK

            }

        }

        public class ClickarBotonIdEventArgs : EventArgs
        {
            public int Id { get; }

            public ClickarBotonIdEventArgs(int id)
            {
                Id = id;
            }
        }
    }
}
