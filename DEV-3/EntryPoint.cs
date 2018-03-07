using System;
using System.Numerics;

namespace DEV_3
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                BigInteger inputNumber = BigInteger.Parse(args[0]);
                int primаryOfNewSystem = Int32.Parse(args[1]);
                ConverterToOtherSystem converter = new ConverterToOtherSystem(primаryOfNewSystem);

                Console.WriteLine(converter.GetChangedNumber(inputNumber));
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}