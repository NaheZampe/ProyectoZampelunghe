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
    public class ServicioMedicamentos : IServicioMedicamentos
    {
        private readonly IRepositorioMedicamentos _repo;
        public ServicioMedicamentos()
        {
            _repo = new RepositorioMedicamentos();
        }
        public void Borrar(int IdMedicamento)
        {
            try
            {
                _repo.Borrar(IdMedicamento);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(Medicamentos medicamentos)
        {
            try
            {
                return _repo.Existe(medicamentos);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Medicamentos> GetMedicamentos()
        {
            try
            {
                return _repo.GetMedicamentos();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Guardar(Medicamentos medicamentos)
        {
            try
            {
                if (medicamentos.IdMedicamento==0)
                {
                    _repo.Agregar(medicamentos);
                }
                else
                {
                    _repo.Editar(medicamentos);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
