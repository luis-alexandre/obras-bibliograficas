using Dapper;
using Guide.ObrasLiterarias.Domain.Entities;
using Microsoft.Data.Sqlite;
using System;
using System.Threading.Tasks;

namespace Guide.ObrasLiterarias.Infra.Infra.SqlLite
{
    public abstract class SqLiteBaseRepository<T> where T: BaseEntity
    {
        private SqliteConnection GetConnection()
        {
            return new SqliteConnection($"Data Source={Environment.GetEnvironmentVariable("databaseFile")}");
        }

        public async Task<int> ExecuteNonQueryAsyc(string sqlCommand, T obj)
        {
            int result = 0;

            using(var connection = GetConnection())
            {
                connection.Open();
                result = await connection.ExecuteAsync(sqlCommand, obj);
            }

            return result;
        }
    }
}
