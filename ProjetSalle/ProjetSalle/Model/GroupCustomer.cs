using ProjetSalle.Model.People;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSalle.Model
{
    class CustomerGroup
    {
        public int IDGroup { get; set; }

        public List<Customer> ListCustomer { get; set; }

        public int NumberOfCustomer { get; set; }

    }
}