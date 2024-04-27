using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Account.Reposatory.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "361f8c23-d146-4fb9-b9ed-cee5f723d757");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52b45e55-b0b2-45bd-8dcd-11cdcbc2e5b3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5928d7c1-23ae-49db-8910-c6b85846a626");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b5d8013e-069a-4e6d-adde-86c7918954c9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0b7fa55a-869a-4b9b-a848-9558e16ad9c5", "3", "Private Sector", "Private Sector" },
                    { "513c996d-6f12-4df8-bdcd-bf6c47608ee8", "2", "Civil Society Organization", "Civil Society Organization" },
                    { "a510609f-5f2d-4614-8ba1-4c383299bde5", "0", "Visitor", "Visitor" },
                    { "d5c1e0fb-46d3-48be-a603-828247951bd9", "1", "Government Agency", "Government Agency" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b7fa55a-869a-4b9b-a848-9558e16ad9c5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "513c996d-6f12-4df8-bdcd-bf6c47608ee8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a510609f-5f2d-4614-8ba1-4c383299bde5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5c1e0fb-46d3-48be-a603-828247951bd9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "361f8c23-d146-4fb9-b9ed-cee5f723d757", "1", "Government Agency", "Government Agency" },
                    { "52b45e55-b0b2-45bd-8dcd-11cdcbc2e5b3", "3", "Private Sector", "Private Sector" },
                    { "5928d7c1-23ae-49db-8910-c6b85846a626", "2", "Civil Society Organization", "Civil Society Organization" },
                    { "b5d8013e-069a-4e6d-adde-86c7918954c9", "0", "Visitor", "Visitor" }
                });
        }
    }
}
