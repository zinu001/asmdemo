using Microsoft.AspNetCore.Mvc;

namespace asm2.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
