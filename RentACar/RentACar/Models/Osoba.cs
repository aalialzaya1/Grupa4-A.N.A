using System; namespace RentACar.Models {     public class Osoba : IRegistracija, IPrijava     {         private int id;         private String ime;         private String prezime;         private DateTime datumRodjenja;         private String email;         private String brojTelefona;         private String korisnickoIme;         private String sifra;          public Osoba()         {          }          public Osoba(int id, string ime, string prezime, DateTime datumRodjenja, string email, string brojTelefona, string korisnickoIme, string sifra)         {             this.id = id;             this.ime = ime;             this.prezime = prezime;             this.datumRodjenja = datumRodjenja;             this.email = email;             this.brojTelefona = brojTelefona;             this.korisnickoIme = korisnickoIme;             this.sifra = sifra;         }          public int Id { get => id; set => id = value; }         public string Ime { get => ime; set => ime = value; }         public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }         public string Email { get => email; set => email = value; }         public string BrojTelefona { get => brojTelefona; set => brojTelefona = value; }         public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }         public string Sifra { get => sifra; set => sifra = value; }

        public void prijava(string korisnickoIme, string sifra)
        {
            throw new NotImplementedException();
        }

        public void registriraj()
        {
            throw new NotImplementedException();
        }
    } }  