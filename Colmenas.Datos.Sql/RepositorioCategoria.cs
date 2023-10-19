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
    public class RepositorioCategoria : IRepositorioCategoria
    {
        private readonly string cadenaConexion;
        public RepositorioCategoria()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["Miconexion"].ToString();
        }
        public void Agregar(Categoria categoria)
        {
            using (IDbConnection conn = new SqlConnection(cadenaConexion))
            {
                string insertQuery = @"INSERT INTO Categoria (NombreCategoria, Descripcion) 
                        VALUES (@NombreCategoria, @Descripcion); SELECT SCOPE_IDENTITY()";
                int id = conn.QuerySingle<int>(insertQuery, categoria);
                categoria.IdCategoria = id;
            }
        }

        public void Borrar(int IdCategoria)
        {
            using (IDbConnection conn = new SqlConnection(cadenaConexion))
            {
                string DeleteQuery = @"DELETE FROM Categoria WHERE IdCategoria=@IdCategoria";
                conn.Execute(DeleteQuery, new { IdCategoria });
            }
        }

        public void Editar(Categoria categoria)
        {
            using (IDbConnection conn = new SqlConnection(cadenaConexion))
            {
                string UpdateQuery = @"UPDATE Categoria SET NombreCategoria=@NombreCategoria, 
                                        Descripcion=@Descripcion 
                                        WHERE IdCategoria=@IdCategoria";
                conn.Execute(UpdateQuery, categoria);
            }
        }

        public bool Existe(Categoria categoria)
        {
            var cantidad = 0;
            using (IDbConnection conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (categoria.IdCategoria == 0)
                {
                    selectQuery = "SELECT COUNT(*) FROM Categoria WHERE NombreCategoria=@NombreCategoria";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, categoria);
                }
                else
                {
                    selectQuery = @"SELECT COUNT(*) FROM Categorias WHERE NombreCategoria=@NombreCategoria 
                    AND IdCategoria!=@IdCategoria";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, categoria);
                }
            }
            return cantidad > 0;
        }

        public List<Categoria> GetCategoria()
        {
            using (IDbConnection con = new SqlConnection(cadenaConexion))
            {
                var selectQuery = @"SELECT IdCategoria, NombreCategoria, Descripcion FROM Categoria 
                                    ORDER BY NombreCategoria";
                List<Categoria> lista = con.Query<Categoria>(selectQuery).ToList();
                return lista;
            }
        }
    }
}
