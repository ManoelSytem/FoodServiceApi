﻿using Aplication.Interface;
using Dominio;
using InfraEstrutura;
using InfraEstrutura.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Aplication.Repository
{
    public class ProdutoRepository : IRepository<Produto>, IProduto
    {
        AplicationDbContext _context;
        public ProdutoRepository(AplicationDbContext context)
        {
            _context = context;
        }
        public void Add(Produto entity)
        {
            _context.Produto.Add(entity);
        }
        public Produto GetById(int codigoProduto)
        {
            return _context.Produto.Where(p => p.codigo == codigoProduto).OrderBy(c => c.codigo).Single();
        }
        public void Delete(Produto entity)
        {
            throw new NotImplementedException();
        }
      
        public IEnumerable<Produto> Get()
        {
            throw new NotImplementedException();
        }
        public void Update(Produto entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Produto> Get(Expression<Func<Produto, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Produto GetById(Expression<Func<Produto, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
