using System;

namespace spoj_csharp
{
    class Program
    {
        static string halfOfHalf(string str)
        {
            string toReturn = "";
            for (int i = 0; i < str.Length / 2; i += 2)
            {
                toReturn += str[i];
            }
            return toReturn;
        }

        static void Main(string[] args)
        {
            string[] resource = new string[200];
            int how_many;
            how_many = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < how_many; i++)
            {
                resource[i] = Console.ReadLine();
            }

            for (int i = 0; i < how_many; i++)
            {
                string output = halfOfHalf(resource[i]);
                Console.WriteLine($"{output}");
            }

        }
    }
}
