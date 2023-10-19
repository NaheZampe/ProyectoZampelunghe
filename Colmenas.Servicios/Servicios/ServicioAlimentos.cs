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
    public class ServicioAlimentos : IServicioAlimentos
    {
        private readonly IRepositorioAlimentos _repo;
        public ServicioAlimentos()
        {
            _repo= new RepositorioAlimentos();
        }
        public void Borrar(int IdAlimento)
        {
            try
            {
                _repo.Borrar(IdAlimento);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(Alimentos alimentos)
        {
            try
            {
                return _repo.Equals(alimentos);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public List<Alimentos> GetAlimentos()
        {
            try
            {
                return _repo.GetAlimentos();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Guardar(Alimentos alimentos)
        {
            try
            {
                if (alimentos.IdAlimento == 0)
                {
                    _repo.Agregar(alimentos);
                }
                else
                {
                    _repo.Editar(alimentos);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
