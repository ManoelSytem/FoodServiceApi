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
        public CardapioController(IJsonAutoMapper jsonAutoMapper)
        {
            _JsonAutoMapper = jsonAutoMapper;
            _CardapioService = new CardapioService();
        }
        // GET: api/<CardapioController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CardapioController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CardapioController>
        [Route("Create")]
        [HttpPost]
        public ActionResultado Post(CardapioModel cardapioModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Cardapio novoCarpio = _JsonAutoMapper.ConvertAutoMapperJson<Cardapio>(cardapioModel);
                    _CardapioService.Adicionar(novoCarpio);
                    return _JsonAutoMapper.Resposta("Cadapio criado com sucesso!");
                }
            }
            catch (Exception e)
            {
                return _JsonAutoMapper.Resposta("Falha!",e);
            }

            return _JsonAutoMapper.Resposta("Contatar Administrador!");
        }

        [HttpPost]
        [Route("CreateListaCardapio")]
        public ActionResultado AddListaItemProduto(ListaModel listaCardapioItemPodutoModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ProdutoNegocio produtoNegocio = new ProdutoNegocio();
                    ListaItemProduto litaItemProduto = _JsonAutoMapper.ConvertAutoMapperJson<ListaItemProduto>(listaCardapioItemPodutoModel);
                    List<ListaItemProduto> ListaCardapio = new List<ListaItemProduto>();
                    produtoNegocio.VerificaListaDeProdutoExiste(listaCardapioItemPodutoModel.ListCodProduto);
                    _CardapioService.CriarListaCardapio(litaItemProduto);
                    return _JsonAutoMapper.Resposta("Lista de cardápio criado com sucesso!");
                }
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
