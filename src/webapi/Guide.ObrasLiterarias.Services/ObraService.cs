using Guide.ObrasLiterarias.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Guide.ObrasLiterarias.Services
{
    public class ObraService : IObraService
    {
        private List<string> _excecoes;

        public ObraService()
        {
            this._excecoes = new List<string>();
            CarregarExcecoes();
        }

        public async Task<Dictionary<string, string>> GerarCitacaoAsync(int numeroAutores, List<string> autores)
        {
            if (numeroAutores != autores.Count)
            {
                throw new ArgumentException("Número de autores não corresponde com a quantidade informada.");
            }

            Dictionary<string, string> result = new Dictionary<string, string>();

            foreach (var item in autores)
            {
                var citacao = ObterCitacao(item);
                result.Add(item, citacao);
            }

            return result;
        }

        private string ObterCitacao(string autorNome)
        {
            StringBuilder citacao = new StringBuilder();

            var nomes = autorNome.Split(' ');
            citacao.Append(nomes[nomes.Length - 1].ToUpper());

            if (nomes.Length > 1)
            {
                citacao.Append(",");

                for (int i = 0; i < nomes.Length - 1; i++)
                {
                    if (!this._excecoes.Contains(nomes[i]))
                    {
                        nomes[i] = char.ToUpper(nomes[i][0]) + nomes[i].Substring(1).ToLower();
                        citacao.Append($" {nomes[i]}");
                    }
                    else
                    {
                        citacao.Append($" {nomes[i].ToLower()}");
                    }
                }
            }

            return citacao.ToString();
        }

        private void CarregarExcecoes()
        {
            this._excecoes = new List<string>()
            {
                "da",
                "de",
                "do",
                "das",
                "dos"
            };
        }
    }
}
