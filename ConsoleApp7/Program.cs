using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main()
        {
            First fr = new First(int.Parse(Console.ReadLine()), bool.Parse(Console.ReadLine()));
            fr.FindMiddle();
            fr.OnlyLower();
            fr.NoRepeat();
            fr.First();
        }
    }
}
