using Microsoft.AspNetCore.Mvc;

namespace asmdemo.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
