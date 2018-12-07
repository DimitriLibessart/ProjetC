using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSalle.Model.People
{
    class Customer //client
    {
        int numTable;
        //int Order = Order;

        public Customer(int numTable)
        {
            this.numTable = numTable;
        }
        static void Arrived()
        {
            for (int i = 0; i<1000; i++){
            Console.WriteLine("Customer: I'm here");
        }
            }

        public void TakeOrder()
        {

        }

    }
}