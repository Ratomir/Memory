using System;
using System.Collections.Generic;
using System.Text;

using System.Drawing;

namespace Memori
{
    class Slike
    {
        private Image[] nizSlika = new Image[6];

        public Image[] NizSlika
        {
            get { return nizSlika; }
            set { nizSlika = value; }
        }

        public Slike()
        {
            NizSlika[0] = Properties.Resources.Pozadina1;
            NizSlika[1] = Properties.Resources.Pozadina2;
            NizSlika[2] = Properties.Resources.Pozadina3;
            NizSlika[3] = Properties.Resources.Pozadina4;
            NizSlika[4] = Properties.Resources.Pozadina5;
            NizSlika[5] = Properties.Resources.Pozadina6;
        }

        public Image this[int index]
        {
            get { return NizSlika[index-1]; }
            set { /* set the specified index to value here */ }
        }
    }
}
