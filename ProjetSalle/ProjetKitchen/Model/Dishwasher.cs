using System;
using System.Collections.Generic;
using System.Threading;

namespace ProjetKitchen.Model
{
    //FR trad : Machine à laver
    class Dishwasher : Washer
    {
        new readonly int WasherTime = 600000; //Washing Machine Time (in seconds)

        new readonly int Contenance = 24; //Contenance for each items 

        /* Initialisation of the Dishwasher
         */
        public Dishwasher()
        {
            Console.WriteLine("Dishwasher is ready to be used");
        }
        private void WasherWork()
        {
            WashingMachine.Available = false;
            // While the thread is alive
            while (Thread.CurrentThread.IsAlive)
            {
                Thread.Sleep(WasherTime);
            }
            WashingMachine.Available = true;
        }

    }
}