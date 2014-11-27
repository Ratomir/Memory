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
    public partial class frmTabela : Form
    {
        public frmTabela()
        {
            InitializeComponent();
        }

        private void frmTabela_Load(object sender, EventArgs e)
        {
            SqlCeConnection konekcija = null;
            SqlCeDataAdapter adapter = null;
            SqlCeCommand komanda = null;
            SqlCeDataReader citac = null;

            using (konekcija = new SqlCeConnection("Data Source = " + Application.StartupPath + @"\BazaIgrača.sdf"))
            {
                konekcija.Open();

                using (adapter = new SqlCeDataAdapter())
                using (komanda = new SqlCeCommand("SELECT [ImeIgraca], [Bodovi] FROM Nalog ORDER by Bodovi DESC", konekcija))
                {
                    adapter.SelectCommand = komanda;

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvTabela.DataSource = dt;
                }

                using (komanda = new SqlCeCommand("SELECT [ImeIgraca], [Bodovi] FROM Nalog ORDER by Bodovi DESC", konekcija))
                {
                    citac = komanda.ExecuteReader();

                    if(citac.Read())
                    {
                        lblNajboljiIme1.Text = citac.GetString(0);
                        lblNajboljiBodovi1.Text = citac.GetInt32(1).ToString();
                    }
                    if (citac.Read())
                    {
                        lblNajboljiIme2.Text = citac.GetString(0);
                        lblNajboljiBodovi2.Text = citac.GetInt32(1).ToString();
                    }
                    if (citac.Read())
                    {
                        lblNajboljiIme3.Text = citac.GetString(0);
                        lblNajboljiBodovi3.Text = citac.GetInt32(1).ToString();
                    }
                }
            }
        }
    }
}
