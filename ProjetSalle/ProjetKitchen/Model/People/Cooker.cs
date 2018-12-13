using System.Collections.Generic;

namespace ProjetKitchen.Model
{
    class Cooker
    {
        public int ID { get; set; }

        public List<Recettes> TravailList { get; set; }

        public Cooker()
        {
        }
    }
}