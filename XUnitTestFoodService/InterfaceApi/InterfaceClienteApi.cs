using Aplication.Model;
using Dominio;
using FoodServiceApi.Model;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTestFoodService.InterfaceApi
{
    public interface InterfaceClienteApi
    {
        [Post("/api/Cliente/Create")]
        Task<ActionResultado> CreateClienteAsync(ClienteModel model);
    }
}
