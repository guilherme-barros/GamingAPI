using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUmParaUm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Derrotas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Disputas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vitorias",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonagemId",
                table: "TB_ARMAS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersonagemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 2,
                column: "PersonagemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 3,
                column: "PersonagemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 4,
                column: "PersonagemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 5,
                column: "PersonagemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 6,
                column: "PersonagemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 7,
                column: "PersonagemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 193, 250, 173, 109, 179, 225, 244, 231, 180, 12, 95, 20, 160, 200, 162, 155, 245, 126, 163, 194, 62, 54, 227, 37, 153, 6, 16, 7, 52, 65, 216, 206, 81, 8, 84, 169, 90, 179, 163, 195, 164, 133, 76, 53, 83, 5, 194, 188, 10, 95, 173, 164, 120, 134, 166, 33, 173, 35, 218, 153, 48, 57, 87, 187 }, new byte[] { 196, 118, 30, 139, 117, 44, 57, 178, 243, 145, 200, 20, 88, 150, 189, 116, 170, 236, 11, 230, 247, 13, 11, 175, 182, 71, 183, 229, 214, 149, 12, 195, 90, 188, 63, 100, 126, 95, 136, 178, 110, 81, 131, 61, 178, 87, 164, 151, 143, 50, 178, 101, 147, 128, 118, 32, 170, 115, 147, 88, 195, 129, 170, 101, 95, 69, 205, 199, 205, 181, 201, 190, 137, 146, 29, 44, 4, 24, 252, 104, 81, 222, 5, 75, 146, 77, 74, 228, 233, 122, 88, 132, 246, 131, 191, 217, 166, 170, 242, 183, 7, 160, 66, 165, 136, 211, 74, 228, 98, 64, 137, 45, 57, 243, 181, 5, 91, 135, 231, 79, 39, 45, 52, 177, 31, 123, 11, 160 } });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                principalTable: "TB_PERSONAGENS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropColumn(
                name: "Derrotas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Disputas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Vitorias",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 54, 222, 79, 96, 255, 25, 187, 94, 34, 187, 25, 163, 107, 103, 24, 201, 221, 200, 62, 214, 222, 138, 99, 72, 1, 117, 68, 178, 25, 137, 32, 71, 137, 60, 185, 245, 217, 31, 197, 184, 91, 162, 72, 190, 236, 169, 224, 73, 17, 234, 2, 238, 226, 111, 64, 249, 12, 182, 141, 7, 135, 40, 78, 8 }, new byte[] { 243, 243, 26, 153, 133, 69, 213, 233, 38, 128, 67, 176, 70, 11, 78, 13, 116, 214, 195, 0, 22, 81, 117, 37, 221, 154, 205, 150, 50, 195, 170, 68, 199, 67, 123, 224, 155, 159, 250, 251, 170, 110, 110, 205, 54, 121, 43, 25, 81, 179, 87, 136, 98, 94, 18, 80, 114, 25, 247, 172, 219, 56, 60, 190, 246, 234, 240, 11, 171, 44, 120, 192, 103, 249, 122, 163, 25, 6, 179, 224, 235, 169, 58, 137, 183, 22, 39, 105, 56, 164, 35, 109, 102, 179, 89, 18, 153, 248, 74, 43, 93, 206, 97, 225, 16, 187, 157, 128, 18, 59, 156, 26, 175, 99, 105, 111, 176, 106, 122, 52, 51, 107, 104, 125, 197, 150, 245, 229 } });
        }
    }
}
