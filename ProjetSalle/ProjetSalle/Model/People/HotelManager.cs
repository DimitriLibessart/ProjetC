using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetSalle.Model.People
{
    class HotelManager
    {
        public List<Table> TableAvaible { get; set; }

        public HotelManager()
        {

            //Initialisation of the availables tables
            TableAvaible = new List<Table>();

            PlacementClient();

            /*
            //if new client arrived then verify that tables are available
            Thread verifTableDispo = new Thread(new ThreadStart(PlacementClient));

            verifTableDispo.Start();
            */
        }

        //Regarde si des clients sont en attente et cherche à les placer
        public void PlacementClient()
        {
            List<CustomerGroup> newClients = Restaurant.Instance.ListNewClients;
            if (newClients != null)
            {
                Console.WriteLine("Recherche de tables dispo pour les nouveau clients\n");
                GetTableLibre();

                if (TableAvaible.Count != 0)
                {
                    Console.WriteLine("Recherche de places pour les clients\n");
                    foreach(CustomerGroup customers in newClients)
                    {
                        if(TableAvaible.Find(x => x.CapaciteTable <= customers.NumberOfCustomer) != null) 
                        {
                            Table table = TableAvaible.Find(x => x.CapaciteTable <= customers.NumberOfCustomer);
                            if(table != null)
                            {
                                table.ClientsOnTable = customers;
                                Console.WriteLine("Affectation des clients à une tables\n");
                                Restaurant.Instance.ListClients.Add(customers);
                                Restaurant.Instance.ListNewClients.Remove(customers);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Pas de place disponible pour le groupe\n");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Ils n'y a plus de table disponnible, les clients attendent...\n");
                }
            }
            Thread.Sleep(1000);
        }
        // Get the list of tables availables in Restaurant
        private void GetTableLibre(){
            Console.WriteLine("Recherche de tables libre");

            foreach(Piece piece in Restaurant.Instance.ListPiece)
            {
                foreach (Table table in piece.ListTable.FindAll(x => x.StatusTable == EnumStatus.Clean))
                {
                    Console.WriteLine("La table " + table.NumTable + " de la salle " + piece.IDPiece + " est libre\n");
                    TableAvaible.Add(table);
                }
            }
        }

        //For each Clients who leave, incement the benefices of the restaurant
        private void GetPaiementFromClients(CustomerGroup customers)
        {
            int numberOfClients = customers.NumberOfCustomer;
            foreach(Customer customer in customers.ListCustomer)
            {
                Restaurant.Instance.Benefices += 20;
                

            }
        }

    }

}
