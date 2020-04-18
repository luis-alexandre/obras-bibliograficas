using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guide.ObrasLiterarias.Api.Contracts
{
    public class GerarCitacaoRequest
    {
        /// <summary>
        /// Lista de Autores
        /// </summary>
        public List<string> Autores { get; set; }
    }
}
