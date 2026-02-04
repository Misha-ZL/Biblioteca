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
using Biblioteca_proyecto.Modelo;

namespace Biblioteca_proyecto.Vista
{
    public partial class EditarUsuario : Form
    {
        //lo he tenido que poner public para acceder desde Usuarios.cs 
        public MiControlador ControladorModUsuario = new MiControlador();
        public EditarUsuario()
        {
            InitializeComponent();
            this.Load += EditarUsuario_Load;
        }

        public int id;

       
        private void EditarUsuario_Load(object sender, EventArgs e)
        {


            //Se carga la informacion del usuario en los textbox correspondientes
            DataTable data = ControladorModUsuario.BuscarUsuarioPorID(id);
            TbNombre.Text = data.Rows[0]["Nombre"].ToString();
            TbAppellido1.Text = data.Rows[0]["Apellido_1"].ToString();
            TbApellido2.Text = data.Rows[0]["Apellido_2"].ToString();
            TbTelefono.Text = data.Rows[0]["Telefono"].ToString();


        }

        private void BtnEditarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
              
                ControladorModUsuario.ModificarUsuario(id, TbNombre.Text, TbAppellido1.Text, TbApellido2.Text, Convert.ToInt32(TbTelefono.Text));
                MessageBox.Show("Editando ID: " + id);
                

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    
    
    }
