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
        string Recipe;
        private int NumTable { get; set; }
        int IDGroup;
        private List<Customer> listCustomer;
        int Customernumber;

        public CustomerGroup(List<Customer> listCustomer)
        {
            this.listCustomer = listCustomer;
        }
        public void FonctionExemple(int numTable)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Server=ORDINATEUR-KISU\\SQLEXPRESS;Database=ProjectC#;Trusted_Connection=true";
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT ID FROM RoundTable", conn);
                command.Parameters.Add(new SqlParameter("0", 1));
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("FirstColumn\n");
                    while (reader.Read())
                    {
                        IDGroup = int.Parse(String.Format("{0} \n",
                            reader[0]));
                        Console.WriteLine(IDGroup);
                    }
                }
                foreach (Table)
            {
                if(IDGroup==NumTable)
                {
                    foreach(Customer in listCustomer)
                    {
                        Command.Add(string Recipe);
                    }
                }
            }
        }
    }
}