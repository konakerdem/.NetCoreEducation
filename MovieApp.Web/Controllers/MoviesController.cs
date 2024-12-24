using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Models;
using System.Collections.Generic;

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
            //Movie Modeli tipinde liste nesnesi oluşturuyorum.   Bu listeyi yine parametre olarak göndereceğim
            // eskiden movie tipinde nesne oluşturup değiken tanımlıyordum.
            var filmListesi = new List<Movie>()
            {
                new Movie{Title="film 1 ",Description="Açıklama 1",Director="Yönetmen 1",Players=new string[]{"oyuncu1","oyuncu2"}},
                new Movie{Title="film 2 ",Description="Açıklama 2",Director="Yönetmen 2",Players=new string[]{"oyuncu1","oyuncu2"}},
                new Movie{Title="film 3 ",Description="Açıklama 3",Director="Yönetmen 3",Players=new string[]{"oyuncu1","oyuncu2"}}


            };


            return View("MoviesList",filmListesi); //View Movie klasörü altında MoiveList dosyasını arasın diye 1.parametre

          //  return View("MoviesList");  Movies Klasörü altında MoviesList viewini arayacak 

        }


        
    }
}
