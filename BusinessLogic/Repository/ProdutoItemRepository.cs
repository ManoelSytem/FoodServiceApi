﻿using Dominio;
using InfraEstrutura;
using InfraEstrutura.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Aplication.Repository
{
    public class ProdutoItemRepository : IRepository<ListaItemProduto>
    {
        AplicationDbContext _context;
        public ProdutoItemRepository()
        {
            _context = new AplicationDbContext();
        }
        public void Add(ListaItemProduto entity)
        {
            _context.ListaItemProduto.Add(entity);
        }

        public void Delete(string codMenuSeq)
        {
            (from listMenu in _context.ListaItemProduto
             where listMenu.codMenuSeq == codMenuSeq && listMenu.delete != "1"
             select listMenu).ToList().ForEach(x => x.delete = "1");
            _context.SaveChanges();
        }

        public void Update(string codMenuSeq)
        {
            (from listMenu in _context.ListaItemProduto
             where listMenu.codMenuSeq == codMenuSeq && listMenu.delete != "1"
             select listMenu).ToList().ForEach(x => x.update = "1");
            _context.SaveChanges();
        }

        public string GerarcodMenuSeq()
        {
            int maxCodLista = _context.ListaItemProduto.Max(u => u.codigoLista);

            return Convert.ToString(maxCodLista += 1);
        }


        public List<ListaItemProduto> ObterProdutoClienteAssociadoCardapio(int idProduto, string cliente)
        {
            var listaItemProduto = (from listMenu in _context.Cardapio
                                    join itemProduto in _context.ListaItemProduto on listMenu.idCardapio equals itemProduto.codigoCardapio
                                    where itemProduto.codProduto == idProduto && listMenu.idUser == cliente && itemProduto.delete != "1"
                                    select itemProduto).ToList();
            _context.SaveChanges();

            return listaItemProduto;
        }

        public void Delete(ListaItemProduto entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ListaItemProduto> Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ListaItemProduto> Get(Expression<Func<ListaItemProduto, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public ListaItemProduto GetById(Expression<Func<ListaItemProduto, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public ListaItemProduto GetByIdFind(Expression<Func<ListaItemProduto, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(ListaItemProduto entity)
        {
            _context.Update(entity);
        }
    }
}
