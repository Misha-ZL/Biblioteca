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
    }
}
