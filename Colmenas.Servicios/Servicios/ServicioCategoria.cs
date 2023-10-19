using Colmenas.Datos.Comun;
using Colmenas.Datos.Sql;
using Colmenas.Entidades;
using Colmenas.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmenas.Servicios.Servicios
{
    public class ServicioCategoria : IServicioCategoria
    {
        private readonly IRepositorioCategoria _repo;
        public ServicioCategoria()
        {
            _repo = new RepositorioCategoria();
        }
        public void Borrar(int IdCategoria)
        {
            try
            {
                _repo.Borrar(IdCategoria);
            }
            catch (Exception)
            {

                throw;
            } 
        }

        public bool Existe(Categoria Categoria)
        {
            try
            {
                return _repo.Existe(Categoria);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Categoria> GetCategoria()
        {
            try
            {
                return _repo.GetCategoria();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Guardar(Categoria Categoria)
        {
            try
            {
                if (Categoria.IdCategoria==0)
                {
                    _repo.Agregar(Categoria);
                }
                else
                {
                    _repo.Editar(Categoria);
                }
            }
            catch (Exception)
            {

                throw;
            } 
        }
    }
}
