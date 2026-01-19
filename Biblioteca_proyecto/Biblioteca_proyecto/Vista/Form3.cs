using System;
using Biblioteca_proyecto.Controlador;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Biblioteca_proyecto
{
/* public Controlador miControlador = new Controlador(); */
    public partial class FPrincipal : Form
    {
        public FPrincipal()
        {
            InitializeComponent();
        }


        private void InsertarFormulario(Form formulario)
        {
          
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Hide();
            }

            formulario.MdiParent = this;
            formulario.Dock = DockStyle.Fill;
            formulario.Show();
        }

   

       /* private void smiLibrosBuscar_Click(object sender, EventArgs e)
        {
            var form = FLibros.GetInstance();
            InsertarFormulario(form);
        }*/
    }
}
