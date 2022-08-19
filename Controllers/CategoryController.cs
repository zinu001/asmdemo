using asmdemo.Models;
using demoweb.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq;

namespace asmdemo.Controllers
{
    public class CategoryController : Controller
    {
        //khai báo ApplicationDbContext để truy xuất và thay đổi dữ liệu của bảng
        private ApplicationDbContext context;
        public CategoryController(ApplicationDbContext applicationDbContext)
        {
            context = applicationDbContext;
        }
        //load toàn bộ dữ liệu của bảng  
        [Authorize(Roles = "Storeowner")]
        public IActionResult Index() => View(context.Category.ToList());

        public IActionResult Detail(int id)
        {
            var country = context.Category.Include(c => c.Books)      //1-M
                                         .ThenInclude(b => b.Category) //category => author 
                                         .FirstOrDefaultAsync(c => c.Id == id);
            /* Note:
             * Nếu 2 bảng có kết nối trực tiếp (đi thẳng) thì dùng hàm Include
             * Nếu 2 bảng có kết nối gián tiếp (đi vòng) thông qua bảng trung gian thì dùng hàm ThenInclude
             */
            return View(country);
        }
        //xoá dữ liệu từ bảng
        public IActionResult Delete(int id)
        {
            var category = context.Category.Find(id);
            context.Category.Remove(category);
            context.SaveChanges();
            TempData["Message"] = "Delete Category successfully !";
            return RedirectToAction("Index");
        }

        //thêm dữ liệu vào bảng
        //1. render ra view
        [HttpGet]
        public IActionResult Create()
        {
            //đẩy danh sách của country sang bảng Add Brand
            ViewBag.Category = context.Category.ToList();
            return View();
        }
        //2. nhận và xử lý dữ liệu được gửi từ form
        [HttpPost]
        public IActionResult Create(Category category)
        {
            //check tính hợp lệ của dữ liệu 
            if (ModelState.IsValid)
            {
                //add dữ liệu vào DB
                context.Add(category);
                context.SaveChanges();
                //hiển thị thông báo thành công về view
                TempData["Message"] = "Add category successfully !";
                //quay ngược về trang index
                return RedirectToAction(nameof(Index));
            }
            //nếu dữ liệu không hợp lệ thì trả về form để nhập lại
            return View(category);
        }

        //sửa dữ liệu của bảng
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = context.Category.ToList();
            return View(context.Category.Find(id));
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            //check tính hợp lệ của dữ liệu 
            if (ModelState.IsValid)
            {
                //update dữ liệu vào DB
                context.Update(category);
                context.SaveChanges();
                //hiển thị thông báo thành công về view
                TempData["Message"] = "Edit category successfully !";
                //quay ngược về trang index
                return RedirectToAction(nameof(Index));
            }
            //nếu dữ liệu không hợp lệ thì trả về form để nhập lại
            return View(category);
        }

    }
}
