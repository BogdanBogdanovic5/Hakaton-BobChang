namespace Hakatonb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int aktivniId;
        FormaZaPodatke fzp = new FormaZaPodatke();

        private void Form1_Load(object sender, EventArgs e)
        {
            fzp.Show();
            fzp.Close();
            panelZaRegister.Visible = false;
            dodatnoOVamaPanel.Visible = false;
            registerLoginDugmePanil.Visible = true;
            LoginPanel.Visible = false;
            NazadDugme.Visible = false;
            aktivniId = -1;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            registerLoginDugmePanil.Visible = false;
            panelZaRegister.Visible = true;
            NazadDugme.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {
                skillsetPanel.Visible = false;
                dodatnoOVamaPanel.Visible = true;
            }
            else
            {
                skillsetPanel.Visible = true;
                dodatnoOVamaPanel.Visible = false;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            registerLoginDugmePanil.Visible = false;
            LoginPanel.Visible = true;
            panelZaRegister.Visible = false;
            NazadDugme.Visible = true;
        }

        private void NazadDugme_Click(object sender, EventArgs e)
        {
            NazadDugme.Visible = false;
            LoginPanel.Visible = false;
            panelZaRegister.Visible = false;
            registerLoginDugmePanil.Visible = true;
        }

        private void RegistrujSeDugme_Click(object sender, EventArgs e)
        {

            try
            {
                string ime = rIme.Text;
                string prezime = rPrezime.Text;
                int godine = int.Parse(rGodine.Text);
                string sifra = rSifra.Text;
                string brojTelefona = rBrojTelefona.Text;
                string grad = rGrad.Text;


                if (ime == "" || prezime == "" || sifra == "" || brojTelefona == "" || grad == "") { throw new Exception(); }
                if (radioButton1.Checked)
                {
                    // volonter
                    bool[] sposobnosti = new bool[4];
                    sposobnosti[0] = checkBox1.Checked;
                    sposobnosti[1] = checkBox2.Checked;
                    sposobnosti[2] = checkBox3.Checked;
                    sposobnosti[3] = checkBox4.Checked;
                    int id = fzp.p.sveOsobe.Count;
                    OsobaClass o = new Volonter(id, ime, prezime, godine, sifra, brojTelefona, grad, sposobnosti);
                    fzp.p.sveOsobe.Add(o);
                    fzp.p.volonteri.Add(o);
                    aktivniId = id;

                    VolonterHomePage_c v = new VolonterHomePage_c();
                    v.Show();
                    this.Hide();
                }
                else
                {
                    // korisnik
                    string dodatniPodaci = rDodatniPodaci.Text;
                    int id = fzp.p.sveOsobe.Count;
                    OsobaClass o = new Korisnik(id, ime, prezime, godine, sifra, brojTelefona, grad, dodatniPodaci);
                    fzp.p.sveOsobe.Add(o);
                    fzp.p.korisnici.Add(o);
                    aktivniId = id;

                    KorisnikHomePage k = new KorisnikHomePage();
                    k.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Unesite ispravne podatke");
            }
        }


        private void UlogujSeDugme_Click(object sender, EventArgs e)
        {
            bool nadjen = false;

            string brojTelefona = tBrojTelefona.Text;
            string sifra = tSifra.Text;

            foreach (OsobaClass clan in fzp.p.sveOsobe)
            {
                if (clan.BrojTelefona == brojTelefona)
                {
                    nadjen = true;
                    if (clan.Sifra == clan.Enkriptuj(sifra))
                    {
                        aktivniId = clan.Id;
                        if (clan.Volonter)
                        {
                            VolonterHomePage_c v = new VolonterHomePage_c();
                            v.Show();
                        }
                        else
                        {
                            KorisnikHomePage k = new KorisnikHomePage();
                            k.Show();
                        }
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Pogresana sifra");
                    }
                }
            }
            if (!nadjen)
            {
                MessageBox.Show("Pogresan broj telefona");
            }
        }
    }
}