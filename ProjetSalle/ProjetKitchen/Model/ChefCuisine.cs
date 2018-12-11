using ProjetKitchen.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetKitchen.Model
{
    class ChefCuisine
    {
        private static ChefCuisine _instance;
        static readonly object instanceLock = new object();

        private List<Recettes> Order;

        /*
         * Get the list of Orders 
         * Verif the Availability of Ingrédients
         */
        private ChefCuisine()
        {
            /*

            GetCommandFromRestaurant();

            foreach(Order in Orders)
            {
                if( VerifIngredient(Order) )
                {
                    AlarmIngredientNotAvailable();
                }
            }
            */
            DisplayOrders();

        }

        private void DisplayOrders()
        {
            int nbrCuisinier = InitKitchen.Config.Kitchen.Cuisiner ;

            foreach (Recettes recette in Order)
            {
                foreach (Cooker cook in List<Cooker>) {
                    if (cook.ID == nbrCuisinier % nbrCuisinier)
                    {
                        cook.TravailList.Add(recette);
                    }
                }
            }
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

        // If no instance of the kitchen, then, create one
        public static ChefCuisine Instance
        {
            get
            {
                if (_instance == null) //Les locks prennent du temps, il est préférable de vérifier d'abord la nullité de l'instance.
                {
                    lock (instanceLock)
                    {
                        if (_instance == null) //on vérifie encore, au cas où l'instance aurait été créée entretemps.
                            _instance = new ChefCuisine();
                    }
                }
                return _instance;
            }
        }
    }
}
