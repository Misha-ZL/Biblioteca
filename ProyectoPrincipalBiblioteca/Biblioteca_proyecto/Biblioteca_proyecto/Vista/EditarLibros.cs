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

namespace Biblioteca_proyecto.Vista
{
    public partial class EditarLibros : Form
    {

        public MiControlador ControladorModLibro = new MiControlador();

        public int id;


        public EditarLibros()
        {
            InitializeComponent();
            this.Load += EditarLibro_Load;
        }

        private void EditarLibro_Load(object sender, EventArgs e)
        {
            // Cargar info del libro
            DataTable data = ControladorModLibro.BuscarLibroPorID(id);

            if (data.Rows.Count == 0)
            {
                MessageBox.Show("No se encontró el libro con ID: " + id);
                this.Close();
                return;
            }

            TbTitulo.Text = data.Rows[0]["Titulo"].ToString();
            TbEscritor.Text = data.Rows[0]["Escritor"].ToString();
            TbAnoEdicion.Text = data.Rows[0]["Ano_Edicion"].ToString();
             TbSinopsis.Text = data.Rows[0]["Sinopsis"].ToString();

            // Disponible (puede venir bool o 0/1)
            object dispObj = data.Rows[0]["Disponible"];
            bool disponible = (dispObj is bool b) ? b : Convert.ToInt32(dispObj) == 1;
            ChkDisponible.Checked = disponible;
        }

        private void BtnEditarLibro_Click(object sender, EventArgs e)
        {
            try
            {
                int ano = Convert.ToInt32(TbAnoEdicion.Text);
                bool disponible = ChkDisponible.Checked;

                ControladorModLibro.ModificarLibro( id, TbTitulo.Text, TbEscritor.Text, ano,  TbSinopsis.Text, disponible
                );

                MessageBox.Show("Editado libro ID: " + id);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
