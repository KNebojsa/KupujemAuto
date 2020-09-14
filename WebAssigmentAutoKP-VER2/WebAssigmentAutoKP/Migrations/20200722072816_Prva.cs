using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAssigmentAutoKP.Migrations
{
    public partial class Prva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Automobili",
                columns: table => new
                {
                    AutomobilId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorisnickoIme = table.Column<string>(maxLength: 50, nullable: false),
                    Marka = table.Column<string>(maxLength: 50, nullable: false),
                    Model = table.Column<string>(maxLength: 50, nullable: false),
                    Godiste = table.Column<string>(maxLength: 50, nullable: false),
                    ZapreminaMotora = table.Column<string>(maxLength: 50, nullable: false),
                    Snaga = table.Column<string>(maxLength: 50, nullable: false),
                    Gorivo = table.Column<string>(maxLength: 50, nullable: false),
                    Karoserija = table.Column<string>(maxLength: 50, nullable: false),
                    BinarniPodaci = table.Column<byte[]>(nullable: true),
                    TipFajla = table.Column<string>(maxLength: 20, nullable: true),
                    Opis = table.Column<string>(maxLength: 200, nullable: false),
                    Cena = table.Column<double>(nullable: false),
                    Kontakt = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Automobili", x => x.AutomobilId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Automobili");
        }
    }
}
