using System;

namespace Task2
{
    public class RectangleArea
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Length of the rectangle");
                int length = int.Parse(Console.ReadLine());

                Console.WriteLine("Width of the rectangle");
                int width = int.Parse(Console.ReadLine());

                int area = length * width;

                if( area <= 0 )
                {
                    throw new Exception("Invalid input");
                }
               
                Console.WriteLine("{0} * {1} = {2}", length, width, area);
            }

            catch (Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }
        }
    }
}
