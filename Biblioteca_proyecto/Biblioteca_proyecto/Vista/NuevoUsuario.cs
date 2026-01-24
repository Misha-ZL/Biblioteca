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
    public partial class FNuevoUsuario : Form
    {
        public FNuevoUsuario()
        {
            InitializeComponent();
        }


        private static FNuevoUsuario FormNuevoUsuario;

        public static FNuevoUsuario GetInstance()
        {
            if (FormNuevoUsuario == null)
            {
                FormNuevoUsuario = new FNuevoUsuario();
            }
            return FormNuevoUsuario;
        }
    }
}
