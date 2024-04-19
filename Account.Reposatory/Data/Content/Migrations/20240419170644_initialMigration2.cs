using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Account.Reposatory.Data.Content.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "491bdf53-aa5c-4f85-b187-1fc6df803d46");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5450777c-b7ad-4d07-b879-728d2f8fcfc0");

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "198c3825-4600-465c-8ab8-aa335bb9b558", "3", "Private Sector", "Private Sector" },
                    { "267ad4da-63a2-4c30-b3b7-2e395508d1a1", "2", "Civil Society Organization", "Civil Society Organization" },
                    { "2c99e52c-9385-4c79-8c9e-e09a98a504c2", "0", "Visitor", "Visitor" },
                    { "6b587787-bdfa-47b5-9bc4-a3b798628148", "1", "Government Agency", "Government Agency" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "198c3825-4600-465c-8ab8-aa335bb9b558");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "267ad4da-63a2-4c30-b3b7-2e395508d1a1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c99e52c-9385-4c79-8c9e-e09a98a504c2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b587787-bdfa-47b5-9bc4-a3b798628148");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "491bdf53-aa5c-4f85-b187-1fc6df803d46", "1", "GoverateAgencyMan", "GoverateAgencyMan" },
                    { "5450777c-b7ad-4d07-b879-728d2f8fcfc0", "0", "Volunteer", "Volunteer" }
                });
        }
    }
}
