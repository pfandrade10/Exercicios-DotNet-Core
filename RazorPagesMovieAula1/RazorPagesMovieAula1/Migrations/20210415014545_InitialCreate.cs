using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPagesMovieAula1.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Diretor_DiretorID",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Movie_DiretorID",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "DiretorID",
                table: "Movie");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DiretorID",
                table: "Movie",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movie_DiretorID",
                table: "Movie",
                column: "DiretorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Diretor_DiretorID",
                table: "Movie",
                column: "DiretorID",
                principalTable: "Diretor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
