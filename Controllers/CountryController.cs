using demoweb.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace demoweb.Controllers
{
    public class CountryController : Controller
    {
        //khai báo ApplicationDbContext để truy xuất và thay đổi dữ liệu của bảng
        private ApplicationDbContext context;
        public CountryController (ApplicationDbContext applicationDbContext)
        {
            context = applicationDbContext;
        }

        public IActionResult Detail (int id)
        {
            var country = context.Country.Include(c => c.Brands)      //Country - Brand: 1 - M
                                         .ThenInclude(b => b.Mobiles) //Country => Brand => Mobile
                                         .FirstOrDefault(c => c.Id == id);
            /* Note:
             * Nếu 2 bảng có kết nối trực tiếp (đi thẳng) thì dùng hàm Include
             * Nếu 2 bảng có kết nối gián tiếp (đi vòng) thông qua bảng trung gian thì dùng hàm ThenInclude
             */
            return View(country);
        }
    }
}
