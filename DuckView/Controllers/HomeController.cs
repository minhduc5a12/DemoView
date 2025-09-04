using System.Diagnostics;
using DuckView.Models;
using Microsoft.AspNetCore.Mvc;

namespace DuckView.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
