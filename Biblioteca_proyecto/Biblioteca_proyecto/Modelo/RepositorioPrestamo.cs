using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_proyecto.Modelo
{
    public class RepositorioPrestamo
    {
        public void SumarPrestamo(Prestamo prestamo)
        {
            string sql = "INSERT INTO Prestamos (ID_Libro, ID_Usuario, Fecha_Inicio, Fecha_Fin) " +
                         "VALUES (@idLibro, @idUsuario, @fechaInicio, @fechaFin)";

            SQLiteCommand cmd = new SQLiteCommand(sql);

            cmd.Parameters.Add("@idLibro", DbType.Int32).Value = prestamo.Id_Libro;
            cmd.Parameters.Add("@idUsuario", DbType.Int32).Value = prestamo.Id_Usuario;
            cmd.Parameters.Add("@fechaInicio", DbType.String).Value = prestamo.Fecha_Inicio; 
            cmd.Parameters.Add("@fechaFin", DbType.String).Value = prestamo.Fecha_Fin;       

            SQLiteHelper.Ejecuta(Properties.Settings.Default.conexion, cmd);
        }

        public void ModificarPrestamo(Prestamo prestamo)
        {
            string sql = "UPDATE Prestamos SET ID_Libro=@idLibro, ID_Usuario=@idUsuario, " +
                         "Fecha_Inicio=@fechaInicio, Fecha_Fin=@fechaFin " +
                         "WHERE ID=@id";

            SQLiteCommand cmd = new SQLiteCommand(sql);

            cmd.Parameters.Add("@id", DbType.Int32).Value = prestamo.Id;
            cmd.Parameters.Add("@idLibro", DbType.Int32).Value = prestamo.Id_Libro;
            cmd.Parameters.Add("@idUsuario", DbType.Int32).Value = prestamo.Id_Usuario;
            cmd.Parameters.Add("@fechaInicio", DbType.String).Value = prestamo.Fecha_Inicio;
            cmd.Parameters.Add("@fechaFin", DbType.String).Value = prestamo.Fecha_Fin;

            SQLiteHelper.Ejecuta(Properties.Settings.Default.conexion, cmd);
        }

        public void BorrarPrestamo(int id)
        {
            string sql = "DELETE FROM Prestamos WHERE ID=@id";
            SQLiteCommand cmd = new SQLiteCommand(sql);
            cmd.Parameters.Add("@id", DbType.Int32).Value = id;

            SQLiteHelper.Ejecuta(Properties.Settings.Default.conexion, cmd);
        }

        public DataTable CargarPrestamosTodo()
        {
            string sql = "SELECT * FROM Prestamos";
            SQLiteCommand cmd = new SQLiteCommand(sql);
            return SQLiteHelper.GetDataTable(Properties.Settings.Default.conexion, cmd);
        }

        public DataTable BuscarPrestamoPorID(int id)
        {
            string sql = "SELECT * FROM Prestamos WHERE ID=@id";
            SQLiteCommand cmd = new SQLiteCommand(sql);
            cmd.Parameters.Add("@id", DbType.Int32).Value = id;

            return SQLiteHelper.GetDataTable(Properties.Settings.Default.conexion, cmd);
        }

    }
}
