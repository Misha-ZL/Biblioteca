
using System;
using System.Data;
using System.Data.SQLite;

namespace Biblioteca_proyecto.Modelo
{
    /// <summary>
    /// Provee metodos estaticos para facilitar la conexion y ejecucion de comandos de SQLite.
    /// </summary>
    internal class SQLiteHelper
    {
        /// <summary>
        /// Establece y abre la conexion con una base de datos SQLite con el string adecuado de conexion.
        /// </summary>
        /// <param name="bbdd">El string especifico de conexion para la BD.</param>
        /// <returns>Una SQLiteConnection abierta con la respectiva base de datos.</returns>
        /// <exception cref="Exception">Se lanza cuando no se puede establecer conexion con la BD.</exception>
        public static SQLiteConnection Conectar(string bbdd)
        {
            try
            {
                /// Crear la conexion
                SQLiteConnection cnn = new SQLiteConnection(bbdd);
                cnn.Open();
                return cnn;
            }
            catch (Exception ex)
            {
                /// Lanzar excepcion si no se puede conectar
                throw new Exception("No se logró realizar la conexión debido a: " + ex.Message);
            }
        }
        /// <summary>
        /// Ejecuta el comando SQLite especifico en la BD y devuelve los datos de los resultados.
        /// </summary>
        /// <param name="bbdd">El nombre o ruta de la BD a conectar.</param>
        /// <param name="cmd">Comando SQLite a ejecutarse.</param>
        /// <returns>Un SQLiteDataReader con el comando ejecutado. La conexion asociada se cierra cuando el lector de datos se cierra.</returns>
        /// <exception cref="Exception">Se lanza cuando las instrucciones solicitadas no pueden ejecutarse.</exception>
        public static SQLiteDataReader GetDataReader(string bbdd, SQLiteCommand cmd)
        {
            try
            {
                ///Establecer la conexion
                SQLiteConnection cnx = Conectar(bbdd);
                cmd.Connection = cnx;

                /// El DataReader cerrará la conexión cuando se cierre
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                /// Lanzar excepcion si no se puede ejecutar el comando
                throw new Exception("No se logró realizar la consulta por: " + ex.Message);
            }
        }
        /// <summary>
        /// Ejecuta el comando SQLite especificado en la BD y devuelve una tabla de datos con los resultados.
        /// </summary>
        /// <param name="bbdd">El nombre o ruta de la BD a conectar.</param>
        /// <param name="cmd">Comando SQLite a ejecutarse.</param>
        /// <returns>Una tabla de datos con la informacion del comando ejecutado.</returns>
        /// <exception cref="Exception">Se lanza cuando el comando no puede realizarse.</exception>
        public static DataTable GetDataTable(string bbdd, SQLiteCommand cmd)
        {
            try
            {
                /// Establecer la conexion
                using (SQLiteConnection cnx = Conectar(bbdd))
                {
                    cmd.Connection = cnx;

                    DataSet ds = new DataSet();
                    ds.Tables.Add("datos");
                    /// Rellenar el DataSet con el resultado del comando
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                    {
                        da.Fill(ds, "datos");
                    }

                    return ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                /// Lanzar excepcion si no se puede ejecutar el comando
                throw new Exception("No se logró realizar la consulta por: " + ex.Message);
            }
        }
        /// <summary>
        /// Ejecuta un comando SQLite que no es de consulta en la BD.
        /// </summary>
        /// <param name="bbdd">El nombre o ruta de la BD a conectar.</param>
        /// <param name="cmd">Comando SQLite a ejecutarse.</param>
        /// <exception cref="Exception">Se lanza cuando el comando no puede realizarse.</exception>
        public static void Ejecuta(string bbdd, SQLiteCommand cmd)
        {
            try
            {
                using (SQLiteConnection cnx = Conectar(bbdd))
                {
                    cmd.Connection = cnx;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se logró realizar la consulta por: " + ex.Message);
            }
        }
    }
}
