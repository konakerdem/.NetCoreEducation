using Microsoft.AspNetCore.Mvc;

namespace MovieApp.Web.Controllers
{
    public class DenemeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
