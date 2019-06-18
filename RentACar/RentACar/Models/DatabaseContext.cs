using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace RentACar.Models
{
    public class DatabaseContext : DbContext {
        public static DatabaseContext instance;

        public static DatabaseContext getInstance()
        {
            return instance;
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) => instance = this;

        public DbSet<Vozilo> Vozila { get; set; }
        public DbSet<Osoba> Osobe { get; set; }
        public DbSet<Grad> Gradovi { get; set; }
        public DbSet<Racun> Racuni{ get; set; }
        public DbSet<Rezervacija> Rezervacije { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vozilo>().ToTable("Vozilo");
            modelBuilder.Entity<Osoba>().ToTable("Osoba");
            modelBuilder.Entity<Grad>().ToTable("Grad");
            modelBuilder.Entity<Racun>().ToTable("Racun");
            modelBuilder.Entity<Rezervacija>().ToTable("Rezervacija");
     
        }
        public Vozilo dajVozilo(int vId)
        {
            return Vozila.Find(vId);
        }
        public Osoba dajOsobu(int oId)
        {
            return Osobe.Find(oId);
        }
        public Racun dajRacun(int rId)
        {
            return Racuni.Find(rId);
        }
        public Rezervacija dajRezervaciju(int rId)
        {
            return Rezervacije.Find(rId);
        }
        public Grad dajGrad(int gId)
        {
            return Gradovi.Find(gId);
        }
        public List<Vozilo> PretragaPoMarki(String marka)         {             List<Vozilo> vozila = Vozila.Where((Vozilo vozilo) => vozilo.Marka.Equals(marka)).ToList();             return vozila;         }         public List<Vozilo> PretragaPoBrojuSjedista(String brSjedista)         {             List<Vozilo> vozila = Vozila.Where((Vozilo vozilo) => vozilo.BrojSjedista.Equals(brSjedista)).ToList();             return vozila;         }         public List<Vozilo> PretregaPoDatumu()         {             List<Vozilo> vozila = Vozila.Where((Vozilo vozilo) => vozilo.Dostupnost.Equals(1)).ToList();             return vozila;         }
    }
}
