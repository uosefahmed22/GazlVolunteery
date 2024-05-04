using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Account.Reposatory.Migrations
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
                keyValue: "3c2ea29d-2b8e-460a-8f1c-4954e42d46ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6de7510f-97bf-475f-a810-2b71abf7fa20");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a0313a2-f676-478f-942d-2afa83de7907");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "deb6f6fd-54d3-4ae6-82cf-ebfcb2b294cb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "47ee4e0d-3629-4dc1-97d7-ccff63498f81", "3", "PrivateSector", "PrivateSector" },
                    { "99ccca07-4eaf-47d8-93ca-444f8896dbbd", "0", "Visitor", "Visitor" },
                    { "dc144567-7665-4a19-aecc-9df72815e335", "1", "GovernmentAgency", "GovernmentAgency" },
                    { "e4c9b904-f3f6-427a-987c-4426917b6c76", "2", "CivilOrganization", "CivilOrganization" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47ee4e0d-3629-4dc1-97d7-ccff63498f81");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99ccca07-4eaf-47d8-93ca-444f8896dbbd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc144567-7665-4a19-aecc-9df72815e335");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4c9b904-f3f6-427a-987c-4426917b6c76");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3c2ea29d-2b8e-460a-8f1c-4954e42d46ba", "0", "Visitor", "Visitor" },
                    { "6de7510f-97bf-475f-a810-2b71abf7fa20", "3", "PrivateSector", "PrivateSector" },
                    { "7a0313a2-f676-478f-942d-2afa83de7907", "1", "GovernmentAgency", "GovernmentAgency" },
                    { "deb6f6fd-54d3-4ae6-82cf-ebfcb2b294cb", "2", "CivilOrganization", "CivilOrganization" }
                });
        }
    }
}
