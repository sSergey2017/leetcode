using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.ItSelf
{
    public interface IHandler
    {
        void Handle(Stream stream, Request request);
        Task HandleAsync(Stream stream, Request request);
    }
}
