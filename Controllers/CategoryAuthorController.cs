using Microsoft.AspNetCore.Mvc;

namespace asmdemo.Controllers
{
    public class CategoryAuthorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
