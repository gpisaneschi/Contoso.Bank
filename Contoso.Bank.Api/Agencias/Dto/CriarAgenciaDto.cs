using System;
using System.ComponentModel.DataAnnotations;

namespace Contoso.Bank.Api.API.Agencias
{
    public class CriarAgenciaDto
    {
        [Required, MinLength(5), MaxLength(10)]
        public string Codigo { get; set; }

        [Required, MinLength(3), MaxLength(50)]
        public string Cidade { get; set; }
    }
}