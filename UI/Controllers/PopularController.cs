using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class PopularController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
