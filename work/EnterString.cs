using System;

namespace Task1
{
    class EnterString
    {
        static void Main()
        {
            Console.WriteLine("Hello, world!");
            Console.WriteLine("And hi again!");

            Random r = new Random();
            int a = r.Next(5, 50);

            for (int i = 0; i<a; i++)
            {
                Console.Write("!");
            }
        }
    }
}
