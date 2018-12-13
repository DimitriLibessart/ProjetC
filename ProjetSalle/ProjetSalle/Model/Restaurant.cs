using System;
using System.Collections.Generic;
using System.IO;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using ProjetSalle.Model.People;
using ProjetSalle.View;

namespace ProjetSalle.Model
{
    class Restaurant
    {
        private static Restaurant _instance;
        static readonly object instanceLock = new object();

        //Config File for the Peoples of the restaurant
        public Rootobject JsonConfig { get; set; } = Newtonsoft.Json.JsonConvert.DeserializeObject<Rootobject>(File.ReadAllText(@"C:\Users\theo\OneDrive\EXIA\A3\Projets_A3\Projet_Prog_Système\dev_folder\ProjetC\ProjetSalle\ProjetSalle\BDD\Config.json"));

        public Displayer DisplayerRef { get; set; } //Config File for the Peoples of the restaurant

        //rnd(n) give a random number
        private Random rnd;

        //Benefices
        public int Benefices { get; set; }

        public List<Piece> ListPiece { get; set; }

        //Number of groups arrived in the Restaurant
        public int GroupeNumber { get; set; }

        //List of clients who are waiting for a table
        public List<CustomerGroup> ListNewClients { get; set; }

        //List of clients who are or was placed on table
        public List<CustomerGroup> ListClients { get; set; }

        public HotelManager HotelManager { get; set; }

        public Menu Menu { get; set; }


        private Restaurant() { }


        /* Initilisation of the Elements of the Restaurant
         * Initilisation of the Personnel of the Restaurant
         * Get the Recettes Names for the Menu of the Restaurant
         * Call the Methode to add new Clients (in a group)
         */ 
        public void InitRestaurant()
        {
            Console.WriteLine("\n\nPreparation de la Salle à manger du Restaurant\n");

            GroupeNumber = 0;
            rnd = new Random();

            //Create a List of New Clients
            ListNewClients = new List<CustomerGroup>();
            ListClients = new List<CustomerGroup>();

            //Create a List of Piece
            ListPiece = new List<Piece>();

            //Create a List of Table
            List<Table> listTable = new List<Table>();

            //Initalisation of the Restaurant (Rooms and Tables)
            //Add a random number (between 1 and 4) of Rooms to the Restaurant
            for (int room = 1; room <= rnd.Next(1,4); room++)
            {
                int nbrTables = rnd.Next(1, 8);
                //Add a random number (between 1 and 8) of tables to the List
                for (int table=1; table <= nbrTables; table++)
                {
                    int capTable = rnd.Next(2, 10);
                    Console.WriteLine("Il y a une table de "+ capTable + " places");

                    listTable.Add(new Table
                    {
                        NumTable = table,
                        CapaciteTable = capTable,
                        StatusTable = EnumStatus.Clean
                    });
                }

                Console.WriteLine("Il y a " + nbrTables + " tables dans la piece " + room + "\n");

                // Create a Piece and add the list of table to it
                Piece piece = new Piece
                {
                    IDPiece = room,
                    ListTable = listTable,
                    ListRowChiefs = new List<RowChief>(),
                    ListRoomClerk = new List<RoomClerk>(),
                    ListServer = new List<Server>()
                };

                //Add the Room to the Restaurant
                ListPiece.Add(piece);
            }
            Console.WriteLine("Les tables de chaque pieces sont en place\n");


            /* Initialisation of the peoples on the restaurant
             */

             foreach (Piece piece in ListPiece)
             {
                Console.WriteLine("Dans la salle" + piece.IDPiece +  "\n");

                // Create a Row Chief and add him to the list by room
                for (int rchief = 1; rchief <= JsonConfig.Config.RestaurantConf.RowChief; rchief++)
                {
                    piece.ListRowChiefs.Add(new RowChief
                    {
                        IDRowChief = rchief,
                        RoomNumber = piece.IDPiece
                    });
                }
                Console.WriteLine("Les Chefs de Rang sont en place\n");

                // Create a Room Clerk and add him to the list by room
                for (int rclerk =1; rclerk <= JsonConfig.Config.RestaurantConf.RoomClerk; rclerk++)
                {
                    piece.ListRoomClerk.Add(new RoomClerk
                    {
                        IDRoomClerk = rclerk,
                        RoomNumber = piece.IDPiece
                    });
                }
                Console.WriteLine("Les Commis sont en place\n");

                // Create a Server and add him to the list by room
                for (int serv =1; serv <= JsonConfig.Config.RestaurantConf.RowChief; serv++)
                {
                    piece.ListServer.Add(new Server
                    {
                        IDServer = serv,
                        RoomNumber = piece.IDPiece
                    });
                }
                Console.WriteLine("Les Serveurs sont en place\n -------------------------- \n ");
            }


            //Initalisation of the Menu
            Menu = new Menu() {
                ListEntreeInMenu = new List<string>(),
                ListPlatInMenu = new List<string>(),
                ListDessertInMenu = new List<string>()
            };

            //Add recettes to tis Menu
            AddRecettesToMenu();
            Console.WriteLine("Les Cartes des Menus sont complété\n");

            NewClientThreadFunction();

            // Le Maitre d'Hotel lance la journée
            Restaurant.Instance.HotelManager = new HotelManager();

            Console.Read();

}

