using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CECarteleraPelicula
    {
        public int IdCartelera { get; set; }
        public int IdPelicula { get; set; }
        public DateTime Fecha { get; set; }
        public string NombrePelicula { get; set; }
    }
}
