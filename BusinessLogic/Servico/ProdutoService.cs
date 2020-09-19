﻿using Dominio;
using InfraEstrutura.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplication.Servico
{
    public class ProdutoService : IDisposable
    {
        UnitOfWork _uow;
        public ProdutoService(UnitOfWork uow)
        {
            _uow = uow;
        }

        public ProdutoService()
        {
            _uow = new UnitOfWork();
        }
        public void Adicionar(Produto prod)
        {
            _uow.ProdutoRepository.Add(prod);
            _uow.Commit();
        }

        public IEnumerable<Produto> Listar(string cliente)
        {
            return _uow.ProdutoRepository.Get(p => p.cliente == cliente);
        }

        public void CreateListaPoduto(ListaItemProduto listaItemProduto)
        {
             _uow.ProdutoItemRepository.Add(listaItemProduto);
             _uow.Commit();
        }

        public Produto ObterProdutoPorId(int codigoProduto)
        {
           return  _uow.ProdutoRepository.GetById(p => p.codigo == codigoProduto);
        }

        public void Dispose()
        {
            _uow.Dispose();
        }
    }
}
