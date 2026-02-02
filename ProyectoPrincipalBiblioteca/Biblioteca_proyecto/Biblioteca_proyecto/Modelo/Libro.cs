using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_proyecto.Modelo
{
    /// <summary>
    /// Representa un libro en el sistema de la biblioteca, con propiedades como Titulo, Escritor, Ano_Edicion, Sinopsis y Disponible.
    /// </summary>
    public class Libro
    {
        public Libro(string titulo, string escritor, int ano_Edicion, string sinopsis, bool disponible)
        {
            Titulo = titulo;
            Escritor = escritor;
            Ano_Edicion = ano_Edicion;
            Sinopsis = sinopsis;
            Disponible = disponible;
        }
        public Libro(int id,string titulo, string escritor, int ano_Edicion, string sinopsis, bool disponible)
        {
            Titulo = titulo;
            Escritor = escritor;
            Ano_Edicion = ano_Edicion;
            Sinopsis = sinopsis;
            Disponible = disponible;
            Id = id;
        }

        public int Id {get; set;}
        public String Titulo {get; set;}
        public String Escritor {get; set;}
        public int Ano_Edicion {get; set;}
        public String Sinopsis {get; set;}

        public Boolean Disponible { get; set;}



       
    }
}
