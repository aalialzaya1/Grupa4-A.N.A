using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentACar.Migrations
{
    public partial class rentACarMigracija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grad",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grad", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Osoba",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(nullable: true),
                    DatumRodjenja = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    BrojTelefona = table.Column<string>(nullable: true),
                    KorisnickoIme = table.Column<string>(nullable: true),
                    Sifra = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Osoba", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vozilo",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true),
                    Marka = table.Column<string>(nullable: true),
                    BrojVrata = table.Column<int>(nullable: false),
                    BrojSjedista = table.Column<int>(nullable: false),
                    VrstaGoriva1 = table.Column<int>(nullable: false),
                    Dostupnost = table.Column<bool>(nullable: false),
                    Fotografija = table.Column<int>(nullable: false),
                    OsnovnaCijena = table.Column<double>(nullable: false),
                    Transmisija1 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vozilo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Rezervacija",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BrojDana = table.Column<int>(nullable: false),
                    KlijentId = table.Column<int>(nullable: true),
                    Voziloid = table.Column<int>(nullable: true),
                    NacinPlacanja1 = table.Column<int>(nullable: false),
                    GradPreuzimanjaId = table.Column<int>(nullable: true),
                    GradVracanjaId = table.Column<int>(nullable: true),
                    DatumPreuzimanja = table.Column<DateTime>(nullable: false),
                    DatumVracanja = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervacija", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rezervacija_Grad_GradPreuzimanjaId",
                        column: x => x.GradPreuzimanjaId,
                        principalTable: "Grad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rezervacija_Grad_GradVracanjaId",
                        column: x => x.GradVracanjaId,
                        principalTable: "Grad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rezervacija_Osoba_KlijentId",
                        column: x => x.KlijentId,
                        principalTable: "Osoba",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rezervacija_Vozilo_Voziloid",
                        column: x => x.Voziloid,
                        principalTable: "Vozilo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Racun",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdMenadzera = table.Column<int>(nullable: false),
                    SifraRacuna = table.Column<int>(nullable: false),
                    Iznos = table.Column<double>(nullable: false),
                    RezervacijaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racun", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Racun_Rezervacija_RezervacijaId",
                        column: x => x.RezervacijaId,
                        principalTable: "Rezervacija",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Racun_RezervacijaId",
                table: "Racun",
                column: "RezervacijaId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_GradPreuzimanjaId",
                table: "Rezervacija",
                column: "GradPreuzimanjaId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_GradVracanjaId",
                table: "Rezervacija",
                column: "GradVracanjaId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_KlijentId",
                table: "Rezervacija",
                column: "KlijentId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_Voziloid",
                table: "Rezervacija",
                column: "Voziloid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Racun");

            migrationBuilder.DropTable(
                name: "Rezervacija");

            migrationBuilder.DropTable(
                name: "Grad");

            migrationBuilder.DropTable(
                name: "Osoba");

            migrationBuilder.DropTable(
                name: "Vozilo");
        }
    }
}
