using Microsoft.AspNetCore.Mvc;
using StaplesProject2MVC.Models;
using System.Diagnostics;

namespace StaplesProject2MVC.Controllers
{
    public class HomeController : Controller
    {
        
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
