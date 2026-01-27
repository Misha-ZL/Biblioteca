using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_proyecto.Modelo
{
    public class Prestamo

    
    { 
        
        public Prestamo(int id, int id_libro, int id_usuario, String fecha_inicio, String fecha_fin)
        {
            Id = id;
            Id_Libro = id_libro;
            Id_Usuario = id_usuario;
            Fecha_Inicio = fecha_inicio;
            Fecha_Fin = fecha_fin;
        }
        public Prestamo( int id_libro, int id_usuario, String fecha_inicio, String fecha_fin)
        {
            
            Id_Libro = id_libro;
            Id_Usuario = id_usuario;
            Fecha_Inicio = fecha_inicio;
            Fecha_Fin = fecha_fin;
        }


        public int Id { get; set; }
        public int Id_Libro { get; set; }
        public int Id_Usuario { get; set; }
        public String Fecha_Inicio { get; set; }
        public String Fecha_Fin { get; set; }


    }
}
