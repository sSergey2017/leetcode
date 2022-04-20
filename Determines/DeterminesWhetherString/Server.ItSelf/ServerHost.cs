using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace Server.ItSelf
{
    public class ServerHost
    {
        private readonly IHandler _handler;
        public ServerHost(IHandler handler)
        {
            _handler = handler;
        }

        public void Start()
        {
            TcpListener listener = new TcpListener(IPAddress.Any, 80);
            listener.Start();

            while (true)
            {
                var client = listener.AcceptTcpClient();
                using (var stream = client.GetStream())
                using (var reader = new StreamReader(stream))
                {

                    var firstLine = reader.ReadLine();
                    //while (true)
                    for (string line = null; line != String.Empty; line = reader.ReadLine())
                    {
                        //var line = reader.ReadLine();
                        // Console.WriteLine(line);
                    }
                    var request = RequestParser.Parse(firstLine);

                    _handler.Handle(stream, request);

                    //using (var reader = new StreamReader(stream))
                    //using (var writer = new StreamWriter(stream))
                    //{
                    //    //while (true)
                    //    for (string line = null; line != String.Empty; line = reader.ReadLine())
                    //    {
                    //        //var line = reader.ReadLine();
                    //        Console.WriteLine(line);
                    //    }
                    //    writer.WriteLine("Hello server!!!");

                    //}
                }
            }
        }
    }
}
