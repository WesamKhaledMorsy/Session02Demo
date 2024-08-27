using Microsoft.AspNetCore.Mvc;

namespace Session02Demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            //To go to any outer link
            //return Redirect("https://www.google.com/");

            return View();
        }
        public ActionResult Privacy()
        {
            return View();
        }
        public ActionResult ContactUs()
        {
            return View();
        }
    }
}
