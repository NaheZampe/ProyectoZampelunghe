using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmenas.Entidades
{
    public class Alimentos
    {
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public int IdAlimento { get; set; }
        public string Alimento { get; set; }
        
    }
}
