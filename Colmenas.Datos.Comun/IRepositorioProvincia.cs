using Colmenas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmenas.Datos.Comun
{
    public interface IRepositorioProvincia
    {
        List<Provincia> GetProvincias();
        void Agregar(Provincia provincia);
        void Borrar(int IdProvincia);
        void Editar(Provincia provincia);
        bool Existe(Provincia provincia);
    }
}
