using Microsoft.EntityFrameworkCore.Migrations;

namespace APITCC2021.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doencas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doencas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sintomas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sintomas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AssociacaoDoencasSintomas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoencaId = table.Column<int>(type: "int", nullable: false),
                    SintomaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssociacaoDoencasSintomas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssociacaoDoencasSintomas_Doencas_DoencaId",
                        column: x => x.DoencaId,
                        principalTable: "Doencas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssociacaoDoencasSintomas_Sintomas_SintomaId",
                        column: x => x.SintomaId,
                        principalTable: "Sintomas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssociacaoDoencasSintomas_DoencaId",
                table: "AssociacaoDoencasSintomas",
                column: "DoencaId");

            migrationBuilder.CreateIndex(
                name: "IX_AssociacaoDoencasSintomas_SintomaId",
                table: "AssociacaoDoencasSintomas",
                column: "SintomaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssociacaoDoencasSintomas");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Doencas");

            migrationBuilder.DropTable(
                name: "Sintomas");
        }
    }
}
