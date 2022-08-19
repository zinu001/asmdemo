using demoweb.Data;
using demoweb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace asmdemo.Controllers
{
    public class BookController : Controller
    {
        private ApplicationDbContext context;
        public BookController(ApplicationDbContext applicationDbContext)
        {
            context = applicationDbContext;
        }
        [Authorize(Roles = "Storeowner")]
        public IActionResult Index()
        {
            //soft book by id in index view
            var books = context.Book.OrderByDescending(b => b.Id).ToList();
            return View(books);
        }

        [Authorize(Roles = "Customer")]
        //display card book in store
        public IActionResult Store()
        {
            return View(context.Book.ToList());
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)// delete book by id in index
        {
            var book = context.Book.Find(id);
            context.Book.Remove(book);
            context.SaveChanges();
            TempData["Message"] = "Delete book successfully !";
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Storeowner, Customer")]
        public IActionResult Detail(int id)
        {
            var book = context.Book.Include(b => b.Category)  //Book - Category : Many to One
                                       .ThenInclude(b => b.Authors)  //Book - Author: Many to one
                                       .FirstOrDefault(b => b.Id == id);
            return View(book);
        }
        [Authorize(Roles = "Storeowner")]
        [HttpPost]
        public IActionResult Create(BookController book)
        {
            //check tính hợp lệ của dữ liệu 
            if (ModelState.IsValid)
            {
                //add dữ liệu vào DB
                context.Add(book);
                context.SaveChanges();
                //hiển thị thông báo thành công về view
                TempData["Message"] = "Add book successfully !";
                //quay ngược về trang index
                return RedirectToAction(nameof(Index));
            }

            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(BookController book)
        {
            //check tính hợp lệ của dữ liệu 
            if (ModelState.IsValid)
            {
                //update dữ liệu vào DB
                context.Update(book);
                context.SaveChanges();
                //hiển thị thông báo thành công về view
                TempData["Message"] = "Edit book successfully !";
                //quay ngược về trang index
                return RedirectToAction(nameof(Index));
            }
            //nếu dữ liệu không hợp lệ thì trả về form để nhập lại
            return View(book);
        }
        [HttpPost]
        public IActionResult SearchName(string keyword)// Search by name in Index
        {
            var books = context.Book.Where(b => b.Name.Contains(keyword)).ToList();
            return View("Index", books);
        }
        [Authorize(Roles ="Customer")]
        public IActionResult PriceAsc()// soft price up
        {
            var mobiles = context.Book.OrderBy(b => b.Price).ToList();
            return View("Store", mobiles);
        }

        public IActionResult PriceDesc()// soft price down
        {
            var books = context.Book.OrderByDescending(b => b.Price).ToList();
            return View("Store", books);
        }

        [HttpPost]
        public IActionResult Search(string keyword) // Search by name in store
        {
            var books = context.Book.Where(b => b.Name.Contains(keyword)).ToList();
            return View("Store", books);
        }


    }
}
