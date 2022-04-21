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

        public async Task StartAsync()
        {
            Console.WriteLine("Server Started Async");
            TcpListener listner = new TcpListener(IPAddress.Any, 80);
            listner.Start();

            while (true)
            {
                var client = await listner.AcceptTcpClientAsync();
                var _ = ProcessClientAsync(client);
            }
        }

        private async Task ProcessClientAsync(TcpClient client)
        {
            try
            {
                using (client)
                using (var stream = client.GetStream())
                using (var reader = new StreamReader(stream))
                {
                    var firstLine = await reader.ReadLineAsync();
                    for (string line = null; line != string.Empty; line = await reader.ReadLineAsync())
                        ;

                    var request = RequestParser.Parse(firstLine);

                    await _handler.HandleAsync(stream, request);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void StartV2()
        {
            Console.WriteLine("Server started v2");
            TcpListener listener = new TcpListener(IPAddress.Any, 80);
            listener.Start();

            while (true)
            {
                var client = listener.AcceptTcpClient();
                ProcessClient(client);
            }
        }

        private void ProcessClient(TcpClient client)
        {
            ThreadPool.QueueUserWorkItem(o =>
            {
                using (var stream = client.GetStream())
                using (var reader = new StreamReader(stream))
                {

                    var firstLine = reader.ReadLine();
                    for (string line = null; line != String.Empty; line = reader.ReadLine())
                    {
                    }
                    var request = RequestParser.Parse(firstLine);

                    _handler.Handle(stream, request);
                }
            });
        }

        public void Start()
        {
            Console.WriteLine("Server started");
            TcpListener listener = new TcpListener(IPAddress.Any, 80);
            listener.Start();

            while (true)
            {
                using (var client = listener.AcceptTcpClient()) 
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
