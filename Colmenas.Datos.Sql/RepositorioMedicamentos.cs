using Colmenas.Datos.Comun;
using Colmenas.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Dapper;

namespace Colmenas.Datos.Sql
{
    public class RepositorioMedicamentos : IRepositorioMedicamentos
    {
        private readonly string cadenaConexion;
        public RepositorioMedicamentos()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }
        public void Agregar(Medicamentos medicamentos)
        {
            using (IDbConnection conn = new SqlConnection(cadenaConexion))
            {

                string insertQuery = @"INSERT INTO Medicamentos (Medicamento) 
                            VALUES (@Medicamento); SELECT SCOPE_IDENTITY()";
                int id = conn.QuerySingle<int>(insertQuery, medicamentos);
                medicamentos.IdMedicamento = id;
            }
        }

        public void Borrar(int IdMedicamento)
        {
            using (IDbConnection conn = new SqlConnection(cadenaConexion))
            {
                string DeleteQuery = @"DELETE FROM Medicamentos WHERE IdMedicamento=@IdMedicamento";
                conn.Execute(DeleteQuery, new { IdMedicamento });
            }
        }

        public void Editar(Medicamentos medicamentos)
        {
            using (IDbConnection conn = new SqlConnection(cadenaConexion))
            {
                string UpdateQuery = @"UPDATE Medicamentos SET Medicamento=@Medicamento
                                        WHERE IdMedicamento=@IdMedicamento";
                conn.Execute(UpdateQuery, medicamentos);
            }
        }

        public bool Existe(Medicamentos medicamentos)
        {
            var cantidad = 0;
            using (IDbConnection conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (medicamentos.IdMedicamento == 0)
                {
                    selectQuery = "SELECT COUNT(*) FROM Medicamentos WHERE Medicamento=@Medicamento";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, medicamentos);
                }
                else
                {
                    selectQuery = @"SELECT COUNT(*) FROM Medicamentos WHERE Medicamento=@Medicamento 
                    AND IdMedicamento!=@IdMedicamento";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, medicamentos);
                }
            }
            return cantidad > 0;
        }

        public List<Medicamentos> GetMedicamentos()
        {
            using (IDbConnection con = new SqlConnection(cadenaConexion))
            {
                var selectQuery = @"SELECT IdMedicamento, Medicamento FROM Medicamentos 
                                    ORDER BY Medicamento";
                List<Medicamentos> lista = con.Query<Medicamentos>(selectQuery).ToList();
                return lista;
            }
        }
    }
}
