using Microsoft.AspNetCore.Mvc;
using System;

namespace SistemaWebEmpleado.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

    }
}
