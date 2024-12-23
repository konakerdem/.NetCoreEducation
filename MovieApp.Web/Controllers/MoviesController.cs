using Microsoft.AspNetCore.Mvc;

namespace MovieApp.Web.Controllers
{
    public class MoviesController : Controller
    {

        //actions ilk ders
        /*
        public string Index()
        {
            return "Film Index";
        }

        //localhost:38231/movies/list
        public string List()
        {
            return "Film Listesi";
        }

        //localhost:38231/movies/details
        public string Details()
        {
            return "Film Detayı";

        }

        */
    
        
        public IActionResult Index()
        { 
            
            return View();
        
        }

        //View dosyasının adını değiştirme
        public IActionResult List() 
        {

            return View("MoviesList"); // Movies Klasörü altında MoviesList viewini arayacak 

        }



    }
}
