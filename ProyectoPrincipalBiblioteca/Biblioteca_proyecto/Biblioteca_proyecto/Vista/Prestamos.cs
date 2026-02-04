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

        //LLama al metodo FPrestamos_Load al iniciar el formulario
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

            //Limia lo que habia antes en el TableLayoutPanel

            TlpPrestamos.Controls.Clear();

            int NuevaFila = 0;

            // Recorre las filas del DataTable y crea un UserControl1 por cada fila
            foreach (DataRow fila in datos.Rows)
            {
                UserControl1 prestamo = new UserControl1();

                prestamo.ID = Convert.ToInt32(fila["ID"]);
                prestamo.ISBN = Convert.ToInt32(fila["ID_Libro"]);
                prestamo.DNI = Convert.ToInt32(fila["ID_Usuario"]);
                prestamo.Prestamo = fila.Field<string>("Fecha_Inicio");
                prestamo.Devolucion = fila.Field<string>("Fecha_Fin");

                //Se añaden los eventos de borrar y editar a los Botones del UserControl1
                prestamo.BorrarPrestamo += Control_BorrarPrestamo;
                prestamo.EditarPrestamo += Control_EditarPrestamo;

                prestamo.Dock = DockStyle.Fill;
                TlpPrestamos.RowCount = TlpPrestamos.RowCount + 1;
                TlpPrestamos.RowStyles.Insert(NuevaFila, new RowStyle(SizeType.AutoSize));

                //Se añade el UserControl1 al TableLayoutPanel como una nueva fila
                TlpPrestamos.Controls.Add(prestamo, 0, NuevaFila);
                NuevaFila++;

            }
        }





        private void Control_EditarPrestamo(object sender, UserControl1.ClickarBotonIdEventArgs e)
        {

            //Creacion de Formulario EditarPrestamo
            EditarPrestamo editarPrestamo = new EditarPrestamo();
            //Se le pasa el id del prestamo seleccionado al formulario EditarPrestamo
            editarPrestamo.idPrestamo = e.Id;
            //Hay que poner en EditarUsuario el controlador nuevo que se genera en public para acceder a el
            //le pasa el controlador al formulario EditarPrestamo para que pueda usar sus metodos
            editarPrestamo.ControladorEditarPrestamo = ControladorPrestamos;
            //Se abre el formulario EditarPrestamo como un dialogo modal
            editarPrestamo.ShowDialog();
            //Despues de cerrar el formulario EditarPrestamo, se recarga la lista de prestamos
            Cargar(ControladorPrestamos.CargarPrestamos());
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
