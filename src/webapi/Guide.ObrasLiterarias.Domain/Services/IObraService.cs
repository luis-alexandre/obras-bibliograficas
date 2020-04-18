using System;
using System.Collections.Generic;
using System.Text;

namespace Guide.ObrasLiterarias.Domain.Services
{
    public interface IObraService
    {
        Dictionary<string, string> GerarCitacao(List<string> Autores);
    }
}
