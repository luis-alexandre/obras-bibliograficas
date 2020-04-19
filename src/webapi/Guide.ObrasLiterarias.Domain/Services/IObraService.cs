using System.Collections.Generic;
using System.Threading.Tasks;

namespace Guide.ObrasLiterarias.Domain.Services
{
    public interface IObraService
    {
        Task<Dictionary<string, string>> GerarCitacaoAsync(int numeroAutores, List<string> autores);
    }
}
