using Colmenas.Datos.Comun;
using Colmenas.Datos.Sql;
using Colmenas.Entidades;
using Colmenas.Servicios.Interfaces;
using System;
using System.Collections.Generic;

namespace Colmenas.Servicios
{
    public class ServicioProvincia : IServicioProvincia
    {
        private readonly IRepositorioProvincia _repo;
        public ServicioProvincia()
        {
            _repo = new RepositorioProvincia();
        }

        public void Borrar(int IdProvincia)
        {
            try
            {
                _repo.Borrar(IdProvincia);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(Provincia prov)
        {
            try
            {
                return _repo.Existe(prov);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Provincia> GetProvincias()
        {
            try
            {
                return _repo.GetProvincias();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Guardar(Provincia provincia)
        {
            try
            {
                if (provincia.IdProvincia == 0)
                {
                    _repo.Agregar(provincia);
                }
                else
                {
                    _repo.Editar(provincia);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
