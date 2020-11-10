﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using BackOfficeFoodService.Models;
using BackOfficeFoodService.Servico;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Refit;

namespace BackOfficeFoodService.Controllers
{
    public class CaixaController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> CupomNaoFiscal(string seqAbreMesa)
        {
            if (ModelState.IsValid)
            {
                if (AutenticanteVerifiy())
                {
                  
                    var ICliente = RestService.For<IClienteServico>(Servico.Servico.UrlBaseFoodService());
                    var email = HttpContext.Session.GetObject<Usuario>("Usuario").Email;
                    var dadosEmpresaCleinte =  await ICliente.ObterClientePorEmail(email);

                    var IMesaService = RestService.For<IMesaService>(Servico.Servico.UrlBaseFoodService());
                    var consumoModel = await IMesaService.ObterConsumoDaMesa(seqAbreMesa,true);

                    CupomNaoFiscalModel cupomNaoFiscalModel = new CupomNaoFiscalModel();
                    cupomNaoFiscalModel.cliente = dadosEmpresaCleinte;
                    cupomNaoFiscalModel.consumoModel = consumoModel;

                    TempData["SeqAbreMesa"] = seqAbreMesa;
                    return View(cupomNaoFiscalModel);
                }
            }
            return View();
        }
        public async Task<IActionResult> ContaAReceber()
        {
            try
            {
                var ICaixa = RestService.For<ICaixaService>(Servico.Servico.UrlBaseFoodService());
                var listaFormaPgto = await ICaixa.ObterListaPagamento();
                ViewBag.FormaPagamento = new SelectList(listaFormaPgto, "codigo", "descricao");
                return View();

            }
            catch (Exception ex)
            {
                SetFlash(Enum.FlashMessageType.Error, ex.Message);
                return View();
            }

        }


    }
}
