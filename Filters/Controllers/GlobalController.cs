﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filters.Controllers
{
    public class GlobalController : Controller
    {
        public ViewResult Index() => View("Message", "This is the global controller");
    }
}
