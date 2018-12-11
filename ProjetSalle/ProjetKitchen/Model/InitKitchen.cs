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
        InitKitchen()
        {

            /* Initialisation of the washing  machines
             */
            WashingMachine washingMachine = new WashingMachine();
            Dishwasher dishwasher = new Dishwasher();
            UtencilWasher utencilWasher = new UtencilWasher();

            // Initialisation of the Kitchen Chef
            ChefCuisine chefCuisine = new ChefCuisine();

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

    }

}
