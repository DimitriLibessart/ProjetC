using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSalle.Model.People
{
    class Server
    {

        //private List<> listePorte;
        public List<string> Commands { get; set; }

        public Commandsrestaurant OrderInst { get; set; }

        private Server()
        {
            OrderInst = new Commandsrestaurant();
            /*
                List<string> TmpOrderList = OrderInst.Salle1.Command1.CommandsList;


                foreach (string Commande in TmpOrderList.)
                {
                    foreach(string Recette in Commande)
                    {
                        Commands.Add(Recette);
                        Console.WriteLine(Recette);
                    }
                }
                */

            // Console.WriteLine("Voici la commande de la table :" + IdCommand + "pour le client"+IdCustomer); Serve the command of a customer
            public void Clear()
            {
                // Console.WriteLine("Je débarasse la table :"+IdTable); Clear a table
            }
        }
    }

}