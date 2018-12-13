using ProjetKitchen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetKitchen.Controller
{
    class Controller
    {
        public Kitchen Kitchen { get; set; }

        public View.Displayer Displayer { get; set; }

        public Controller()
        {
            Console.WriteLine("Preparation de la Cuisine\n");
            Kitchen = Kitchen.Instance;

            Kitchen.InitKitchen();
        }
    }
}
