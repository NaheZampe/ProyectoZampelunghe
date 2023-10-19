using Colmenas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmenas.Datos.Comun
{
    public interface IRepositorioAlimentos
    {
        List<Alimentos> GetAlimentos();
        void Agregar(Alimentos alimentos);
        void Borrar(int IdAlimento);
        void Editar(Alimentos alimentos);
        bool Existe(Alimentos alimentos);
    }
}
