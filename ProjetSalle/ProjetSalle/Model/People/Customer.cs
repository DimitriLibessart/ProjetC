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
        public int ID { get; set; }

        public List<string> Command { get; set; }


        /* 
         * param : 
         * return : 
         */ 
        public void Arriver()
        {
            Console.WriteLine("Le client arrive");
        }

        /* 
         * param : 
         * return : 
         */ 
        public void Commander()
        {
            Console.WriteLine("Je desire commander : " + Command); //Parse Commande
            // set Command
        }

        /* 
         * param : 
         * return : 
         */ 
        public void Commander2()
        {
            Console.WriteLine("Si ce n'est pas possible j'aimerais alors commander ceci : " + Command); //Parse Commande2
        }

    }
    
}
