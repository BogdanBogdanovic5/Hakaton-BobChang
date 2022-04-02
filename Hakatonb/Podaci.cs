using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hakatonb
{
    public class Podaci
    {
        public List<OsobaClass> sveOsobe;
        public List<OsobaClass> volonteri;
        public List<OsobaClass> korisnici;

        public List<Posao> sviPoslovi;

        public Podaci()
        {
            sveOsobe = new List<OsobaClass>();
            volonteri = new List<OsobaClass>();
            korisnici = new List<OsobaClass>();

            sviPoslovi = new List<Posao>(); 
        }
    }

}
