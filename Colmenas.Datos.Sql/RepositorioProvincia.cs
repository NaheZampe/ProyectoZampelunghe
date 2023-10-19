using Colmenas.Datos.Comun;
using Colmenas.Entidades;
using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Colmenas.Datos.Sql
{
    public class RepositorioProvincia : IRepositorioProvincia
    {
        private readonly string cadenaConexion;
        public RepositorioProvincia()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }
        public void Agregar(Provincia provincia)
        {
            using (IDbConnection conn = new SqlConnection(cadenaConexion))
            {

                string insertQuery = @"INSERT INTO Provincias (NombreProvincia) 
                            VALUES (@NombreProvincia); SELECT SCOPE_IDENTITY()";
                int id = conn.QuerySingle<int>(insertQuery, provincia);
                provincia.IdProvincia = id;

            }
        }

        public void Borrar(int IdProvincia)
        {
            using (IDbConnection conn = new SqlConnection(cadenaConexion))
            {

                string DeleteQuery = @"DELETE FROM Provincias WHERE IdProvincia=@IdProvincia";
                conn.Execute(DeleteQuery, new { IdProvincia });
            }
        }

        public void Editar(Provincia provincia)
        {
            using (IDbConnection conn = new SqlConnection(cadenaConexion))
            {

                string UpdateQuery = @"UPDATE Provincias SET NombreProvincia=@NombreProvincia
                                        WHERE IdProvincia=@IdProvincia";
                conn.Execute(UpdateQuery, provincia);
            }
        }

        public bool Existe(Provincia provincia)
        {
            var cantidad = 0;
            using (IDbConnection conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (provincia.IdProvincia == 0)
                {
                    selectQuery = "SELECT COUNT(*) FROM Provincias WHERE NombreProvincia=@NombreProvincia";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, provincia);
                }
                else
                {
                    selectQuery = @"SELECT COUNT(*) FROM Provincias WHERE NombreProvincia=@NombreProvincia 
                    AND IdProvincia!=@IdProvincia";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, provincia);
                }
            }
            return cantidad > 0;
        }

        public List<Provincia> GetProvincias()
        {
            using (IDbConnection con = new SqlConnection(cadenaConexion))
            {
                var selectQuery = @"SELECT IdProvincia, NombreProvincia FROM Provincias 
                                    ORDER BY NombreProvincia";
                List<Provincia> lista = con.Query<Provincia>(selectQuery).ToList();
                return lista;
            }
        }
    }
}
