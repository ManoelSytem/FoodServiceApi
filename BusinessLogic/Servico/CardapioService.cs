using Aplication.Interface;
using Aplication.Repository;
using Dominio;
using InfraEstrutura.Interface;
using InfraEstrutura.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplication.Servico
{
    public class CardapioService : IDisposable
    {
        UnitOfWork _uow;
        public CardapioService(UnitOfWork uow)
        {
            _uow = uow;
        }

        public CardapioService()
        {
            _uow  = new UnitOfWork();
        }
        public IEnumerable<Cardapio> Listar()
        {
            return _uow.CardapioRepository.Get();
        } 
        public void Adicionar(Cardapio cli)
        {
            _uow.CardapioRepository.Add(cli);
            _uow.Commit();
        }
        public void Excluir(Cardapio cli)
        {
            _uow.CardapioRepository.Delete(cli);
            _uow.Commit();

        }
        public void Alterar(Cardapio cli)
        {
            _uow.CardapioRepository.Update(cli);
            _uow.Commit();
        }

        public void Dispose()
        {
            _uow.Dispose();
        }
    }
}
