using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProdInsumos.Infra.Data.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Cpf = table.Column<string>(type: "TEXT", maxLength: 11, nullable: false),
                    Setor = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Entrega = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Computador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Setor = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Cpu = table.Column<string>(type: "TEXT", nullable: false),
                    Disco = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    TamanhoDisco = table.Column<int>(type: "INTEGER", maxLength: 100000000, nullable: false),
                    Marca = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Modelo = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    SistemaOperacional = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    MemoriaRam = table.Column<int>(type: "INTEGER", maxLength: 100000, nullable: false),
                    funcionarioId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Computador_Funcionario_funcionarioId",
                        column: x => x.funcionarioId,
                        principalTable: "Funcionario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Alocado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdFuncionario = table.Column<int>(type: "INTEGER", nullable: false),
                    IdComputador = table.Column<int>(type: "INTEGER", nullable: false),
                    DataRecebido = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataEntrega = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Entregue = table.Column<bool>(type: "INTEGER", nullable: false),
                    ComputadorId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alocado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alocado_Computador_ComputadorId",
                        column: x => x.ComputadorId,
                        principalTable: "Computador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Alocado_Funcionario_IdFuncionario",
                        column: x => x.IdFuncionario,
                        principalTable: "Funcionario",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alocado_ComputadorId",
                table: "Alocado",
                column: "ComputadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Alocado_IdFuncionario",
                table: "Alocado",
                column: "IdFuncionario");

            migrationBuilder.CreateIndex(
                name: "IX_Computador_funcionarioId",
                table: "Computador",
                column: "funcionarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alocado");

            migrationBuilder.DropTable(
                name: "Computador");

            migrationBuilder.DropTable(
                name: "Funcionario");
        }
    }
}
