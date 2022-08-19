using asmdemo.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace demoweb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Author> Author { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Category> Category { get; set; }

        public DbSet<Order> Order { get; set; }

        //add dữ liệu ban đầu cho bảng
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            /*SeedCountry(builder);
            SeedBrand(builder);*/
            SeedBook(builder);
            SeedAuthor(builder);
            //add dữ liệu cho 3 bảng: User, Role, UserRole => Authentication (Login/Logout) + Authorization (Role Assign)
            SeedUser(builder);
            SeedRole(builder);
            SeedUserRole(builder);
        }

        private void SeedAuthor(ModelBuilder builder)
        {
            builder.Entity<Author>().HasData(
                new Author { Id = 1, Name = "Nguyễn Nhật Ánh" },
                new Author { Id = 2, Name = "Vũ Trọng Phụng" }
                );
        }
        private void SeedCategory(ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Truyện Ngắn", Description = "Truyện ngắn là một thể loại văn học. Nó thường là các câu chuyện kể bằng văn xuôi và có xu hướng ngắn gọn, súc tích và hàm nghĩa hơn các câu truyện dài như tiểu thuyết." },
                new Category { Id = 2, Name = "Tiểu thuyết", Description = "Tiểu thuyết là một thể loại văn xuôi có hư cấu, thông qua nhân vật, hoàn cảnh, sự việc để phản ánh bức tranh xã hội rộng lớn và những vấn đề của cuộc sống con người, biểu hiện tính chất tường thuật, tính chất kể chuyện bằng ngôn ngữ văn xuôi theo những chủ đề xác định." }
                );
        }

        /*private void SeedCountry(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country { Id = 1, Name = "Korea" },
                new Country { Id = 2, Name = "USA" },
                new Country { Id = 3, Name = "China" }
                );
        }*/

        private void SeedUserRole(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = "1",
                    RoleId = "1"
                },
                new IdentityUserRole<string>
                {
                    UserId = "2",
                    RoleId = "2"
                },
                new IdentityUserRole<string>
                {
                    UserId = "3",
                    RoleId = "3"
                }
            );
        }

        private void SeedRole(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "1",
                    Name = "Admin",
                    NormalizedName = "Admin"
                },
                new IdentityRole
                {
                    Id = "2",
                    Name = "Customer",
                    NormalizedName = "Customer"
                },
                new IdentityRole
                {
                    Id = "3",
                    Name = "Storeowner",
                    NormalizedName = "Storeowner"
                }
            );
        }

        private void SeedUser(ModelBuilder builder)
        {
            //tạo tài khoản test cho admin & customer
            var admin = new IdentityUser
            {
                Id = "1",
                Email = "admin@gmail.com",
                UserName = "admin@gmail.com",
                NormalizedUserName = "admin@gmail.com"
            };
            var customer = new IdentityUser
            {
                Id = "2",
                Email = "customer@gmail.com",
                UserName = "customer@gmail.com",
                NormalizedUserName = "customer@gmail.com"
            };
            var storeowner = new IdentityUser
            {
                Id = "3",
                Email = "storeowner@gmail.com",
                UserName = "storeowner@gmail.com",
                NormalizedUserName = "storeowner@gmail.com"
            };

            //khai báo thư viện để mã hóa mật khẩu cho user
            var hasher = new PasswordHasher<IdentityUser>();

            //set mật khẩu đã mã hóa cho từng user
            admin.PasswordHash = hasher.HashPassword(admin, "123456");
            customer.PasswordHash = hasher.HashPassword(customer, "123456");
            storeowner.PasswordHash = hasher.HashPassword(storeowner, "123456");

            //add 2 tài khoản test vào bảng User
            builder.Entity<IdentityUser>().HasData(admin, customer, storeowner);
        }

        private void SeedBook(ModelBuilder builder)
        {
            builder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Name = "Mắt Biếc",
                    AuthorId = 1,
                    Quantity = 12,
                    Price = 250.000,
                    Image = "https://ebookhay.net/wp-content/uploads/2021/02/mat-biec-pdf.jpg",
                    Description = "Mắt biếc là tiểu thuyết của nhà văn Nguyễn Nhật Ánh trong loạt truyện viết về tình yêu thanh thiếu niên của tác giả này cùng với Thằng quỷ nhỏ, Cô gái đến từ hôm qua,... Đây được xem là một trong những tác phẩm tiêu biểu của Nguyễn Nhật Ánh, từng được dịch giả Kato Sakae dịch để giới thiệu với độc giả Nhật Bản với tựa đề Tsuburana hitomi",
                    CategoryId = 1
                },
                new Book
                {
                    Id = 2,
                    Name = "Tôi thấy hoa vàng trên cỏ xanh",
                    AuthorId = 1,
                    Quantity = 10,
                    Price = 210.000,
                    Image = "https://newshop.vn/public/uploads/content/toi-thay-hoa-vang-tren-co-xanh.png",
                    Description = "Tôi thấy hoa vàng trên cỏ xanh là một tiểu thuyết dành cho thanh thiếu niên của nhà văn Nguyễn Nhật Ánh, xuất bản lần đầu tại Việt Nam vào ngày 9 tháng 12 năm 2010 bởi Nhà xuất bản Trẻ với phần tranh minh họa do Đỗ Hoàng Tường thực hiện",
                    CategoryId = 1
                },
                new Book
                {
                    Id = 3,
                    Name = "Kính vạn hoa",
                    AuthorId = 1,
                    Quantity = 11,
                    Price = 190.000,
                    Image = "https://www.khaitam.com/Data/Sites/1/Product/19297/kinh---van---hoa---tap-5.png",
                    Description = "Kính vạn hoa là một bộ truyện dài nhiều tập của nhà văn Nguyễn Nhật Ánh. Bộ truyện gồm 54 tập truyện mang tính hài hước kể về những chuyện vui buồn trong giới ",
                    CategoryId = 1
                },
                new Book
                {
                    Id = 4,
                    Name = "Số đỏ",
                    AuthorId = 2,
                    Quantity = 15,
                    Price = 120.000,
                    Image = "https://lh6.googleusercontent.com/-VrA8w0cexZ8/VOx9bPe0C5I/AAAAAAAAUVA/gnCyKbigjYA/w360-h472-no/39016.png",
                    Description = "Số đỏ là một tiểu thuyết văn học của nhà văn Vũ Trọng Phụng, đăng ở Hà Nội báo từ số 40 ngày 7 tháng 10 1936 và được in thành sách lần đầu vào năm 1938",
                    CategoryId = 2
                },
                new Book
                {
                    Id = 5,
                    Name = "Trúng số độc đắc",
                    AuthorId = 2,
                    Quantity = 16,
                    Price = 50.000,
                    Image = "https://vnwriter.net/wp-content/uploads/2019/03/sach-trung-so-doc-dac.png",
                    Description = "Trúng Số Độc Đắc là tác phẩm cuối đời của Vũ Trọng Phụng. Khác với lối viết tiểu thuyết trước, cứ đến ngày báo ra mới viết một chương, đưa in xong hết mới mới thành sách, Trúng Số Độc Đắc được Vũ Trọng Phụng viết một mạch đến khi hoàn thành, tự tay đi đóng thành quyển rồi mới đưa cho nhà xuất bản",
                    CategoryId = 2
                },
                new Book
                {
                    Id = 6,
                    Name = "Giông tố",
                    AuthorId = 2,
                    Quantity = 17,
                    Price = 70.000,
                    Image = "https://sachhaynendoc.net/wp-content/uploads/2020/04/%E1%BA%A2nh-b%C3%ACa-cu%E1%BB%91n-ti%E1%BB%83u-tuy%E1%BA%BFt-Gi%C3%B4ng-t%E1%BB%91.png",
                    Description = "Tiểu thuyết Giông tố dài 30 chương và thêm một đoạn kết: nhưng sự việc xảy ra trong một thời gian cũng ngắn vậy. Như lời Vũ Trọng Phụng ghi vào lòng truyện, sự việc mở ra vào tháng 10-1932 và kết thúc vào mùa hè 1933.",
                    CategoryId = 2
                },
                new Book
                {
                    Id = 7,
                    Name = "Lão Hạc",
                    AuthorId = 3,
                    Quantity = 18,
                    Price = 55.000,
                    Image = "http://nhasachminhthang.vn/UserFiles/files/l%C3%A3o%20h%E1%BA%A1c.png",
                    Description = "Lão Hạc là một truyện ngắn của nhà văn Nam Cao được viết năm 1943. Tác phẩm được đánh giá là một trong những truyện ngắn khá tiêu biểu của d",
                    CategoryId = 1
                },
                new Book
                {
                    Id = 8,
                    Name = "Chí Phèo",
                    AuthorId = 3,
                    Quantity = 19,
                    Price = 85.000,
                    Image = "http://nhasachminhthang.vn/UserFiles/files/ch%C3%AD%20ph%C3%A8o%20110K.png",
                    Description = "Chí Phèo - tập truyện ngắn tái hiện bức tranh chân thực nông thôn Việt Nam trước 1945, nghèo đói, xơ xác trên con đường phá sản, bần cùng, hết sức thê thảm, người nông dân bị đẩy vào con đường tha hóa, lưu manh hóa. Nam Cao không hề bôi nhọ người nông dân, trái lại nhà văn đi sâu vào nội tâm nhân vật để khẳng định nhân phẩm và bản chất lương thiện ngay cả khi bị vùi dập, cướp mất cà nhân hình, nhân tính của người nông dân, đồng thời kết án đanh thép cái xã hội tàn bạo đó trước 1945.",
                    CategoryId = 1
                },
                new Book
                {
                    Id = 9,
                    Name = "Đời thừa",
                    AuthorId = 3,
                    Quantity = 8,
                    Price = 45.000,
                    Image = "https://nhasachminhthang.vn/UserFiles/files/tuy%E1%BB%83n%20t%E1%BA%ADp%20nam%20cao%20120k.png",
                    Description = "Trong mảng sáng tác về đề tài tiểu tư sản của Nam Cao, truyện ngắn \"Đời Thừa\" có một vị trí đặc biệt. \"Đời Thừa\" đã ghi lại chân thật hình ảnh buồn thảm của người tri thức tiểu tư sản nghèo, nhà văn Nam Cao đã phác hoạ rõ nét hình ảnh vừa bi vừa hài của lớp người này trở nên đầy ám ảnh.",
                    CategoryId = 1
                },
                new Book
                {
                    Id = 10,
                    Name = "Đôi mắt",
                    AuthorId = 3,
                    Quantity = 20,
                    Price = 115.000,
                    Image = "https://nhasachminhthang.vn/UserFiles/files/NAM%202019/S%C3%A1ch%20V%C4%83n%20h%E1%BB%8Dc/%C4%91%C3%B4i%20m%E1%BA%AFt%2070k.png",
                    Description = "Tập truyện ngắn \"Đôi mắt\" gồm 15 tác phẩm tiêu biểu trong giai đoạn sáng tác từ 1941 - 1950 của Nam Cao",
                    CategoryId = 1
                }
            );
            //throw new NotImplementedException();
        }
      

    /*private void SeedBrand(ModelBuilder builder)
    {
        builder.Entity<Brand>().HasData(
            new Brand { Id = 1, Name = "Samsung", CountryId = 1 },
            new Brand { Id = 2, Name = "Apple", CountryId = 2 },
            new Brand { Id = 3, Name = "Xiaomi", CountryId = 3 }
         );
        // throw new NotImplementedException();
    }*/
}
}
