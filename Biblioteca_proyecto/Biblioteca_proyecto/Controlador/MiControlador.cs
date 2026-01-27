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

        
        public Modelo.RepositorioUsuario repositorioUsuario =new Modelo.RepositorioUsuario();

      
        public Modelo.RepositorioLibro repositorioLibro =new Modelo.RepositorioLibro();

       
        public Modelo.RepositorioPrestamo repositorioPrestamo =new Modelo.RepositorioPrestamo();

        //Crear nuevo
        public void NuevoUsuario(string Nombre,string Apellido_1,string Apellido_2, int Telefono)
        {
            if(Nombre == "" || Apellido_1 == "" || Telefono <= 0){

                throw new Exception("Debes rellenar todos los datos");
            }

            Usuario usuario =new Usuario(Nombre,Apellido_1,Apellido_2,Telefono);
            repositorioUsuario.SumarUsuario(usuario);


        }
        public void NuevoLibro(string Titulo, string Escritor, int Ano,string Sinopsis, Boolean Disponible)
        {
            if(Titulo == "" || Escritor == "" || Ano <= 0 || Sinopsis == ""  ){

                throw new Exception("Debes rellenar todos los datos");
            }

            Libro libro=new Libro(Titulo,Escritor,Ano,Sinopsis,Disponible);
            repositorioLibro.SumarLibro(libro);


        }
        public void NuevoPrestamo(int Id_Libro,int Id_Usuario,String fecha_inicio,String fecha_fin)
        {   


            bool libroExiste = repositorioLibro.BuscarLibroPorID(Id_Libro).Rows.Count > 0;
            bool usuarioExiste = repositorioUsuario.BuscarUsuarioPorID(Id_Usuario).Rows.Count > 0;

            if (!libroExiste)
            {
                throw new Exception("El libro no existe");
            }

            if (!usuarioExiste) { throw new Exception("El usuario no existe"); 
            
            }

            if ( fecha_fin == "" || fecha_fin == ""  ){

                throw new Exception("Debes rellenar todos los datos");
            }

            Prestamo prestamo=new Prestamo(Id_Libro,Id_Usuario,fecha_inicio,fecha_fin);
            repositorioPrestamo.SumarPrestamo(prestamo);


         }

        //Eliminar por ID
        public void EliminarUsuario(int id)
        {
            repositorioUsuario.BorrarUsuario(id);
        }

        public void EliminarLibro(int id)
        {
            repositorioLibro.BorrarLibro(id);
        }

        public void EliminarPrestamo(int id)
        {
            repositorioPrestamo.BorrarPrestamo(id);
        }

        //Cargar todo 
        public DataTable CargarUsuarios()
        {
            return repositorioUsuario.CargarUsuariosTodo();
        }

        public DataTable CargarLibros()
        {
            return repositorioLibro.CargarLibrosTodo();
        }

        public DataTable CargarPrestamos()
        {
            return repositorioPrestamo.CargarPrestamosTodo();
        }

        //Buscar por ID
        public DataTable BuscarUsuarioPorID(int id)
        {
            return repositorioUsuario.BuscarUsuarioPorID(id);
        }
        public DataTable BuscarLibroPorID(int id)
        {
            return repositorioLibro.BuscarLibroPorID(id);
        }

        public DataTable BuscarPrestamoPorID(int id)
        {
            return repositorioPrestamo.BuscarPrestamoPorID(id);
        }

        //Modificar por ID
        public void ModificarUsuario(int id,string Nombre, string Apellido_1, string Apellido_2, int Telefono)
        {
            if (Nombre == "" || Apellido_1 == "" || Telefono <= 0)
            {

                throw new Exception("Debes rellenar todos los datos");
            }

            bool UsuarioExiste = repositorioUsuario.BuscarUsuarioPorID(id).Rows.Count > 0;
            if (!UsuarioExiste)
            {
                throw new Exception("El usuario no existe");
            }



            Usuario usuario = new Usuario(Nombre, Apellido_1, Apellido_2, Telefono);
            repositorioUsuario.ModificarUsuario(usuario);


        }
        public void ModificarLibro(int id,string Titulo, string Escritor, int Ano, string Sinopsis, Boolean Disponible)
        {
            if (Titulo == "" || Escritor == "" || Ano <= 0 || Sinopsis == "")
            {

                throw new Exception("Debes rellenar todos los datos");
            }

            bool LibroExiste = repositorioUsuario.BuscarUsuarioPorID(id).Rows.Count > 0;
            if (!LibroExiste)
            {
                throw new Exception("El libro no existe");
            }

            Libro libro = new Libro(Titulo, Escritor, Ano, Sinopsis, Disponible);
            repositorioLibro.ModificarLibro(libro);


        }

        public void ModificarPrestamo(int Id_Libro, int Id_Usuario, String fecha_inicio, String fecha_fin)
        {


            bool LibroExiste = repositorioLibro.BuscarLibroPorID(Id_Libro).Rows.Count > 0;
            bool UsuarioExiste = repositorioUsuario.BuscarUsuarioPorID(Id_Usuario).Rows.Count > 0;

            if (!LibroExiste)
            {
                throw new Exception("El libro no existe");
            }

            if (!UsuarioExiste)
            {
                throw new Exception("El usuario no existe");

            }

            if (fecha_fin == "" || fecha_fin == "")
            {

                throw new Exception("Debes rellenar todos los datos");
            }

            Prestamo prestamo = new Prestamo(Id_Libro, Id_Usuario, fecha_inicio, fecha_fin);
            repositorioPrestamo.ModificarPrestamo(prestamo);


        }










    }
}
