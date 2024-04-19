using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Account.Reposatory.Data.Content.Migrations
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
                keyValue: "a7ff5cc9-91b6-470b-960a-677fb7a10e6f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e938e613-c804-4775-a6f3-536c7e0f354b");

            migrationBuilder.AlterColumn<decimal>(
                name: "Longitude",
                table: "Volunteers",
                type: "decimal(20,17)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(11,8)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Latitude",
                table: "Volunteers",
                type: "decimal(20,17)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,8)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Longitude",
                table: "GoverrateAgency",
                type: "decimal(20,17)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(11,8)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Latitude",
                table: "GoverrateAgency",
                type: "decimal(20,17)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,8)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "415a6d91-b89f-4869-9bbc-49ef95c93767", "0", "Volunteer", "Volunteer" },
                    { "8d93c73d-ea37-4886-9d95-4dd4e8677bdb", "1", "GoverateAgencyMan", "GoverateAgencyMan" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "415a6d91-b89f-4869-9bbc-49ef95c93767");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d93c73d-ea37-4886-9d95-4dd4e8677bdb");

            migrationBuilder.AlterColumn<decimal>(
                name: "Longitude",
                table: "Volunteers",
                type: "decimal(11,8)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(20,17)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Latitude",
                table: "Volunteers",
                type: "decimal(10,8)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(20,17)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Longitude",
                table: "GoverrateAgency",
                type: "decimal(11,8)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(20,17)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Latitude",
                table: "GoverrateAgency",
                type: "decimal(10,8)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(20,17)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a7ff5cc9-91b6-470b-960a-677fb7a10e6f", "0", "Volunteer", "Volunteer" },
                    { "e938e613-c804-4775-a6f3-536c7e0f354b", "1", "GoverateAgencyMan", "GoverateAgencyMan" }
                });
        }
    }
}
