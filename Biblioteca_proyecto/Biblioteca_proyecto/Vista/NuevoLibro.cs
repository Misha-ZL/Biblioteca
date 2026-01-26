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
    public partial class NuevoLibro : Form
    {
        public NuevoLibro()
        {
            InitializeComponent();
        }
        public Controlador.MiControlador ControladorLibro = new Controlador.MiControlador();

        

        private static NuevoLibro FormNuevoLibro;



        public static NuevoLibro GetInstance()
        {
            if (FormNuevoLibro == null || FormNuevoLibro.IsDisposed)
            {
                FormNuevoLibro = new NuevoLibro();
            }
            return FormNuevoLibro;
        }

        private void BtnAddUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                //Convierte el texto de TBTelefono a in si esta ok devuelve true
                bool ok = int.TryParse(TbAnoEdicion.Text, out int TelefonoInt);
                

                if (!ok)
                {
                    throw new Exception("El teléfono debe ser numérico.");
                }

                ControladorLibro.NuevoLibro(TbTitulo.Text, TbEscritor.Text, TelefonoInt,TbSinopsis.Text, ChkDisponible.Checked);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
