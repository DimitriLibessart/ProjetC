using System;
using System.Collections.Generic;
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

        public Config Config { get; set; } //Config File for the Peoples of the restaurant

        public Displayer DisplayerRef { get; set; } //Config File for the Peoples of the restaurant

        //rnd(n) give a random number
        private Random rnd;
        private System.Timers.Timer myTimer;

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
            GroupeNumber = 0;
            rnd = new Random();

            //Initalisation of the Restaurant (Rooms and Tables)
            //Add a random number (between 1 and 4) of Rooms to the Restaurant
            for (int room = 1; room <= rnd.Next(1,4); room++)
            {
                //Create a List
                List<Table> listTable = new List<Table>();

                List<Piece> ListPiece = new List<Piece>();

                //Add a random number (between 1 and 8) of tables to the List
                for(int table =1; table <= rnd.Next(1,8); table++)
                {
                    listTable.Add(new Table
                    {
                        NumTable = table,
                        CapaciteTable = rnd.Next(2,10),
                        StatusTable = EnumStatus.Clean
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


            /* Initialisation of the peoples on the restaurant
             */

            Restaurant.Instance.HotelManager = new HotelManager();

             foreach (Piece piece in ListPiece)
            {
                // Create a Row Chief and add him to the list by room
                for (int rchief = 1; rchief <= Config.RestaurantConf.RowChief; rchief++)
                {
                    piece.ListRowChiefs.Add(new RowChief
                    {
                        IDRowChief = rchief,
                        RoomNumber = piece.IDPiece
                    });
                }

                // Create a Room Clerk and add him to the list by room
                for (int rclerk =1; rclerk <= Config.RestaurantConf.RoomClerk; rclerk++)
                {
                    piece.ListRoomClerk.Add(new RoomClerk
                    {
                        IDRoomClerk = rclerk,
                        RoomNumber = piece.IDPiece
                    });
                }

                // Create a Server and add him to the list by room
                for (int serv =1; serv <= Config.RestaurantConf.RowChief; serv++)
                {
                    piece.ListServer.Add(new Server
                    {
                        IDServer = serv,
                        RoomNumber = piece.IDPiece
                    });
                }
            }


            //Initalisation of the Menu
            Menu = new Menu();

            //Add recettes to tis Menu
            AddRecettesToMenu();

            AddNewClientEveryTimes();
        }

        /* Add the List aof the Entree, Plat and Dessert Get from BDD to the Menu Class
         */ 
        private void AddRecettesToMenu()
        {
            Menu.ListPlatInMenu.AddRange( new List<String> {"Carottes", "Celeris", "Betraves"} );

            Menu.ListPlatInMenu.AddRange( new List<String> {"Lapin", "Ours", "cheval", "Poulet"} );

            Menu.ListPlatInMenu.AddRange( new List<String> {"Chocolat", "Glace", "Gauffre", "Crepes", "Cafe"} );
        }

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


        //Thread That Create group of clients
        private void NewClientThreadFunction(object source, ElapsedEventArgs e)
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

            Console.WriteLine("New Clients has arrived");
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