using System;
using System.Collections.Generic;
using System.Threading;

namespace ProjetKitchen.Model
{
    //FR trad : Machine à laver
    class Dishwasher
    {
        public static bool Available { get; internal set; }

        //Contenance : 24 de chaque (assietes et couverts)
        public int Contenance { get; internal set; } = 24;

        public int DishwasherTime { get; set; } = 600000; //Dishwasher Time (in milli-seconds)

        /* Initialisation of the Washing Machine
         */
        public Dishwasher()
        {
            Console.WriteLine("Dishwasher is ready to be used");
        }

        /* Change status of element in the virtual Dishwasher
         * Create a thread for the time of the wash
         * Let free the elements after the washing time
         */
        public Dishwasher(List<Dish> WashingSet)
        {
            foreach (Dish dish in WashingSet)
            {
                dish.StatusDish = ElementStatus.InCleaning;
            }

            Thread thread = new Thread(new ThreadStart(DishwasherWork));
            thread.Start();
        }

        private void DishwasherWork()
        {
            // While the thread is alive
            while (Thread.CurrentThread.IsAlive)
            {
                Thread.Sleep(DishwasherTime);
            }
        }
    }
}