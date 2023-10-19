using Colmenas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmenas.Servicios.Interfaces
{
    public interface IServicioAlimentos
    {
        bool Existe(Alimentos alimentos);
        void Borrar(int IdAlimento);
        List<Alimentos> GetAlimentos();
        void Guardar(Alimentos alimentos);
    }
}
