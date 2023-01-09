using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TesteClient.Migrations
{
    public partial class Ajourdumodelead : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdresseApplicationUser");

            migrationBuilder.CreateTable(
                name: "ApplicationUserAdresse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCilent = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdAdresse = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserAdresse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationUserAdresse_Adresses_IdAdresse",
                        column: x => x.IdAdresse,
                        principalTable: "Adresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserAdresse_AspNetUsers_IdCilent",
                        column: x => x.IdCilent,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserAdresse_IdAdresse",
                table: "ApplicationUserAdresse",
                column: "IdAdresse");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserAdresse_IdCilent",
                table: "ApplicationUserAdresse",
                column: "IdCilent");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserAdresse");

            migrationBuilder.CreateTable(
                name: "AdresseApplicationUser",
                columns: table => new
                {
                    AdressesId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ApplicationUsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdresseApplicationUser", x => new { x.AdressesId, x.ApplicationUsersId });
                    table.ForeignKey(
                        name: "FK_AdresseApplicationUser_Adresses_AdressesId",
                        column: x => x.AdressesId,
                        principalTable: "Adresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdresseApplicationUser_AspNetUsers_ApplicationUsersId",
                        column: x => x.ApplicationUsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdresseApplicationUser_ApplicationUsersId",
                table: "AdresseApplicationUser",
                column: "ApplicationUsersId");
        }
    }
}
