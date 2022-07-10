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

        public ViewResult Register()
        {

            return View();
        }

        [HttpPost]  // Следующий метод срабатывает только на POST-запрос
        // Метод может автоматически собрать все переданные данные в модель
        //  по совпадению имен
        public IActionResult RegUser(Models.RegUserModel UserData)
        {
            // return Json(UserData);  // способ проверить передачу данных
            String[] err = new String[6];

            if (UserData == null)
            {
                err[0] = "Некорректный вызов (нет данных)";
            }
            else
            {
                if (String.IsNullOrEmpty(UserData.Login))
                {
                    err[2] = "Логин не может быть пустым";
                }
                if (String.IsNullOrEmpty(UserData.Email))
                {
                    err[5] = "Email не может быть пустым";
                }

                var currentImgName = UserData.Avatar?.FileName;
                if ( UserData.Avatar != null )  // есть переданный файл
                {
                    // файл нужно сохранить в нужном месте.
                    // для простоты доступа - в папку wwwroot/img
                    // !! крайне НЕ рекомендуется сохранять имя переданного файла
                    //  - возможен конфликт, если разные пользователи -- одно имя
                    //  - уязвимость - если в имени файла есть ../

                    // Д.З. Сформировать новое имя файла, сохранить расширение,
                    //   убедиться, что файл не стирает к-то другой файл

                    var filesInDir = Directory.GetFiles("./wwwroot/img");
                    var filesInDirCount = filesInDir.Count();
                    var noSameNameCount = 0;

                    do
                    {
                        noSameNameCount = 0;
                        foreach (var file in filesInDir)
                        {
                            var indexOfLastSlash = file.LastIndexOf('\\');
                            // -1 because i don't need slash in file name
                            var thisFileName = file.Substring(indexOfLastSlash + 1, file.Length - indexOfLastSlash - 1);

                            if (thisFileName == currentImgName)
                            {
                                currentImgName += Guid.NewGuid().ToString();
                                break;
                            }
                            noSameNameCount++;
                        }
                    } while (filesInDirCount != noSameNameCount);

                    UserData.Avatar.CopyToAsync(
                        new FileStream(
                            "./wwwroot/img/" + currentImgName,
                            FileMode.Create));
                }
                // если валидация пройдена, то добавляем пользователя в БД
                // валидация успешна если нет сообщений об ошибках
                bool isValid = true;
                foreach (string error in err)
                {
                    if (!String.IsNullOrEmpty(error)) isValid = false;
                }
                if (isValid)   // валидация успешна
                {
                    var user = new DAL.Entities.User();
                    // крипто-соль - это случайное число (в сроковом виде)
                    user.PassSalt = _hasher.Hash(DateTime.Now.ToString());
                    user.PassHash = _hasher.Hash(
                        UserData.Password1 + user.PassSalt);  // соль "смешивается" с паролем
                    user.Avatar = currentImgName;   // заменить по результатам ДЗ
                    user.Email = UserData.Email;
                    user.RealName = UserData.RealName;
                    user.Login = UserData.Login;
                    user.RegMoment = DateTime.Now;

                    // добавляем в БД (контекст)
                    _introContext.Users.Add(user);

                    // сохраняем изменения
                    _introContext.SaveChanges();
                }
            }
            ViewData["UserData"] = UserData;
            ViewData["err"] = err;
            return View("Register");
        }

        public IActionResult Data()
        {
            return Json(new { field = "value" });
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