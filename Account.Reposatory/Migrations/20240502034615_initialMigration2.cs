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
                keyValue: "451db184-1c3a-4178-85c8-d9d8792ea7d2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b205885-ebbf-4e48-a8bf-8ae821dca451");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6a932bd9-1156-4075-8e78-4a778b6f97ac");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5f855f9-fdeb-48e8-a3bc-f0f24e562080");

            migrationBuilder.CreateTable(
                name: "Opportunities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OpportunityType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImplementingEntity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvailableCount = table.Column<int>(type: "int", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(20,17)", nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal(20,17)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opportunities", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Opportunities");

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
                    { "451db184-1c3a-4178-85c8-d9d8792ea7d2", "2", "CivilOrganization", "CivilOrganization" },
                    { "4b205885-ebbf-4e48-a8bf-8ae821dca451", "0", "Visitor", "Visitor" },
                    { "6a932bd9-1156-4075-8e78-4a778b6f97ac", "3", "PrivateSector", "PrivateSector" },
                    { "c5f855f9-fdeb-48e8-a3bc-f0f24e562080", "1", "GovernmentAgency", "GovernmentAgency" }
                });
        }
    }
}
