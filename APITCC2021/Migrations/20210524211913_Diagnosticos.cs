using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APITCC2021.Migrations
{
    public partial class Diagnosticos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Diagnosticos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Resultados = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnosticos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Diagnosticos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Diagnosticos_UsuarioId",
                table: "Diagnosticos",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Diagnosticos");
        }
    }
}
