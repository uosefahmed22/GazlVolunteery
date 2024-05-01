using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Account.Reposatory.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0805fe22-dfee-4e68-bfcc-de21a835533c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56f92eeb-8d4e-42c4-a94c-c0a288e5e255");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93b89772-88be-48c8-b7d5-b6b111bba1bf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a719cc04-3b7f-44f9-b1d6-0ac9f6f04670");

            migrationBuilder.AlterColumn<decimal>(
                name: "Longitude",
                table: "Associations",
                type: "decimal(20,17)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Latitude",
                table: "Associations",
                type: "decimal(20,17)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<decimal>(
                name: "Longitude",
                table: "Associations",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(20,17)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Latitude",
                table: "Associations",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(20,17)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0805fe22-dfee-4e68-bfcc-de21a835533c", "0", "Visitor", "Visitor" },
                    { "56f92eeb-8d4e-42c4-a94c-c0a288e5e255", "1", "Government Agency", "Government Agency" },
                    { "93b89772-88be-48c8-b7d5-b6b111bba1bf", "3", "Private Sector", "Private Sector" },
                    { "a719cc04-3b7f-44f9-b1d6-0ac9f6f04670", "2", "Civil Society Organization", "Civil Society Organization" }
                });
        }
    }
}
