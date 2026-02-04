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

namespace Biblioteca_proyecto.Vista
{
    public partial class EditarPrestamo : Form
    {

        public Controlador.MiControlador ControladorEditarPrestamo = new MiControlador();

        public int idPrestamo;
        private int IdLibro;
        private int IdUsuario;


        //Cuando se carga el formulario se ejecuta EditarPrestamo_Load
        public EditarPrestamo()
        {
            InitializeComponent();
            this.Load += EditarPrestamo_Load;

           
        }

        //Si hay fila seleccionada Coge el ID de esa fila y lo guarda en la variable IdLibro.
        private void DgvLibro_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvLibro.CurrentRow == null)
            {
                return;
            }
          

            IdLibro = Convert.ToInt32(DgvLibro.CurrentRow.Cells["ID"].Value);

        }


        //Si hay fila seleccionada Coge el ID de esa fila y lo guarda en la variable IdUsuario.
        private void DgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvUsuarios.CurrentRow == null)
            {
                return;
            }
            

            IdUsuario = Convert.ToInt32(DgvUsuarios.CurrentRow.Cells["ID"].Value);

        }
        

        public void CargarDatos()
        {
            DgvLibro.AutoGenerateColumns = true;
            DgvLibro.DataSource = ControladorEditarPrestamo.CargarLibrosDisponibles();
            DgvLibro.Columns["Disponible"].Visible = true;
            DgvLibro.Columns["ID"].Visible = false;
            DgvLibro.Columns["Titulo"].Visible = true;
            DgvLibro.Columns["Escritor"].Visible = true;
            DgvLibro.Columns["Ano_Edicion"].Visible = true;
            DgvLibro.Columns["Sinopsis"].Visible = false;

            DgvUsuarios.AutoGenerateColumns = true;
            DgvUsuarios.DataSource = ControladorEditarPrestamo.CargarUsuarios();
            DgvUsuarios.Columns["ID"].Visible = false;
            DgvUsuarios.Columns["Nombre"].Visible = true;
            DgvUsuarios.Columns["Apellido_1"].Visible = true;
            DgvUsuarios.Columns["Apellido_2"].Visible = true;
            DgvUsuarios.Columns["Telefono"].Visible = true;


        }

        public void CargarPrestamoActual()
        {

            DataTable data = ControladorEditarPrestamo.BuscarPrestamoPorID(idPrestamo);

            //Se guarda el ID de el libro y usuario del préstamo actual en variables privadas.
            IdLibro = Convert.ToInt32(data.Rows[0]["ID_Libro"]);
            IdUsuario = Convert.ToInt32(data.Rows[0]["ID_Usuario"]);
            TbIncio.Text = data.Rows[0]["Fecha_Inicio"].ToString();
            TbFin.Text = data.Rows[0]["Fecha_Fin"].ToString();

            //Recorre los DataGridView para seleccionar las filas correspondientes al libro y usuario del préstamo actual.
            foreach (DataGridViewRow row in DgvLibro.Rows)
            {
                if (Convert.ToInt32(row.Cells["ID"].Value) == IdLibro)
                {
                    row.Selected = true;
                    break;
                }
            }

            foreach (DataGridViewRow row in DgvUsuarios.Rows)
            {
                if (Convert.ToInt32(row.Cells["ID"].Value) == IdUsuario)
                {
                    row.Selected = true;
                    break;
                }
            }

        }



        //CargarDatos() carga los datos de  los libros y usuarios en los DataGridView correspondientes.
        // CargarPrestamoActual() carga los detalles del préstamo actual en los controles de texto y selecciona el libro y usuario correspondientes en los DataGridView.

        private void EditarPrestamo_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarPrestamoActual();

            DgvLibro.SelectionChanged += DgvLibro_SelectionChanged;
            DgvUsuarios.SelectionChanged += DgvUsuarios_SelectionChanged;

        }

        private void BtnAddReserva_Click(object sender, EventArgs e)
        {
            try
            {
               

                if (TbIncio.Text == "" || TbFin.Text == "")
                    throw new Exception("Debes introducir las fechas de prestamo y devolucion.");

                ControladorEditarPrestamo.ModificarPrestamo(idPrestamo, IdLibro, IdUsuario, TbIncio.Text, TbFin.Text);

                MessageBox.Show("Prestamo editado correctamente.");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
