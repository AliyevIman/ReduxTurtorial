using AdminPanelTest.Model_VIew;
using AdminPanelTest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AdminPanelTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TestContext _testContext;
        public HomeController(ILogger<HomeController> logger, TestContext context)
        {
            _logger = logger;
            _testContext = context;
        }

        public IActionResult Index()
        {
            IndexVM vm = new();
            vm.Section1 =_testContext.Section1ss.First();

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