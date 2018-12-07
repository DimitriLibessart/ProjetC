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

           /* Random rnd = new Random();
            

            for (int i = 0; i < 10; i++)
            {
                string[] client = { "Content", "Pas content", "Pressé" };
                int mIndex = rnd.Next(client.Length);
                Console.WriteLine("   Client :     {0}", client[mIndex]);
                Console.WriteLine("Customer: I'm here");
            }*/

        }
        static void Arrived()
        {
            Random rnd = new Random();
            string[] client = { "Happy", "Angry", "Speed" };

            List<string> hapinness = new List<string>();

            for (int i = 0; i < 10; i++)
            {
                int mIndex = rnd.Next(client.Length);
                hapinness.Add(client[mIndex]);

                Console.WriteLine("   Customer :     {0}", client[mIndex]);
                Console.WriteLine("Customer: I'm here");
            }
            Console.WriteLine(hapinness.FindAll(h => h == "Happy").Count.ToString());
        }
    }
}