using MySql.Data.MySqlClient;
using System.Data;
using Dapper;

namespace UHFReader.DAL
{
    public class BaseDal
    {
        protected IDbConnection GetConnection()
        {
            return new MySqlConnection(DatabaseConfig.ConnectionString);
        }

        protected int Execute(string sql, object param = null)
        {
            using (var conn = GetConnection())
            {
                return conn.Execute(sql, param);
            }
        }

        protected T QueryFirstOrDefault<T>(string sql, object param = null)
        {
            using (var conn = GetConnection())
            {
                return conn.QueryFirstOrDefault<T>(sql, param);
            }
        }

        protected System.Collections.Generic.IEnumerable<T> Query<T>(string sql, object param = null)
        {
            using (var conn = GetConnection())
            {
                return conn.Query<T>(sql, param);
            }
        }
    }
}
