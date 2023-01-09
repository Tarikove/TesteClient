using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TesteClient.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserAdresse_AspNetUsers_IdCilent",
                table: "ApplicationUserAdresse");

            migrationBuilder.RenameColumn(
                name: "IdCilent",
                table: "ApplicationUserAdresse",
                newName: "IdApplicationUser");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationUserAdresse_IdCilent",
                table: "ApplicationUserAdresse",
                newName: "IX_ApplicationUserAdresse_IdApplicationUser");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserAdresse_AspNetUsers_IdApplicationUser",
                table: "ApplicationUserAdresse",
                column: "IdApplicationUser",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserAdresse_AspNetUsers_IdApplicationUser",
                table: "ApplicationUserAdresse");

            migrationBuilder.RenameColumn(
                name: "IdApplicationUser",
                table: "ApplicationUserAdresse",
                newName: "IdCilent");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationUserAdresse_IdApplicationUser",
                table: "ApplicationUserAdresse",
                newName: "IX_ApplicationUserAdresse_IdCilent");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserAdresse_AspNetUsers_IdCilent",
                table: "ApplicationUserAdresse",
                column: "IdCilent",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
