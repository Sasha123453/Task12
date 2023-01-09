using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Task12.Models;

namespace Task12.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public TaskViewModel SumCount(string Number)
        {
            int number = int.Parse(Number);
            double result = 0;
            for (int i = 1; i <= number; i++)
            {
                result += Math.Pow(-1, number) / (2 * number + 1);
            }
            TaskViewModel vm = new TaskViewModel
            {
                Id = 0,
                Number = result
            };
            return vm;
        }
        public TaskViewModel ChangeCount(string Price, string Paid)
        {
            double price = double.Parse(Price, System.Globalization.CultureInfo.InvariantCulture);
            double paid = double.Parse(Paid, System.Globalization.CultureInfo.InvariantCulture);
            TaskViewModel vm = new TaskViewModel
            {
                Id = 1,
                Number = paid - price
            };
            return vm;
        }
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult ShowChange(string Price, string Paid)
        {
            TaskViewModel vm = ChangeCount(Price, Paid);
            return View(vm);
        }
		[HttpPost]
		public IActionResult ShowSum(string Number)
        {
            TaskViewModel vm = SumCount(Number);
            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}