using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hakatonb
{
    public class OsobaClass
    {
        protected int id;
        protected string ime;
        protected string prezime;
        protected int godine;
        protected string sifra;
        protected string brojTelefona;
        protected string grad;

        protected bool volonter;

        public OsobaClass(int id, string ime, string prezime, int godine, string sifra, string brojTelefona, string grad)
        {
            this.id = id;
            this.ime = ime;
            this.prezime = prezime;
            this.godine = godine;
            this.sifra = Enkriptuj(sifra);
            this.brojTelefona = brojTelefona;
            this.grad = grad;
        }

        public int Id
        {
            get { return id; }
        }
        public int Ime
        {
            get { return Ime; }
        }
        public int Prezime
        {
            get { return Prezime; }
        }

        public int Godine
        {
            get { return godine; }
        }

        public string Sifra
        {
            get { return sifra; }
        }

        public string BrojTelefona
        {
            get { return brojTelefona; }
        }

        public string Grad
        {
            get { return grad; }
        }

        public bool Volonter
        { 
            get { return volonter; } 
        }

        public string Enkriptuj(string sifra)
        {
            int i;
            string sifra1 = "";
            for (i = 0; i < sifra.Length; i++)
            {
                sifra1 += 'a' + (sifra[i] - 'a') * 5;
            }
            return sifra1;
        }
    }

    public class Volonter : OsobaClass
    {
        private double ukupnaOcena;
        private int brojOcena;
        private string[] stvarneSposobnosti = new string[4] { "medicinska pomoc", "nabavka", "pomoc u kuci", "nabavka lekova" };
        private bool[] sposobnosti;

        public Volonter(int id, string ime, string prezime, int godine, string sifra, string brojTelefona, string grad, bool[] sposobnist)
            : base(id, ime, prezime, godine, sifra, brojTelefona, grad)
        {
            this.ukupnaOcena = 0;
            this.brojOcena = 0;
            sposobnosti = new bool[4] { false, false, false, false };
            this.sposobnosti[0] = sposobnosti[0];
            this.sposobnosti[1] = sposobnosti[1];
            this.sposobnosti[2] = sposobnosti[2];
            this.sposobnosti[3] = sposobnosti[3];
            volonter = true;
        }




        public double ProsecnaOcena()
        {
            if (brojOcena > 0)
            {
                return ukupnaOcena / brojOcena;
            }
            return 0;
        }

        public double UkupnaOcena
        {
            get { return ukupnaOcena; }
        }

        public int BrojOcena
        {
            get { return brojOcena; }
        }

        public bool[] Sposobnosti
        {
            get { return sposobnosti; }
        }
    }

    public class Korisnik : OsobaClass
    {
        private string dodatniPodaci;
        private List<Posao> mojiPoslovi;

        public Korisnik(int id, string ime, string prezime, int godine, string sifra, string brojTelefona, string grad, string dodatniPodaci)
             : base(id, ime, prezime, godine, sifra, brojTelefona, grad)
        {
            this.dodatniPodaci = dodatniPodaci;
            volonter = false;
            mojiPoslovi = new List<Posao>();
        }

        public string DodatniPodaci
        {
            get { return dodatniPodaci; }
        }

        public List<Posao> MojiPoslovi
        {
            get { return mojiPoslovi; }
            set { mojiPoslovi = value; }
        }

        public void DodajPosao(Posao p)
        {
            mojiPoslovi.Add(p);
        }

        public override string ToString()
        {
            string tostr = "Ja sam " + ime + " " + prezime + ". Godine: " + godine + ". Broj telefona: " + brojTelefona + ". \n" + "Dodatni podaci: " + dodatniPodaci;
            return tostr;
        }
    }
}
