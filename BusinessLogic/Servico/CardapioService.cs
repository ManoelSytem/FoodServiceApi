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
    public class CardapioService : IDisposable, ICardapio
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
        public void Adicionar(Cardapio card)
        {
            _uow.CardapioRepository.Add(card);
            _uow.Commit();
        }
        public void CriarListaCardapio(ListaItemProduto listaItemProduto)
        {
            _uow.ProdutoItemRepository.Add(listaItemProduto);
        }
        public void Excluir(Cardapio card)
        {
            _uow.CardapioRepository.Delete(card);
            _uow.Commit();

        }
        public void Alterar(Cardapio card)
        {
            _uow.CardapioRepository.Update(card);
            _uow.Commit();
        }
        public IEnumerable<Cardapio> Listar(string cliente)
        {
            return _uow.CardapioRepository.Get(p => p.idUser == cliente);
        }


        public void Dispose()
        {
            _uow.Dispose();
        }

       
    }
}
