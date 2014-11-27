using System;
using System.Collections.Generic;
using System.Text;

using System.Windows.Forms;

namespace Memori
{
    class Picture
    {
        private PictureBox[] nizPictureBox = new PictureBox[12];

        public PictureBox[] NizPictureBox
        {
            get { return nizPictureBox; }
            set { nizPictureBox = value; }
        }

        public Picture(PictureBox pct, int index)
        {
            nizPictureBox[index] = pct;
        }
    }
}
