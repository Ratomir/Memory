using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Data.SqlServerCe;

namespace Memori
{
    public partial class frmMain : Form
    {
        PictureBox[] nizSlika = new PictureBox[12];

        Stopwatch stoperica = new Stopwatch();

        int[,] matrica = {
                              {0,0,0,0},
                              {0,0,0,0},
                              {0,0,0,0}};

        byte staraVrsta1 = 0, staraKolona1 = 0, staraVrsta2 = 0, staraKolona2 = 0, brojPogodaka=0;
        bool Master = true, pogodak = true;

        Slike slike;

        User korisnik;

        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(string sifra, string ImeIgraca, int brojBodova) 
        {
            InitializeComponent();
            korisnik = new User(ImeIgraca, sifra, brojBodova);

            lblIme.Text = korisnik.Ime;
            lblBodovi.Text = korisnik.BrojBodova.ToString();
        }

        public void UcitavanjeSlicica()
        {
            Random rnd = new Random();
            int trenutniBroj;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    bool vrti;
                    int brojPonavljanja;
                    do
                    {
                        vrti = false;
                        brojPonavljanja = 0;
                        trenutniBroj = rnd.Next(1, 7);
                        for (int k = 0; k < 3; k++)
                        {
                            for (int z = 0; z < 4 && vrti == false; z++)
                            {
                                if (matrica[k, z] == trenutniBroj)
                                    brojPonavljanja++;

                                if (brojPonavljanja == 2)
                                    vrti = true;
                            }
                        }
                    } while (vrti);

                    if (vrti == false)
                    {
                        matrica[i, j] = trenutniBroj;
                    }
                }
            }

            slike = new Slike();

