using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSalle
{
    class Order
    {
        private Order order;
        private List<Order> listOrder;
        public Order(Order order, List<Order> listOrder)
        {
            this.order = order;
            this.listOrder = listOrder;
            //listePlat.Add(new Plat());
        }
    }
}