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
        [Post("/Cardapio/CreateListaCardapio")]
        Task<ActionResult> CreateListaCardapio(ListaModel listaModel);
        [Get("/Cardapio/GetListCardapio")]
        Task<List<CardapioModel>> GetListCardapioPorCliente(string cliente);
    }
}
