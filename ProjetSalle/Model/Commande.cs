using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSalle
{
    class Commande
    {
        private Plat plt;
        private List<Plat> listePlat;
        public Commande(Plat plt, List<Plat> listePlat)
        {
            this.plt = plt;
            this.listePlat = listePlat;
            listePlat.Add(new Plat());
        }
    }
}
