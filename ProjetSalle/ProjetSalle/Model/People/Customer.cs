﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetSalle.Model.People
{
    class Customer
    {
        public List<string> Command { get; set; }

        /* 
         * param : 
         * return : 
         */ 
        public void Arriver()
        {
            Console.WriteLine("Le client arrive");
        }

        /* 
         * param : 
         * return : 
         */ 
        public void Commander()
        {
            Console.WriteLine("Je desire commander : " + Command1); //Parse Commande
            // set Command
        }

        /* 
         * param : 
         * return : 
         */ 
        public void Commander2()
        {
            Console.WriteLine("Si ce n'est pas possible j'aimerais alors commander ceci : " + Command2); //Parse Commande2
        }
        /*
                 private Order order;
        private List<Order> listOrder;
        public Order(Order order, List<Order> listOrder)
        {
            try
            {
                TcpClient tcpclnt = new TcpClient();
                Console.WriteLine("Connecting.....");

                tcpclnt.Connect("127.0.0.1", 8001);
                // use the ipaddress as in the server program

                Console.WriteLine("Connected");
                Console.Write("Enter the string to be transmitted : ");

                String str = Console.ReadLine();
                Stream stm = tcpclnt.GetStream();

                ASCIIEncoding asen = new ASCIIEncoding();
                byte[] ba = asen.GetBytes(str);
                Console.WriteLine("Transmitting.....");

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
        }*/

    }
    
}
