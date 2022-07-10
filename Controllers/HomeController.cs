using Intro.Models;
using Intro.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Intro.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RandomService _randomService;
        private readonly IHasher _hasher;
        private readonly DAL.Context.IntroContext _introContext;

        public HomeController(              // Внедрение зависимостей
            ILogger<HomeController> logger, // через конструктор
            RandomService randomService,
            IHasher hasher,
            DAL.Context.IntroContext introContext)  
        {
            _logger = logger;
            _randomService = randomService;
            _hasher = hasher;
            _introContext = introContext;
        }

        public IActionResult Index()
        {
            ViewData["rnd"] = "<b>" + _randomService.Integer + "</b>";
            ViewBag.hash = _hasher.Hash("123");
            ViewData["UsersCount"] = _introContext.Users.Count();
            ViewBag.userNames = _introContext.Users.Select(user => user.RealName);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            var model = new AboutModel
            {
                Data = "The Model Data"
            };
            return View(model);
        }

        public IActionResult Data()
        {
            return Json(new { field = "value" });
        }

        public IActionResult Contacts()
        {
            var model = new ContactsModel();
            model.Phone = "123131231";
            model.Name = "ddd";
            model.Adress = "wddadsda";

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(
                new ErrorViewModel { 
                    RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier 
                });
        }
    }
}
/*
 * Д.З. Вывести на стартовой странице всех
 * зарегистрированных в БД пользователей (только RealName)
 */