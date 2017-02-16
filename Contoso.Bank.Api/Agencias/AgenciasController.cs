

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contoso.Bank.Api.API.Agencias
{
    [Route("[controller")]
    public class AgenciasController : Controller
    {
        private readonly IAgenciaService agenciaService;

        public AgenciasController(IAgenciaService agenciaService)
        {
            this.agenciaService = agenciaService;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Get()
        {
            var agencias = agenciaService.Obter();
            return Ok(agencias);

        }


        [Route("")]
        [HttpGet]
        public IActionResult Create(CriarAgenciaDto dto)
        {
            CriarAgenciaCommand command = new CriarAgenciaCommand
            {
                Codigo = dto.Codigo,
                Cidade = dto.Cidade

            };
            var agencia = agenciaService.Inserir(command);
            return Ok(agencia);

        }
    }
}
