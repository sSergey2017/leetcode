using Server.ItSelf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerTest1.Controllers
{
    public record User (string Name, string Surename, string Login);
    public class UserController : IController
    {
        public User[] Index()
        {
            Thread.Sleep(5);
            return new[]
            {
                new User("II", "PP", "hh"),
                new User("II", "PP", "hh2"),
                new User("II", "PP", "hh1")
            };
        }

        public async Task<User[]> IndexAsync()
        {
            await Task.Delay(50);
            return new[]
            {
                new User("II", "PP", "hhAAA"),
                new User("II", "PP", "hh2AA"),
                new User("II", "PP", "hh1SSSS")
            };
        }
    }
}
