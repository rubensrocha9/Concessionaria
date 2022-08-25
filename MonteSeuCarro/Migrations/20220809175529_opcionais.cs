using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonteSeuCarro.Migrations
{
    /// <inheritdoc />
    public partial class opcionais : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Opcionais_Carros_CarroId",
                table: "Opcionais");

            migrationBuilder.RenameColumn(
                name: "OpcionaisCarros",
                table: "Opcionais",
                newName: "Opcionais");

            migrationBuilder.RenameColumn(
                name: "CarroId",
                table: "Opcionais",
                newName: "Carro Id");

            migrationBuilder.RenameColumn(
                name: "AdicionaisId",
                table: "Opcionais",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Opcionais_CarroId",
                table: "Opcionais",
                newName: "IX_Opcionais_Carro Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Opcionais_Carros_Carro Id",
                table: "Opcionais",
                column: "Carro Id",
                principalTable: "Carros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Opcionais_Carros_Carro Id",
                table: "Opcionais");

            migrationBuilder.RenameColumn(
                name: "Opcionais",
                table: "Opcionais",
                newName: "OpcionaisCarros");

            migrationBuilder.RenameColumn(
                name: "Carro Id",
                table: "Opcionais",
                newName: "CarroId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Opcionais",
                newName: "AdicionaisId");

            migrationBuilder.RenameIndex(
                name: "IX_Opcionais_Carro Id",
                table: "Opcionais",
                newName: "IX_Opcionais_CarroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Opcionais_Carros_CarroId",
                table: "Opcionais",
                column: "CarroId",
                principalTable: "Carros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
