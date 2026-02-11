using Biblioteca_proyecto.Controlador;
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
            this.WindowState = FormWindowState.Maximized;
            this.Activated += FLibros_Load;
        }

        private static FLibros FormLibro;


        MiControlador ControladorLibro = new MiControlador();

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            Cargar(ControladorLibro.CargarLibrosDisponibles());
        }

        private void FLibros_Load(object sender, EventArgs e)
        {
            Cargar(ControladorLibro.CargarLibrosDisponibles());
        }
        public void Cargar(DataTable datos)
        {
            tlpLibros.SuspendLayout();

            tlpLibros.Controls.Clear();
            tlpLibros.RowStyles.Clear();
            tlpLibros.RowCount = 0;

            int nuevaFila = 0;

            // Header
            VerLibros.VerLibros plantilla = new VerLibros.VerLibros();
            plantilla.SetBotonesVisibles(false);
            plantilla.Dock = DockStyle.Fill;


            tlpLibros.RowCount++;
            tlpLibros.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpLibros.Controls.Add(plantilla, 0, nuevaFila);
            nuevaFila++;

            // Filas reales
            foreach (DataRow fila in datos.Rows)
            {
                VerLibros.VerLibros libro = new VerLibros.VerLibros();

                libro.ID = Convert.ToInt32(fila["ID"]);
                libro.Titulo = fila.Field<string>("Titulo");
                libro.Escritor = fila.Field<string>("Escritor");
                libro.Edicion = Convert.ToInt32(fila["Ano_Edicion"]);

                object dispObj = fila["Disponible"];
                bool disponible = (dispObj is bool b) ? b : Convert.ToInt32(dispObj) == 1;
                libro.Disponible = disponible;

                libro.EditarLibro += Control_EditarLibro;
                libro.BorrarLibro += Control_BorrarLibro;

                libro.Dock = DockStyle.Fill;

                tlpLibros.RowCount++;
                tlpLibros.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                tlpLibros.Controls.Add(libro, 0, nuevaFila);
                nuevaFila++;
            }

            tlpLibros.ResumeLayout(true);
            tlpLibros.PerformLayout();
        }


        private void Control_EditarLibro(object sender, VerLibros.VerLibros.ClickarBotonIdEventArgs e)
        {

            Vista.EditarLibros editar = new Vista.EditarLibros();
            editar.id = e.Id;
            editar.ControladorModLibro = ControladorLibro;
            editar.ShowDialog();

            Cargar(ControladorLibro.CargarLibrosDisponibles());
        }

        private void Control_BorrarLibro(object sender, VerLibros.VerLibros.ClickarBotonIdEventArgs e)
        {
            ControladorLibro.EliminarLibro(e.Id);
            Cargar(ControladorLibro.CargarLibrosDisponibles());
        }


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
