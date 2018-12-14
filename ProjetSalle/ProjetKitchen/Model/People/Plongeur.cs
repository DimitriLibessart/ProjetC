using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetKitchen.Model
{
    class Plongeur
    {
        public int ID { get; set; }

        public List<Dish> DirtyDishies { get; set; }

        public Plongeur(String typeElement = "Vaiselle") // TypeElement { Vaiselle, Linge, Ustencils};
        {
            GetVaisselle();
            CheckDispoLavage();

            Laver(typeElement, DirtyDishies);

        }

        private void CheckDispoLavage()
        {
            if (Dishwasher.Available)
            {

            }
            else if (WashingMachine.Available)
            {

            }
        }

        private void CheckDispoLavage(String typeElement)
        {
            //DirtyDishies.add(); 
        }

        private void GetVaisselle()
        {
            //Get the Dishies List from the JSON or BDD
            //DirtyDishies = 

        }

        private void Laver(String typeElement, List<Dish> aLaver)
        {

            switch (typeElement)
            {
                case "Vaiselle":

                    GetDishiesToDishWasher(aLaver);
                    break; 

                case "Linge":
                    Use(aLaver);
                    break;

                case "Ustencils":
                    foreach(Dish utencil in aLaver)
                    {
                        WashUtensils(utencil);
                    }
                    break;
            }
        }

        private void Use(List<Dish> DirtyDishies)
        {
            throw new NotImplementedException();
        }

        private void WashUtensils(Dish utencil)
        {
            throw new NotImplementedException();
        }

        private List<Dish> GetDishiesToDishWasher(List<Dish> DirtyDishies)
        {
            int fouchettes = 24, cuillères = 24, couteaux = 24, assietes = 24, verres = 24;
            int contenance = fouchettes + cuillères + couteaux + assietes + verres;
            while (contenance !=0)
            {
                foreach(Dish dish in DirtyDishies)
                {
                    switch (dish.Category)
                    {
                        case "Fouchettes":
                            fouchettes--;
                            break;

                        case "Cuilleres":
                            cuillères--;
                            break;

                        case "Couteaux":
                            couteaux--;
                            break;

                        case "Assietes":
                            assietes--;
                            break;

                        case "Verres":
                            verres--;
                            break;
                    }
                }
            }
            return DirtyDishies;
        }
    }
}
