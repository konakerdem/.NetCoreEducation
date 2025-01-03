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
            //kullanacaðým servisleri projeme eklemem gerekiyor 
            services.AddControllersWithViews();//MVC için
            //Razor pages için services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();//wwwroot klasörünü eriþime açar

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                /* 
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });

                //gelebilecek diðer istekler için cevaplarý yazýyoruz
                endpoints.MapGet("movies/", async context =>
                {
                    await context.Response.WriteAsync("Welcome to movies!");
                });
                */

                /*controller ile kendim yazmaya baþlýyorum

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


                // / movies/list urlsi gelince MoviesController çalýþacak List fonksiyonuyla
                endpoints.MapControllerRoute(
                    name:"movieList",
                    pattern:"movies/list",
                    defaults:new {controller="Movies",action="List"}
                    //List olduðu için diðer sayfadaki IActionresult , view kýsýmalrýný deðiþtiriyorum
                    
                    );
                    
                //movies/details
                   endpoints.MapControllerRoute(
                   name: "movieList",
                   pattern: "movies/details",
                   defaults: new { controller = "Movies", action = "Details" }
                   //MoviesC... altýnda Details fonksiyonunu çalýþtýracak
                   );

                */


                //default controller


                //localhost:38231/{default}  deðiþken ile isteneni tutuyoruz

                    endpoints.MapControllerRoute(
                    name: "default",
                    pattern:"{controller=Home}/{action=Index}/{id?}"  //id ? li yani opsiyonel girilmek zorunda deðil
                    //ilk kýsým controller ismi olur 2.kýsým action ismi olur 
                    //herhangi birþey belirtilmezse controller=Home olsun action=Index olsun


                    //sadece movies girdim kalanýný otomatik Index olarak tamamlar  movies in action u Index olur

                    );

                    //    Hiçbir þey yok ise Home Index çalýþtýrýyor.
                    //    movies/details istendiðinde       movies   controllerý    altýnda     detailsý    çalýþtýrýr 
                    //    movies/list    istendiðinde       movies   controllerý    altýnda     list        çalýþtýrýr
                    //    controllerlara   ve   fonksiyonlara ona göre isim ver o zaman 








            });







        }

    }
}
