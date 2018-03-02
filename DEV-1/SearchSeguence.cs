using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1
{
    /// <summary>
    ///The SequenceSearch class is the main class of the program that works with the string
    ///It finds the maximum number of identical consecutive characters in the string
    /// </summary>

    class SearchSequence
    {
        static void Main(string[] args)
        {

            if (args.Length>=1 && args.Length < 3)
            {
                string inputString = args[0];
                int counterOfChars = 1;
                int maxSequence = 0;
                for (int i = 0; i < inputString.Length-1 ; i++)
                {
                    if (inputString[i] == inputString[i + 1])
                    {
                        counterOfChars++;
                    }
                    else
                    {
                        if (counterOfChars > maxSequence)
                        {
                            maxSequence = counterOfChars;
                        }
                        counterOfChars = 1;
                    }
                }
                if (counterOfChars > maxSequence)
                {
                    maxSequence = counterOfChars;
                }
                Console.WriteLine("Maximum sequence of chars in string = {0}", maxSequence);
            }
            else
            {
                Console.WriteLine("The string wasn't entered");
            }
        }
    }
}