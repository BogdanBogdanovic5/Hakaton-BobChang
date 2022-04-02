using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hakatonb
{
    public partial class KorisnikHomePage : Form
    {
        public KorisnikHomePage()
        {
            InitializeComponent();
        }

        Form1 f = new Form1();
        FormaZaPodatke fzp = new FormaZaPodatke();

        private void finalnoPravljenjePoslaDugme_Click(object sender, EventArgs e)
        {
            try
            {
                string naslov = textBox1.Text;
                bool[] sposobnosti = new bool[4];
                sposobnosti[0] = cb1.Checked;
                sposobnosti[1] = cb2.Checked;
                sposobnosti[2] = cb3.Checked;
                sposobnosti[3] = cb4.Checked;
                if (!(cb1.Checked || cb2.Checked || cb3.Checked || cb4.Checked))
                {
                    throw new Exception();
                }



                Posao p = new Posao(fzp.p.sviPoslovi.Count, f.aktivniId, sposobnosti);
                fzp.p.sviPoslovi.Add(p);
                listBox1.Items.Add(p);

                foreach(Korisnik k in fzp.p.korisnici)
                {
                    if(k.Id == f.aktivniId)
                    {
                        k.DodajPosao(p);
                        listBox1.Items.Add(p.ToString());
                        break;
                    }
                }
                

                /*
                listBox1.Items.Clear();
                foreach (Korisnik k in fzp.p.korisnici)
                {
                    if (k.Id == f.aktivniId)
                    {
                        foreach (Posao px in k.MojiPoslovi)
                        {
                            listBox1.Items.Add(px.ToString());
                        }
                    }
                }
                */

                PravljenjePosla.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Niste označili kakva vam je pomoć potrebna");
            }
        }

        private void KorisnikHomePage_Load(object sender, EventArgs e)
        {
            PravljenjePosla.Visible = false;
        }

        private void noviPosaoDugme_Click(object sender, EventArgs e)
        {
            PravljenjePosla.Visible = true;
            cb1.Checked = false;
            cb2.Checked = false;
            cb3.Checked = false;
            cb4.Checked = false;
            textBox1.Text = "";
        }

        private void logoutDugme_Click(object sender, EventArgs e)
        {
            f.Show();
            this.Hide();
        }
    }
}
