using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_proyecto.Modelo
{
    public class RepositorioLibro
    {

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

        public void BorrarLibro(int id)
        {
            string sql = $"DELETE FROM Libros WHERE ID={id}";
            
            SQLiteCommand cmd = new SQLiteCommand(sql);

            SQLiteHelper.Ejecuta(Properties.Settings.Default.conexion, cmd);
        }

        public DataTable CargarLibrosTodo()
        {
            DataTable datos = new DataTable();
            string sql = "SELECT * FROM Libros";
            SQLiteCommand cmd = new SQLiteCommand(sql);
            datos = SQLiteHelper.GetDataTable(Properties.Settings.Default.conexion, cmd);
            return datos;
        }


        public DataTable BuscarLibroPorID(int id)
        {
            DataTable datos = new DataTable();
            string sql = $"SELECT * FROM Libros WHERE ID={id}";
            SQLiteCommand cmd = new SQLiteCommand(sql);
            datos = SQLiteHelper.GetDataTable(Properties.Settings.Default.conexion, cmd);
            return datos;
        }





    }
}
