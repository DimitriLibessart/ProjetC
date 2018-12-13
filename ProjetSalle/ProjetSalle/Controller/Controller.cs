using ProjetSalle.Model;
using ProjetSalle.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSalle.Controller
{
    class Controller
    { 
        public Model.Restaurant Restaurant { get; set; }
        public View.Displayer Displayer { get; }

        public Controller()
        {
            Console.WriteLine("Preparation de la Salle à manger du Restaurant\n");
            Restaurant = Restaurant.Instance;

            Restaurant.InitRestaurant();
            //Displayer = new Displayer();

        }
        
    }
}