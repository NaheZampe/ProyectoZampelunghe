using Colmenas.Datos.Comun;
using Colmenas.Entidades;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Colmenas.Datos.Sql
{
    public class RepositorioAlimentos : IRepositorioAlimentos
    {
        private readonly string cadenaConexion;
        public RepositorioAlimentos()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }
        public void Agregar(Alimentos alimento)
        {
            using (IDbConnection conn = new SqlConnection(cadenaConexion))
            {

                string insertQuery = @"INSERT INTO Alimentos (Alimento) 
                            VALUES (@Alimento); SELECT SCOPE_IDENTITY()";
                int id = conn.QuerySingle<int>(insertQuery, alimento);
                alimento.IdAlimento = id;

            }
        }

        public void Borrar(int IdAlimento)
        {
            using (IDbConnection conn = new SqlConnection(cadenaConexion))
            {

                string DeleteQuery = @"DELETE FROM Alimentos WHERE IdAlimento=@IdAlimento";
                conn.Execute(DeleteQuery, new { IdAlimento });
            }
        }

        public void Editar(Alimentos alimentos)
        {
            using (IDbConnection conn = new SqlConnection(cadenaConexion))
            {
                string UpdateQuery = @"UPDATE Alimentos SET Alimento=@Alimento
                                        WHERE IdAlimento=@IdAlimento";
                conn.Execute(UpdateQuery, alimentos);
            }
        }

        public bool Existe(Alimentos alimentos)
        {
            var cantidad = 0;
            using (IDbConnection conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (alimentos.IdAlimento == 0)
                {
                    selectQuery = "SELECT COUNT(*) FROM Alimentos WHERE Alimento=@Alimento";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, alimentos);
                }
                else
                {
                    selectQuery = @"SELECT COUNT(*) FROM Alimentos WHERE Alimento=@Alimento 
                    AND IdAlimento!=@IdAlimento";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, alimentos);
                }
            }
            return cantidad > 0;
        }

        public List<Alimentos> GetAlimentos()
        {
            using (IDbConnection con = new SqlConnection(cadenaConexion))
            {
                var selectQuery = @"SELECT IdAlimento, Alimento FROM Alimentos 
                                    ORDER BY Alimento";
                List<Alimentos> lista = con.Query<Alimentos>(selectQuery).ToList();
                return lista;
            }
        }
    }
}
