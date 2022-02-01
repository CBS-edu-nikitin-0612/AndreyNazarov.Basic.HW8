using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please use number of one of the folowing colors:");
            MyClass.Color[] colors = (MyClass.Color[])Enum.GetValues(typeof(MyClass.Color));
            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine($"{colors[i]} - {(int)colors[i]}");
            }

            var inputColor = int.Parse(Console.ReadLine());
            Console.WriteLine("Please type text");
            var inputText = Console.ReadLine();

            MyClass.Print(inputText, inputColor);
        }
    }
}
