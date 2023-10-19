using Colmenas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmenas.Datos.Comun
{
    public interface IRepositorioCategoria
    {
        List<Categoria> GetCategoria();
        void Agregar(Categoria categoria);
        void Borrar(int IdCategoria);
        void Editar(Categoria categoria);
        bool Existe(Categoria categoria);
    }
}
