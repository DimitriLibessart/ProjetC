using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSalle.Model.People
{
    class Server
    {
        public int IDServer { get; set; }

        public int RoomNumber { get; set; }

        public Server(){}


        /*
         * 
         */
        public void ServicePlats()
        {

        }

        /* Clear the Table (Remove all elements and clear it)
         * param: (int) number of the table to clear in the room
         */
        public void ClearTable(int numTable)
        {
            Restaurant.Instance.ListPiece[RoomNumber].ListTable[numTable].StatusTable = EnumStatus.Clean;
        }
    }
}