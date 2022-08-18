using demoweb.Data;
using demoweb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace demoweb.Controllers
{
    public class BrandController : Controller
    {
        //khai báo ApplicationDbContext để truy xuất và thay đổi dữ liệu của bảng
        private ApplicationDbContext context;
        public BrandController (ApplicationDbContext applicationDbContext)
        {
            context = applicationDbContext;
        }

        //load toàn bộ dữ liệu của bảng  
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View(context.Brand.ToList());
        }

        //xoá dữ liệu từ bảng
        
        public IActionResult Delete(int id)
        {
            var brand = context.Brand.Find(id);
            context.Brand.Remove(brand);
            context.SaveChanges();
            TempData["Message"] = "Delete brand successfully !";
            return RedirectToAction("Index");
        }

        //xem thông tin theo id
        public IActionResult Detail (int id)
        {
            var brand = context.Brand.Include(b => b.Mobiles)  //Brand - Mobile : 1 - M
                                     .Include(b => b.Country)  //Brand - Country : M - 1
                                     .FirstOrDefault(b => b.Id == id);
            return View(brand);
        }

        //thêm dữ liệu vào bảng
        //hàm 1: render ra view
        [HttpGet]
        public IActionResult Create()
        {
            //đẩy danh sách của country sang bảng Add Brand
            ViewBag.Countries = context.Country.ToList();
            return View();
        }

        //hàm 2: nhận và xử lý dữ liệu được gửi từ form
        [HttpPost]
        public IActionResult Create (Brand brand)
        {
            //check tính hợp lệ của dữ liệu 
            if (ModelState.IsValid)
            {
                //add dữ liệu vào DB
                context.Add(brand);
                context.SaveChanges();
                //hiển thị thông báo thành công về view
                TempData["Message"] = "Add brand successfully !";
                //quay ngược về trang index
                return RedirectToAction(nameof(Index));
            }
            //nếu dữ liệu không hợp lệ thì trả về form để nhập lại
            return View(brand);
        }

        //sửa dữ liệu của bảng
        [HttpGet]
        public IActionResult Edit (int id)
        {
            ViewBag.Countries = context.Country.ToList();
            return View(context.Brand.Find(id));
        }

        [HttpPost]
        public IActionResult Edit (Brand brand)
        {
            //check tính hợp lệ của dữ liệu 
            if (ModelState.IsValid)
            {
                //update dữ liệu vào DB
                context.Update(brand);
                context.SaveChanges();
                //hiển thị thông báo thành công về view
                TempData["Message"] = "Edit brand successfully !";
                //quay ngược về trang index
                return RedirectToAction(nameof(Index));
            }
            //nếu dữ liệu không hợp lệ thì trả về form để nhập lại
            return View(brand);
        }
    }
}
