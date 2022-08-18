using Microsoft.AspNetCore.Mvc;

namespace asmdemo.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Store()
        {
            return View();
        }
    }

}
