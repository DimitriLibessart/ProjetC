using System;
using System.Collections.Generic;
using System.Threading;

namespace ProjetKitchen.Model
{
    class WashingMachine
    {
        public static bool Available { get; internal set; }

        //Contenance : 10 de chaque
        public int Contenance { get; internal set; }

        public int WashingMachineTime { get; set; } = 900000; //Washing Machine Time (in seconds)

        /* Initialisation of the Washing Machine
         */
        public WashingMachine()
        {
            Console.WriteLine("Washing Machine is ready to be used");
        }

        /* Change status of element in the virtual Washing Machine
         * Create a thread for the time of the wash
         * Let free the elements after the washing time
         */
        public void UseWashingMachine(List<Dish> WashingSet)
        {
            foreach(Dish dish in WashingSet)
            {
                dish.StatusDish = ElementStatus.InCleaning;
            }

            Thread thread = new Thread(new ThreadStart(WashingMachineWork));
            thread.Start();

            foreach (Dish dish in WashingSet)
            {
                dish.StatusDish = ElementStatus.Clean;
            }
        }

        private void WashingMachineWork()
        {
            // While the thread is alive
            while (Thread.CurrentThread.IsAlive)
            {
                Thread.Sleep(WashingMachineTime);
            }
        }
    }
}