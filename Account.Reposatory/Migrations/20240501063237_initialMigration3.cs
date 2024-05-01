using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Account.Reposatory.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "070983e8-41d4-4ab3-9cff-c8815b3bb77c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39237d5a-6343-434b-a5a0-d71cc5ca88ca");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "63658037-66e9-4a46-ba5d-a652a7954fac");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b23b70c-c089-4902-a2fa-6959946bfc28");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2ce08a82-9cbe-4c11-9258-a0e884827ad2", "0", "Visitor", "Visitor" },
                    { "bb2e1797-6ddc-41f3-b955-27089cde9f66", "1", "Government Agency", "Government Agency" },
                    { "c15bcf0f-9656-40db-b8e3-df0a2de887d0", "2", "Civil Society Organization", "Civil Society Organization" },
                    { "ec7a14b7-f22b-4453-9325-3234f965a0c2", "3", "Private Sector", "Private Sector" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ce08a82-9cbe-4c11-9258-a0e884827ad2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb2e1797-6ddc-41f3-b955-27089cde9f66");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c15bcf0f-9656-40db-b8e3-df0a2de887d0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec7a14b7-f22b-4453-9325-3234f965a0c2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "070983e8-41d4-4ab3-9cff-c8815b3bb77c", "0", "Visitor", "Visitor" },
                    { "39237d5a-6343-434b-a5a0-d71cc5ca88ca", "3", "Private Sector", "Private Sector" },
                    { "63658037-66e9-4a46-ba5d-a652a7954fac", "2", "Civil Society Organization", "Civil Society Organization" },
                    { "9b23b70c-c089-4902-a2fa-6959946bfc28", "1", "Government Agency", "Government Agency" }
                });
        }
    }
}
