using ProjetSalle.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSalle.Controller
{
    class Controller
    { 
        public Restaurant Restaurant { get; set; }

        Controller()
        {
            Restaurant = Restaurant.Instance;
        }
    }
}