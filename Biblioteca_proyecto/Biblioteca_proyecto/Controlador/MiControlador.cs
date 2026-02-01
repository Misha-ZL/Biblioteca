using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_proyecto.Modelo;

namespace Biblioteca_proyecto.Controlador
{
    /// <summary>
    /// Provee los metodos para manejar las operaciones de usuarios, libros y prestamos, 
    /// incluyendo crear, eliminar, cargar, buscar y modificar registros.
    /// </summary>
    public class MiControlador
    {
        /// <summary>
        /// Provee acceso a los metodos de manejo de Usuarios en la base de datos.
        /// </summary>
        public Modelo.RepositorioUsuario repositorioUsuario =new Modelo.RepositorioUsuario();

        /// <summary>
        /// Provee acceso a los metodos de manejo de Libros en la base de datos.
        /// </summary>
        public Modelo.RepositorioLibro repositorioLibro =new Modelo.RepositorioLibro();

        /// <summary>
        /// Provee acceso a los metodos de manejo de Prestamos en la base de datos.
        /// </summary>
        public Modelo.RepositorioPrestamo repositorioPrestamo =new Modelo.RepositorioPrestamo();

      /// <summary>
      /// Añade un nuevo usuario con el nombre, apellido y numero de telefono especificados a la lista de usuarios.
      /// </summary>
      /// <param name="Nombre">Nombre del usuario.</param>
      /// <param name="Apellido_1">Primer apellido.</param>
      /// <param name="Apellido_2">Segundo apellido.</param>
      /// <param name="Telefono">Numero telefonico del usuario.</param>
      /// <exception cref="Exception">Se lanza cuando hay campos incompletos o el telefono es invalido.</exception>
        public void NuevoUsuario(string Nombre,string Apellido_1,string Apellido_2, int Telefono)
        {
            if(Nombre == "" || Apellido_1 == "" || Telefono <= 0){

                throw new Exception("Debes rellenar todos los datos");
            } else
            {
                Usuario usuario = new Usuario(Nombre, Apellido_1, Apellido_2, Telefono);
                repositorioUsuario.SumarUsuario(usuario);
            }
        }
        /// <summary>
        /// Añade un nuevo libro con su titulo, escritor, año de publicacion, sinopsis y su disponibilidad a la lista de libros.
        /// </summary>
        /// <param name="Titulo">Titulo principal del libro</param>
        /// <param name="Escritor">Quien escribio el libro</param>
        /// <param name="Ano">fecha de publicacion</param>
        /// <param name="Sinopsis">Breve resumen del libro</param>
        /// <param name="Disponible">Su actual disponibilidad para ser prestado</param>
        /// <exception cref="Exception">Se lanza cuando cualquiera de los campos esta incompleto o es erroneo</exception>
        public void NuevoLibro(string Titulo, string Escritor, int Ano,string Sinopsis, Boolean Disponible)
        {
            if(Titulo == "" || Escritor == "" || Ano <= 0 || Sinopsis == ""  ){

                throw new Exception("Debes rellenar todos los datos");
            } else 
            {
                Libro libro = new Libro(Titulo, Escritor, Ano, Sinopsis, Disponible);
                repositorioLibro.SumarLibro(libro);
            }

        }
        /// <summary>
        /// Añade un nuevo prestamo con el respectivo ID del libro y usuario, la fecha en la que inicia y en la que finaliza a la lista de prestamos.
        /// </summary>
        /// <param name="Id_Libro">Identificador del libro</param>
        /// <param name="Id_Usuario">Identificador del usuario</param>
        /// <param name="fecha_inicio">Fecha en la que se crea el prestamo</param>
        /// <param name="fecha_fin">Fecha en la que finaliza el prestamo</param>
        /// <exception cref="Exception">Se lanza cuando cualquiera de los campos esta incompleto o no es valido</exception>
        public void NuevoPrestamo(int Id_Libro,int Id_Usuario,String fecha_inicio,String fecha_fin)
        {   


            bool libroExiste = repositorioLibro.BuscarLibroPorID(Id_Libro).Rows.Count > 0;
            bool usuarioExiste = repositorioUsuario.BuscarUsuarioPorID(Id_Usuario).Rows.Count > 0;

            if (!libroExiste)
            {
                throw new Exception("El libro no existe");
            } else if (!usuarioExiste)
            {
                throw new Exception("El usuario no existe");
            } else if (fecha_fin == "" || fecha_fin == "")
            {
                throw new Exception("Debes rellenar todos los datos");
            } else
            {
                Prestamo prestamo = new Prestamo(Id_Libro, Id_Usuario, fecha_inicio, fecha_fin);
                repositorioPrestamo.SumarPrestamo(prestamo);

            }
         }


