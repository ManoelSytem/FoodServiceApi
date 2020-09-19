using BackOfficeFoodService.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackOfficeFoodService.Servico
{
    public interface IProdutoServico
    {
        [Post("/Produto/Create")]
        Task<ActionResultado> Post(ProdutoModel produtoModel);
        [Get("/Produto/GetListProduto")]
        Task<List<ProdutoModel>> GetListProdutoPorCliente(string cliente);
    }
}
