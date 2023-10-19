using Colmenas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmenas.Datos.Comun
{
    public interface IRepositorioMedicamentos
    {
        List<Medicamentos> GetMedicamentos();
        void Agregar(Medicamentos medicamentos);
        void Borrar(int IdMedicamento);
        void Editar(Medicamentos medicamentos);
        bool Existe(Medicamentos medicamentos);
    }
}
