using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplication.Model;
using Aplication.Servico;
using Aplication.Util;
using Dominio;
using FoodServiceApi.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoodServiceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IJsonAutoMapper _JsonAutoMapper;
        private readonly ProdutoService _ProdutoService;
        public ProdutoController(IJsonAutoMapper JsonAutoMapper)
        {
            _JsonAutoMapper = JsonAutoMapper;
            _ProdutoService = new ProdutoService();
        }
        // GET: api/<ProdutoController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ProdutoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProdutoController>
        [HttpPost]
        [Route("Create")]
        public ActionResultado Post(ProdutoModel produtoModel)
        {
            try
            {
                Produto teste = _JsonAutoMapper.ConvertAutoMapperJson<Produto>(produtoModel);
                if (ModelState.IsValid)
                {
                     Produto produto = _JsonAutoMapper.ConvertAutoMapperJson<Produto>(produtoModel);
                    _ProdutoService.Adicionar(produto);
                    return _JsonAutoMapper.Resposta("Produto criado com sucesso!");
                }
            }
            catch (Exception e)
            {
                return _JsonAutoMapper.Resposta("Falha!", e);
            }

            return _JsonAutoMapper.Resposta("Contatar Administrador!");
        }
 
        // DELETE api/<ProdutoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
