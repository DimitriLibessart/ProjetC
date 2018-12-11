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

        private static WashingMachine washingMachine;
        private static Dishwasher dishwasher;
        private static UtencilWasher utencilWasher;

        private static ChefCuisine chefCuisine;

        private InitKitchen()
        {

            /* Initialisation of the washing  machines
             */
            washingMachine = new WashingMachine();
            dishwasher = new Dishwasher();
            utencilWasher = new UtencilWasher();

            // Initialisation of the Kitchen Chef
            chefCuisine = new ChefCuisine();

            Config config = new Config();

            // Initialisation of the Kitchen squad
            // the Cooks
            for (int c = 1; c <= config.Kitchen.Cuisiner; c++)
            {
                Cooker cooker = new Cooker() { ID = c };
            }

            // the Commis Kitchen
            for (int ck = 1; ck <= config.Kitchen.Cuisiner; ck++)
            {
                CommisKitchen commisKitchen = new CommisKitchen() { ID = ck };
            }

            // the Plongeur
            for (int p = 1; p <= config.Kitchen.Cuisiner; p++)
            {
                Plongeur plongeur = new Plongeur() { ID = p };
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
