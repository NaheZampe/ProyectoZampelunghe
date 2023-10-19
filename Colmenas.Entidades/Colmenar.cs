using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmenas.Entidades
{
    public class Colmenar
    {
        public int IdColmenar  { get; set; }
        public int IdLocalidad { get; set; }
        public int IdUbicacion { get; set; }
        public int IdProvincia { get; set; }
        public int CantidadMuertas { get; set; }
        public string NombreColmenar { get; set; }
        public Localidad Localidad { get; set; }
        public Ubicacion Ubicacion { get; set; }
        public Provincia Provincia { get; set; }
    }
}
