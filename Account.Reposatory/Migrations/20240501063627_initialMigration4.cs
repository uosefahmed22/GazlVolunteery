using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Account.Reposatory.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "GovernmentAgency",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Charity",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "GovernmentAgency",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Charity",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
    }
}
