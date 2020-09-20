using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackOfficeFoodService.Models;
using BackOfficeFoodService.Servico;
using BackOfficeFoodService.Util;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Refit;

namespace BackOfficeFoodService.Controllers
{
    public class CardapioController : ControllerBase
    {
        // GET: CardapioController
        public async Task<ActionResult> Index()
        {
            return View();
        }

        // GET: CardapioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CardapioController/Create
        public async Task<ActionResult> Create()
        {
            try
            {
                if (AutenticanteVerifiy())
                {
                    var email = HttpContext.Session.GetObject<Usuario>("Usuario").Email;
                    var ICardapio = RestService.For<ICardapioServico>(Servico.Servico.UrlBaseFoodService());
                    var result = await ICardapio.GetListCardapioPorCliente(email);
                    var cardapioModel = new CardapioModel
                    {
                        ListCardapio = result
                    };
                    return View(cardapioModel);
                }
                else { return RedirectToAction("index", "login"); }
            }
            catch (Exception ex)
            {
                SetFlash(Enum.FlashMessageType.Error, ex.Message);
                return View();
            }
        }

        public async Task<ActionResult> MenuListCardapio(string codcardapio)
        {
            var email = HttpContext.Session.GetObject<Usuario>("Usuario").Email;
            var IProduto = RestService.For<IProdutoServico>(Servico.Servico.UrlBaseFoodService());
            var listProduto = await IProduto.GetListProdutoPorCliente(email);
            ViewBag.ProdutoList = new MultiSelectList(listProduto, "codigo", "nome");
            return View();
        }

        // POST: CardapioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CardapioModel collection)
        {
            try
            {
                if (AutenticanteVerifiy())
                {
                    var IcardapioAPI = RestService.For<ICardapioServico>(Servico.Servico.UrlBaseFoodService());
                    collection.idUser = HttpContext.Session.GetObject<Usuario>("Usuario").Email;
                    var result = await IcardapioAPI.Post(collection);
                    SetFlash(Enum.FlashMessageType.Success, result.Message);
                    return View();
                }
                return View();
            }
            catch (Exception ex)
            {
                SetFlash(Enum.FlashMessageType.Error, ex.Message);
                return View();
            }
        }

        // GET: CardapioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CardapioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CardapioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CardapioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
