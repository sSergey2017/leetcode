using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Server.ItSelf
{
    public class StaticFileHandler : IHandler
    {
        private readonly string _path;

        public StaticFileHandler(string path)
        {
            _path = path;
        }
        public void Handle(Stream stream, Request request )
        {
            // using (var reader = new StreamReader(stream))
            using (var writer = new StreamWriter(stream))
            {
                //var firstLine = reader.ReadLine();
                ////while (true)
                //for (string line = null; line != String.Empty; line = reader.ReadLine())
                //{
                //    //var line = reader.ReadLine();
                //    // Console.WriteLine(line);
                //}
                //var request = RequestParser.Parse(firstLine);
                var filePath = Path.Combine(_path, request.Path.Substring(1));

                if (!File.Exists(filePath))
                {
                    //TODO 404
                    ResponseWriter.WriteStatus(HttpStatusCode.NotFound, stream);
                }
                else
                {
                    using (var fileStream = File.OpenRead(filePath))
                    {
                        fileStream.CopyTo(stream);
                    }
                }

                Console.WriteLine(filePath);
                writer.WriteLine("Hello server!!!");

            }
        }
    }
}
