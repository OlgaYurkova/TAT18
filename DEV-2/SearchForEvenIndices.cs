using System;
using System.Text;

namespace DEV_2
{
    /// <summary>
    /// The SearchForEvenIndices class is the main class of the program that works with the string
    /// Outputs to the console the original string consisting of characters with even indices
    /// </summary>
    class SearchForEvenIndices
    {
        static void Main()
        {
            Console.WriteLine("input string :");
            StringBuilder inputString = new StringBuilder(Console.ReadLine());

            for (int i = 1; i < inputString.Length; i++)
            {
                inputString.Remove(i, 1);
            }

            if (inputString.Length == 0)
            {
                Console.WriteLine("The string length is null");
            }

            Console.WriteLine(inputString);
        }
    }
}
