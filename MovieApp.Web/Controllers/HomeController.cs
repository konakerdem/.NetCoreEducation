using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Models;

namespace MovieApp.Web.Controllers
{
    public class HomeController : Controller
    {

        // view routing


        //Home altında Action methodunun adı neyse (Index) o isimde view arar
        public IActionResult Index()
        {   //döndüreceğim view bilgilerini buradan gönderiyorum.

            string filmBasligi = "Film Başlığı";
            string filmAciklama = "Filmin Açıklaması";
            string filmYonetmen = "Filmin Yönetmeni";
            string[] oyuncular = {"oyuncu1", "oyuncu2"};

            //viewbag veya model ile bu bilgiler gönderilebilir 

            /*ViewBag
            ViewBag.FilmBasligi=filmBasligi; // çanta ile değişkeni taşıyorum.
            ViewBag.FilmAciklamasi=filmAciklama;
            ViewBag.FilmYonetmeni = filmYonetmen;
            ViewBag.Oyuncular=oyuncular;
            */



            //MVC ye göre yaptığımızda Modelleyip göndermemiz lazım
            var m = new Movie(); //model classımızdan nesne oluşturduk 
            m.Title = filmBasligi;
            m.Description = filmAciklama;
            m.Director = filmYonetmen;
            m.Players = oyuncular;





            return View(m); 
            //döndürülecek view i tanımlamamız gerekiyor
            // değişken verilerimi parametre olarak gönderdim gibi düşünebiliriz
        }







        public IActionResult About()
        {
            return View();
        }






    }
}
