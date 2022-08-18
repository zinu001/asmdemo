using demoweb.Data;
using demoweb.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace demoweb.Controllers
{
    public class OrderController : Controller
    {
        //khai báo ApplicationDbContext để truy xuất và thay đổi dữ liệu của bảng
        private ApplicationDbContext context;
        public OrderController(ApplicationDbContext applicationDbContext)
        {
            context = applicationDbContext;
        }

        [HttpPost]
        public IActionResult Make(int id, int quantity)
        {
            //tạo Order mới
            var order = new Order();
            //set giá trị trong từng thuộc tính của Order
            var mobile = context.Mobile.Find(id);
            order.Mobile = mobile;
            order.MobileId = id;
            order.OrderQuantity = quantity;
            order.OrderPrice = mobile.Price * quantity;
            order.OrderDate = DateTime.Now;
            order.UserEmail = User.Identity.Name;
            //add Order vào DB
            context.Order.Add(order);
            //trừ quantity của mobile
            mobile.Quantity -= quantity;
            context.Mobile.Update(mobile);
            //lưu cập nhật vào DB
            context.SaveChanges();
            //gửi về thông báo order thành công
            TempData["Success"] = "Order mobile successfully !";
            //redirect về trang mobile store
            return RedirectToAction("Store", "Mobile");
        }
    }
}
