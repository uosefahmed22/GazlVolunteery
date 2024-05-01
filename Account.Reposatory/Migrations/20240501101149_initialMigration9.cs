using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Account.Reposatory.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73be15af-d9c0-40d6-9e77-506e1eaf373a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8099b33b-162b-4651-9a0f-7d6e597bf4fe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e97fae22-c6da-4c45-9c74-ff6140220d5a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f09ad074-c29f-4683-9325-0fcc0378f7c5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1621059c-3985-4a0b-830b-c6260702d8fb", "0", "Visitor", "Visitor" },
                    { "26786374-3906-40c4-a0a9-26f710b5ab44", "2", "CivilSocietyOrganization", "CivilSociety Organization" },
                    { "95fae837-8bef-43c1-9201-3ba17f0d4f4b", "3", "PrivateSector", "PrivateSector" },
                    { "d750e523-c850-4f7c-aa40-6cc07d8ef644", "1", "GovernmentAgency", "GovernmentAgency" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1621059c-3985-4a0b-830b-c6260702d8fb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26786374-3906-40c4-a0a9-26f710b5ab44");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "95fae837-8bef-43c1-9201-3ba17f0d4f4b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d750e523-c850-4f7c-aa40-6cc07d8ef644");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "73be15af-d9c0-40d6-9e77-506e1eaf373a", "0", "Visitor", "Visitor" },
                    { "8099b33b-162b-4651-9a0f-7d6e597bf4fe", "1", "Government Agency", "Government Agency" },
                    { "e97fae22-c6da-4c45-9c74-ff6140220d5a", "3", "Private Sector", "Private Sector" },
                    { "f09ad074-c29f-4683-9325-0fcc0378f7c5", "2", "Civil Society Organization", "Civil Society Organization" }
                });
        }
    }
}
