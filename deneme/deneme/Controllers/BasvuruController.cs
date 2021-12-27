using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace deneme.Controllers
{
    public class BasvuruController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
