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
            public void PlaceClient()
            {
            }
            public void PresenteCarte()
            {
            }
            public void MettreNappe()
            {
            }
            public void PrendreCommande()
            {
            }
            public void PrendreCommandePartie()
            {
            }
        public void SendKitchen()
        {
            try
            {
                TcpClient tcpclnt = new TcpClient();
                tcpclnt.Connect("127.0.0.1", 8001);
                String str = "Bonjour";
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

