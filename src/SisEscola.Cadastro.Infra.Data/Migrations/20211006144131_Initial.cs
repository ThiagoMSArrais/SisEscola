using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SisEscola.Cadastro.Infra.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Alunos",
                schema: "dbo",
                columns: table => new
                {
                    IdAluno = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "NVARCHAR(90)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "Date", nullable: false),
                    Segmento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FotoPerfil = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    CascadeMode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.IdAluno);
                });

            migrationBuilder.CreateTable(
                name: "Responsaveis",
                schema: "dbo",
                columns: table => new
                {
                    IdResponsavel = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "NVARCHAR(90)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "DATE", nullable: false),
                    Parentesco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "NVARCHAR(12)", nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR(150)", nullable: false),
                    IdAluno = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CascadeMode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responsaveis", x => x.IdResponsavel);
                    table.ForeignKey(
                        name: "FK_Responsaveis_Alunos_IdResponsavel",
                        column: x => x.IdResponsavel,
                        principalSchema: "dbo",
                        principalTable: "Alunos",
                        principalColumn: "IdAluno",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responsaveis",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Alunos",
                schema: "dbo");
        }
    }
}
