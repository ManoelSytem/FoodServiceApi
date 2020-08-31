using Aplication.Model;
using FoodServiceApi.Model;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTestFoodService.InterfaceApi
{
    public interface InterfaceApiCardapio
    {
        [Post("/api/Cardapio/Create")]
        Task<ActionResultado> CreateCardapioAsync(CardapioModel model);

        [Post("/api/Cardapio/CreateListaCardapio")]
        Task<ActionResultado> CreateListaCardapioAsync(ListaModel model);
    }
}
