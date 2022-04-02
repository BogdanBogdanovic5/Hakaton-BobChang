using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hakatonb
{
    public class Posao
    {
        int idposla;
        int idkorisnika;
        int idvolontera;
        bool zauzet;
        bool zavrsen;
        bool[] sposobnosti = new bool[4];

        public Posao(int idposla, int idkorisnika, bool[] sposobnosti)
        {
            this.idposla = idposla;
            this.idkorisnika = idkorisnika;
            this.zauzet = false;
            this.zavrsen = false;
            this.sposobnosti = sposobnosti;
            this.idvolontera = -1;
        }

        public void ZauzmiPosao(Volonter v)
        {
            zauzet = true;
            idvolontera = v.Id;
        }

        public bool Match(Volonter v)
        {
            Form1 f= new Form1();
            FormaZaPodatke fzp = new FormaZaPodatke();
            if (v.Grad == fzp.p.sveOsobe[idkorisnika].Grad)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (sposobnosti[i])
                    {
                        if (!v.Sposobnosti[i])
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            return false;
        }

        public bool ZaPrikaz()
        {
            return !zauzet;
        }

        public override string ToString()
        {
            Form1 f = new Form1();
            FormaZaPodatke fzp = new FormaZaPodatke();
            string[] stvarneSposobnosti = new string[4] { "medicinska pomoc", "nabavka", "pomoc u kuci", "nabavka lekova" };
            string posaoStr = "";
            //posaoStr += fzp.p.sveOsobe[idkorisnika].Ime + " " + fzp.p.sveOsobe[idkorisnika].Prezime + " " +  fzp.p.sveOsobe[idkorisnika].BrojTelefona + " ";
            for(int i =0;i<4;i++)
            {
                if(sposobnosti[i])
                {
                    posaoStr += stvarneSposobnosti[i] + " ";
                }
            }
            return posaoStr;
        }

        public bool[] Sposobnosti
        {
            get { return sposobnosti; }
        }
    }
}
