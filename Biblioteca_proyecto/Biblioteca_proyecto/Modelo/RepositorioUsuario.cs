using System;
using System.Data;
using System.Data.SQLite;

namespace Biblioteca_proyecto.Modelo
{
    public class RepositorioUsuario
    {

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

        public void BorrarUsuario(int id)
        {
            string sql = $"DELETE FROM Usuarios WHERE ID={id}";
            SQLiteCommand cmd = new SQLiteCommand(sql);
            SQLiteHelper.Ejecuta(Properties.Settings.Default.conexion, cmd);
        }

        public DataTable CargarUsuariosTodo()
        {
            DataTable datos = new DataTable();
            string sql = "SELECT * FROM Usuarios";
            SQLiteCommand cmd = new SQLiteCommand(sql);
            datos = SQLiteHelper.GetDataTable(Properties.Settings.Default.conexion, cmd);
            return datos;
        }

        public DataTable BuscarUsuarioPorID(int id)
        {
            DataTable datos = new DataTable();
            string sql = $"SELECT * FROM Usuario WHERE ID={id}";
            SQLiteCommand cmd = new SQLiteCommand(sql);
            datos = SQLiteHelper.GetDataTable(Properties.Settings.Default.conexion, cmd);
            return datos;
        }



    }
}
