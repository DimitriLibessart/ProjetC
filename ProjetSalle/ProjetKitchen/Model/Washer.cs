using System;
using System.Collections.Generic;
using System.Threading;

namespace ProjetKitchen.Model
{
    //Class parent for the washing machines 
    class Washer
    {
        public static bool Available { get; internal set; }

        public int Contenance { get; internal set; }

        public int WasherTime { get; set; } //Washer Time (in seconds)

        /* Change status of element in the virtual Washing Machine
         * Create a thread for the time of the wash
         * Let free the elements after the Washer time
         */
        public void UseWasher(List<Dish> WashingSet)
        {
            foreach (Dish dish in WashingSet)
            {
                dish.StatusDish = ElementStatus.InCleaning;
            }

            Thread thread = new Thread(new ThreadStart(WasherWork));
            thread.Start();

            foreach (Dish dish in WashingSet)
            {
                dish.StatusDish = ElementStatus.Clean;
            }
        }

        private void WasherWork()
        {
            // While the thread is alive
            while (Thread.CurrentThread.IsAlive)
            {
                Thread.Sleep(WasherTime);
            }
        }
    }
}