using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmenas.Entidades
{
    public class Ubicacion
    {
        public int IdUbicacion { get; set; }
        public string NombreUbic { get; set; }
        public int IdLocalidad { get; set; }
        public int IdProvincia { get; set; }
        public Localidad Localidad { get; set; }
        public Provincia Provincia { get; set; }
    }
}
