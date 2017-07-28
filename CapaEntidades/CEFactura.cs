using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaEntidades
{
    public class CEFactura
    {
        public int IdFactura { get; set; }
        public DateTime Fecha { get; set; }
        public int IdPelicula { get; set; }
        public string NombrePelicula { get; set; }
        public int IdTecnologia { get; set; }
        public int CantidadBoleto { get; set; }
        public double PrecioBoleto { get; set; }
        public int IdUsuario { get; set; }

    }
}