        /* Add the List aof the Entree, Plat and Dessert Get from BDD to the Menu Class
         */ 
        private void AddRecettesToMenu()
        {
<<<<<<< HEAD
            Menu.ListEntreeInMenu.AddRange( new List<String> {"Carottes", "Celeris", "Betraves"} );
=======
                List<string> NomEntree = null;
                List<string> NomPlat = null;
                List<string> NomDessert = null;
>>>>>>> 6b089e4061ec84de71dd9113efa644b4839f0ba3

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
            Menu.ListPlatInMenu.AddRange(NomEntree);

<<<<<<< HEAD
            Menu.ListDessertInMenu.AddRange( new List<String> {"Chocolat", "Glace", "Gauffre", "Crepes", "Cafe"} );
=======
            Menu.ListPlatInMenu.AddRange(NomPlat);

            Menu.ListPlatInMenu.AddRange(NomDessert);
>>>>>>> 6b089e4061ec84de71dd9113efa644b4839f0ba3
        }

        /*
        // Method that add new groupes every n times
        private void AddNewClientEveryTimes()
        {
            //Thread newClient = new Thread(new ThreadStart(NewClientThreadFunction));

            // Create a timer
            myTimer = new System.Timers.Timer();
            // Tell the timer what to do when it elapses
            myTimer.Elapsed += new ElapsedEventHandler(NewClientThreadFunction);
            // Set it to go off every five seconds
            myTimer.Interval = rnd.Next(1000,1000000);
            // And start it        
            myTimer.Enabled = true;
        }
        */

        //Thread That Create group of clients
        private void NewClientThreadFunction()
        {
            int rndNbrClient = rnd.Next(2, 8);

            CustomerGroup tmpGrp = new CustomerGroup()
            {
                ListCustomer = new List<Customer>()
            };

            for (int i = 1; i <= rndNbrClient; i++)
            {
                int entreeSelect = rnd.Next(0, Menu.ListEntreeInMenu.Count - 1);
                int platSelect = rnd.Next(0, Menu.ListPlatInMenu.Count - 1);
                int desertSelect = rnd.Next(0, Menu.ListDessertInMenu.Count - 1);

                tmpGrp.IDGroup = GroupeNumber;
                tmpGrp.ListCustomer.Add(new Customer() {
                    ID = GroupeNumber+i,
<<<<<<< HEAD
                    Command = new List<String>{
                        Menu.ListEntreeInMenu[entreeSelect],
                        Menu.ListPlatInMenu[platSelect],
                        Menu.ListDessertInMenu[desertSelect]
                    }
=======
                    Command = {
                                Menu.ListEntreeInMenu[Command_entree],
                                Menu.ListPlatInMenu[Command_plat],
                                Menu.ListDessertInMenu[Command_Dessert]
                              }
>>>>>>> 6b089e4061ec84de71dd9113efa644b4839f0ba3
                });
                tmpGrp.NumberOfCustomer = tmpGrp.ListCustomer.Count;
            }

            GroupeNumber += 10;

            //Add the groupe created to the list of Clients groups
<<<<<<< HEAD
            ListNewClients.Add(tmpGrp);

            Console.WriteLine("New Clients has arrived \nIls sont : " + tmpGrp.NumberOfCustomer + "\n");
=======
            ListNewClients.Add(tmpGrp); 
>>>>>>> 6b089e4061ec84de71dd9113efa644b4839f0ba3
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