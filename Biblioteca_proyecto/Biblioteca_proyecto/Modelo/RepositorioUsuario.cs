using System;
using System.Data;
using System.Data.SQLite;

namespace Biblioteca_proyecto.Modelo
{
    public class RepositorioUsuario
    {

        public void SumarEmpleado(Usuario usuario)
        {
            string sql = "INSERT INTO Usuarios (Nombre, Apellido_1, Apellido_2, Telefono ) VALUES (@nombre, @apellido1, @apellido2, @telefono)";
            SQLiteCommand cmd = new SQLiteCommand(sql);

            cmd.Parameters.Add("@nombre", DbType.String).Value = usuario.Nombre;
            cmd.Parameters.Add("@apellido1", DbType.String).Value = usuario.Apellido_1;
            cmd.Parameters.Add("@apellido2", DbType.String).Value = usuario.Apellido_2;
            cmd.Parameters.Add("@telefono", DbType.Int32).Value = usuario.Telefono;
          

            SQLiteHelper.Ejecuta(Properties.Settings.Default.conexion, cmd);
        }


    }
}
