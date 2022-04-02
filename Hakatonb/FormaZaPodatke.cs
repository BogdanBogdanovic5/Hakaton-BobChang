using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hakatonb
{
    public partial class FormaZaPodatke : Form
    {
        public FormaZaPodatke()
        {
            InitializeComponent();
        }

        public Podaci p = new Podaci();

        private void FormaZaPodatke_Load(object sender, EventArgs e)
        {
            Korisnik k1 = new Korisnik(0, "Mihajlo", "Petrovic", 32, "Diznac95", "0600045600", "Nis", "Fali mu leva noga");
            Korisnik k2 = new Korisnik(1, "Miodrag", "Mihajlovic", 22, "mikimaus2", "0617435600", "Leskovac", "Fali mu desna noga");
            Korisnik k3 = new Korisnik(2, "Tamara", "Dragicevic", 38, "kikirikisedamsest", "0640004500", "Nis", "Nema desnu saku");
            Korisnik k4 = new Korisnik(3, "Milica", "Petrovic", 32, "sifra123", "0600745601", "Novi Sad", "Paralizovana");

            Volonter v1 = new Volonter(4, "Aleksa", "Janackov", 19, "opasanLik552", "062953729", "Novi Sad", new bool[] { true, false, false, true });
            Volonter v2 = new Volonter(5, "Milorad", "Zivkovic", 42, "sicevoFTW5378", "062956429", "Nis", new bool[] { true, false, false, true });
            Volonter v3 = new Volonter(6, "Dragoljub", "Spasic", 26, "5h394hswe*/4", "061953796", "Zajecar", new bool[] { true, false, false, true });
            Volonter v4 = new Volonter(7, "Andjela", "Krstic", 19, "neverovatnoDobraSifra123", "063956972", "Bela Palanka", new bool[] { true, false, false, true });

            Posao p1 = new Posao(0, 2, new bool[] { true, false, false, true });
            Posao p2 = new Posao(1, 1, new bool[] { true, false, false, true });
            Posao p3 = new Posao(2, 0, new bool[] { true, false, false, true });
            Posao p4 = new Posao(3, 0, new bool[] { true, false, false, true });
            Posao p5 = new Posao(4, 3, new bool[] { true, false, false, true });

            p.sveOsobe.Add(k1);
            p.sveOsobe.Add(k2);
            p.sveOsobe.Add(k3);
            p.sveOsobe.Add(k4);

            p.korisnici.Add(k1);
            p.korisnici.Add(k2);
            p.korisnici.Add(k3);
            p.korisnici.Add(k4);

            p.sveOsobe.Add(v1);
            p.sveOsobe.Add(v2);
            p.sveOsobe.Add(v3);
            p.sveOsobe.Add(v4);

            p.volonteri.Add(v1);
            p.volonteri.Add(v2);
            p.volonteri.Add(v3);
            p.volonteri.Add(v4);

            p.sviPoslovi.Add(p1);
            p.sviPoslovi.Add(p2);
            p.sviPoslovi.Add(p3);
            p.sviPoslovi.Add(p4);
            p.sviPoslovi.Add(p5);

            Hide();
        }
    }
}
