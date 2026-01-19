using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_proyecto.Modelo
{
    internal class Prestamo
    {
        public int Id { get; set; }
        public int Id_libro { get; set; }
        public int Id_usuario { get; set; }
        public String Fecha_inicio { get; set; }
        public String Fecha_fin { get; set; }
    }
}
