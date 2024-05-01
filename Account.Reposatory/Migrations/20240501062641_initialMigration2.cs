using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Account.Reposatory.Migrations
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

            migrationBuilder.AddColumn<int>(
                name: "Charity",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GovernmentAgency",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Charity",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "GovernmentAgency",
                table: "AspNetUsers");

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
    }
}
