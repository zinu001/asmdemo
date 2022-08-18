using Microsoft.AspNetCore.Mvc;

namespace asmdemo.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
