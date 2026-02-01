using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_proyecto.Modelo
{
    /// <summary>
    /// Provee metodos para el manejo de libros en la base de datos SQLite, como agregar, modificar, borrar y 
    /// buscar libros, asi como cargar todos los libros.
    /// </summary>
    public class RepositorioLibro
    {
        /// <summary>
        /// Añade un nuevo registro de libro a la BD asi como su informacion asociada.
        /// </summary>
        /// <param name="libro">Libro con la informacion a ser insertada.</param>
        public void SumarLibro(Libro libro)
        {
            string sql = "INSERT INTO Libros (Titulo, Escritor, Ano_Edicion, Sinopsis, Disponible) VALUES (@titulo, @escritor, @ano_edicion, @sinopsis, @disponible)";
            SQLiteCommand cmd = new SQLiteCommand(sql);

            cmd.Parameters.Add("@titulo", DbType.String).Value = libro.Titulo;
            cmd.Parameters.Add("@escritor", DbType.String).Value = libro.Escritor;
            cmd.Parameters.Add("@ano_edicion", DbType.Int32).Value = libro.Ano_Edicion;
            cmd.Parameters.Add("@sinopsis", DbType.String).Value = libro.Sinopsis;
            cmd.Parameters.Add("@disponible", DbType.Int32).Value = libro.Disponible ? 1: 0;


            SQLiteHelper.Ejecuta(Properties.Settings.Default.conexion, cmd);
        }
        /// <summary>
        /// Actualiza los detalles de un libro en la BD.
        /// </summary>
        /// <param name="libro">Libro con la informacion a ser actualizada.</param>
        public void ModificarLibro(Libro libro)
        {
            string sql = "Update Libros set Titulo=@titulo, Escritor=@escritor, Ano_Edicion=@ano_edicion, Sinopsis=@sinopsis, Disponible=@disponible WHERE ID=@id";
            SQLiteCommand cmd = new SQLiteCommand(sql);

            
            cmd.Parameters.Add("@id", DbType.Int32).Value = libro.Id;
            cmd.Parameters.Add("@titulo", DbType.String).Value = libro.Titulo;
            cmd.Parameters.Add("@escritor", DbType.String).Value = libro.Escritor;
            cmd.Parameters.Add("@ano_edicion", DbType.Int32).Value = libro.Ano_Edicion;
            cmd.Parameters.Add("@sinopsis", DbType.String).Value = libro.Sinopsis;
            cmd.Parameters.Add("@disponible", DbType.Int32).Value = libro.Disponible ? 1: 0;


            SQLiteHelper.Ejecuta(Properties.Settings.Default.conexion, cmd);
        }
        /// <summary>
        /// Elimina un libro de la BD segun su ID.
        /// </summary>
        /// <param name="id">ID del libro a ser eliminado.</param>
        public void BorrarLibro(int id)
        {
            string sql = $"DELETE FROM Libros WHERE ID={id}";
            
            SQLiteCommand cmd = new SQLiteCommand(sql);

            SQLiteHelper.Ejecuta(Properties.Settings.Default.conexion, cmd);
        }
        /// <summary>
        ///Recoge toda la informacion de la tabla 'Libros' y la devuelve.
        /// </summary>
        /// <returns>Una tabla con toda la informacion de la tabla 'libros'.</returns>
        public DataTable CargarLibrosTodo()
        {
            DataTable datos = new DataTable();
            string sql = "SELECT * FROM Libros";
            SQLiteCommand cmd = new SQLiteCommand(sql);
            datos = SQLiteHelper.GetDataTable(Properties.Settings.Default.conexion, cmd);
            return datos;
        }
        /// <summary>
        /// Recoge una tabla con todos los libros disponibles en la BD.
        /// </summary>
        /// <returns>Una tabla con los libros disponibles.</returns>
        public DataTable CargarLibrosDisponibles()
        {
            DataTable datos = new DataTable();
            string sql = "SELECT * FROM Libros Where Disponible = 1";
            SQLiteCommand cmd = new SQLiteCommand(sql);
            datos = SQLiteHelper.GetDataTable(Properties.Settings.Default.conexion, cmd);
            return datos;
        }

        /// <summary>
        /// Reune la informacion de un libro concreto en base a su ID.
        /// </summary>
        /// <param name="id">ID que queremos buscar.</param>
        /// <returns>Una tabla de datos con la informacion del libro que buscamos.</returns>
        public DataTable BuscarLibroPorID(int id)
        {
            DataTable datos = new DataTable();
            string sql = $"SELECT * FROM Libros WHERE ID=@id";
            SQLiteCommand cmd = new SQLiteCommand(sql);
            cmd.Parameters.Add("@id", DbType.Int32).Value = id;
            datos = SQLiteHelper.GetDataTable(Properties.Settings.Default.conexion, cmd);
            return datos;
        }

    }
}
