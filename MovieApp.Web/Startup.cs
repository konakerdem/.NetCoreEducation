using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //kullanaca��m servisleri projeme eklemem gerekiyor 
            services.AddControllersWithViews();//MVC i�in
            //Razor pages i�in services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();//wwwroot klas�r�n� eri�ime a�ar

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                /* 
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });

                //gelebilecek di�er istekler i�in cevaplar� yaz�yoruz
                endpoints.MapGet("movies/", async context =>
                {
                    await context.Response.WriteAsync("Welcome to movies!");
                });
                */

                /*controller ile kendim yazmaya ba�l�yorum

                //localhost:38231
                   endpoints.MapControllerRoute(
                   name: "home",
                   pattern: "",
                   defaults: new { controller = "Home", action = "Index" }
                   );

                //localhost:38231/about

                endpoints.MapControllerRoute(
                   name: "about",
                   pattern: "/about",
                   defaults: new { controller = "Home", action = "About" }
                   );


                // / movies/list urlsi gelince MoviesController �al��acak List fonksiyonuyla
                endpoints.MapControllerRoute(
                    name:"movieList",
                    pattern:"movies/list",
                    defaults:new {controller="Movies",action="List"}
                    //List oldu�u i�in di�er sayfadaki IActionresult , view k�s�malr�n� de�i�tiriyorum
                    
                    );
                    
                //movies/details
                   endpoints.MapControllerRoute(
                   name: "movieList",
                   pattern: "movies/details",
                   defaults: new { controller = "Movies", action = "Details" }
                   //MoviesC... alt�nda Details fonksiyonunu �al��t�racak
                   );

                */


                //default controller


                //localhost:38231/{default}  de�i�ken ile isteneni tutuyoruz

                    endpoints.MapControllerRoute(
                    name: "default",
                    pattern:"{controller=Home}/{action=Index}/{id?}"  //id ? li yani opsiyonel girilmek zorunda de�il
                    //ilk k�s�m controller ismi olur 2.k�s�m action ismi olur 
                    //herhangi bir�ey belirtilmezse controller=Home olsun action=Index olsun


                    //sadece movies girdim kalan�n� otomatik Index olarak tamamlar  movies in action u Index olur

                    );

                    //    Hi�bir �ey yok ise Home Index �al��t�r�yor.
                    //    movies/details istendi�inde       movies   controller�    alt�nda     details�    �al��t�r�r 
                    //    movies/list    istendi�inde       movies   controller�    alt�nda     list        �al��t�r�r
                    //    controllerlara   ve   fonksiyonlara ona g�re isim ver o zaman 








            });







        }

    }
}
