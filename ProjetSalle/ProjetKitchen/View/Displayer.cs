using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetKitchen.View
{
    class Displayer
    {

        private static Displayer _instanceDisplayer;
        static readonly object instanceLock = new object();


        private Displayer() { }

        public void DisplayerResto()
        {
        }

        // If no instance of the View, then, create one
        public static Displayer Instance
        {
            get
            {
                if (_instanceDisplayer == null) //Les locks prennent du temps, il est préférable de vérifier d'abord la nullité de l'instance.
                {
                    lock (instanceLock)
                    {
                        if (_instanceDisplayer == null) //on vérifie encore, au cas où l'instance aurait été créée entretemps.
                            _instanceDisplayer = new Displayer();
                    }
                }
                return _instanceDisplayer;
            }
        }
    }
}
