using Guide.ObrasLiterarias.Domain.Services;
using System;
using System.Collections.Generic;

namespace Guide.ObrasLiterarias.Services
{
    public class ObraService : IObraService
    {
        public Dictionary<string, string> GerarCitacao(List<string> Autores)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();

            foreach (var item in Autores)
            {
                result.Add(item, $"Teste com o Autor {item}");
            }

            return result;
        }
    }
}
