using Dominio;
using InfraEstrutura;
using InfraEstrutura.Interface;
using InfraEstrutura.Repository;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Aplication.Repository
{
    public class ContaRepository
    { 
        RepositoryGeneric<Conta> _repositoryGeneric;
        AplicationDbContext _context;
        public ContaRepository()
        {
            _context = new AplicationDbContext();
            _repositoryGeneric = new RepositoryGeneric<Conta>(_context);
        }

        public void Add(Conta conta)
        {
            _repositoryGeneric.Add(conta);
        }
     
    }
}
