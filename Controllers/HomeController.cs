using Intro.Models;
using Intro.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Intro.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RandomService _randomService;
        private readonly IHasher _hasher;
        private readonly IDateTimeSeparated _dateTimeSeparated;
        private readonly DAL.Context.IntroContext _introContext;

        public HomeController(ILogger<HomeController> logger,
            RandomService randomService,
            IHasher hasher,
            IDateTimeSeparated dateTimeSeparated,
            DAL.Context.IntroContext introContext)
        {
            _logger = logger;
            _randomService = randomService;
            _hasher = hasher;
            _dateTimeSeparated = dateTimeSeparated;
            _introContext = introContext;
        }

        public ViewResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegUser(Models.RegUserModel UserData)
        {
            //return Json(UserData);
            string[] err = new string[6];
            string[] inputValues = new string[3];

            inputValues[0] = UserData.RealName;
            inputValues[1] = UserData.Login;
            inputValues[2] = UserData.Email;

            if (UserData == null)
            {
                err[0] = ("Некорректный вызов");
            }
            else
            {
                if (String.IsNullOrEmpty(UserData.RealName))
                {
                    err[1] = "Имя не может быть пустым";
                }
                if (String.IsNullOrEmpty(UserData.Login))
                {
                    err[2] = "Логин не может быть пустым";
                }
                if (String.IsNullOrEmpty(UserData.Password1))
                {
                    err[3] = "Первый пароль не может быть пустым";
                }
                if (String.IsNullOrEmpty(UserData.Password2))
                {
                    err[4] = "Второй пароль не может быть пустым";
                }
                if (String.IsNullOrEmpty(UserData.Email))
                {
                    err[5] = "Эмэйл не может быть пустым";
                }
            }
            ViewData["err"] = err;
            ViewData["inputValues"] = inputValues;
            return View("Register");
        }

        public IActionResult Index()
        {
            ViewData["rnd"] = _randomService.Integer;
            ViewBag.hash = _hasher.Hash("123");
            ViewData["UsersCount"] = _introContext.Users.Count();

            ViewBag.date = _dateTimeSeparated.Date();
            ViewBag.time = _dateTimeSeparated.Time();

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
                Data = "Data"
            };

            return View(model);
        }

        public IActionResult Contacts()
        {
            //создание объекта данные которого используются в View
            var model = new ContactsModel
            {
                Adress = "221b Baker Street",
                Phone = "+44 1632 960729",
                Name = "Sherlock Holmes Investigation Bureau"
            };

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
