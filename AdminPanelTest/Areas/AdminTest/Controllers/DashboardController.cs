using Microsoft.AspNetCore.Mvc;

namespace AdminPanelTest.Areas.AdminTest.Controllers
{
    [Area("AdminTest")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
