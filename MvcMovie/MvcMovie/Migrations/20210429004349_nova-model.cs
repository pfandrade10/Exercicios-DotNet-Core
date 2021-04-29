﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovie.Migrations
{
    public partial class novamodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DiretorID",
                table: "Movie",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Diretor",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diretor", x => x.ID);
                });

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
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Diretor_DiretorID",
                table: "Movie");

            migrationBuilder.DropTable(
                name: "Diretor");

            migrationBuilder.DropIndex(
                name: "IX_Movie_DiretorID",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "DiretorID",
                table: "Movie");
        }
    }
}
