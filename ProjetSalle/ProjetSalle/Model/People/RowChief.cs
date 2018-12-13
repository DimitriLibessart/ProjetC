using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjetSalle.Model.People
{
    class RowChief
    {

        public int RoomNumber { get; set; }

        public int IDRowChief { get; set; }

        //private List<> listePorte;
        public List<string> CommandsTable { get; set; }


        public RowChief() { }

        /*
         * 
         */
        public void PlaceClient(CustomerGroup groupeClient, int numTable)
        {

        }

        /*
         * 
         */
        public void MettreTable(int numTable)
        {

            Table table = Restaurant.Instance.ListPiece[RoomNumber].ListTable[numTable];

            table.ElementsOnTable.Add("Nappe");

            table.StatusTable = EnumStatus.Ready;
        }

        /* Get Commands from Clients on the specified table and add them to the list of Commands
         * Param: (int) Number of the table
         */
        private void PriseCommandes(int tableToServ)
        {
            Table table = Restaurant.Instance.ListPiece[RoomNumber].ListTable[tableToServ];

            foreach (Customer customer in table.ClientsOnTable.ListCustomer)
            {
                CommandsTable.AddRange(customer.Command);
            }
        }

        //Sends strings of the commands 
        public void SendKitchen()
        {
            foreach (string str in CommandsTable)
                try
                {
                    TcpClient tcpclnt = new TcpClient();
                    tcpclnt.Connect("127.0.0.1", 8001);
                    Stream stm = tcpclnt.GetStream();
                    ASCIIEncoding asen = new ASCIIEncoding();
                    byte[] ba = asen.GetBytes(str);
                    Console.WriteLine("Transmission de la commande en cuisine");
                    stm.Write(ba, 0, ba.Length);
                    byte[] bb = new byte[100];
                    int k = stm.Read(bb, 0, 100);
                    for (int i = 0; i < k; i++)
                        Console.Write(Convert.ToChar(bb[i]));
                    tcpclnt.Close();
                }

                catch (Exception e)
                {
                    Console.WriteLine("Error..... " + e.StackTrace);
                }
            }
        }
    }
}

