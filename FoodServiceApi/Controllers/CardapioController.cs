using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplication.Interface;
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
        public BadRequestObjectResult Post(CardapioModel cardapioModel)
        {
            if (ModelState.IsValid)
            {
                Cardapio novoCarpio = _JsonAutoMapper.ConvertAutoMapperJson<Cardapio>(cardapioModel);
                _CardapioService.Adicionar(novoCarpio);
                return BadRequest(ModelState);
            }
            return BadRequest("sucesso");
        }

        // PUT api/<CardapioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CardapioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
