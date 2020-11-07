using BackOfficeFoodService.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackOfficeFoodService.Servico
{
    public interface IMesaService
    {
        [Post("/Mesa/Create")]
        Task<ActionResultado> Post(MesaModel mesaModel);
        [Post("/Mesa/AdicionaConsumoMesa")]
        Task<ActionResultado> AdicionaConsumoMesa(ConsumoModel ConsumoModel);
        [Get("/Mesa/ObterListaMesa")]
        Task<List<MesaModel>> ObterListaMesa();

    }
}
