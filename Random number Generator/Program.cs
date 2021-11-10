using System;

namespace Random_number_Generator
{
    internal static class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            char userChoice;
            bool tryP;
            do {
                Console.WriteLine("Would you like for the program to be completely random or for you to set a range \n[r]andom, [s]et");
                tryP = char.TryParse(Console.ReadLine()?.ToLower(), out userChoice);
                if (!tryP || userChoice != 'r' && userChoice != 's')
                {
                    Console.WriteLine("This isn't a valid type");
                }
            } while (!tryP || userChoice != 's' && userChoice != 'r');
            
            switch (userChoice)
            {
                case 's':
                    int number1, number2;
                    
                    do {
                        Console.WriteLine("Insert the first number");
                        tryP = int.TryParse(Console.ReadLine(), out number1);
                        if (!tryP)
                        {
                            Console.WriteLine("The number inserted isn't valid");
                        }
                    } while (!tryP);

                    do {
                        Console.WriteLine("Insert the second number");
                        tryP = int.TryParse(Console.ReadLine(), out number2);
                        if (!tryP)
                        {
                            Console.WriteLine("The number inserted isn't valid");
                        }
                    } while (!tryP);

                    if (number1 > number2)
                    {
                        (number1, number2) = (number2, number1);
                    }
                    number2++;
                    Console.WriteLine($"The generated number is {rnd.Next(number1, number2)}");
                    break;
                case 'r':
                    Console.WriteLine($"The generated number is {rnd.Next()}");
                    break;
            }
            Console.ReadKey();
        }
    }
}
