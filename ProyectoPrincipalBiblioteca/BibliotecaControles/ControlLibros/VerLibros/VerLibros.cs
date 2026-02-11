using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerLibros
{
    public partial class VerLibros: UserControl
    {
        public VerLibros()
        {
           
            InitializeComponent();
        }


        private int LibroID;
        private int AnoEdicion;
        public int ID
        {
            get => LibroID;
            set
            {
                LibroID = value;
                LAB_ID.Text = LibroID.ToString();
            }
        }

        public string Titulo
        {
            get => LAB_Titulo.Text;
            set => LAB_Titulo.Text = value;
        }

        public string Escritor
        {
            get => LAB_Escritor.Text;
            set => LAB_Escritor.Text = value;
        }

        public int Edicion
        {
            get => AnoEdicion;

            set
            {
                 AnoEdicion = value;
                 LAB_AnoEdicion.Text = AnoEdicion.ToString();
            }
        }

     
        public bool Disponible
        {
            get => Chk_Disponible.Checked;
            set => Chk_Disponible.Checked = value;
        }

        /// <summary>
        /// Para mostrar/ocultar botones como tú haces (por ejemplo si es modo solo lectura).
        /// </summary>
        public void SetBotonesVisibles(bool visibles)
        {
            btnEditar.Visible = visibles;
            btnEliminar.Visible = visibles;
            Chk_Disponible.Visible = visibles;
        }

       
        public event EventHandler<ClickarBotonIdEventArgs> BorrarLibro;
        public event EventHandler<ClickarBotonIdEventArgs> EditarLibro;

        
      
        public class ClickarBotonIdEventArgs : EventArgs
        {
            public int Id { get; }

            public ClickarBotonIdEventArgs(int id)
            {
                Id = id;
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de eliminar este libro?",
                "Eliminar",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
                BorrarLibro?.Invoke(this, new ClickarBotonIdEventArgs(ID));
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            EditarLibro?.Invoke(this, new ClickarBotonIdEventArgs(ID));

            
        }
    }
}
