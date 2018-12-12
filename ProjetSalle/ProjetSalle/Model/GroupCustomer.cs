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
        public List<String> Recipe { get; set; }

        private int NumTable { get; set; }

        public int IDGroup { get; set; }

        public  List<Customer> ListCustomer { get; set; }

        public int NumberOfCustomer { get; set; }

        /* 
         * param : 
         * return : 
         */ 
        public CustomerGroup(List<Customer> listCustomer)
        {
            this.listCustomer = listCustomer;
        }

        /* 
         * param : 
         * return : 
         */ 
        private SetRecipe(){

        }

        /* 
         * param : 
         * return : 
         */ 
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