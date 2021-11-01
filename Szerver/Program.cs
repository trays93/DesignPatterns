using System;
using System.Net;
using System.Net.Sockets;

namespace Szerver
{
    class Program
    {
        static void Main()
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            TcpListener listener = new TcpListener(ip, 9999);

            while (true)
            {
                listener.Start();
                Console.WriteLine("Waiting...");
                Socket s = listener.AcceptSocket();
                byte[] b = new byte[100];
                int count = s.Receive(b);
                string input = string.Empty;
                for (int i = 0; i < count; i++)
                {
                    input += Convert.ToChar(b[i]);
                }

                IActualPrices realSubject = new ActualPrices();
                int returnValue = 0;
                string message = string.Empty;

                switch (input)
                {
                    case "g":
                        message = "Gold Price";
                        returnValue = realSubject.GoldPrice;
                        break;
                    case "s":
                        message = "Silver Price";
                        returnValue = realSubject.SilverPrice;
                        break;
                    case "d":
                        message = "Dollar to Forint Price";
                        returnValue = realSubject.DollarToForint;
                        break;
                }

                s.Send(BitConverter.GetBytes(returnValue));
                s.Close();
                listener.Stop();
                Console.WriteLine($"Response for ({message}) Sent...");
            }
        }
    }
}
