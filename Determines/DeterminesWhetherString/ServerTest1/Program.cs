using System.Net.Sockets;
using System.Net;
using Server.ItSelf;

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// ServerHost server = new ServerHost(new StaticFileHandler(Path.Combine(Environment.CurrentDirectory, "www")));
ServerHost host = new ServerHost(new ControllerHandler(typeof(Program).Assembly));
host.Start();

//TcpListener listener = new TcpListener(IPAddress.Any, 80);
//listener.Start();

//while (true)
//{
//    var client = listener.AcceptTcpClient();
//    using (var stream = client.GetStream())
//    {
//        using (var reader = new StreamReader(stream))
//        using (var writer = new StreamWriter(stream))
//        {
//            //while (true)
//            for (string line = null; line != String.Empty; line = reader.ReadLine())
//            {
//                //var line = reader.ReadLine();
//                Console.WriteLine(line);
//            }
//            writer.WriteLine("Hello server!!!");

//        }
//    }
//}