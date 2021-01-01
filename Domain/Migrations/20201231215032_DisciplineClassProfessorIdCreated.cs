using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class DisciplineClassProfessorIdCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Discipline_Professor_ProfessorId",
                table: "Discipline");

            migrationBuilder.AlterColumn<int>(
                name: "ProfessorId",
                table: "Discipline",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Discipline_Professor_ProfessorId",
                table: "Discipline",
                column: "ProfessorId",
                principalTable: "Professor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Discipline_Professor_ProfessorId",
                table: "Discipline");

            migrationBuilder.AlterColumn<int>(
                name: "ProfessorId",
                table: "Discipline",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Discipline_Professor_ProfessorId",
                table: "Discipline",
                column: "ProfessorId",
                principalTable: "Professor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
