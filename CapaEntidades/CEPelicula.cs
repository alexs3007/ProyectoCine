using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CEPelicula
    {
        public int IdPelicula { get; set; }
        public string NombrePelicula { get; set; }
        public string Sinopsis { get; set; }
        public string Lanzamiento { get; set; }
        public string Duracion { get; set; }
        public int IdGenero { get; set; }
        public int IdClasificacion { get; set; }
        public byte[] Imagen { get; set; }
        public string URL { get; set; }
        public int IdUsuario { get; set; }

    }
}
