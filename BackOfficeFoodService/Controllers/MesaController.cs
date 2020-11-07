using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackOfficeFoodService.Models;
using BackOfficeFoodService.Servico;
using Microsoft.AspNetCore.Mvc;
using Refit;

namespace BackOfficeFoodService.Controllers
{
    public class MesaController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }


        public async Task<IActionResult>  Create(MesaModel collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (AutenticanteVerifiy())
                    {
                        var IMesaService = RestService.For<IMesaService>(Servico.Servico.UrlBaseFoodService());
                        var result = await IMesaService.Post(collection);
                        SetFlash(Enum.FlashMessageType.Success, result.Message);
                        return RedirectToAction("index");
                    }
                }
                return View();
            }
            catch (Exception ex)
            {
                SetFlash(Enum.FlashMessageType.Error, ex.Message);
                return RedirectToAction("index");
            }
        }

        public async Task<IActionResult> GerenciaMesa()
        {
            var IMesaService = RestService.For<IMesaService>(Servico.Servico.UrlBaseFoodService());
            var result = await IMesaService.ObterListaMesa();
            return View(result);
        }

        public IActionResult MesaConsumo(int codigo, int numeroMesa)
        {
            TempData["codigo"] = codigo;
            TempData["numeroMesa"] = numeroMesa;
            return View();
        }


        public async Task<IActionResult> AdicionarConsumoMesa(string codMesa, string codProduto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (AutenticanteVerifiy())
                    {

                        var itemConsumo = new ConsumoModel
                        {
                            codMesa = codMesa,
                            codProduto = codProduto
                        };

                        var IMesaService = RestService.For<IMesaService>(Servico.Servico.UrlBaseFoodService());
                        var result = await IMesaService.AdicionaConsumoMesa(itemConsumo);
                        SetFlash(Enum.FlashMessageType.Success, result.Message);
                        return RedirectToAction("index");
                    }
                }
                return View();
            }
            catch (Exception ex)
            {
                SetFlash(Enum.FlashMessageType.Error, ex.Message);
                return RedirectToAction("index");
            }
        }
    }
}
