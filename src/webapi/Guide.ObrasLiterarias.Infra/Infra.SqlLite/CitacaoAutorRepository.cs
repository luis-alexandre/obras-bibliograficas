using Guide.ObrasLiterarias.Domain.Entities;
using Guide.ObrasLiterarias.Domain.Repository;
using System.Threading.Tasks;

namespace Guide.ObrasLiterarias.Infra.Infra.SqlLite
{
    public class CitacaoAutorRepository : SqLiteBaseRepository<CitacaoAutor>, ICitacaoAutorRepository
    {
        public async Task<int> InserirAsync(CitacaoAutor item)
        {
            string sqlCommand = @"INSERT INTO CitacaoAutor (Id, Autor, Citacao)
                                  VALUES (@Id, @Autor, @Citacao)";

            var result = await ExecuteNonQueryAsyc(sqlCommand, item);
            return result;
        }
    }
}
