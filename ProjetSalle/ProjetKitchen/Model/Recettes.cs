using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ProjetKitchen.Model
{
    public class Recettes
    {
        public String RecetteName { get; set; }

        public List<Dish> Ustencils { get; set; }

        public int TimeToRealize { get; set; }

        public List<string> ListIngredients { get; set; }

        public void RecupRecette()
        {
            var NomEntree = new List<string>();
            string Entree;
            var NomPlat = new List<string>();
            string Plat;
            var NomDessert = new List<string>();
            string Dessert;
            using (SqlConnection conn = new SqlConnection())
            {

                conn.ConnectionString = "Server=ORDINATEUR-KISU\\SQLEXPRESS;Database=C#_Project;Trusted_Connection=true";
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Name FROM Recipe WHERE Category='Entree'", conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Entree = string.Format("{0} \n",
                            reader[0]);
                        NomEntree.Add(Entree);
                    }
                }
                SqlCommand command2 = new SqlCommand("SELECT Name FROM Recipe WHERE Category='Plat'", conn);
                using (SqlDataReader reader = command2.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Plat = string.Format("{0} \n",
                            reader[0]);
                        NomPlat.Add(Plat);
                    }
                }
                SqlCommand command3 = new SqlCommand("SELECT Name FROM Recipe WHERE Category='Dessert'", conn);
                using (SqlDataReader reader = command3.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Dessert = string.Format("{0} \n",
                            reader[0]);
                        NomDessert.Add(Dessert);
                    }
                }
                Console.ReadLine();
                foreach (var item in NomEntree)
                {
                    Console.WriteLine(item);
                }
                foreach (var item in NomPlat)
                {
                    Console.WriteLine(item);
                }
                foreach (var item in NomDessert)
                {
                    Console.WriteLine(item);
                }
            }
        }

    }
}