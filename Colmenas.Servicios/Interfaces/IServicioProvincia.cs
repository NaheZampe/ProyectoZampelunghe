using Colmenas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmenas.Servicios.Interfaces
{
    public interface IServicioProvincia
    {
        bool Existe(Provincia prov);
        void Borrar(int IdProvincia);
        List<Provincia> GetProvincias();
        void Guardar(Provincia provincia);
    }
}
