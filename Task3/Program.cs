using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var worker = new Post(100, Positions.Accountant);
            Console.WriteLine($"Bonus? => {Accountant.AskForBonus(worker)}");
        }
    }
}
