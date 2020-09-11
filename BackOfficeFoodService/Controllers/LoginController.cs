﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackOfficeFoodService.Models;
using BackOfficeFoodService.Servico;
using BackOfficeFoodService.Util;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Refit;

namespace BackOfficeFoodService.Controllers
{
    public class LoginController : ControllerBase
    {
        // GET: LoginController
        public ActionResult Index()
        {
            return View();
        }

        // GET: LoginController/Details/5
        [HttpPost]
        public async Task<ActionResult> Login(LoginModel collection)
        {
            try
            {
              
                var loginAPI = RestService.For<ILoginAPI>(Servico.Servico.UrlBase());
                Token token = await loginAPI.PostCredentials(collection);
                if (token != null)
                {
                    if (Convert.ToBoolean(token.authenticated))
                    {
                        var usuario = await loginAPI.Get();
                        HttpContext.Session.SetObject<Usuario>("Usuario", usuario);
                        HttpContext.Session.SetObject<Token>("Token", token);
                    }
                }
                return View();
            }
            catch (ApiException ex)
            {
                var jsonToList = JsonExeptionResult.ApiResult(ex);
                SetFlash(Enum.FlashMessageType.Error, "flashMensagemText");
                return RedirectToAction(nameof(Index));
            }

        }

        // GET: LoginController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoginController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(LoginModel collection)
        {
            try
            {
                var loginAPI = RestService.For<ILoginAPI>(Servico.Servico.UrlBase());
                Token token = await loginAPI.RegisterUser(collection);
                return RedirectToAction(nameof(Index));
            }
            catch (ApiException ex)
            {
                var jsonToList = JsonExeptionResult.ApiResult(ex);
                return View();
            }
        }

        // GET: LoginController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LoginController/Edit/5
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

        // GET: LoginController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LoginController/Delete/5
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
