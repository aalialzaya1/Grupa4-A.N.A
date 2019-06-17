using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentACar.Database
{
    public class Migracija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vozilo",
                columns: table => new
                {
                    voziloId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    naziv = table.Column<string>(nullable: false),
                    marka = table.Column<string>(nullable: true),
                    brojVrata = table.Column<int>(nullable: true),
                    brojSjedista = table.Column<int>(nullable: true),
                    dostupnost = table.Column<int>(nullable: true),
                    fotografija = table.Column<int>(nullable: true),
                    osnovnaCijena = table.Column<float>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("voziloId", x => x.voziloId);
                });

            migrationBuilder.CreateTable(
                name: "Osoba",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ime = table.Column<string>(nullable: true),
                    prezime = table.Column<string>(nullable: true),
                    datumRodjenja = table.Column<DateTime>(nullable: false),
                    brojTelefona = table.Column<string>(nullable: true),
                    korisnickoIme = table.Column<string>(nullable: true),
                    sifra = table.Column<String>(nullable: true),
                    tip = table.Column<String>(nullable: true)

                },
                constraints: table =>
                {
                    table.PrimaryKey("osobaId", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Grad",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    naziv = table.Column<String>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gradId", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Racun",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    sifraRacuna = table.Column<string>(nullable: false),
                    izons = table.Column<float>(nullable: true),
                    osobaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("racunId", x => x.id);
                    table.ForeignKey(
                        name: "osobaId",
                        column: x => x.osobaId,
                        principalTable: "Osoba",
                        principalColumn: "osobaId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Rezervacija",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brojDana = table.Column<int>(nullable: true),
                    datumPreuzimanja = table.Column<DateTime>(nullable: false),
                    datumVracanja = table.Column<DateTime>(nullable: false),
                    vId = table.Column<int>(nullable: true),
                    gId = table.Column<int>(nullable: true),
                    oId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("rezervacijaId", x => x.id);
                    table.ForeignKey(
                        name: "voziloId",
                        column: x => x.vId,
                        principalTable: "Vozilo",
                        principalColumn: "voziloId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "osobaId",
                        column: x => x.oId,
                        principalTable: "Osoba",
                        principalColumn: "osobaId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "gradId",
                        column: x => x.gId,
                        principalTable: "Grad",
                        principalColumn: "gradId",
                        onDelete: ReferentialAction.NoAction);
                });

  

            migrationBuilder.CreateIndex(
                name: "index_vozila",
                table: "Vozilo",
                column: "voziloId");

            migrationBuilder.CreateIndex(
                name: "index_osoba",
                table: "Osoba",
                column: "osobaId");

            migrationBuilder.CreateIndex(
                name: "index_grad",
                table: "Grad",
                column: "gradId");

            migrationBuilder.CreateIndex(
                name: "index_racun",
                table: "Racun",
                column: "racunId");

            migrationBuilder.CreateIndex(
                name: "index_rezervacija",
                table: "Rezervacija",
                column: "rezervacijaId");
                
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rezervacija");

            migrationBuilder.DropTable(
                name: "Racun");

            migrationBuilder.DropTable(
                name: "Grad");

            migrationBuilder.DropTable(
                name: "Osoba");

            migrationBuilder.DropTable(
                name: "Vozilo");

        }
    }
}