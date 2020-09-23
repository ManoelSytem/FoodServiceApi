using BackOfficeFoodService.Models;
using Microsoft.AspNetCore.Mvc;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackOfficeFoodService.Servico
{
    public interface ICardapioServico
    {
        [Post("/Cardapio/Create")]
        Task<ActionResultado> Post(CardapioModel cardapioModel);
        [Get("/Cardapio/GetListCardapio")]
        Task<List<CardapioModel>> GetListCardapioPorCliente(string cliente);
        [Get("/Cardapio/CreateListaCardapio")]
        Task<ActionResultado> PostListCardapio(ListaModel listModel);
    }
}
