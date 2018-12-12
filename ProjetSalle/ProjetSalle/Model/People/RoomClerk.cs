using ProjetSalle.Model.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSalle.Model.People
{
    //Commis_salle
    class RoomClerk : Server 
    {
        public int IDRoomClerk { get; set; }

        public void ServirPainEau(int numTable)
        {
            Restaurant.Instance.ListPiece[RoomNumber].ListTable[numTable].ElementsOnTable.AddRange(new List<String>{ "Pain", "Eau"});
        }
    }
}