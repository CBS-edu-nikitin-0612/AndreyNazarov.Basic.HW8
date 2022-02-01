using System;

namespace Task2
{
    internal static class MyClass
    {
        public enum Color
        {
            Black = ConsoleColor.Black,
            Red = ConsoleColor.Red,
            Blue = ConsoleColor.Blue
        }
        public static void Print(string stroka, int color)
        {
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(stroka);
            Console.ResetColor();
        }
    }


}
