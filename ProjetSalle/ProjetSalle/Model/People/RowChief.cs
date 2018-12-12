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
            
            /*
             * 
            */
            public void PlaceClient()
            {
            for (int i = 1; i <= Restaurant.Instance.ListPiece.Count; i++){
                TableAvaible.AddRange(Restaurant.Instance.ListPiece[i].ListTable(x => x.available == true));  
             
             CustomerGroup groupCustomer = Restaurant.Instance.GroupeNumber.
            }
            }


            public void MettreNappe()
            {
            }

            public PrendreCommande(int GetPlat)
            {
            Table table = Restaurant.ListePlat.Find(x => x == GetPlat);

            foreach(Customer customer in table.ClientsOnTable.ListCustomer)
            {
               GetTable.AddRange(customer.Command);
            }
            }


            public TransmetCommande()
            {

            
            }

    }
    

}

