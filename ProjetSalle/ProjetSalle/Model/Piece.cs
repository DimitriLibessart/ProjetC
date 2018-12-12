using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetSalle.Model.People;

namespace ProjetSalle.Model
{
    class Piece
    {
        public int IDPiece { get; set; }

        public List<Table> ListTable { get; set; }

        public List<RowChief> ListRowChiefs { get; set; }

        public List<RoomClerk> ListRoomClerk { get; set; }

        public List<Server> ListServer { get; set; }

    }
}