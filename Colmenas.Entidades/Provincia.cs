using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Colmenas.Entidades
{
    public class Provincia
    {
        public int IdProvincia { get; set; }
        public string NombreProvincia { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
