using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetKitchen.Model
{

    class Plongeur
    {
        public List<Dish> DirtyDishies { get; set; }

        Plongeur()
        {
            GetVaisselle();

            CheckDispoLavage();

            Laver(typeElement);

        }

        private void CheckDispoLavage()
        {
            
        }

        private void CheckDispoLavage(String typeElement)
        {
            
        }

        private void Laver(object typeElement)
        {
            throw new NotImplementedException();
        }

        private void GetVaisselle()
        {
            //Get the Dishies List from the JSON or BDD
            //DirtyDishies = 

        }
    }
}
