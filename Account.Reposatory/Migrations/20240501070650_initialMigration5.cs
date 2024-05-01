using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Account.Reposatory.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41d09d03-aeb7-43fe-ad9d-5da70f1eae42");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74c8ab7c-e671-41d4-948b-31f3d284f455");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7cc828ca-03e2-4bdf-a673-e98c87c764d1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b9f6a3a2-0011-4f6f-b50e-e77e46bb6573");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0d6bbe55-a012-4fa2-9750-5050fdd80c0e", "0", "Visitor", "Visitor" },
                    { "38f25de4-3f31-4b15-a513-0ffd2aeff81d", "1", "Government Agency", "Government Agency" },
                    { "8e0b42fa-1512-45d8-8916-25e80ac441c1", "3", "Private Sector", "Private Sector" },
                    { "ce9a76a5-61ae-4abd-96d7-6b79db79dedf", "2", "Civil Society Organization", "Civil Society Organization" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d6bbe55-a012-4fa2-9750-5050fdd80c0e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38f25de4-3f31-4b15-a513-0ffd2aeff81d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e0b42fa-1512-45d8-8916-25e80ac441c1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce9a76a5-61ae-4abd-96d7-6b79db79dedf");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "41d09d03-aeb7-43fe-ad9d-5da70f1eae42", "1", "Government Agency", "Government Agency" },
                    { "74c8ab7c-e671-41d4-948b-31f3d284f455", "0", "Visitor", "Visitor" },
                    { "7cc828ca-03e2-4bdf-a673-e98c87c764d1", "3", "Private Sector", "Private Sector" },
                    { "b9f6a3a2-0011-4f6f-b50e-e77e46bb6573", "2", "Civil Society Organization", "Civil Society Organization" }
                });
        }
    }
}
