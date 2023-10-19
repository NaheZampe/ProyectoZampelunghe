using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmenas.Entidades
{
    public class Categoria
    {
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }
        public string Descripcion { get; set; }
    }
}
