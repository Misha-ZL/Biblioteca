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
    public partial class NuevoPrestamo : Form
    {

        public Controlador.MiControlador ControladorReserva = new MiControlador();
        public NuevoPrestamo()
        {
            InitializeComponent();
            this.Load += NuevoPrestamo_Load;
        }


        private static NuevoPrestamo FormNuevaReserva;
        public static NuevoPrestamo GetInstance()
        {
            if (FormNuevaReserva == null || FormNuevaReserva.IsDisposed)
            {
                FormNuevaReserva = new NuevoPrestamo();
            }
            return FormNuevaReserva;
        }

        public void CargarDatos()
        {
            DgvLibro.AutoGenerateColumns = true;
            DgvLibro.DataSource = ControladorReserva.CargarLibrosDisponibles();
            DgvLibro.Columns["Disponible"].Visible = true;
            DgvLibro.Columns["ID"].Visible = false;
            DgvLibro.Columns["Titulo"].Visible = true;
            DgvLibro.Columns["Escritor"].Visible = true;
            DgvLibro.Columns["Ano_Edicion"].Visible = true;
            DgvLibro.Columns["Sinopsis"].Visible = false;

            DgvUsuarios.AutoGenerateColumns = true;
            DgvUsuarios.DataSource = ControladorReserva.CargarUsuarios();
            DgvUsuarios.Columns["ID"].Visible = false;
            DgvUsuarios.Columns["Nombre"].Visible = true;
            DgvUsuarios.Columns["Apellido_1"].Visible = true;
            DgvUsuarios.Columns["Apellido_2"].Visible = true;
            DgvUsuarios.Columns["Telefono"].Visible = true;


        }

        private void NuevoPrestamo_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void BtnAddReserva_Click(object sender, EventArgs e)
        {

            try
            {
                ControladorReserva.NuevoPrestamo(
                       Convert.ToInt32(DgvLibro.CurrentRow.Cells["ID"].Value),
                       Convert.ToInt32(DgvUsuarios.CurrentRow.Cells["ID"].Value),
                       TbFin.Text,
                       TbIncio.Text
                       );
                MessageBox.Show("Reserva realizada con éxito.");

                LimpiarFormulario();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            LimpiarFormulario();
        }
    


    private void LimpiarFormulario()
        {
            TbIncio.Clear();
            TbFin.Clear();
            DgvLibro.ClearSelection();
            DgvUsuarios.ClearSelection();

        }
    }

}
