using Guide.ObrasLiterarias.Domain.Entities;
using System.Threading.Tasks;

namespace Guide.ObrasLiterarias.Domain.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<int> InserirAsync(T item);
    }
}
