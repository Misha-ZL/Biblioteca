using System;
using System.Data;
using System.Data.SQLite;

namespace Biblioteca_proyecto.Modelo
{
    /// <summary>
    /// Provee metodos para el manejo de usuarios en la base de datos SQLite, como agregar, modificar, borrar y buscar usuarios,
    /// Asi como cargar todos los usuarios.
    /// </summary>
    public class RepositorioUsuario
    {
        /// <summary>
        /// Añade un nuevo usuario a la base da datos.
        /// </summary>
        /// <param name="usuario">Informacion a ser insertada.</param>
        public void SumarUsuario(Usuario usuario)
        {
            string sql = "INSERT INTO Usuarios (Nombre, Apellido_1, Apellido_2, Telefono ) VALUES (@nombre, @apellido1, @apellido2, @telefono)";
            SQLiteCommand cmd = new SQLiteCommand(sql);

            cmd.Parameters.Add("@nombre", DbType.String).Value = usuario.Nombre;
            cmd.Parameters.Add("@apellido1", DbType.String).Value = usuario.Apellido_1;
            cmd.Parameters.Add("@apellido2", DbType.String).Value = usuario.Apellido_2;
            cmd.Parameters.Add("@telefono", DbType.Int32).Value = usuario.Telefono;
          

            SQLiteHelper.Ejecuta(Properties.Settings.Default.conexion, cmd);
        }
        /// <summary>
        /// Hace una actualizacion de la informacion de un usario ya cargado en la base de datos.
        /// </summary>
        /// <param name="usuario">Datos a ser actualizados.</param>
        public void ModificarUsuario(Usuario usuario)
        {
            string sql = "Update Usuarios set  Nombre=@nombre, Apellido_1=@apellido1, Apellido_2=@apellido2, Telefono=@telefono Where ID=@id";
            SQLiteCommand cmd = new SQLiteCommand(sql);

            cmd.Parameters.Add("@nombre", DbType.String).Value = usuario.Nombre;
            cmd.Parameters.Add("@id", DbType.String).Value = usuario.Id;
            cmd.Parameters.Add("@apellido1", DbType.String).Value = usuario.Apellido_1;
            cmd.Parameters.Add("@apellido2", DbType.String).Value = usuario.Apellido_2;
            cmd.Parameters.Add("@telefono", DbType.Int32).Value = usuario.Telefono;
          

            SQLiteHelper.Ejecuta(Properties.Settings.Default.conexion, cmd);
        }
        /// <summary>
        /// Borra un usuario de la BD en base a su ID.
        /// </summary>
        /// <param name="id">ID a ser borrado.</param>
        public void BorrarUsuario(int id)
        {
            string sql = $"DELETE FROM Usuarios WHERE ID={id}";
            SQLiteCommand cmd = new SQLiteCommand(sql);
            SQLiteHelper.Ejecuta(Properties.Settings.Default.conexion, cmd);
        }
        /// <summary>
        /// Recive todos los registros de la tabla usuarios.
        /// </summary>
        /// <returns>Una tabla de datos con todos los usuarios y su informacion.</returns>
        public DataTable CargarUsuariosTodo()
        {
            DataTable datos = new DataTable();
            string sql = "SELECT * FROM Usuarios";
            SQLiteCommand cmd = new SQLiteCommand(sql);
            datos = SQLiteHelper.GetDataTable(Properties.Settings.Default.conexion, cmd);
            return datos;
        }
        /// <summary>
        /// Recive toda la informacion de un usuario en base a su ID desde la BD.
        /// </summary>
        /// <param name="id">ID del usuario que buscamos.</param>
        /// <returns>Una tabla con toda la informacion del respectivo usuario.</returns>
        public DataTable BuscarUsuarioPorID(int id)
        {
            string sql = "SELECT * FROM Usuarios WHERE ID=@id";
            SQLiteCommand cmd = new SQLiteCommand(sql);
            cmd.Parameters.Add("@id", DbType.Int32).Value = id;

            return SQLiteHelper.GetDataTable(Properties.Settings.Default.conexion, cmd);
        }




    }
}
