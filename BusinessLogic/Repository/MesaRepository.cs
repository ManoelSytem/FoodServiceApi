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
    public class MesaRepository 
    {
        RepositoryGeneric<Mesa> _repositoryGeneric;
        AplicationDbContext _context;
        public MesaRepository()
        {
            _context = new AplicationDbContext();
            _repositoryGeneric = new RepositoryGeneric<Mesa>(_context);
        }

        public void Add(Mesa mesa)
        {
            _repositoryGeneric.Add(mesa);
        }

        public IEnumerable<Mesa> GetAll()
        {
           return _repositoryGeneric.Get();
        }

        public void edit(Mesa mesa)
        {
            _repositoryGeneric.Update(mesa);
        }
        
    }
}
