using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRecords
{
    //internal class Cat
    //{
    //}

    public record Pet(int age);
    public record Cat(string name, string clor, int age) : Pet (age);
}
