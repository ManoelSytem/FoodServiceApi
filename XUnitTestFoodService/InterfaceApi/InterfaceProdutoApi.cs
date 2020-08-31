using Aplication.Model;
using FoodServiceApi.Model;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTestFoodService.InterfaceApi
{
    public interface InterfaceProdutoApi
    {
        [Post("/api/Produto/Create")]
        Task<ActionResultado> CreateProdutoAsync(ProdutoModel model);
    }
}
