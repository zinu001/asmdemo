using asmdemo.Models;
using demoweb.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq;

namespace asmdemo.Controllers
{
    public class AuthorController : Controller
    {
        private ApplicationDbContext context;
        public AuthorController(ApplicationDbContext applicationDbContext)
        {
            context = applicationDbContext;
        }

        //load toàn bộ dữ liệu của bảng  
        [Authorize(Roles = "Storeowner")]
        public IActionResult Index() => View(context.Author.ToList());

        //xoá dữ liệu từ bảng
        public IActionResult Delete(int id)
        {
            var author = context.Author.Find(id);
            context.Author.Remove(author);
            context.SaveChanges();
            TempData["Message"] = "Delete Author successfully !";
            return RedirectToAction("Index");
        }

        //xem thông tin theo id
        public IActionResult Detail(int id)
        {
            var author = context.Author.Include(b => b.Books)  //1-M
                                       .ThenInclude(b => b.Category)  //Author - Category : 1 - M
                                       .FirstOrDefault(b => b.Id == id);
            return View(author);
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
        public IActionResult Create(Author author)
        {
            //check tính hợp lệ của dữ liệu 
            if (ModelState.IsValid)
            {
                //add dữ liệu vào DB
                context.Add(author);
                context.SaveChanges();
                //hiển thị thông báo thành công về view
                TempData["Message"] = "Add author successfully !";
                //quay ngược về trang index
                return RedirectToAction(nameof(Index));
            }
            //nếu dữ liệu không hợp lệ thì trả về form để nhập lại
            return View(author);
        }

        //sửa dữ liệu của bảng
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Countries = context.Category.ToList();
            return View(context.Author.Find(id));
        }

        [HttpPost]
        public IActionResult Edit(Author author)
        {
            //check tính hợp lệ của dữ liệu 
            if (ModelState.IsValid)
            {
                //update dữ liệu vào DB
                context.Update(author);
                context.SaveChanges();
                //hiển thị thông báo thành công về view
                TempData["Message"] = "Edit author successfully !";
                //quay ngược về trang index
                return RedirectToAction(nameof(Index));
            }
            //nếu dữ liệu không hợp lệ thì trả về form để nhập lại
            return View(author);
        }
    }
}
