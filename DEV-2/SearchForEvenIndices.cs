using System;
using System.Text;

namespace DEV_2
{
    /// <summary>
    /// The SearchForEvenIndices class is the main class of the program that works with the string
    /// Outputs to the console the original string consisting of characters with even indices
    /// </summary>
    public class SearchForEvenIndices
    {
        static void Main()
        {
            Console.WriteLine("input string :");
            String input = Console.ReadLine();
            SearchForEvenIndices index = new SearchForEvenIndices();
            Console.WriteLine(index.FormatString(input));
        }

        public string FormatString(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            StringBuilder inputString = new StringBuilder();

            for (int i = 0; i < input.Length; i += 2)
            {
                inputString.Append(input[i]);
            }
            return inputString.ToString();
        }
    }
}
