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
        public Commandsrestaurant orderInst { get; set; }
        
        private Server()
            {
                orderInst = new Commandsrestaurant();
                List<string> TmpOrderList = orderInst.Salle1.Command1;
            
                foreach (string Commande in TmpOrderList.CommandsList)
                {
                    foreach(string Recette in Commande)
                    {
                        Commands.Add(Recette);
                        Console.WriteLine(Recette);
                    }
                }

            }

        }
}