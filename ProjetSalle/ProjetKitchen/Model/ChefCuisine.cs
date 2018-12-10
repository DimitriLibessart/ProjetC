using ProjetKitchen.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetKitchen.Model
{
    class ChefCuisine
    {
        public List<Recettes> Orders { get; set; }

        /*
         * Get the list of Orders 
         * Verif the Availability of Ingrédients
         */
        public ChefCuisine()
        {
            /*
            private Recettes Order;

            GetCommandFromRestaurant();

            foreach(Order in Orders)
            {
                if( VerifIngredient(Order) )
                {
                    AlarmIngredientNotAvailable();
                }
            }
            */
        }

        /*
         * Get the list of Commands from the Restaurant
         * return : List<Recettes> Orders
         */
        private void GetCommandFromRestaurant()
        {
            //Get the Command List from the JSON or BDD
            //commands = 
        }

        /*
         * Verif that Ingredients for a Command are available
         * Param: command that we want to check
         * return: boolean
         */ 
        private Boolean VerifIngredient(Recettes Order)
        {
            if(false){
                //Console.WriteLine("Les ingrédients de cette commande ne sont pas disponnible \n");
                //return false;
            }
            else
            {
                return true;
            }
        }

        /*
         * Alarm le serveur dans le cas ou la commande n'est pas dispo
         */ 
        private void AlarmIngredientNotAvailable()
        {
            //envoi un message au serveur pour lui demander une nouvelle commande
        }
    }
}
