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
        public Controller Controller { get; set; }

        static void Main(string[] args)
        {
            Controller controller = new Controller();
        }
    }
}