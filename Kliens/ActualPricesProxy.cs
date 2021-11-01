using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace Kliens
{
    public class ActualPricesProxy : IActualPrices
    {
        public int DollarToForint
        {
            get => GetResponseFromServer("d");
        }

        public int GoldPrice
        {
            get => GetResponseFromServer("g");
        }

        public int SilverPrice
        {
            get => GetResponseFromServer("s");
        }

        private int GetResponseFromServer(string input)
        {
            int result = 0;

            using (TcpClient client = new TcpClient())
            {
                client.Connect("127.0.0.1", 9999);

                Stream stream = client.GetStream();
                ASCIIEncoding asen = new ASCIIEncoding();
                byte[] ba = asen.GetBytes(input.ToCharArray());

                stream.Write(ba, 0, ba.Length);

                byte[] br = new byte[100];
                int k = stream.Read(br, 0, 100);

                result += BitConverter.ToInt32(br, 0);
                client.Close();
            }

            return result;
        }
    }
}