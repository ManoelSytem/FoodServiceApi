using Dominio;
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
             where listMenu.codMenuSeq == codMenuSeq
             select listMenu).ToList().ForEach(x => x.delete = "1");
            _context.SaveChanges();
        }

        public string GerarcodMenuSeq()
        {
            int maxCodLista = _context.ListaItemProduto.Max(u => u.codigoLista);

            return Convert.ToString(maxCodLista += 1);
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
