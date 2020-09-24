using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;
using Aplication.Interface;
using Aplication.Model;
using Aplication.Negocio;
using Aplication.Servico;
using Aplication.Util;
using Dominio;
using FoodServiceApi.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoodServiceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardapioController : ControllerBase
    {
        private readonly IJsonAutoMapper _JsonAutoMapper;
        private readonly CardapioService _CardapioService;
        public CardapioController(IJsonAutoMapper JsonAutoMapper)
        {
            _JsonAutoMapper = JsonAutoMapper;
            _CardapioService = new CardapioService();
        }
        // GET: api/<CardapioController>
        [HttpGet]
        [Route("GetListCardapio")]
        public List<CardapioModel> Get(string cliente)
        {
            var listCardapio =  _CardapioService.Listar(cliente);
            var listCardapioModel = _JsonAutoMapper.ConvertAutoMapperListJson<CardapioModel>(listCardapio);
            return listCardapioModel;
        }

        // GET api/<CardapioController>/5
        [HttpGet]
        [Route("GetCardapioPorId")]
        public CardapioModel Get(int id)
        {
            var Cardapio = _CardapioService.GetById(id);
            var CardapioModel = _JsonAutoMapper.ConvertAutoMapperJson<CardapioModel>(Cardapio);
            return CardapioModel;
        }

        // POST api/<CardapioController>
        [Route("Create")]
        [HttpPost]
        public ActionResultado Post(CardapioModel cardapioModel)
        {
            try
            {
                    Cardapio novoCarpio = _JsonAutoMapper.ConvertAutoMapperJson<Cardapio>(cardapioModel);
                    _CardapioService.Adicionar(novoCarpio);
                    return _JsonAutoMapper.Resposta("Cadapio criado com sucesso!");
            }
            catch (Exception e)
            {
                return _JsonAutoMapper.Resposta("Falha!",e);
            }
        }

        [HttpPost]
        [Route("CreateListaCardapio")]
        public ActionResultado AddListaItemProduto(ListaModel cardapioMenu)
        {
            try
            {
                    ProdutoNegocio produtoNegocio = new ProdutoNegocio();
                    CardapoNegocio cardapioNegocio = new CardapoNegocio();

                    produtoNegocio.VerificaListaDeProdutoExiste(cardapioMenu.ListCodProduto);
                    var listMenuCardapio  = cardapioNegocio.MontarListaMenuCardapio(cardapioMenu.codigoCardapio, cardapioMenu.titulo, cardapioMenu.descricao, cardapioMenu.ListCodProduto);
                    
                    foreach(ListaItemProduto item in listMenuCardapio)
                    _CardapioService.CriarListaCardapio(item);

                    return _JsonAutoMapper.Resposta("Lista de cardápio criado com sucesso!");
                
            }
            catch (Exception e)
            {
                return _JsonAutoMapper.Resposta("Falha!", e);
            }

            return _JsonAutoMapper.Resposta("Contatar Administrador!");
        }

        // DELETE api/<CardapioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
