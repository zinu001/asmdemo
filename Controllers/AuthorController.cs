using Microsoft.AspNetCore.Mvc;

namespace asmdemo.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
