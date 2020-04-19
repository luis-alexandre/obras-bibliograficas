using System.Collections.Generic;

namespace Guide.ObrasLiterarias.Api.Contracts
{
    public class GerarCitacaoRequest
    {
        /// <summary>
        /// Número de autores.
        /// </summary>
        public int NumeroAutores { get; set; }

        /// <summary>
        /// Nome completo dos Autores
        /// </summary>
        public List<string> Autores { get; set; }
    }
}
