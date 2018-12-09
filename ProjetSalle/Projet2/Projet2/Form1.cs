using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace Projet2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Customer Michel = new Customer();
            Michel.Arriver(pictureBox3);
            HotelManager Denis = new HotelManager();
            Denis.AccueilClient(talk);
            
        }
        private void Valider_Click(object sender, EventArgs e)
        {
            HotelManager Denis2 = new HotelManager();
            Denis2.CheckReservation(talk,Nom,tbtxt2);
        }

        private void BtnPers_Click(object sender, EventArgs e)
        {
            HotelManager Denis3 = new HotelManager();
            Denis3.AssignerTable(talk,tboxPers);
        }

        private void Testbtn_Click(object sender, EventArgs e)
        {

        }
    }
}

