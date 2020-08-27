using Dominio;
using InfraEstrutura;
using InfraEstrutura.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Aplication.Repository
{
    public class ProdutoItemRepository : IRepository<ListaItemProduto>
    {
        AplicationDbContext _context;
        public ProdutoItemRepository(AplicationDbContext context)
        {
            _context = context;
        }
        public void Add(ListaItemProduto entity)
        {
            throw new NotImplementedException();
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

        public void Update(ListaItemProduto entity)
        {
            throw new NotImplementedException();
        }
    }
}
