// See https://aka.ms/new-console-template for more information
using TestRecords;

Console.WriteLine("Hello, World!");



Pet pet = new Pet(3);
Cat cat = new Cat("Tom", "red", 10);

Console.WriteLine(cat.ToString());

cat = cat with { name = "Pet" };

Console.WriteLine(cat.ToString());

