using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace ProjetSalle.Model.People
{
    class RowChief
    {
        public List<Table> TableAvaible { get; set; }

        public int RoomNumber { get; set; }

        public int IDRowChief { get; set; }

        //private List<> listePorte;
        public List<string> CommandsTable { get; set; }


        public RowChief() { }

        /*
         * 
         */
        public void PlaceClient(CustomerGroup groupeClient, int numTable)
        {

        }

        /*
         * 
         */
        public void MettreTable(int numTable)
        {

            Table table = Restaurant.Instance.ListPiece[RoomNumber].ListTable[numTable];

            table.ElementsOnTable.Add("Nappe");

            table.StatusTable = EnumStatus.Ready;
        }

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
    }
}

