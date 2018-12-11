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
<<<<<<< HEAD
        string Command1 { get; set; }
        string Command2 { get; set; }
=======
        string Commande { get; set; }
        string Commande2 { get; set; }
>>>>>>> d7df1a9e4bdcd4c9095cd8e995d711986453772a
        public void Arriver()
        {
            Console.WriteLine("Le client arrive");
        }
        public void Commander()
        {
<<<<<<< HEAD
            Console.WriteLine("Je desire commander : " + Command1); //Parse Commande
        }
        public void Commander2()
        {
            Console.WriteLine("Si ce n'est pas possible j'aimerais alors commander ceci : " + Command2); //Parse Commande2
=======
            Console.WriteLine("Je desire commander : " + Commande); //Parse Commande
        }
        public void Commander2()
        {
            Console.WriteLine("Si ce n'est pas possible j'aimerais alors commander ceci : " + Commande); //Parse Commande2
>>>>>>> d7df1a9e4bdcd4c9095cd8e995d711986453772a
        }
    }
}
