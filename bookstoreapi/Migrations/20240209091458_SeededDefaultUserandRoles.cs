using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApp.API.Migrations
{
    public partial class SeededDefaultUserandRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7a4ae6c0-63b0-42b0-9341-2cc03b318077", "9fa3cc0a-cd63-4d67-a7dc-f0ca1168910a", "User", "USER" },
                    { "93429b14-714e-4dd6-8349-37d3aa5249cd", "b6c20f77-6666-429c-ab17-911809975da5", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0cd0e10e-a6d9-40c4-ad93-6ec11109f1b7", 0, "8dfb7df1-3eaa-4738-bb4d-f05354ff0547", "admin@bookstore.com", false, "System", "Admin", false, null, "ADMIN@BOOKSTORE.COM", "ADMIN@BOOKSTORE.COM", "AQAAAAEAACcQAAAAEMvh2JBoa+3FHrc7w58kLuM0HHYk1zUo656FhE6qXUgZE9EojTpyEOPMG2reWzdWEA==", null, false, "532dd6bd-8194-462b-a178-61495c8a394d", false, "admin@bookstore.com" },
                    { "38740140-078e-4bb3-be02-d5cf6b934b9e", 0, "bf0a7c82-2c6c-47d2-a3a4-ca7119117f2f", "user@bookstore.com", false, "System", "User", false, null, "USER@BOOKSTORE.COM", "USER@BOOKSTORE.COM", "AQAAAAEAACcQAAAAEKKdMmuGKYzAIlfxGb4ws98HUgDJudvZx/0YbeWm7JGEB9Qms2b987wwX2Qc7W1Udw==", null, false, "9b45bfac-fbba-4dc2-b84a-28fa70dbbbc3", false, "user@bookstore.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "93429b14-714e-4dd6-8349-37d3aa5249cd", "0cd0e10e-a6d9-40c4-ad93-6ec11109f1b7" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7a4ae6c0-63b0-42b0-9341-2cc03b318077", "38740140-078e-4bb3-be02-d5cf6b934b9e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "93429b14-714e-4dd6-8349-37d3aa5249cd", "0cd0e10e-a6d9-40c4-ad93-6ec11109f1b7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7a4ae6c0-63b0-42b0-9341-2cc03b318077", "38740140-078e-4bb3-be02-d5cf6b934b9e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a4ae6c0-63b0-42b0-9341-2cc03b318077");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93429b14-714e-4dd6-8349-37d3aa5249cd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cd0e10e-a6d9-40c4-ad93-6ec11109f1b7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38740140-078e-4bb3-be02-d5cf6b934b9e");
        }
    }
}
