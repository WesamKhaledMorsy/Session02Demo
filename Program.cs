using Microsoft.Extensions.FileSystemGlobbing.Internal;

namespace Session02Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            // To Use Bootstrap and any thing in wwwroot or resources
            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(endpoints => {
                endpoints.MapControllerRoute(name: "default",
                   pattern: "/{controller=Home}/{action=Index}",
                   defaults: new { controller = "Home", action = "Index" }
                   );          
            });
            //app.MapGet("/Product/{id?}",async context =>
            //{
            //    var id = context.Request.RouteValues["id"];
            //    if (id == null)
            //        await context.Response.WriteAsync("Products");
            //    else
            //        await context.Response.WriteAsync($"Product :: {id}");
            //});
                
            //app.MapGet("/", () => "Hello World!");
            
            app.Run();
        }
    }
}
