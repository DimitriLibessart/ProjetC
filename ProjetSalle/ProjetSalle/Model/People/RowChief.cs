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
        

        public List<string> GetTable { get; set; }

        public int Send { get; set; }


            public void PlaceClient()
            {
            }
            public void PresenteCarte()
            {
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


            public void PrendreCommandePartie()
            {
            }

            public TransmetCommande()
            {

            
            }

    }
    

}

