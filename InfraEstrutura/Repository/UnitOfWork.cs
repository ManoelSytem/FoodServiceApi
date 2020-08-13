using Dominio;
using InfraEstrutura.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfraEstrutura.Repository
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        public AplicationDbContext _context;
        private Repository<Cliente> _clienteRepository;
        public UnitOfWork(AplicationDbContext context)
        {
            _context = context;
        }
        public UnitOfWork()
        {
            _context = new AplicationDbContext();
        }
        public IRepository<Cliente> ClienteRepository
        {
            get
            {
                return _clienteRepository = _clienteRepository ?? new Repository<Cliente>(_context);
            }
        }
        public void Commit()
        {
            _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
