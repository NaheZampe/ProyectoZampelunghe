using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmenas.Entidades
{
    public class Colmena
    {
        public int IdColmena { get; set; }
        public int IdColmenar { get; set; }
        public int IdDuenio { get; set; }
        public string ConVida { get; set; }
        public Colmenar Colmenar { get; set; }
        public Duenio Duenio { get; set; }
    }
}
