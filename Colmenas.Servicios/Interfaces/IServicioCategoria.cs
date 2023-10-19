using Colmenas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmenas.Servicios.Interfaces
{
    public interface IServicioCategoria
    {
        bool Existe(Categoria Categoria);
        void Borrar(int IdCategoria);
        List<Categoria> GetCategoria();
        void Guardar(Categoria Categoria);
    }
}
