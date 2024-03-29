﻿using Intro.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;

namespace Intro.Controllers
{
    public class AuthController : Controller
    {
        private readonly Services.IHasher _hasher;
        private readonly DAL.Context.IntroContext _introContext;
        public AuthController(Services.IHasher hasher, DAL.Context.IntroContext introContext)
        {
            _hasher = hasher;
            _introContext = introContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            String err = HttpContext.Session.GetString("RegError");
            String values = HttpContext.Session.GetString("Values");
            if (err != null)
            {
                ViewData["Error"] = err;
                ViewData["err"] = err.Split(";");
                ViewData["values"] = values.Split(";");
                HttpContext.Session.Remove("RegError");

                if (HttpContext.Session.GetString("userData") != null)
                {
                    Models.RegUserModel UserData = JsonConvert.DeserializeObject<Models.RegUserModel>
                        (HttpContext.Session.GetString("userData"));
                    ViewData["UserData"] = HttpContext.Session.GetString("UserData");
                }
            }
            return View();
        }

        [HttpPost]  // Следующий метод срабатывает только на POST-запрос
                    // Метод может автоматически собрать все переданные данные в модель
                    //  по совпадению имен
        public IActionResult RegUser(Models.RegUserModel UserData)
        {
            // return Json(UserData);  // способ проверить передачу данных
            String[] err = new String[6];
            String[] values = new String[3];

            values[0] = UserData.RealName;
            values[1] = UserData.Login;
            values[2] = UserData.Email;

            if (UserData == null)
            {
                err[0] = "Некорректный вызов (нет данных)";
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
                    err[3] = "Пароль не может быть пустым";
                }
                if (String.IsNullOrEmpty(UserData.Password2))
                {
                    err[4] = "Пароль не может быть пустым";
                }
                if (String.IsNullOrEmpty(UserData.Email))
                {
                    err[5] = "Email не может быть пустым";
                }
                if (UserData.Avatar != null)  // есть переданный файл
                {
                    // файл нужно сохранить в нужном месте.
                    // для простоты доступа - в папку wwwroot/img
                    // !! крайне НЕ рекомендуется сохранять имя переданного файла
                    //  - возможен конфликт, если разные пользователи -- одно имя
                    //  - уязвимость - если в имени файла есть ../

                    // Д.З. Сформировать новое имя файла, сохранить расширение,
                    //   убедиться, что файл не стирает к-то другой файл

                    UserData.Avatar.CopyToAsync(
                        new FileStream(
                            "./wwwroot/img/" + UserData.Avatar.FileName,
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
                    user.Avatar = UserData.Avatar.FileName;   // заменить по результатам ДЗ
                    user.Email = UserData.Email;
                    user.RealName = UserData.RealName;
                    user.Login = UserData.Login;
                    user.RegMoment = DateTime.Now;

                    if (_introContext.Users.Select(user => user.Login == user.Login).First())
                    {
                        err[2] = "Логин занят";
                    }
                    else
                    {
                        // добавляем в БД (контекст)
                        _introContext.Users.Add(user);

                        // сохраняем изменения
                        _introContext.SaveChanges();
                    }
                }
            }
            UserData.Password1 = String.Empty;
            UserData.Password2 = String.Empty;
            UserData.Avatar = null;

            HttpContext.Session.SetString("UserData" 
                ,JsonConvert.SerializeObject(UserData));
            //ViewData["err"] = err;
            //return View("Register"); -- так нельзя

            HttpContext.Session.SetString(
                "RegError",
                String.Join(";", err));
            HttpContext.Session.SetString("Values", String.Join(";", values));

            // Sessin - хранит значимые типы 

            return RedirectToAction("Register");
        }
    }
}
