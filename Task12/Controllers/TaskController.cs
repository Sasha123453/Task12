using Microsoft.AspNetCore.Mvc;
using Task12.Models;

namespace Task12.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Sum()
        {
            return View();
            //
        }
        public IActionResult Change()
        {
            return View();
        }
    }
}
