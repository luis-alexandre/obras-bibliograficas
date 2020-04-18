using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guide.ObrasLiterarias.Api.Contracts
{
    public class GerarCitacaoResponse
    {
        public List<Citacao> Citacoes { get; set; } = new List<Citacao>();
    }

    public class Citacao
    {
        public string Autor { get; set; }

        public string AutorCitacao { get; set; }
    }
}
