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
    public partial class FLibros : Form
    {
        public FLibros()
        {
            InitializeComponent();
        }

        private static FLibros FormLibro;

        public static FLibros GetInstance()
        {
            if (FormLibro == null)
            {
                FormLibro = new FLibros();
            }
            return FormLibro;
        }
    }
}
