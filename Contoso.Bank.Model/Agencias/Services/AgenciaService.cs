using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contoso.Bank.Model.Agencias.Services
{
    public interface IAgenciaService
    {
        IEnumerable<Agencia> Obter();
        Agencia Inserir(CriarAgenciaCommand command);
        Agencia Atualizar(AtualizarAgenciaCommand command);
        void Remover(RemoverAgenciaCommand command);
    }

    public class AgenciaService : IAgenciaService
    {
        public Agencia Atualizar(AtualizarAgenciaCommand command)
        {
            throw new NotImplementedException();
        }

        public Agencia Inserir(CriarAgenciaCommand command)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Agencia> Obter()
        {
            throw new NotImplementedException();
        }

        public void Remover(RemoverAgenciaCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
