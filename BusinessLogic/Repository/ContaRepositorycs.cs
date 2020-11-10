using Aplication.Interface;
using Dominio;
using InfraEstrutura;
using InfraEstrutura.Interface;
using InfraEstrutura.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Aplication.Repository
{
    public class ContaRepository : IContaRepository
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

        public Conta ObterContaPendente(string seqAbreMesa)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FormaPagamento> ObterListaFormaPagamento()
        {
            return _context.FormaPagamento.ToList();
        }
    }
}
