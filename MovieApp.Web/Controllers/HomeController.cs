using Microsoft.AspNetCore.Mvc;

namespace MovieApp.Web.Controllers
{
    public class HomeController : Controller
    {

        // view routing


        //Home altında Action methodunun adı neyse (Index) o isimde view arar
        public IActionResult Index()
        {
            return View(); //döndürülecek view i tanımlamamız gerekiyor
        }







        public IActionResult About()
        {
            return View();
        }






    }
}
