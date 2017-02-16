using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contoso.Bank.Model.Agencias
{
    public class Agencia
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Cidade { get; set; }

        public DateTimeOffset CriadoEm { get; set; }
        public DateTimeOffset? AlteradoEm { get; set; }

    }
}
