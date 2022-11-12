using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelListing.API.CoreMigrations
{
    public partial class AddedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "06c3ab25-83cb-41f4-ab27-1860f38f6038", "7b5d6136-4047-4f9f-88f2-8ac9548ade94", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5950a9be-b6d6-4eb2-a83f-0c99b084dc96", "db402205-3162-4483-a048-4bbc6264259a", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06c3ab25-83cb-41f4-ab27-1860f38f6038");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5950a9be-b6d6-4eb2-a83f-0c99b084dc96");
        }
    }
}
