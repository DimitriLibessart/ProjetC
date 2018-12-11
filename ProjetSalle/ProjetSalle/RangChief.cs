using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet2
{
    class RangChief
    {
        PictureBox _pbox;
        public void Arriver(PictureBox pbox)
        {
            _pbox = pbox;
            pbox.Location = new Point(pbox.Location.X - 150, pbox.Location.Y + 150);
        }
    }
}
