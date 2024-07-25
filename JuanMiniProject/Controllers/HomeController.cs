using JuanMiniProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JuanMiniProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
