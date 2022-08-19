using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace asmdemo.Migrations
{
    public partial class aaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 15, nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Author_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Image = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Book_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Book_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(nullable: false),
                    CustomerEmail = table.Column<string>(nullable: true),
                    OrderQuantity = table.Column<int>(nullable: false),
                    OrderPrice = table.Column<double>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "703f7a57-0e72-45dd-a24b-2a55b87579fa", "Admin", "Admin" },
                    { "2", "ad67f7b3-2005-4556-bf01-0f5dd7ae7e6f", "Customer", "Customer" },
                    { "3", "51aac660-3642-4dfb-98be-4518d67edbc3", "Storeowner", "Storeowner" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "952ab49d-d4aa-4cfa-9387-30c469ab0fbe", "admin@gmail.com", false, false, null, null, "admin@gmail.com", "AQAAAAEAACcQAAAAEJn2DK5ARnja/X249xKtlto5Wo7pclWTZjSv6Z1OOpa9Wjet/ujtLhBQJJuhF3xp5A==", null, false, "2a9ab810-ae4f-4c9e-afa6-f124efdbc24d", false, "admin@gmail.com" },
                    { "2", 0, "eeb5e0eb-ed1f-464b-8c95-e1ad93fe310e", "customer@gmail.com", false, false, null, null, "customer@gmail.com", "AQAAAAEAACcQAAAAEEKJfGdMyZ5gRD46h6PNZj/dPbkTTB0fMj3MWKYlvtV/sCOkED2Skrk0M+eAcFzk/Q==", null, false, "2eb23eb8-4955-450d-987e-ec26a1305ff9", false, "customer@gmail.com" },
                    { "3", 0, "f295f478-6b99-4633-8805-69212b3cd43f", "storeowner@gmail.com", false, false, null, null, "storeowner@gmail.com", "AQAAAAEAACcQAAAAELugzKriTQ0s31AR9QdLSfhKWMJ3GQtfqKu1JWsGw8mzokxMrmsLlyTBJ5x8Bpwe6Q==", null, false, "c34ecd24-d960-4515-936e-6b2b3655e1d0", false, "storeowner@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Nguyễn Nhật Ánh" },
                    { 2, 2, "Vũ Trọng Phụng" },
                    { 3, 2, "Nam Cao" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "1", "1" },
                    { "2", "2" },
                    { "3", "3" }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Image", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1, "Mắt biếc là tiểu thuyết của nhà văn Nguyễn Nhật Ánh trong loạt truyện viết về tình yêu thanh thiếu niên của tác giả này cùng với Thằng quỷ nhỏ, Cô gái đến từ hôm qua,... Đây được xem là một trong những tác phẩm tiêu biểu của Nguyễn Nhật Ánh, từng được dịch giả Kato Sakae dịch để giới thiệu với độc giả Nhật Bản với tựa đề Tsuburana hitomi", "https://ebookhay.net/wp-content/uploads/2021/02/mat-biec-pdf.jpg", "Mắt Biếc", 250.0, 12 },
                    { 2, 1, 1, "Tôi thấy hoa vàng trên cỏ xanh là một tiểu thuyết dành cho thanh thiếu niên của nhà văn Nguyễn Nhật Ánh, xuất bản lần đầu tại Việt Nam vào ngày 9 tháng 12 năm 2010 bởi Nhà xuất bản Trẻ với phần tranh minh họa do Đỗ Hoàng Tường thực hiện", "https://newshop.vn/public/uploads/content/toi-thay-hoa-vang-tren-co-xanh.png", "Tôi thấy hoa vàng trên cỏ xanh", 210.0, 10 },
                    { 3, 1, 1, "Kính vạn hoa là một bộ truyện dài nhiều tập của nhà văn Nguyễn Nhật Ánh. Bộ truyện gồm 54 tập truyện mang tính hài hước kể về những chuyện vui buồn trong giới ", "https://www.khaitam.com/Data/Sites/1/Product/19297/kinh---van---hoa---tap-5.png", "Kính vạn hoa", 190.0, 11 },
                    { 4, 2, 2, "Số đỏ là một tiểu thuyết văn học của nhà văn Vũ Trọng Phụng, đăng ở Hà Nội báo từ số 40 ngày 7 tháng 10 1936 và được in thành sách lần đầu vào năm 1938", "https://lh6.googleusercontent.com/-VrA8w0cexZ8/VOx9bPe0C5I/AAAAAAAAUVA/gnCyKbigjYA/w360-h472-no/39016.png", "Số đỏ", 120.0, 15 },
                    { 5, 2, 2, "Trúng Số Độc Đắc là tác phẩm cuối đời của Vũ Trọng Phụng. Khác với lối viết tiểu thuyết trước, cứ đến ngày báo ra mới viết một chương, đưa in xong hết mới mới thành sách, Trúng Số Độc Đắc được Vũ Trọng Phụng viết một mạch đến khi hoàn thành, tự tay đi đóng thành quyển rồi mới đưa cho nhà xuất bản", "https://vnwriter.net/wp-content/uploads/2019/03/sach-trung-so-doc-dac.png", "Trúng số độc đắc", 50.0, 16 },
                    { 6, 2, 2, "Tiểu thuyết Giông tố dài 30 chương và thêm một đoạn kết: nhưng sự việc xảy ra trong một thời gian cũng ngắn vậy. Như lời Vũ Trọng Phụng ghi vào lòng truyện, sự việc mở ra vào tháng 10-1932 và kết thúc vào mùa hè 1933.", "https://sachhaynendoc.net/wp-content/uploads/2020/04/%E1%BA%A2nh-b%C3%ACa-cu%E1%BB%91n-ti%E1%BB%83u-tuy%E1%BA%BFt-Gi%C3%B4ng-t%E1%BB%91.png", "Giông tố", 70.0, 17 },
                    { 7, 3, 2, "Lão Hạc là một truyện ngắn của nhà văn Nam Cao được viết năm 1943. Tác phẩm được đánh giá là một trong những truyện ngắn khá tiêu biểu của d", "http://nhasachminhthang.vn/UserFiles/files/l%C3%A3o%20h%E1%BA%A1c.png", "Lão Hạc", 55.0, 18 },
                    { 8, 3, 2, "Chí Phèo - tập truyện ngắn tái hiện bức tranh chân thực nông thôn Việt Nam trước 1945, nghèo đói, xơ xác trên con đường phá sản, bần cùng, hết sức thê thảm, người nông dân bị đẩy vào con đường tha hóa, lưu manh hóa. Nam Cao không hề bôi nhọ người nông dân, trái lại nhà văn đi sâu vào nội tâm nhân vật để khẳng định nhân phẩm và bản chất lương thiện ngay cả khi bị vùi dập, cướp mất cà nhân hình, nhân tính của người nông dân, đồng thời kết án đanh thép cái xã hội tàn bạo đó trước 1945.", "http://nhasachminhthang.vn/UserFiles/files/ch%C3%AD%20ph%C3%A8o%20110K.png", "Chí Phèo", 85.0, 19 },
                    { 9, 3, 2, "Trong mảng sáng tác về đề tài tiểu tư sản của Nam Cao, truyện ngắn \"Đời Thừa\" có một vị trí đặc biệt. \"Đời Thừa\" đã ghi lại chân thật hình ảnh buồn thảm của người tri thức tiểu tư sản nghèo, nhà văn Nam Cao đã phác hoạ rõ nét hình ảnh vừa bi vừa hài của lớp người này trở nên đầy ám ảnh.", "https://nhasachminhthang.vn/UserFiles/files/tuy%E1%BB%83n%20t%E1%BA%ADp%20nam%20cao%20120k.png", "Đời thừa", 45.0, 8 },
                    { 10, 3, 2, "Tập truyện ngắn \"Đôi mắt\" gồm 15 tác phẩm tiêu biểu trong giai đoạn sáng tác từ 1941 - 1950 của Nam Cao", "https://nhasachminhthang.vn/UserFiles/files/NAM%202019/S%C3%A1ch%20V%C4%83n%20h%E1%BB%8Dc/%C4%91%C3%B4i%20m%E1%BA%AFt%2070k.png", "Đôi mắt", 115.0, 20 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Author_CategoryId",
                table: "Author",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_AuthorId",
                table: "Book",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_CategoryId",
                table: "Book",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_BookId",
                table: "Order",
                column: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
