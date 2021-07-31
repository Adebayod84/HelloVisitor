using System;

namespace HelloVisitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");

            var name = Console.ReadLine();

            Console.WriteLine($"Helllo {name}");

            Console.ReadKey();
        }
    }
}
