using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace Memori
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnNoviIgrac_Click(object sender, EventArgs e)
        {
            if (txtImeIgraca.Text.Length == 0)
            {
                var odgovor = MessageBox.Show("Niste unjeli naziv! Ponovite unos. ","Greška", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                switch (odgovor)
                {
                    case DialogResult.No:
                        break;
                    case DialogResult.Yes:
                        {
                            txtImeIgraca.SelectionStart = 1;
                        }
                        break;
                    default:
                        break;
                }
            }
            else if (txtSifra.Text.Length == 0)
            {
                var odgovor = MessageBox.Show("Niste unjeli šifru! Ponovite unos. ", "Greška", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                switch (odgovor)
                {
                    case DialogResult.No:
                        break;
                    case DialogResult.Yes:
                        {
                            /*
                             * Pitati profesora kako da se vratim na textBox.
                             * */
                            txtSifra.SelectionStart = 1;
                        }
                        break;
                    default:
                        break;
                }
            }
            else
            {
                SqlCeConnection konekcija = null;
                SqlCeCommand komanda = null;
                using (konekcija = new SqlCeConnection("Data Source = " + Application.StartupPath + @"\BazaIgrača.sdf"))
                using (komanda = new SqlCeCommand("INSERT INTO Nalog(Sifra, Bodovi, ImeIgraca) VALUES (@Sifra, @Bodovi, @ImeIgraca)", konekcija))
                {
                    try
                    {
                        konekcija.Open();

                        komanda.Parameters.AddWithValue("@Sifra", txtSifra.Text);
                        komanda.Parameters.AddWithValue("@Bodovi", 0);
                        komanda.Parameters.AddWithValue("@ImeIgraca", txtImeIgraca.Text);

                        if (komanda.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Uspješno ste se upisali u igricu.\nDobrodošlicu vam želi RVS tim.\nUživajte.", "Informacije", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            MessageBox.Show("Korisnik sa unjetom šifrom već postoji.\nMolimo Vas da unesete drugu šifru.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCeConnection konekcija = null;
            SqlCeCommand komanda = null;
            SqlCeDataReader citac = null;

            using (konekcija = new SqlCeConnection("Data Source = " + Application.StartupPath + @"\BazaIgrača.sdf"))
            using (komanda = new SqlCeCommand("SELECT * FROM Nalog WHERE Sifra = @Sifra", konekcija))
            {
                try
                {
                    konekcija.Open();

                    komanda.Parameters.AddWithValue("@Sifra", txtSifra.Text);
                    citac = komanda.ExecuteReader();

                    if ((citac.Read()) && (txtSifra.Text == citac.GetString(0)) && (txtImeIgraca.Text == citac.GetString(2)))
                    {
                        MessageBox.Show("Uspješno ste se ulogovali u igricu.\nDobrodošlicu vam želi RVS tim.\nUživajte.", "Informacije", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmMain glavnaForma = new frmMain(citac.GetString(0), citac.GetString(2), citac.GetInt32(1));

                        /*
                         * Provjeriti da li se ovde zatvara konekcija na bazu.
                         * NE ZATVARA SE FORMA!!!
                         * OPASNO, OPASNO, OPASNO!!!
                         * MORAM RUČNO DA UGASIM DEBUGER!
                         * */
                        this.Hide();
                        glavnaForma.Show();
                    }
                    else
                    {
                        MessageBox.Show("Korisnik sa unjetom šifrom već postoji.\nMolimo Vas da unesete drugu šifru.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        MessageBox.Show("Korisnik sa unjetom šifrom već postoji.\nMolimo Vas da unesete drugu šifru.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                finally
                {
                    citac.Close();
                }
            }
        }
    }
}
