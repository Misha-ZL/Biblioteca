using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_proyecto.Modelo;

namespace Biblioteca_proyecto.Controlador
{
     public class MiControlador
    {

        public Usuario usuario;
        public Modelo.RepositorioUsuario repositorioUsuario =new Modelo.RepositorioUsuario();

        public void NuevoUsuario(string Nombre,string Apellido_1,string Apellido_2, int Telefono)
        {
            if(Nombre == "" || Apellido_1 == "" || Telefono <= 0){

                throw new Exception("Debes rellenar todos los datos");
            }

            Usuario usuario =new Usuario(Nombre,Apellido_1,Apellido_2,Telefono);
            repositorioUsuario.SumarEmpleado(usuario);


        }


        public MiControlador() { }
    }
}
