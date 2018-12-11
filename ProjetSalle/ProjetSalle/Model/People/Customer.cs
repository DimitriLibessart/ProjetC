using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetSalle.Model.People
{
    class Customer
    {
        string Commande { get; set; }
        string Commande2 { get; set; }
        public void Arriver()
        {
            Console.WriteLine("Le client arrive");
        }
        public void Commander()
        {
            Console.WriteLine("Je desire commander : " + Commande); //Parse Commande
        }
        public void Commander2()
        {
            Console.WriteLine("Si ce n'est pas possible j'aimerais alors commander ceci : " + Commande); //Parse Commande2
        }
    }
}
