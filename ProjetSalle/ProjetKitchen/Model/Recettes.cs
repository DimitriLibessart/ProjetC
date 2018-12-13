using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading;

namespace ProjetKitchen.Model
{
     public class Recettes
    {
        public String RecetteName { get; set; }

        public List<Dish> Ustencils { get; set; }

        public int TimeToRealize { get; set; }

        public Recettes()
        {
            Thread getRecettes = new Thread(new ThreadStart(RecipeContain));
        }

        //A modifier (strings en recette) et cette list est a mettre dans l init cuisine
        public void RecipeContain()
        {
            List<string> Ustencils2 = new List<string>();
            List<string> ListIngredients = new List<string>();

            using (SqlConnection conn = new SqlConnection())
            {
                int IDRecipe = 0;
                string NomRecette = "Veloute de potiron et carotte";
                conn.ConnectionString = "Server=ORDINATEUR-KISU\\SQLEXPRESS;Database=C#_Project;Trusted_Connection=true";
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT ID FROM Recipe WHERE Name=@0", conn);
                command.Parameters.Add(new SqlParameter("0", NomRecette));
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        IDRecipe = int.Parse(string.Format("{0} \n",
                            reader[0]));
                        Console.WriteLine("ID :" + IDRecipe);
                    }
                }
                SqlCommand command2 = new SqlCommand("SELECT ID FROM Step WHERE ID_Recipe=@0", conn);
                command2.Parameters.Add(new SqlParameter("0", IDRecipe));

                using (SqlDataReader reader = command2.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Ustencils2.Add(string.Format("{0}",
                            reader[0]));
                    }
                }
                SqlCommand command3 = new SqlCommand("SELECT ID_Ingredient FROM Step WHERE ID_Recipe=@0", conn);
                command3.Parameters.Add(new SqlParameter("0", IDRecipe));

                using (SqlDataReader reader = command3.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListIngredients.Add(string.Format("{0}",
                            reader[0]));
                    }
                }

                foreach (string item in Ustencils2)
                {
                    Dish dish = new Dish();
                    Ustencils.Add(dish);
                }
            }
        }
    }
}