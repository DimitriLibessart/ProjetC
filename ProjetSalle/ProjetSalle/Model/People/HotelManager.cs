using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetSalle.Model.People
{
    class HotelManager
    {
        public List<Table> TableAvaible { get; set; }

        private void GetTableLibre(){
            for (int i = 1; i <= Restaurant.Instance.ListPiece.Count; i++){
                TableAvaible.AddRange(Restaurant.Instance.ListPiece[i].ListTable(x => x.available == true));  
            }
        }

    }

}
