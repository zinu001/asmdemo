using Microsoft.AspNetCore.Mvc;

namespace asm2.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
