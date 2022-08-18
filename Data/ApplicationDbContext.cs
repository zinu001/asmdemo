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

        public DbSet<CategoryAuthor> CategoryAuthor { get; set; }

        public DbSet<Order> Order { get; set; }

        //add dữ liệu ban đầu cho bảng
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            /*SeedCountry(builder);
            SeedBrand(builder);*/
            SeedBook(builder);
            //add dữ liệu cho 3 bảng: User, Role, UserRole => Authentication (Login/Logout) + Authorization (Role Assign)
            /*SeedUser(builder);
            SeedRole(builder);
            SeedUserRole(builder);*/
        }

        /*private void SeedCountry(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country { Id = 1, Name = "Korea" },
                new Country { Id = 2, Name = "USA" },
                new Country { Id = 3, Name = "China" }
                );
        }

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

            //khai báo thư viện để mã hóa mật khẩu cho user
            var hasher = new PasswordHasher<IdentityUser>();

            //set mật khẩu đã mã hóa cho từng user
            admin.PasswordHash = hasher.HashPassword(admin, "123456");
            customer.PasswordHash = hasher.HashPassword(customer, "123456");

            //add 2 tài khoản test vào bảng User
            builder.Entity<IdentityUser>().HasData(admin, customer);
        }*/

        private void SeedBook(ModelBuilder builder)
        {
            builder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Name = "Galaxy S22 Ultra",
                    Quantity = 12,
                    Price = 999.99,
                    Image = "",
                    Description = "",
                    CategoryId = 1,
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
