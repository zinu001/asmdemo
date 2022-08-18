using demoweb.Data;
using demoweb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace demoweb.Controllers
{
    public class MobileController : Controller
    {
        //khai báo ApplicationDbContext để truy xuất và thay đổi dữ liệu của bảng
        private ApplicationDbContext context;
        public MobileController(ApplicationDbContext applicationDbContext)
        {
            context = applicationDbContext;
        }

        //load toàn bộ dữ liệu của bảng  
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            //xếp mobile mới được hiển thị ở đầu danh sách (sort id giảm dần)
            var mobiles = context.Mobile.OrderByDescending(m => m.Id).ToList();
            return View(mobiles);
        }

        [Authorize(Roles = "Customer")]
        //hiển thị giao diện dạng card cho khách hàng order sản phẩm
        public IActionResult Store()
        {
            return View(context.Mobile.ToList());
        }

        //xoá dữ liệu từ bảng
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            var mobile = context.Mobile.Find(id);
            context.Mobile.Remove(mobile);
            context.SaveChanges();
            TempData["Message"] = "Delete mobile successfully !";
            return RedirectToAction("Index");
        }

        //xem thông tin theo id
        [Authorize(Roles = "Admin, Customer")]
        public IActionResult Detail(int id)
        {
            var mobile = context.Mobile.Include(m => m.Brand)  //Mobile - Brand : M - 1
                                       .ThenInclude(b => b.Country)  //Brand - Country : M - 1
                                       .FirstOrDefault(b => b.Id == id);
            return View(mobile);
        }

        //thêm dữ liệu vào bảng
        //hàm 1: render ra view
        [HttpGet]
        public IActionResult Create()
        {
            //đẩy danh sách của country sang bảng Add Mobile
            ViewBag.Brands = context.Brand.ToList();
            return View();
        }

        //hàm 2: nhận và xử lý dữ liệu được gửi từ form
        [HttpPost]
        public IActionResult Create(Mobile mobile)
        {
            //check tính hợp lệ của dữ liệu 
            if (ModelState.IsValid)
            {
                //add dữ liệu vào DB
                context.Add(mobile);
                context.SaveChanges();
                //hiển thị thông báo thành công về view
                TempData["Message"] = "Add mobile successfully !";
                //quay ngược về trang index
                return RedirectToAction(nameof(Index));
            }
            //nếu dữ liệu không hợp lệ thì trả về form để nhập lại
            return View(mobile);
        }

        //sửa dữ liệu của bảng
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Brands = context.Brand.ToList();
            return View(context.Mobile.Find(id));
        }

        [HttpPost]
        public IActionResult Edit(Mobile mobile)
        {
            //check tính hợp lệ của dữ liệu 
            if (ModelState.IsValid)
            {
                //update dữ liệu vào DB
                context.Update(mobile);
                context.SaveChanges();
                //hiển thị thông báo thành công về view
                TempData["Message"] = "Edit mobile successfully !";
                //quay ngược về trang index
                return RedirectToAction(nameof(Index));
            }
            //nếu dữ liệu không hợp lệ thì trả về form để nhập lại
            return View(mobile);
        }

        public IActionResult PriceAsc()
        {
            var mobiles = context.Mobile.OrderBy(m => m.Price).ToList();
            return View("Store",mobiles);
        }

        public IActionResult PriceDesc()
        {
            var mobiles = context.Mobile.OrderByDescending(m => m.Price).ToList();
            return View("Store",mobiles);
        }

        [HttpPost]
        public IActionResult Search(string keyword)
        {
            var mobiles = context.Mobile.Where(m => m.Name.Contains(keyword)).ToList();
            return View("Store", mobiles);
        }
    }
}
