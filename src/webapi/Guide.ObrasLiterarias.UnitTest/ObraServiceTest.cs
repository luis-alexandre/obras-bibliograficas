using Guide.ObrasLiterarias.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Guide.ObrasLiterarias.UnitTest
{
    public class ObraServiceTest
    {
        private const string AUTOR_EXEMPLO = "Luis Alexandre Rodrigues";
        private const string AUTOR_RESULTADO = "RODRIGUES, Luis Alexandre";

        private const string SOBRENOME_EXEMPLO = "Rodrigues";
        private const string SOBRENOME_RESULTADO = "RODRIGUES";

        private const string SOBRENOME_COMPOSTO_EXEMPLO = "Joao Silva Neto";
        private const string SOBRENOME_COMPOSTO_RESULTADO = "SILVA NETO, Joao";

        private const string SOBRENOME_COM_SILABA_EXEMPLO = "João Guimaraes da Silva Filho";
        private const string SOBRENOME_COM_SILABA_RESULTADO = "SILVA FILHO, João Guimaraes da";

        private readonly ObraService _obraService;

        public ObraServiceTest()
        {
            this._obraService = new ObraService();
        }

        [Fact]
        public async Task AutorNomeCompleto_RetornarCitacao()
        {
            var citacao = await this._obraService.GerarCitacaoAsync(1, new List<string>
            {
                AUTOR_EXEMPLO
            });

            Assert.Equal(citacao[AUTOR_EXEMPLO], AUTOR_RESULTADO);
        }

        [Fact]
        public async Task SomenteSobrenome_RetornarSobreNomeMaiusculo()
        {
            var citacao = await this._obraService.GerarCitacaoAsync(1, new List<string>
            {
                SOBRENOME_EXEMPLO
            });

            Assert.Equal(citacao[SOBRENOME_EXEMPLO], SOBRENOME_RESULTADO.ToUpper());
        }

        [Fact]
        public async Task SobrenomeCompost_RetornaSobrenomeCompostoMaiusculo()
        {
            var citacao = await this._obraService.GerarCitacaoAsync(1, new List<string>
            {
                SOBRENOME_COMPOSTO_EXEMPLO
            });

            Assert.Equal(citacao[SOBRENOME_COMPOSTO_EXEMPLO], SOBRENOME_COMPOSTO_RESULTADO);
        }

        [Fact]
        public async Task SobreNomeComSilaba_RetornaSilabaMinuscula()
        {
            var citacao = await this._obraService.GerarCitacaoAsync(1, new List<string>
            {
                SOBRENOME_COM_SILABA_EXEMPLO
            });

            Assert.Equal(citacao[SOBRENOME_COM_SILABA_EXEMPLO], SOBRENOME_COM_SILABA_RESULTADO);
        }

    }
}
