using Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfraEstrutura.Interface
{
    public interface IUnitOfWork
    {
        IRepository<Cliente> ClienteRepository { get; }
        void Commit();
    }
}
