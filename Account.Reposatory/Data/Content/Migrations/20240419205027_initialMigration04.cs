using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Account.Reposatory.Data.Content.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration04 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25ee3bf6-40dd-483b-b503-eb76c68e744d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5930b66c-70ed-4d2e-85ba-3fdd94dc837d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "750f8ced-8be6-418c-8ac1-011d0a8deef1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa3e81b5-a32c-46a5-af93-55a0066a312c");

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "124957e6-f4fe-4356-8c53-4e98c58e91e2", "3", "Private Sector", "Private Sector" },
                    { "8a90702d-1662-4b86-b232-d64611b3d7a2", "1", "Government Agency", "Government Agency" },
                    { "9b255fc5-0731-404b-8358-bd125821cdaf", "0", "Visitor", "Visitor" },
                    { "de11a0f4-499b-41a3-af10-ffa72afdec8c", "2", "Civil Society Organization", "Civil Society Organization" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "124957e6-f4fe-4356-8c53-4e98c58e91e2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a90702d-1662-4b86-b232-d64611b3d7a2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b255fc5-0731-404b-8358-bd125821cdaf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de11a0f4-499b-41a3-af10-ffa72afdec8c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "25ee3bf6-40dd-483b-b503-eb76c68e744d", "3", "Private Sector", "Private Sector" },
                    { "5930b66c-70ed-4d2e-85ba-3fdd94dc837d", "1", "Government Agency", "Government Agency" },
                    { "750f8ced-8be6-418c-8ac1-011d0a8deef1", "2", "Civil Society Organization", "Civil Society Organization" },
                    { "fa3e81b5-a32c-46a5-af93-55a0066a312c", "0", "Visitor", "Visitor" }
                });
        }
    }
}
