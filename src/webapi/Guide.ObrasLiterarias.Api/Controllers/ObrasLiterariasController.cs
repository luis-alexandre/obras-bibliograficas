using System;
using System.Threading.Tasks;
using Guide.ObrasLiterarias.Api.Contracts;
using Guide.ObrasLiterarias.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Guide.ObrasLiterarias.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObrasLiterariasController : ControllerBase
    {
        private readonly IObraService _obraService;
        public ObrasLiterariasController(IObraService obraService)
        {
            this._obraService = obraService;
        }

        /// <summary>
        /// Gera citacoes a partir de uma lista de autores.
        /// </summary>
        /// <param name="gerarCitacaoRequest">Lista de autores</param>
        /// <returns></returns>
        [HttpPost]
        [Route("citacoes")]
        public async Task<IActionResult> GerarCitacaoAsync([FromBody] GerarCitacaoRequest gerarCitacaoRequest)
        {
            try
            {
                var result = await this._obraService.GerarCitacaoAsync(gerarCitacaoRequest.NumeroAutores, gerarCitacaoRequest.Autores);

                var response = new GerarCitacaoResponse();

                foreach (var item in result)
                {
                    response.Citacoes.Add(new Citacao
                    {
                        Autor = item.Key,
                        AutorCitacao = item.Value
                    });
                }

                return Ok(response);
            }
            catch(ArgumentException ae)
            {
                return BadRequest(ae.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
