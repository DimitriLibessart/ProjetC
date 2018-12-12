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



    }
}