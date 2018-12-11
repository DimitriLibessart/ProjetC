using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetKitchen.Model
{
    class InitKitchen
    {
        private static InitKitchen _instance;
        static readonly object instanceLock = new object();

        public List<Recettes> Orders { get; set; }

        public Config Config { get; set; }

        public List<Cooker> CookList { get; set; }

        public List<CommisKitchen> CommisKitchenList { get; set; }

        public List<Plongeur> PlongeurList { get; set; }


        private InitKitchen()
        {
            Config = new Config();

            //Get the number of Cook in Config file and instanciate them with an ID
            for(int c =0; c<= Config.Kitchen.Cuisiner; c++)
            {
                CookList.Add(new Cooker() { ID = c });
            }

            //Get the number of Commis Kitchen in Config file and instanciate them with an ID
            for (int cc =0; cc <= Config.Kitchen.CommisCuisine; cc++)
            {
                CommisKitchenList.Add(new CommisKitchen() { ID = cc });
            }

            //Get the number of Plongeur in Config file and instanciate them with an ID
            for (int p =0; p <= Config.Kitchen.Plongeur; p++)
            {
                PlongeurList.Add(new Plongeur() { ID = p });
            }
        }

    // If no instance of the kitchen, then, create one
    public static InitKitchen Instance
        {
            get
            {
                if (_instance == null) //Les locks prennent du temps, il est préférable de vérifier d'abord la nullité de l'instance.
                {
                    lock (instanceLock)
                    {
                        if (_instance == null) //on vérifie encore, au cas où l'instance aurait été créée entretemps.
                            _instance = new InitKitchen();
                    }
                }
                return _instance;
            }
        }

    }

}
