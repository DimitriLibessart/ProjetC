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
        public List<string> CommandsTable { get; set; }

        private Server(){}

        private ServiceTable(int tableToServ)
        {
            Table table = Restaurant.ListTable.Find(x => x == tableToServ);

            foreach(Customer customer in table.ClientsOnTable.ListCustomer)
            {
                CommandsTable.AddRange(customer.Command);
            }
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
        }

            // Console.WriteLine("Voici la commande de la table :" + IdCommand + "pour le client"+IdCustomer); Serve the command of a customer
        public void Clear()
         {
                // Console.WriteLine("Je débarasse la table :"+IdTable); Clear a table
        }
    }
}