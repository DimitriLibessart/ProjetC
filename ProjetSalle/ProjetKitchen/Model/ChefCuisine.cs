using ProjetKitchen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ProjetKitchen.Model
{
    class ChefCuisine
    {
        string Str1 { get; set; }
        bool Bool1 { get; set; }
        public void ChangeStr(string Str1)
        {
            if (Str1 == "Bonjour")
            {
                Console.WriteLine("Le bonjour a été reçu");
            }
            else
            {
                Console.WriteLine("Erreur");
            }
        }
        public void ChangeBool(bool Bool1)
        {
            Bool1 = false;
            Console.WriteLine(Bool1);
            Bool1 = true;
            Console.WriteLine(Bool1);

        }
        private static ChefCuisine _instance;
        static readonly object instanceLock = new object();

        //List of Commands arrived
        public List<String> Orders { get; set; } = new List<String> {"test1", "test1", "test1" };

        public List<Recettes> OrdersArrived { get; set; } 

        public List<Recettes> RecettesList { get; set; } 

        


        //Class Config JSON
        public Config KitchenOrder { get; set; }


        //Singleton 
        private ChefCuisine()
        {
        }

        /*
         * Get the list of Orders 
         * Verif the Availability of Ingrédients
         */
        public void ChefCuisineActions()
        {
            /*
            GetCommandFromRestaurant();

            foreach(Order in RestaurantOrders)
            {
                if( VerifIngredient(Order) )
                {
                    AlarmIngredientNotAvailable();
                }
            }
            DisplayOrders();
            */
        }

        private void DisplayOrders()
        {
            /*
            int nbrCuisinier = KitchenOrder.KitchenConf.Cuisiner ;

            foreach (Recettes recette in Order)
            {
                foreach (Cooker cook in List<Cooker>) {
                    if (cook.ID == nbrCuisinier % nbrCuisinier)
                    {
                        cook.TravailList.Add(recette);
                    }
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

            foreach (String Recette in Orders)
            {
                foreach (Recettes recetteAsk in RecettesList)
                {
                    if (recetteAsk.RecetteName == Recette)
                    {
                        OrdersArrived.Add(recetteAsk);
                    }
                }
            }
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
        public void RecevoirCommande()
        {

            IPAddress ipAd = IPAddress.Parse("127.0.0.1");
            TcpListener myListener = new TcpListener(ipAd, 8001);
            myListener.Start();
            Console.WriteLine("En attente d'une commande");
            Socket s = myListener.AcceptSocket();
            byte[] b = new byte[7];
            int k = s.Receive(b);
            char[] c = new char[7];
            bool test = true;
            for (int i = 0; i < k; i++)
            {
                c[i] = (Convert.ToChar(b[i]));
            }
            string Change = new string(c);
            ASCIIEncoding asen = new ASCIIEncoding();
            s.Send(asen.GetBytes("La commande a été reçue"));
            s.Close();
            myListener.Stop();
            ChefCuisine Robert = new ChefCuisine();
            Console.WriteLine(Change);
            Robert.ChangeStr(Change);
            Robert.ChangeBool(test);
        }
    }
}
