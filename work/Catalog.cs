using System;
using System.IO;

namespace Task3
{
    class Catalog
    {
        static void Main()
        {
            Console.WriteLine("Enter the address of the folder");
            string  address = Console.ReadLine();

            Console.WriteLine("Enter the file permission");
            string permission = Console.ReadLine();

            if (Directory.Exists(address))
            {
                Console.WriteLine("File:");
                string[] files = Directory.GetFiles(address, permission);

                foreach (string addressFile in files)
                {
                    Console.WriteLine(addressFile);
                }
            }
        }
    }
}
