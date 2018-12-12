using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSalle.Model.People
{
    class Server
    {
        public int RoomNumber { get; set; }

        //private List<> listePorte;
        public List<string> CommandsTable { get; set; }

        public Server(){}

        /* Get Commands from Clients on the specified table and add them to the list of Commands
         * Param: (int) Number of the table
         */ 
        private void PriseCommandes(int tableToServ)
        {
            Table table = Restaurant.Instance.ListPiece[RoomNumber].ListTable[tableToServ];

            foreach (Customer customer in table.ClientsOnTable.ListCustomer)
            {
                CommandsTable.AddRange(customer.Command);
            }
        }


        public void Clear()
         {
                // Console.WriteLine("Je débarasse la table :"+IdTable); Clear a table
        }
    }
}