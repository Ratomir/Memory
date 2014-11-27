using System;
using System.Collections.Generic;
using System.Text;

namespace Memori
{
    class User
    {
        private string ime;

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        private string sifra;

        public string Sifra
        {
            get { return sifra; }
            set { sifra = value; }
        }

        private int brojBodova;

        public int BrojBodova
        {
            get { return brojBodova; }
            set { brojBodova = value; }
        }

        public User(string ime, string sifra, int bodovi)
        {
            Ime = ime;
            Sifra = sifra;
            BrojBodova = bodovi;
        }
    }
}
