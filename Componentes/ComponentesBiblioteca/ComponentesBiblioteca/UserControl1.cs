using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentesBiblioteca
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public override Size MinimumSize {
            get => base.MinimumSize; s
                et => base.MinimumSize = value;
        }
        public string ID
        {
            get => lblID.Text; 
            set => lblID.Text = value;
        }
        
        public string NombreApe
        {
            get => lblNombre.Text; 
            set => lblNombre.Text = value;
        }
 
       
       
        public string Telefono
        {
            get => lblTelefono.Text; 
            set => lblTelefono.Text = value;
        }
     
        public string Email
        {
            get => lblEmail.Text; 
            set => lblEmail.Text = value;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
