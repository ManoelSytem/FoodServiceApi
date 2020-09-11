using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackOfficeFoodService.Models;
using BackOfficeFoodService.Servico;
using BackOfficeFoodService.Util;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Refit;

namespace BackOfficeFoodService.Controllers
{
    public class CardapioController : ControllerBase
    {
        // GET: CardapioController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CardapioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CardapioController/Create
        public ActionResult Create()
        {
            var Session = HttpContext.Session.GetObject<Usuario>("Usuario");
            if (Session != null)
            {
                if (HttpContext.Session.GetObject<Usuario>("Usuario").IsAuthenticated)
                {
                    
                    return View();
                }
                else { return RedirectToAction("index", "login"); }
            }
            else
            {
                return RedirectToAction("index", "login");
            }
        }

        // POST: CardapioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CardapioModel collection)
        {
            try
            {
                var IcardapioAPI = RestService.For<ICardapioServico>(Servico.Servico.UrlBase());
                var Session = HttpContext.Session.GetObject<Usuario>("Usuario");
                if (Session != null)
                {
                    if (HttpContext.Session.GetObject<Usuario>("Usuario").IsAuthenticated)
                    {
                        collection.idUser = HttpContext.Session.GetObject<Usuario>("Usuario").Email;
                        var result = await IcardapioAPI.Post(collection);
                    }
                }
                else
                {
                    return RedirectToAction("index", "login");
                }
                return View();
            }
            catch (ApiException ex)
            {
                var jsonToList = JsonExeptionResult.ApiResult(ex);
                SetFlash(Enum.FlashMessageType.Error,jsonToList.description);
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
