using System;
using System.Collections.Generic;
using System.Threading;

namespace ProjetKitchen.Model
{
    //FR trad : Lage Linge
    class WashingMachine : Washer
    {
        new readonly int WasherTime = 900000; //Washing Machine Time (in seconds)

        new readonly int Contenance = 10; //Items to Wash 

        /* Initialisation of the Washing Machine
         */
        public WashingMachine()
        {
            Console.WriteLine("Washing Machine is ready to be used");
        }
    }
}