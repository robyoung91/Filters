﻿using Filters.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filters.Controllers
{
    [Profile, ViewResultDetails, RangeException]
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            //ViewBag.Hello = "Hello to you";
            //ViewBag.Goodbye = "Goodbye to you";
            return View("Message",
            "This is the Index action on the Home controller");
        }

        public ViewResult SecondAction() => View("Message",
            "This is the SecondAction action on the Home controller");

        public ViewResult GenerateException(int? id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            else if (id > 10)
            {
                throw new ArgumentOutOfRangeException(nameof(id));
            }
            else
            {
                return View("Message", $"The value is {id}");
            }
        }
    }
}