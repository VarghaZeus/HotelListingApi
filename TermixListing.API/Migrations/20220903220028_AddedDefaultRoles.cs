using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TermixListing.API.Migrations
{
    public partial class AddedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5a050a7a-6d47-4c90-aa5c-cd3d07af547e", "7cfc52ee-bfba-4781-a218-41677f377f22", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5d8dba94-92cd-43b2-8282-422d1bf579da", "0aa04f09-d90b-49d8-97bf-0af18501ceca", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a050a7a-6d47-4c90-aa5c-cd3d07af547e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d8dba94-92cd-43b2-8282-422d1bf579da");
        }
    }
}
