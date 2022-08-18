using Microsoft.EntityFrameworkCore.Migrations;

namespace asmdemo.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "332b7b87-8500-4d15-af3a-e1a2935524f0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "e5888ce4-9fa4-4837-a7bb-5c95d276792f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "eb5072ab-59ad-400f-b5d4-91da316ba835");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7740b6f2-a763-4af6-9bbd-7f91f8fd52a1", "AQAAAAEAACcQAAAAEIzWxezKanLyUej1w1NICsbjH4+rA0yZZX06j6CCxv9XRhb5hASS0XcteCC2UHu4tg==", "829f280a-5a50-499d-bb06-4e07f8f9effd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4704a50-bf2c-4004-a927-108f528cbb9e", "AQAAAAEAACcQAAAAEPUY3yCGUslhekWZTeGjIOG2BRMJFh6qBxIQQpDDf8KWsoOY1gxa7IJB3FlW6nwMrQ==", "9c528caf-d0ad-4bc3-94da-5a554c1c85e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc18482e-8a0c-4fc7-80fc-4ce4fab1ce46", "AQAAAAEAACcQAAAAEBky15CH3o3P57M2JB2yRehDYAxY1VTNND3kJ8aCb4D4xOzhvJIqgP0s+mVZRKBvKA==", "9140b432-7a89-4d5d-8159-d50ec8a1ffaf" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Nguyễn Nhật Ánh" },
                    { 2, "Vũ Trọng Phụng" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://ebookhay.net/wp-content/uploads/2021/02/mat-biec-pdf.jpg");

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorName", "CategoryId", "CategoryName", "Description", "Image", "Name", "Price", "Quantity", "authorId" },
                values: new object[,]
                {
                    { 7, "Nam Cao", null, "truyện ngắn", "Lão Hạc là một truyện ngắn của nhà văn Nam Cao được viết năm 1943. Tác phẩm được đánh giá là một trong những truyện ngắn khá tiêu biểu của d", "http://nhasachminhthang.vn/UserFiles/files/l%C3%A3o%20h%E1%BA%A1c.png", "Lão Hạc", 55.0, 18, null },
                    { 5, "Vũ Trọng Phụng", null, "tiểu thuyết ", "Trúng Số Độc Đắc là tác phẩm cuối đời của Vũ Trọng Phụng. Khác với lối viết tiểu thuyết trước, cứ đến ngày báo ra mới viết một chương, đưa in xong hết mới mới thành sách, Trúng Số Độc Đắc được Vũ Trọng Phụng viết một mạch đến khi hoàn thành, tự tay đi đóng thành quyển rồi mới đưa cho nhà xuất bản", "https://vnwriter.net/wp-content/uploads/2019/03/sach-trung-so-doc-dac.png", "Trúng số độc đắc", 50.0, 16, null },
                    { 9, "Nam Cao", null, "truyện ngắn", "Trong mảng sáng tác về đề tài tiểu tư sản của Nam Cao, truyện ngắn \"Đời Thừa\" có một vị trí đặc biệt. \"Đời Thừa\" đã ghi lại chân thật hình ảnh buồn thảm của người tri thức tiểu tư sản nghèo, nhà văn Nam Cao đã phác hoạ rõ nét hình ảnh vừa bi vừa hài của lớp người này trở nên đầy ám ảnh.", "https://nhasachminhthang.vn/UserFiles/files/tuy%E1%BB%83n%20t%E1%BA%ADp%20nam%20cao%20120k.png", "Đời thừa", 45.0, 8, null },
                    { 10, "Nam Cao", null, "truyện ngắn", "Tập truyện ngắn \"Đôi mắt\" gồm 15 tác phẩm tiêu biểu trong giai đoạn sáng tác từ 1941 - 1950 của Nam Cao", "https://nhasachminhthang.vn/UserFiles/files/NAM%202019/S%C3%A1ch%20V%C4%83n%20h%E1%BB%8Dc/%C4%91%C3%B4i%20m%E1%BA%AFt%2070k.png", "Đôi mắt", 115.0, 20, null },
                    { 4, "Vũ Trọng Phụng", null, "tiểu thuyết ", "Số đỏ là một tiểu thuyết văn học của nhà văn Vũ Trọng Phụng, đăng ở Hà Nội báo từ số 40 ngày 7 tháng 10 1936 và được in thành sách lần đầu vào năm 1938", "https://lh6.googleusercontent.com/-VrA8w0cexZ8/VOx9bPe0C5I/AAAAAAAAUVA/gnCyKbigjYA/w360-h472-no/39016.png", "Số đỏ", 120.0, 15, null },
                    { 3, "Nguyễn Nhật Ánh", null, "truyện ngắn", "Kính vạn hoa là một bộ truyện dài nhiều tập của nhà văn Nguyễn Nhật Ánh. Bộ truyện gồm 54 tập truyện mang tính hài hước kể về những chuyện vui buồn trong giới ", "https://www.khaitam.com/Data/Sites/1/Product/19297/kinh---van---hoa---tap-5.png", "Kính vạn hoa", 190.0, 11, null },
                    { 2, "Nguyễn Nhật Ánh", null, "truyện ngắn", "Tôi thấy hoa vàng trên cỏ xanh là một tiểu thuyết dành cho thanh thiếu niên của nhà văn Nguyễn Nhật Ánh, xuất bản lần đầu tại Việt Nam vào ngày 9 tháng 12 năm 2010 bởi Nhà xuất bản Trẻ với phần tranh minh họa do Đỗ Hoàng Tường thực hiện", "https://newshop.vn/public/uploads/content/toi-thay-hoa-vang-tren-co-xanh.png", "Tôi thấy hoa vàng trên cỏ xanh", 210.0, 10, null },
                    { 6, "Vũ Trọng Phụng", null, "tiểu thuyết", "Tiểu thuyết Giông tố dài 30 chương và thêm một đoạn kết: nhưng sự việc xảy ra trong một thời gian cũng ngắn vậy. Như lời Vũ Trọng Phụng ghi vào lòng truyện, sự việc mở ra vào tháng 10-1932 và kết thúc vào mùa hè 1933.", "https://sachhaynendoc.net/wp-content/uploads/2020/04/%E1%BA%A2nh-b%C3%ACa-cu%E1%BB%91n-ti%E1%BB%83u-tuy%E1%BA%BFt-Gi%C3%B4ng-t%E1%BB%91.png", "Giông tố", 70.0, 17, null },
                    { 8, "Nam Cao", null, "truyện ngắn", "Chí Phèo - tập truyện ngắn tái hiện bức tranh chân thực nông thôn Việt Nam trước 1945, nghèo đói, xơ xác trên con đường phá sản, bần cùng, hết sức thê thảm, người nông dân bị đẩy vào con đường tha hóa, lưu manh hóa. Nam Cao không hề bôi nhọ người nông dân, trái lại nhà văn đi sâu vào nội tâm nhân vật để khẳng định nhân phẩm và bản chất lương thiện ngay cả khi bị vùi dập, cướp mất cà nhân hình, nhân tính của người nông dân, đồng thời kết án đanh thép cái xã hội tàn bạo đó trước 1945.", "http://nhasachminhthang.vn/UserFiles/files/ch%C3%AD%20ph%C3%A8o%20110K.png", "Chí Phèo", 85.0, 19, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "2adbbf84-9ed3-4bd3-b312-c3ede312df8e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "cf3173a1-3136-4203-a3be-6e0a69092114");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "1f12d6da-2a80-4b21-a938-b1337f672eaa");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a4abe7b-5b53-439a-b8ca-b8abbb158b18", "AQAAAAEAACcQAAAAEDpgaNm18ZDtFsVQH0KyBpAYzj5YqaXdwj5dXEYG8vkE6C2p7K0t6dzh376KD8FXqA==", "af2393d0-e8aa-4607-ba17-31337e85abd9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6cc73b9-3028-43b3-b5de-9b3ec6e36475", "AQAAAAEAACcQAAAAEEGnAlVzLEMd9DDiLYZBNEBOvigdF5zq4xF6Q88+s2SlFqg3D2wAsRNW1shBzp3Nxw==", "fc976a31-03d0-4bcb-a00c-173cfd2d1469" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec793a5a-bda6-4b44-859d-e54388724232", "AQAAAAEAACcQAAAAEItTAvSJd5sD878pkPV5CCpbV2rYCQuXl4wPcoq/a8QEXJU0uTq+OkvF2d+u+ZBeww==", "23f47228-5f1c-412f-803a-fba88b2e6b50" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "");
        }
    }
}
