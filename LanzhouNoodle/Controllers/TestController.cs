using Microsoft.AspNetCore.Mvc;

namespace LanzhouNoodle.controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}
