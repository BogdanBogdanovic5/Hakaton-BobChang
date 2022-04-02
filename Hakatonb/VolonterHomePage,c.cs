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
    public partial class VolonterHomePage_c : Form
    {
        public VolonterHomePage_c()
        {
            InitializeComponent();
        }

        private void VolonterHomePage_c_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            panelPoso.Visible = false;
            Form1 f = new Form1();
            FormaZaPodatke fzp = new FormaZaPodatke();
            listBox1.Items.Clear();

            foreach(Volonter v in fzp.p.volonteri)
            {
                if(v.Id == f.aktivniId)
                {
                    foreach (Posao p in fzp.p.sviPoslovi)
                    {
                        if (p.Match(v))
                        {
                            listBox1.Items.Add(p.ToString());
                        }
                    }
                    break;
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            FormaZaPodatke fzp = new FormaZaPodatke();
            panelPoso.Visible = true;
            listBox1.Enabled = false;

            string[] selected = listBox1.SelectedItem.ToString().Split(' ');
            string ime = selected[0];
            string prezime = selected[1];
            string brojTelefona = selected[2];

            ImeIPrezimeLabel.Text = ime + " " + prezime;
            BrojTelefonaLabel.Text = brojTelefona;

            string[] stvarneSposobnosti = new string[4] { "medicinska pomoc", "nabavka", "pomoc u kuci", "nabavka lekova" };
            string zadatak = " ";
            for (int i = 3; i<=selected.Length ;i++)
            {
                zadatak += selected[i] + " ";
            }
            tekstZadatkaLabel.Text = zadatak;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Enabled=true;
            panelPoso.Visible = false;
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
