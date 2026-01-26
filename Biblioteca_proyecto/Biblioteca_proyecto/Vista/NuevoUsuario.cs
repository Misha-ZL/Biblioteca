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
    public partial class FNuevoUsuario : Form
    {

        public Controlador.MiControlador ControladorUsuario = new Controlador.MiControlador();



        public FNuevoUsuario()
        {
            InitializeComponent();
            
        }

        

        private static FNuevoUsuario FormNuevoUsuario;

     

        public static FNuevoUsuario GetInstance()
        {
            if (FormNuevoUsuario == null || FormNuevoUsuario.IsDisposed)
            {
                FormNuevoUsuario = new FNuevoUsuario();
            }
            return FormNuevoUsuario;
        }

        private void BtnAddUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                //Convierte el texto de TBTelefono a in si esta ok devuelve true
                bool ok = int.TryParse(TbTelefono.Text, out int TelefonoInt);
               
                if (!ok)
                {
                    throw new Exception("El teléfono debe ser numérico.");
                }

                ControladorUsuario.NuevoUsuario(TbNombre.Text, TbAppellido1.Text, TbApellido2.Text,TelefonoInt);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
