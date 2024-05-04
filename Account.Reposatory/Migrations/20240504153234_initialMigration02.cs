using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Account.Reposatory.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration02 : Migration
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

            migrationBuilder.AddColumn<string>(
                name: "ContactNumbers",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SaudiNationalID",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1df911bd-d3e8-4a4c-bd46-94cbabf7e23e", "2", "CivilOrganization", "CivilOrganization" },
                    { "5e88e337-aa4e-4d43-91e1-0c33f7f6cc18", "3", "PrivateSector", "PrivateSector" },
                    { "9968e782-4c73-42c3-8c7e-0fd63e02ff18", "1", "GovernmentAgency", "GovernmentAgency" },
                    { "f9a46150-53c9-4733-a969-b4c5f84702af", "0", "Visitor", "Visitor" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1df911bd-d3e8-4a4c-bd46-94cbabf7e23e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e88e337-aa4e-4d43-91e1-0c33f7f6cc18");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9968e782-4c73-42c3-8c7e-0fd63e02ff18");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f9a46150-53c9-4733-a969-b4c5f84702af");

            migrationBuilder.DropColumn(
                name: "ContactNumbers",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SaudiNationalID",
                table: "AspNetUsers");

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
