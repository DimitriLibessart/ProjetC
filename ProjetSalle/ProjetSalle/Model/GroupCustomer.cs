using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSalle.Model
{
    class CustomerGroup

    {
        int IDGroup;
        private List<Customer> listCustomer;
        int Customernumber;
        bool Reservation;

        public CustomerGroup(List<Customer> listCustomer)
        {
            this.listCustomer = listCustomer;
        }
    }
}