using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetKitchen.Controller
{
    class Program
    {
        public Controller Controller { get; set; }

        static void Main(string[] args)
        {
            // Display the number of command line arguments:
            System.Console.WriteLine("Lancement De la Simulation\n\n");

            Controller controller = new Controller();
        }
    }
}