            nizSlika[0] = pct1;
            nizSlika[1] = pct2;
            nizSlika[2] = pct3;
            nizSlika[3] = pct4;
            nizSlika[4] = pct5;
            nizSlika[5] = pct6;
            nizSlika[6] = pct7;
            nizSlika[7] = pct8;
            nizSlika[8] = pct9;
            nizSlika[9] = pct10;
            nizSlika[10] = pct11;
            nizSlika[11] = pct12;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            UcitavanjeSlicica();
        }

        public void ObradiSliku(byte vrstaTemp, byte kolonaTemp)
        {
            if (pogodak == false)
            {
                nizSlika[this.staraVrsta1 * 4 + this.staraKolona1].Enabled = true;
                nizSlika[this.staraVrsta2 * 4 + this.staraKolona2].Enabled = true;
                nizSlika[this.staraVrsta1 * 4 + this.staraKolona1].BackgroundImage = base.BackgroundImage;
                nizSlika[this.staraVrsta2 * 4 + this.staraKolona2].BackgroundImage = base.BackgroundImage;
            }

            nizSlika[vrstaTemp * 4 + kolonaTemp].BackgroundImage = slike[matrica[vrstaTemp, kolonaTemp]];
            
            if (Master)
            {
                this.staraVrsta1 = vrstaTemp;
                this.staraKolona1 = kolonaTemp;
                Master = false;
                pogodak = true;
                nizSlika[vrstaTemp * 4 + kolonaTemp].Enabled = false;
            }
            else
            {
                if (matrica[this.staraVrsta1, this.staraKolona1] == matrica[vrstaTemp, kolonaTemp])
                {
                    nizSlika[vrstaTemp * 4 + kolonaTemp].Enabled = false;
                    nizSlika[this.staraVrsta1 * 4 + this.staraKolona1].Enabled = false;
                    pogodak = true;
                    slPogodci.Text = "" + (++brojPogodaka);
                    spbPogodci.Increment(10);

                    if (brojPogodaka == 6)
                    {
                        timer1.Stop();
                        stoperica.Stop();
                        /*
                         * Pitati za ternarni operator
                         * */
                        //var odgovor = MessageBox.Show("Čestitamo! Ispunili ste kompletnu memoriju za " + ((stoperica.Elapsed.Minutes > 0) ? (stoperica.Elapsed.Minutes.ToString() +"" ) : (stoperica.Elapsed.Seconds))
                        string ispis = "Čestitamo! Ispunili ste kompletnu memoriju za ";

                        if (stoperica.Elapsed.Minutes > 0)
                        {
                            ispis += stoperica.Elapsed.Minutes + ":";
                        }

                        ispis += stoperica.Elapsed.Seconds + " sekundi. U ovoj partiji ste osvojili ";
                        
                        int bodovi=0;

                        if(stoperica.Elapsed.Seconds <= 10)
                        {
                            bodovi = 10;
                        }
                        else if(stoperica.Elapsed.Seconds >= 11 && stoperica.Elapsed.Seconds <= 30)
                        {
                            bodovi = 5;
                        }
                        else if(stoperica.Elapsed.Seconds >= 31 && stoperica.Elapsed.Seconds <= 40)
                        {
                            bodovi = 3;
                        }
                        else
                        {
                            bodovi = 1;
                        }

                        ispis += bodovi + " bodova.\nDa li želite da potvrdite rezultat?";
                        var odgovor = MessageBox.Show(ispis, "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        switch (odgovor)
                        {
                            case DialogResult.No:
                                {
                                    break;
                                }
                            case DialogResult.Yes:
                                {
                                    SqlCeConnection konekcija = null;
                                    SqlCeCommand komanda = null;

                                    using (konekcija = new SqlCeConnection("Data Source = " + Application.StartupPath + @"\BazaIgrača.sdf"))
                                    using (komanda = new SqlCeCommand("UPDATE Nalog SET Bodovi = @Bodovi WHERE Sifra = @Sifra", konekcija))
                                    {
                                        try
                                        {
                                            konekcija.Open();

                                            komanda.Parameters.AddWithValue("@Sifra", korisnik.Sifra);
                                            komanda.Parameters.AddWithValue("@Bodovi", bodovi + Convert.ToInt32(lblBodovi.Text));

                                            if (komanda.ExecuteNonQuery() > 0)
                                            {
                                                MessageBox.Show("Uspješno ste ažurirali svoje bodove.\nUživajte.", "Informacije", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                lblBodovi.Text = Convert.ToString(bodovi + Convert.ToInt32(lblBodovi.Text));
                                            }
                                        }
                                        catch (SqlCeException ex)
                                        {
                                            if (konekcija.State == ConnectionState.Closed)
                                            {
                                                MessageBox.Show("" + ex.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                Application.ExitThread();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Greška pri upisu rezultata.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                    }

                                    return;
                                }
                            default:
                                break;
                        }
                    }
                }
                else
                {
                    pogodak = false;
                    staraVrsta2 = vrstaTemp;
                    staraKolona2 = kolonaTemp;
                    nizSlika[vrstaTemp * 4 + kolonaTemp].Enabled = false;
                }

                Master = true;
                int brojPokusaja = Convert.ToInt16(slPokusaji.Text);
                brojPokusaja++;
                slPokusaji.Text = Convert.ToString(brojPokusaja);
            }
        }

        private void pct1_Click(object sender, EventArgs e)
        {
            ObradiSliku(0, 0);
        }

        private void pct2_Click(object sender, EventArgs e)
        {
            ObradiSliku(0, 1);
        }

        private void pct3_Click(object sender, EventArgs e)
        {
            ObradiSliku(0, 2);
        }

        private void pct4_Click(object sender, EventArgs e)
        {
            ObradiSliku(0, 3);
        }

        private void pct5_Click(object sender, EventArgs e)
        {
            ObradiSliku(1, 0);
        }

        private void pct6_Click(object sender, EventArgs e)
        {
            ObradiSliku(1, 1);
        }

        private void pct7_Click(object sender, EventArgs e)
        {
            ObradiSliku(1, 2);
        }

        private void pct8_Click(object sender, EventArgs e)
        {
            ObradiSliku(1, 3);
        }

        private void pct9_Click(object sender, EventArgs e)
        {
            ObradiSliku(2, 0);   
        }

        private void pct10_Click(object sender, EventArgs e)
        {
            ObradiSliku(2, 1);
        }

        private void pct11_Click(object sender, EventArgs e)
        {
            ObradiSliku(2, 2);
        }

        private void pct12_Click(object sender, EventArgs e)
        {
            ObradiSliku(2, 3);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            slVrijeme.Text = stoperica.Elapsed.Minutes + " : " + stoperica.Elapsed.Seconds;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            foreach (PictureBox item in nizSlika)
            {
                item.Enabled = true;
            }

            btnStart.Enabled = false;
            btnRestart.Enabled = true;

            timer1.Start();stoperica.Start();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            /*
             * Pitati kako opet incijalizovati matricu kao i na početku.
             * Da li to i može?
             * */
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrica[i, j] = 0;
                }
            }

            UcitavanjeSlicica();

            foreach (PictureBox item in nizSlika)
            {
                item.BackgroundImage = base.BackgroundImage;
                item.Enabled = false;
            }

            btnStart.Enabled = true;
            btnRestart.Enabled = false;

            staraVrsta1 = 0; 
            staraKolona1 = 0; 
            staraVrsta2 = 0; 
            staraKolona2 = 0; 
            brojPogodaka = 0;

            Master = true; 
            pogodak = true;

            slPokusaji.Text = "0";
            slPogodci.Text = "0";
            slVrijeme.Text = "0 : 0";

            spbPogodci.Value = 0;

            stoperica.Stop();
            stoperica.Reset();
            timer1.Stop();
        }

        private void btnTabela_Click(object sender, EventArgs e)
        {
            frmTabela formaTabela = new frmTabela();
            formaTabela.Show();
        }
    }
}
