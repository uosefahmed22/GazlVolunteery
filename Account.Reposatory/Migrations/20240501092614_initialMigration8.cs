using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Account.Reposatory.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b6ae14b-b03f-4267-8a11-5627f43a0fcf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7635e4b5-ab23-4a95-a647-73ff25d5c84b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6703cac-add5-4323-9c54-52698a05e19d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc6c6f69-f5f8-46ad-ad02-5ad7f151cd50");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "73be15af-d9c0-40d6-9e77-506e1eaf373a", "0", "Visitor", "Visitor" },
                    { "8099b33b-162b-4651-9a0f-7d6e597bf4fe", "1", "Government Agency", "Government Agency" },
                    { "e97fae22-c6da-4c45-9c74-ff6140220d5a", "3", "Private Sector", "Private Sector" },
                    { "f09ad074-c29f-4683-9325-0fcc0378f7c5", "2", "Civil Society Organization", "Civil Society Organization" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73be15af-d9c0-40d6-9e77-506e1eaf373a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8099b33b-162b-4651-9a0f-7d6e597bf4fe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e97fae22-c6da-4c45-9c74-ff6140220d5a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f09ad074-c29f-4683-9325-0fcc0378f7c5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4b6ae14b-b03f-4267-8a11-5627f43a0fcf", "0", "Visitor", "Visitor" },
                    { "7635e4b5-ab23-4a95-a647-73ff25d5c84b", "2", "Civil Society Organization", "Civil Society Organization" },
                    { "c6703cac-add5-4323-9c54-52698a05e19d", "1", "Government Agency", "Government Agency" },
                    { "dc6c6f69-f5f8-46ad-ad02-5ad7f151cd50", "3", "Private Sector", "Private Sector" }
                });
        }
    }
}
