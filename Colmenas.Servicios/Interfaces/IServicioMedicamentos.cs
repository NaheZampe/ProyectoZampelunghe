using Colmenas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmenas.Servicios.Interfaces
{
    public interface IServicioMedicamentos
    {
        bool Existe(Medicamentos medicamentos);
        void Borrar(int IdMedicamento);
        List<Medicamentos> GetMedicamentos();
        void Guardar(Medicamentos medicamentos);
    }
}
