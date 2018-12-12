using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetKitchen.Model
{
    class Kitchen
    {
        private static Kitchen _instance;
        static readonly object instanceLock = new object();


        public Config Config { get; set; }

        public List<Cooker> CookList { get; set; }

        public List<CommisKitchen> CommisKitchenList { get; set; }

        public List<Plongeur> PlongeurList { get; set; }

        public ChefCuisine KitchenChef { get; set; }

        public List<Recettes> RecettesList { get; set; }

        public List<Dish> Ustencils { get; set; }

        private Kitchen() { }

        public void InitKitchen()
        {
            //Get the Config File
            Config = new Config();

            //Recup the List of Ustencils in the Database (Armoire)
            GetAllUstencils();

            //Recup the List of Recettes in the Database (menu)
            GetAllRecettesFromMenu();

            //Get the number of Cook in Config file and instanciate them with an ID
            for (int c =0; c<= Config.KitchenConf.Cuisiner; c++)
            {
                CookList.Add(new Cooker() { ID = c });
            }

            //Get the number of Commis Kitchen in Config file and instanciate them with an ID
            for (int cc =0; cc <= Config.KitchenConf.CommisCuisine; cc++)
            {
                CommisKitchenList.Add(new CommisKitchen() { ID = cc });
            }

            //Get the number of Plongeur in Config file and instanciate them with an ID
            for (int p =0; p <= Config.KitchenConf.Plongeur; p++)
            {
                PlongeurList.Add(new Plongeur() { ID = p });
            }
        }

        private void GetAllRecettesFromMenu()
        {
            List<String> Listeeeeee = new List<String> { "test1", "test2", "test3" };

            foreach(String recetteInList in Listeeeeee)
            {
                RecettesList.Add(new Recettes()
                {
                    RecetteName = recetteInList,
                    TimeToRealize = 12,
                    ListIngredients = { "Tomates", "Carottes", "Olives" , "Salade"},
                    Ustencils = {
                        Ustencils.Find(x => x.Name == "Couteau"),
                        Ustencils.Find(x => x.Name == "Fourchette")
                    }   
                });
            }
        }
        private void GetAllUstencils()
        {
            List<String> UstencilsInListeeeeee = new List<String> { "Couteau", "Fourchette", "Pouelle" };

            foreach(String ustencilInList in UstencilsInListeeeeee)
            {
                Ustencils.Add(new Dish()
                {
                    Name = "ustencilInList",
                    Category = "test",
                    StatusDish = ElementStatus.Clean,
                    CleaningTime = 0
                });
            }
        }

        // If no instance of the kitchen, then, create one
        public static Kitchen Instance
        {
            get
            {
                if (_instance == null) //Les locks prennent du temps, il est préférable de vérifier d'abord la nullité de l'instance.
                {
                    lock (instanceLock)
                    {
                        if (_instance == null) //on vérifie encore, au cas où l'instance aurait été créée entretemps.
                            _instance = new Kitchen();
                    }
                }
                return _instance;
            }
        }

    }

}
