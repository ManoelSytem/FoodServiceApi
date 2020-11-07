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
    public class ConsumoRepository
    {
        RepositoryGeneric<Consumo> _repositoryGeneric;
        AplicationDbContext _context;
        public ConsumoRepository()
        {
            _context = new AplicationDbContext();
            _repositoryGeneric = new RepositoryGeneric<Consumo>(_context);
        }

        public void Add(Consumo consumo)
        {
            _repositoryGeneric.Add(consumo);
        }
    }
}
