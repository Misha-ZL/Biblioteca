using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_proyecto.Modelo
{
    public class Usuario
    {
        public Usuario(int id, string nombre, string apellido_1, String apellido_2, int telefono)
        {
            Id = id;
            Nombre = nombre;
            Apellido_1 = apellido_1;
            Apellido_2 = apellido_2;
            Telefono = telefono;
        }
        public Usuario(string nombre, string apellido_1, String apellido_2, int telefono)
        {
            Nombre = nombre;
            Apellido_1 = apellido_1;
            Apellido_2 = apellido_2;
            Telefono = telefono;
        }

        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Apellido_1 { get; set; }
        public String Apellido_2 { get; set; }
        public int Telefono { get; set; }

        
    }
}
