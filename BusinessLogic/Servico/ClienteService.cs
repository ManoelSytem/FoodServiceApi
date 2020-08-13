using Dominio;
using InfraEstrutura.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Servico
{
    public class ClienteService : IDisposable
    {
        UnitOfWork _uow;
        public ClienteService(UnitOfWork uow)
        {
            _uow = uow;
        }

        public ClienteService()
        {
            _uow = new UnitOfWork();
        }

        public IEnumerable<Cliente> ListarClientes()
        {
            return _uow.ClienteRepository.Get();
        }
        public void AdicionarCliente(Cliente cli)
        {
            _uow.ClienteRepository.Add(cli);
            _uow.Commit();
        }
        public void ExcluirCliente(Cliente cli)
        {
            _uow.ClienteRepository.Delete(cli);
            _uow.Commit();
        }
        public void AlterarCliente(Cliente cli)
        {
            _uow.ClienteRepository.Update(cli);
            _uow.Commit();
        }
        public Cliente GetClientePorId(int codigo)
        {
            return _uow.ClienteRepository.GetById(c => c.IdUser == codigo);
        }
        public void Dispose()
        {
            _uow.Dispose();
        }
    }
}
