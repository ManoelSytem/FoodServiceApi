using Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplication.Interface
{
    public interface IContaRepository
    {
        public void Add(Conta conta);
        public Conta ObterContaPendente(string seqAbreMesa);
        public IEnumerable<FormaPagamento> ObterListaFormaPagamento();
    }
}
