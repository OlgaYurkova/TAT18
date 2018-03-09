using System;
using System.Text;
using System.Numerics;

namespace DEV_3
{
    /// <summary>
    /// ConverterToOtherSystem class converts the number in the new system
    /// </summary>
    class ConverterToOtherSystem
    {
        private int primаryOfSystem;

        public ConverterToOtherSystem(int valueBase)
        {
            if ((valueBase < 2) || (valueBase > 20))
            {
                throw new ArgumentException();
            }
            primаryOfSystem = valueBase;
        }

        private char GetPartOfNumber(int numberOfSymbol)
        {
            string allSymbols = "0123456789ABCDEFGHIJ";
            return allSymbols[numberOfSymbol];
        }

        public string GetChangedNumber(BigInteger inputNumber)
        {
            StringBuilder changedNumber = new StringBuilder();

            do
            {
                changedNumber.Insert(0, GetPartOfNumber((int)(inputNumber % primаryOfSystem)));
                inputNumber /= primаryOfSystem;
            }
            while (inputNumber > 0);

            return changedNumber.ToString();
        }
    }
}