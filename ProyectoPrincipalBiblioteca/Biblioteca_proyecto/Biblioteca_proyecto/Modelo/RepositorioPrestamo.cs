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
    /// Provee metodos para el manejo de prestamos en la base de datos SQLite, como agregar, modificar, borrar y buscar prestamos,
    /// ademas de cargar todos los prestamos.
    /// </summary>
    public class RepositorioPrestamo
    {
        /// <summary>
        /// Añade un nuevo registro de prestamo en la tabla 'prestamos' en la BD.
        /// </summary>
        /// <param name="prestamo">El prestamo a ser insertado.</param>
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
        /// <summary>
        /// Actualiza el registro de un prestamo en la BD con la informacion del nuevo prestamo.
        /// </summary>
        /// <param name="prestamo">Prestamo con la infromacion actualizada.</param>
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
        /// <summary>
        /// Elimina el registro de un prestamo de la BD en base a su ID.
        /// </summary>
        /// <param name="id">ID del prestamo a borrar.</param>
        public void BorrarPrestamo(int id)
        {
            string sql = "DELETE FROM Prestamos WHERE ID=@id";
            SQLiteCommand cmd = new SQLiteCommand(sql);
            cmd.Parameters.Add("@id", DbType.Int32).Value = id;

            SQLiteHelper.Ejecuta(Properties.Settings.Default.conexion, cmd);
        }
        /// <summary>
        /// Recive toda la informacion de la tabla 'prestamos'.
        /// </summary>
        /// <returns>Una tabla con toda informacion de la tabla 'Prestamos' de la BD.</returns>
        public DataTable CargarPrestamosTodo()
        {
            string sql = "SELECT * FROM Prestamos";
            SQLiteCommand cmd = new SQLiteCommand(sql);
            return SQLiteHelper.GetDataTable(Properties.Settings.Default.conexion, cmd);
        }
        /// <summary>
        /// Reune la informacion de un prestamo desde la BD segun su ID.
        /// </summary>
        /// <param name="id">ID del prestamo que buscamos.</param>
        /// <returns>Una tabla con la informacion pertinente al prestamo cuyo ID hemos buscado.</returns>
        public DataTable BuscarPrestamoPorID(int id)
        {
            string sql = "SELECT * FROM Prestamos WHERE ID=@id";
            SQLiteCommand cmd = new SQLiteCommand(sql);
            cmd.Parameters.Add("@id", DbType.Int32).Value = id;

            return SQLiteHelper.GetDataTable(Properties.Settings.Default.conexion, cmd);
        }

    }
}
