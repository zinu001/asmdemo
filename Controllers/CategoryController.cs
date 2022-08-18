using Microsoft.AspNetCore.Mvc;

namespace asm2.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
