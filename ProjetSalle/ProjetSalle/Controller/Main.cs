using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProjetSalle.Controller
{
    class Program
    {
        static void Main(string[] args)
        {
           // Controller controller;

            Thread CustomerArrived = new Thread(Arrived);
            CustomerArrived.Start();


        }
        static void Arrived()
        {
            for (int i = 0; i < 5; i++)
            {
               
                Console.WriteLine("Customer: I'm here");
            }
        }
    }
}