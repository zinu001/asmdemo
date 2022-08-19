using Microsoft.EntityFrameworkCore.Migrations;

namespace asmdemo.Migrations
{
    public partial class abc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "782bd419-5fe9-48f5-85f5-b721b12353a9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "21564746-f787-408f-a4d6-e802bd79ca1a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "87921445-deba-4b58-bee1-637b6a0b7f6f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12b99d9d-a3d5-4a35-8aad-78a8a7416b2e", "AQAAAAEAACcQAAAAED0IUHTXDVNqQm9PArigt3JwDg1JByxjqdcjLtQzGfZFvZ9aKE1VUjsZ9Fy0HbQQbg==", "04ce3c15-b6bc-4e0d-93cc-abb419bd437e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5ef64c9-4318-4cdf-bbc1-d57d24c8ce0a", "AQAAAAEAACcQAAAAEPo0PGZTYIar/jS5QlYmxZMHCOW60EqZPcyQI+xXOfQbAgWHvUwFLksAQFffmYPaSA==", "830fd02f-e3cd-4e5f-b422-6c2cd920be66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99143a97-3bbc-45a9-8ede-fb084d3f9ab9", "AQAAAAEAACcQAAAAEG7g+VerrdlHJe4ft+UO6TIH0KAist9z7RPOjPG8iJZRMG2T60mq9qULMAlxoHDWng==", "ffcb5919-66eb-438a-802e-5a4908433d60" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "703f7a57-0e72-45dd-a24b-2a55b87579fa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "ad67f7b3-2005-4556-bf01-0f5dd7ae7e6f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "51aac660-3642-4dfb-98be-4518d67edbc3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "952ab49d-d4aa-4cfa-9387-30c469ab0fbe", "AQAAAAEAACcQAAAAEJn2DK5ARnja/X249xKtlto5Wo7pclWTZjSv6Z1OOpa9Wjet/ujtLhBQJJuhF3xp5A==", "2a9ab810-ae4f-4c9e-afa6-f124efdbc24d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eeb5e0eb-ed1f-464b-8c95-e1ad93fe310e", "AQAAAAEAACcQAAAAEEKJfGdMyZ5gRD46h6PNZj/dPbkTTB0fMj3MWKYlvtV/sCOkED2Skrk0M+eAcFzk/Q==", "2eb23eb8-4955-450d-987e-ec26a1305ff9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f295f478-6b99-4633-8805-69212b3cd43f", "AQAAAAEAACcQAAAAELugzKriTQ0s31AR9QdLSfhKWMJ3GQtfqKu1JWsGw8mzokxMrmsLlyTBJ5x8Bpwe6Q==", "c34ecd24-d960-4515-936e-6b2b3655e1d0" });
        }
    }
}
