using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetSalle.Model.People
{
   public class HotelManager
    {
        public delegate void PlaceClient_EventHandler(Object Client, EventArgs e);
        public event PlaceClient_EventHandler PlaceClient;
        public void AccueilClient()
        {
            Console.WriteLine("Maitre d'hôtel : Bonjour Monsieur quel est votre nom ? Avez vous une reservation ? ");
        }
        public void CheckReservation()

       {
            string nom;
            int id;
            string attitude;
            string commande;
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Server=ORDINATEUR-KISU\\SQLEXPRESS;Database=ProjectC#;Trusted_Connection=true";
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Reservation FROM Customer WHERE Name=@0", conn);
                command.Parameters.Add(new SqlParameter("0", nom));
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        string str = (String.Format("{0} \n", reader[0]));
                        int nbr = int.Parse(str);
                        switch (nbr)
                        {
                            case 0:
                                Console.WriteLine("Maitre d'hôtel : Vous n'avez pas de réservation");
                                break;
                            case 1:
                                Console.WriteLine("Maitre d'hôtel : Vous avez reservé");
                                break;
                        }
                        Console.WriteLine("Maitre d'hôtel : Combien êtes vous ?");
                    }
                }
            }

        }
        public void AssignerTable()
        {
             
             using (SqlConnection conn = new SqlConnection())
             {

                 int nbrPers;
                 int IdTable;
                 conn.ConnectionString = "Server=ORDINATEUR-KISU\\SQLEXPRESS;Database=ProjectC#;Trusted_Connection=true";
                 conn.Open();
                 SqlCommand command = new SqlCommand("Select TOP 1 RoundTable.ID from RoundTable Where Quantity>=@0 AND RoundTable.Vide=1 ", conn); //Select table with enough quantity and not use.
                 command.Parameters.Add(new SqlParameter("0", nbrPers));
                 using (SqlDataReader reader = command.ExecuteReader())
                 {
                     while (reader.Read())
                     {
                         string str = (String.Format("{0} \n", reader[0]));
                         int nbrTable = int.Parse(str);
                         Console.WriteLine("Maitre d'hôtel : Je vous place sur la table " + nbrTable + " Monsieur");
                     }
                 }
                 string string1 = string1;
                 string toFind1 = "table ";
                 string toFind2 = " Monsieur";
                 int start = string1.IndexOf(toFind1) + toFind1.Length;
                 int end = string1.IndexOf(toFind2, start); //Start after the index of 'table' since 'Monsieur' appears twice
                 string string2 = string1.Substring(start, end - start);
                 int nbr2 = int.Parse(string2);
                 SqlCommand command2 = new SqlCommand("Update RoundTable set Vide=0 Where ID=@0 ", conn); //Set the table used to use
                 command2.Parameters.Add(new SqlParameter("0", nbr2));
                 using (SqlDataReader reader2 = command2.ExecuteReader())
                 {
                 }
                 if (PlaceClient != null)
                {
                    PlaceClient(this, EventArgs.Empty);
                }
             }

         
        }       
    }
}
