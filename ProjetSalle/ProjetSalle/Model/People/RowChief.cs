using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSalle.Model.People
{
    class RowChief
    {
        int IdTable { get; set; }
        public void PlaceClient()
        {
            Console.WriteLine("Chef de Rang : Je vous place sur la table :" + IdTable);
        }
        public void PresenteCarte()
        {
            Console.WriteLine("Chef de Rang : Voici la carte");
        }
        public void MettreNappe()
        {

        }
        public void PrendreCommande()
        {

        }
        public void PrendreCommandePartie()
        {

        }
        public void TransmetCommande()
        {

        }
    }

}