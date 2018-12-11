using System;
using System.Collections.Generic;
using System.Threading;

namespace ProjetKitchen.Model
{
    internal class UtencilWasher
    {
        public static bool Available { get; internal set; }

        public static int CleaningTime { get; internal set; }

        public void UseUtencilWasher(List<Dish> UtencilList)
        {
            foreach (Dish dish in UtencilList)
            {
                CleaningTime += dish.CleaningTime;
                dish.StatusDish = ElementStatus.InCleaning;
            }

            //Creation of a new thread for the ustencils cleaning time
            Thread thread = new Thread(new ThreadStart(UtencilWashingWork));
            thread.Start();

            foreach (Dish dish in UtencilList)
            {
                dish.StatusDish = ElementStatus.Clean;
            }

            CleaningTime = 0;
        }

        private void UtencilWashingWork()
        {
            //Set avaibility to false because it's used
            Available = false;

            while (Thread.CurrentThread.IsAlive)
            {
                Thread.Sleep(CleaningTime);
            }

            //Set avaibility to true because it's available
            Available = true;
        }
    }
}