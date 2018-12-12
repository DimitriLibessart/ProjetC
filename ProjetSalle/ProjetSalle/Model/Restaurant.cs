using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ProjetSalle.Model.People;

namespace ProjetSalle.Model
{
    class Restaurant
    {
        private static Restaurant _instance;
        static readonly object instanceLock = new object();


        //rnd(n) give a random number
        private Random rnd;

        public List<Piece> ListPiece { get; set; }

        //Number of groups arrived in the Restaurant
        public int GroupeNumber { get; set; }

        public List<CustomerGroup> ListNewClients { get; set; }

        public Menu Menu { get; set; }


        private Restaurant() { }


        /* Initilisation of the Elements of the Restaurant
         * Initilisation of the Personnel of the Restaurant
         * Get the Recettes Names for the Menu of the Restaurant
         * Call the Methode to add new Clients (in a group)
         */ 
        public void InitRestaurant()
        {
            GroupeNumber = 0;
            rnd = new Random();

            //Initalisation of the Restaurant (Rooms and Tables)
            //Add a random number (between 1 and 4) of Rooms to the Restaurant
            for (int room = 1; room <= rnd.Next(1,4); room++)
            {
                //Create a List
                List<Table> listTable = null;

                //Add a random number (between 1 and 8) of tables to the List
                for(int table =1; table <= rnd.Next(1,8); table++)
                {
                    listTable.Add(new Table
                    {
                        NumTable = table                        
                    });
                }

                // Create a Piece and add the list of table to it
                Piece piece = new Piece
                {
                    IDPiece = room,
                    ListTable = listTable
                };

                //Add the Room to the Restaurant
                ListPiece.Add(piece);
            }


            //Initalisation of the Menu
            Menu = new Menu();

            //Add recettes to tis Menu
            AddRecettesToMenu();

        }

        /* Add the List aof the Entree, Plat and Dessert Get from BDD to the Menu Class
         */ 
        private void AddRecettesToMenu()
        {
                List<string> NomEntree = null;
                List<string> NomPlat = null;
                List<string> NomDessert = null;

                using (SqlConnection conn = new SqlConnection())
                {

                    conn.ConnectionString = "Server=ORDINATEUR-KISU\\SQLEXPRESS;Database=C#_Project;Trusted_Connection=true";
                    conn.Open();
                    SqlCommand command = new SqlCommand("SELECT Name FROM Recipe WHERE Category='Entree'", conn);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            NomEntree.Add(string.Format("{0} \n",
                                reader[0]));
                        }
                    }
                    SqlCommand command2 = new SqlCommand("SELECT Name FROM Recipe WHERE Category='Plat'", conn);
                    using (SqlDataReader reader = command2.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            NomPlat.Add(string.Format("{0} \n",
                                reader[0]));
                        }
                    }
                    SqlCommand command3 = new SqlCommand("SELECT Name FROM Recipe WHERE Category='Dessert'", conn);
                    using (SqlDataReader reader = command3.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            NomDessert.Add(string.Format("{0} \n",
                                reader[0]));
                        }
                    }
                }
            Menu.ListPlatInMenu.AddRange( NomEntree );

            Menu.ListPlatInMenu.AddRange( NomPlat );

            Menu.ListPlatInMenu.AddRange( NomDessert );
        }

        // Method that add new groupes every n times
        private void AddNewClientEveryTimes()
        {
            Thread newClient = new Thread(new ThreadStart(NewClientThreadFunction));
        }

        //Thread That Create group of clients
        private void NewClientThreadFunction()
        {
            int rndNbrClient = rnd.Next(8);

            CustomerGroup tmpGrp = new CustomerGroup();

            for (int i = 1; i <= rndNbrClient; i++)
            {
                //Randoms for Command Client
                int Command_entree = rnd.Next(1,Menu.ListEntreeInMenu.Count);
                int Command_plat = rnd.Next(1,Menu.ListPlatInMenu.Count);
                int Command_Dessert = rnd.Next(1,Menu.ListDessertInMenu.Count);

                tmpGrp.IDGroup = GroupeNumber;
                tmpGrp.ListCustomer.Add(new Customer() {
                    ID = GroupeNumber+i,
                    Command = {
                        Menu.ListEntreeInMenu[Command_entree],
                        Menu.ListPlatInMenu[Command_plat],
                        Menu.ListDessertInMenu[Command_Dessert]
                    }
                });
            }

            GroupeNumber += 10;

            //Add the groupe created to the list of Clients groups
            ListNewClients.Add(tmpGrp);
                
        }

        // If no instance of the Restaurant, then, create one
        public static Restaurant Instance
        {
            get
            {
                if (_instance == null) //Les locks prennent du temps, il est préférable de vérifier d'abord la nullité de l'instance.
                {
                    lock (instanceLock)
                    {
                        if (_instance == null) //on vérifie encore, au cas où l'instance aurait été créée entretemps.
                            _instance = new Restaurant();
                    }
                }
                return _instance;
            }
        }
    }
}