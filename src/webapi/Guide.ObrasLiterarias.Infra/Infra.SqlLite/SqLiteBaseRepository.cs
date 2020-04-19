using Dapper;
using Guide.ObrasLiterarias.Domain.Entities;
using Microsoft.Data.Sqlite;
using System.Threading.Tasks;

namespace Guide.ObrasLiterarias.Infra.Infra.SqlLite
{
    public abstract class SqLiteBaseRepository<T> where T: BaseEntity
    {
        private SqliteConnection GetConnection()
        {
            return new SqliteConnection("Data Source=:memory:");
        }

        public async Task<int> ExecuteNonQueryAsyc(string sqlCommand, T obj)
        {
            int result = 0;

            var tableName = obj.GetType().Name;

            using(var connection = GetConnection())
            {
                connection.Open();

                await connection.ExecuteAsync($"CREATE TABLE IF NOT EXISTS [{tableName}]" + @"(
                                                    [Id] NVARCHAR(128) NOT NULL PRIMARY KEY,
                                                    [Autor] NVARCHAR(128) NOT NULL,
                                                    [Citacao] NVARCHAR(128) NULL
                                                )");

                result = await connection.ExecuteAsync(sqlCommand, obj);
            }

            return result;
        }
    }
}
