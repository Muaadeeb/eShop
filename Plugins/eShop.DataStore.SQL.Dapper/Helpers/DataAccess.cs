using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eShop.DataStore.SQL.Dapper.Helpers
{
    public class DataAccess : IDataAccess
    {
        private readonly string _connectionString;

        public DataAccess(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<T> Query<T, U>(string sql, U parameters)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                return conn.Query<T>(sql, parameters).ToList();
            }
        }

        public T QuerySingle<T, U>(string sql, U parameters)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                return conn.QuerySingle<T>(sql, parameters);
            }
        }

        public void ExecuteCommand<T>(string sql, T parameters)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Execute(sql, parameters);
            }
        }
    }
}