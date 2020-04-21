using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Guide.ObrasLiterarias.Api.Contracts;
using Guide.ObrasLiterarias.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Guide.ObrasLiterarias.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObrasLiterariasController : ControllerBase
    {
        private readonly IObraService _obraService;
        private readonly ILogger<ObrasLiterariasController> _logger;

        public ObrasLiterariasController(IObraService obraService, ILogger<ObrasLiterariasController> logger)
        {
            this._logger = logger;
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

                var response = new List<Citacao>();

                foreach (var item in result)
                {
                    response.Add(new Citacao
                    {
                        Autor = item.Key,
                        AutorCitacao = item.Value
                    });
                }

                return Ok(response);
            }
            catch(ArgumentException ae)
            {
                _logger.LogError(ae.ToString());
                return BadRequest(ae.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return StatusCode(500, ex.Message);
            }
        }
    }
}
