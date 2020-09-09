using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackOfficeFoodService.Models;
using BackOfficeFoodService.Servico;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Refit;

namespace BackOfficeFoodService.Controllers
{
    public class CardapioController : Controller
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
            return View();
        }

        // POST: CardapioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CardapioModel collection)
        {
            try
            {
                var IcardapioAPI = RestService.For<ICardapioServico>(Servico.Servico.UrlBase());
                var result = await IcardapioAPI.Post(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
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
