using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Areas.WebApplicationAdmin.Controllers
{
    [Area("WebApplicationAdmin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