        /// <summary>
        /// Elimina un usuario de la lista de usuarios segun su ID.
        /// </summary>
        /// <param name="id">ID del usuario a eliminar</param>
        public void EliminarUsuario(int id)
        {
            repositorioUsuario.BorrarUsuario(id);
        }
        /// <summary>
        /// Elimina un libro de la lista de libros segun su ID.
        /// </summary>
        /// <param name="id">ID del libro a eliminar</param>
        public void EliminarLibro(int id)
        {
            repositorioLibro.BorrarLibro(id);
        }
        /// <summary>
        /// Elimina un prestamo de la lista de prestamos segun su ID.
        /// </summary>
        /// <param name="id">ID del prestamo a eliminar</param>
        public void EliminarPrestamo(int id)
        {
            repositorioPrestamo.BorrarPrestamo(id);
        }

        /// <summary>
        /// Carga todos los usuarios registrados en la base de datos.
        /// </summary>
        /// <returns>Una tabla de datos con todos los usuarios en la BD</returns>
        public DataTable CargarUsuarios()
        {
            return repositorioUsuario.CargarUsuariosTodo();
        }
        /// <summary>
        /// Carga todos los libros registrados en la base de datos.
        /// </summary>
        /// <returns>Una tabla de datos con todos los libros en la BD</returns>
        public DataTable CargarLibros()
        {
            return repositorioLibro.CargarLibrosTodo();
        }
        /// <summary>
        /// Carga todos los libros disponibles registrados en la base de datos.
        /// </summary>
        /// <returns>Una tabla de datos con todos los libros disponibles en la BD</returns>
        public DataTable CargarLibrosDisponibles()
        {
            return repositorioLibro.CargarLibrosDisponibles();
        }
        /// <summary>
        /// Carga todos los prestamos registrados en la base de datos.
        /// </summary>
        /// <returns>Una tabla de datos con todos los prestamos en la BD</returns>
        public DataTable CargarPrestamos()
        {
            return repositorioPrestamo.CargarPrestamosTodo();
        }

        /// <summary>
        /// Busca un usuario concreto en base a su respectivo ID
        /// </summary>
        /// <param name="id">ID del usuario a buscar</param>
        /// <returns>Una tabla de datos con toda la informacion del usuario solicitado</returns>
        public DataTable BuscarUsuarioPorID(int id)
        {
            return repositorioUsuario.BuscarUsuarioPorID(id);
        }
        /// <summary>
        /// Busca un libro concreto en base a su respectivo ID
        /// </summary>
        /// <param name="id">ID del libro a buscar</param>
        /// <returns>Una tabla de datos con toda la informacion del libro solicitado</returns>
        public DataTable BuscarLibroPorID(int id)
        {
            return repositorioLibro.BuscarLibroPorID(id);
        }
        /// <summary>
        /// Busca un prestamo concreto en base a su respectivo ID
        /// </summary>
        /// <param name="id">ID del prestamo a buscar</param>
        /// <returns>Una tabla de datos con toda la informacion del prestamo solicitado</returns>
        public DataTable BuscarPrestamoPorID(int id)
        {
            return repositorioPrestamo.BuscarPrestamoPorID(id);
        }

        /// <summary>
        /// Modifica la informacion de un usuario existente en la base de datos.
        /// </summary>
        /// <param name="id">ID del usuario a modificar</param>
        /// <param name="Nombre">Nombre a modificar</param>
        /// <param name="Apellido_1">Primer apellido a modificar</param>
        /// <param name="Apellido_2">Segundo apellido a modificar</param>
        /// <param name="Telefono">Numero telefonico del usario a modificar</param>
        /// <exception cref="Exception">Se lanzza si cualquiera de los campos esta incompleto o no es valido</exception>
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
        /// <summary>
        /// Modifica la informacion de un libro existente en la base de datos.
        /// </summary>
        /// <param name="id">ID del libro a modificar</param>
        /// <param name="Titulo">Titulo a modificar</param>
        /// <param name="Escritor">Escritor a modificar</param>
        /// <param name="Ano">Año a modificar</param>
        /// <param name="Sinopsis">Sinopsis a modificar</param>
        /// <param name="Disponible">Disponibilidad a modificar</param>
        /// <exception cref="Exception">Se lanza si cualquiera de los campos esta incompleto o no es valido</exception>
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
        /// <summary>
        /// Modifica la informacion de un prestamo existente en la base de datos.
        /// </summary>
        /// <param name="Id_Libro">ID del libro asociado a modificar</param>
        /// <param name="Id_Usuario">ID del usuario asociado a modificar</param>
        /// <param name="fecha_inicio">Fecha inicial a modificar</param>
        /// <param name="fecha_fin">Fecha de termino a modificar</param>
        /// <exception cref="Exception"></exception>
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
