using System;
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
    public partial class FUsuarios : Form
    {
        public FUsuarios()
        {
            InitializeComponent();
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
