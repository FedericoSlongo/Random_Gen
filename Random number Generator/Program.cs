using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_number_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int first = rnd.Next(), second = rnd.Next();
            if (first > second)
            {
                int temp;
                temp = first;
                first = second;
                second = temp;
            }
            Console.WriteLine($"The generated number is {rnd.Next(first, second)}");
            Console.ReadKey();
        }
    }
}
