using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Account.Reposatory.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Associations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Associations", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Associations");

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
    }
}
