using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplication.Enum;
using Aplication.Model;
using Aplication.Repository;
using Aplication.Util;
using Dominio;
using FoodServiceApi.Model;
using Microsoft.AspNetCore.Mvc;


namespace FoodServiceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MesaController : ControllerBase
    {
        private  MesaRepository _MesaRepository;
        private ConsumoRepository _ConsumoRepository;
        private readonly IJsonAutoMapper _JsonAutoMapper;
        public MesaController(IJsonAutoMapper jsonAutoMapper)
        {
            _JsonAutoMapper = jsonAutoMapper;
            _MesaRepository = new MesaRepository();
        }

        [Route("Create")]
        [HttpPost]
        public ActionResultado Post(MesaModel mesaModel)
        {
            try
            {
                Mesa mesa = _JsonAutoMapper.ConvertAutoMapperJson<Mesa>(mesaModel);
                mesa.status = StatusMesa.Fechado.Value;
                _MesaRepository.Add(mesa);
                return _JsonAutoMapper.Resposta("Mesa criada com sucesso");
            }
            catch (Exception e)
            {
                return _JsonAutoMapper.Resposta("Falha!", e);
            }
        }



        [HttpGet]
        [Route("ObterListaMesa")]
        public List<MesaModel> ObterListaMesa()
        {
            var listMesa = _MesaRepository.GetAll();
            var listaMesaModel = _JsonAutoMapper.ConvertAutoMapperListJson<MesaModel>(listMesa);
            return listaMesaModel;
        }

        [Route("AdicionaConsumoMesa")]
        [HttpPost]
        public ActionResultado AdicionaConsumoMesa(ConsumoModel consumoModel)
        {
            try
            {
                Consumo consumo = _JsonAutoMapper.ConvertAutoMapperJson<Consumo>(consumoModel);
                consumo.horaPedido = DateTime.Now;

                _ConsumoRepository = new ConsumoRepository();
                _ConsumoRepository.Add(consumo);
                return _JsonAutoMapper.Resposta("Item adicionado com sucesso");
            }
            catch (Exception e)
            {
                return _JsonAutoMapper.Resposta("Falha!", e);
            }
        }

        [HttpPost]
        [Route("Edit")]
        public ActionResultado Edit(Mesa mesaModel)
        {
            try
            {
                Mesa mesa = _JsonAutoMapper.ConvertAutoMapperJson<Mesa>(mesaModel);
                return _JsonAutoMapper.Resposta("Mesa alterada com sucesso!");
            }
            catch (Exception e)
            {
                return _JsonAutoMapper.Resposta("Falha!", e);
            }

            return _JsonAutoMapper.Resposta("Contatar Administrador!");
        }

    }
}
