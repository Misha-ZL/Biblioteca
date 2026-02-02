using Biblioteca_proyecto.Controlador;
using BibliotecaControles;
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
            this.WindowState = FormWindowState.Maximized;
        }

    
        MiControlador ControladorUsuario= new MiControlador();

       public void Cargar(DataTable datos) { 



            tlpUsuarios.Controls.Clear();

            int NuevaFila = 0;

            foreach (DataRow fila in datos.Rows)
            {
                verUsuario usuario1= new verUsuario();

                usuario1.idUsuario = fila.Field<string>("ID");
                usuario1.Nombre = fila.Field<string>("Nombre");
                usuario1.Apellido1 = fila.Field<string>("Apellido_1");
                usuario1.Apellido2 = fila.Field<string>("Apellido_2");
                usuario1.Telefono = fila.Field<string>("Telefono");
               

            }
        

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
