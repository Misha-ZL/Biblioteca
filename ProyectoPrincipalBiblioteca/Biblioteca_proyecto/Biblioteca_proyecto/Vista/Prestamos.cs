using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca_proyecto.Controlador;
using BibliotecaControles;
using ControlPrestamo2;

namespace Biblioteca_proyecto.Vista
{
    public partial class Prestamos : Form
    {
        public Prestamos()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Load += FPrestamos_Load;
        }

        MiControlador ControladorPrestamos = new MiControlador();

        private void FPrestamos_Load(object sender, EventArgs e)
        {
            Cargar(ControladorPrestamos.CargarPrestamos());
        }

        public void Cargar(DataTable datos)
        {

            TlpPrestamos.Controls.Clear();

            int NuevaFila = 0;  

            foreach (DataRow fila in datos.Rows)
            {
                UserControl1 prestamo = new UserControl1();

                prestamo.ID = Convert.ToInt32(fila["ID"]);
                prestamo.ISBN = Convert.ToInt32(fila["ID_Libro"]);
                prestamo.DNI = Convert.ToInt32(fila["ID_Usuario"]);
                prestamo.Prestamo = fila.Field<string>("Fecha_Inicio");
                prestamo.Devolucion = fila.Field<string>("Fecha_Fin");
                prestamo.BorrarPrestamo += Control_BorrarPrestamo;

                prestamo.Dock = DockStyle.Fill;
                TlpPrestamos.RowCount = TlpPrestamos.RowCount + 1;
                TlpPrestamos.RowStyles.Insert(NuevaFila, new RowStyle(SizeType.AutoSize));
                TlpPrestamos.Controls.Add(prestamo, 0, NuevaFila);
                NuevaFila++;

            }
        }





        private void Control_EditarPrestamo(object sender, UserControl1.ClickarBotonIdEventArgs e)
        {
            /*
                        Vista.EditarUsuario editarUsuarioForm = new Vista.EditarUsuario();
                        editarUsuarioForm.id = e.Id;
                        //Hay que poner en EditarUsuario el controlador nuevo que se genera en public para acceder a el
                        editarUsuarioForm.ControladorModUsuario = UserControl1.ControladorUsuario;
                        editarUsuarioForm.ShowDialog();

                        Cargar(ControladorUsuario.CargarUsuarios());
            */
        }



        private void Control_BorrarPrestamo(object sender, UserControl1.ClickarBotonIdEventArgs e)
        {
            ControladorPrestamos.EliminarPrestamo(e.Id);
            Cargar(ControladorPrestamos.CargarPrestamos());
        } 
    
    

    private static Prestamos formularioPrestamos;

        public static Prestamos GetInstance()
        {
            if (formularioPrestamos == null)
            {
                formularioPrestamos = new Prestamos();
            }
            return formularioPrestamos;

        }
    } 
}
