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
                value: "012ba66c-39a2-4acb-abcb-1f06c1d2bbbe");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "534b0be4-19df-4406-bb34-6571bb9b90d4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "294b0ade-04f9-4f27-8f8d-dc53e16de730");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3facd90f-5f3e-415b-9ef0-0c5ce79f0228", "AQAAAAEAACcQAAAAEBvL2JDyxpOZLx4hXcMPqFXNUYZKXp3bsMaKXEIhpCmWQxKyRcKvHd9oFJ5Nwgehgw==", "6366b909-d5ab-4d0d-a6d8-01dc633ce4ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f10ed28-903c-48f4-9451-487df249adc0", "AQAAAAEAACcQAAAAECSjC0XD4ZdAHbTY4L23Hdzf7IIY58A/O/O1/MgCf4arI3CbSfhT+9eYJ0D6hXmZSg==", "07f87ec7-3100-4f1d-9e42-e2b57428afe1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef0f606e-1954-4f3b-aa30-720fd6634d55", "AQAAAAEAACcQAAAAEFUIGAE+w4VQYxsZrykuoWKBBBQmKpA2RAR1EauJ92J0RLGA846270aT4RQujBvO0g==", "a2a2737c-b56c-4972-95b7-bea5f8ea39ea" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
