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
            bool try_pap = false;
            char user_choice;
            do
            {
                if (try_pap)
                {
                    Console.WriteLine("This isn't a valid type");
                }
                Console.WriteLine("Would you like for the program to be completely at random or for you to set a range \n[r]andom, [s]et");
            } while (try_pap = !char.TryParse(Console.ReadLine(), out user_choice));

            switch (user_choice)
            {
                case 's':
                case 'S':
                    int number_1, number_2;
                    
                    do
                    {
                        if (try_pap)
                        {
                            Console.WriteLine("The number inserted isn't valid");
                        }
                        Console.WriteLine("Insert the first number ");
                    } while (try_pap = !int.TryParse(Console.ReadLine(), out number_1));

                    do
                    {
                        if (try_pap)
                        {
                            Console.WriteLine("The number inserted isn't valid");
                        }
                        Console.WriteLine("Insert the second number ");
                    } while (try_pap = !int.TryParse(Console.ReadLine(), out number_2));

                    if (number_1 > number_2)
                    {
                        int temp;
                        temp = number_1;
                        number_1 = number_2;
                        number_2 = temp;
                    }
                    number_2++;
                    Console.WriteLine($"The generated number is {rnd.Next(number_1, number_2)}");
                    break;

                case 'r':
                case 'R':
                    int first = rnd.Next(), second = rnd.Next();
                    if (first > second)
                    {
                        int temp;
                        temp = first;
                        first = second;
                        second = temp;
                    }
                    Console.WriteLine($"The generated number is {rnd.Next(first, second)}");
                    break;

                default:
                    Console.WriteLine("It's not a valid type");
                    break;
            }
            
            Console.ReadKey();
        }
    }
}
