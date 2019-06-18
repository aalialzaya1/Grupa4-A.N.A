using System;
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

        public DbSet<Vozilo> Vozilo { get; set; }
        public DbSet<Osoba> Osoba { get; set; }
        public DbSet<Grad> Grad { get; set; }
        public DbSet<Racun> Racun { get; set; }
        public DbSet<Rezervacija> Rezervacija { get; set; }

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
            return Vozilo.Find(vId);
        }
        public Osoba dajOsobu(int oId)
        {
            return Osoba.Find(oId);
        }
        public Racun dajRacun(int rId)
        {
            return Racun.Find(rId);
        }
        public Rezervacija dajRezervaciju(int rId)
        {
            return Rezervacija.Find(rId);
        }
        public Grad dajGrad(int gId)
        {
            return Grad.Find(gId);
        }
    }
}
