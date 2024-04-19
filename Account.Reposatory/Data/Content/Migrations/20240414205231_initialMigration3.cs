using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Account.Reposatory.Data.Content.Migrations
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
                keyValue: "415a6d91-b89f-4869-9bbc-49ef95c93767");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d93c73d-ea37-4886-9d95-4dd4e8677bdb");

            migrationBuilder.AddColumn<string>(
                name: "SaudiNationalID",
                table: "Volunteers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "491bdf53-aa5c-4f85-b187-1fc6df803d46", "1", "GoverateAgencyMan", "GoverateAgencyMan" },
                    { "5450777c-b7ad-4d07-b879-728d2f8fcfc0", "0", "Volunteer", "Volunteer" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "491bdf53-aa5c-4f85-b187-1fc6df803d46");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5450777c-b7ad-4d07-b879-728d2f8fcfc0");

            migrationBuilder.DropColumn(
                name: "SaudiNationalID",
                table: "Volunteers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "415a6d91-b89f-4869-9bbc-49ef95c93767", "0", "Volunteer", "Volunteer" },
                    { "8d93c73d-ea37-4886-9d95-4dd4e8677bdb", "1", "GoverateAgencyMan", "GoverateAgencyMan" }
                });
        }
    }
}
