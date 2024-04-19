using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Account.Reposatory.Data.Content.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration03 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Complements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComplaintDetails = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complements", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Complements");

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
    }
}
