using System;

namespace RND
{
    static class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            char userChoice;
            do
            {
                Console.Clear();
                Console.WriteLine("Would you like for the program to be completely random or for you to set a range \n[r]andom, [s]et");
                
            } while (!char.TryParse(Console.ReadLine(), out userChoice) || userChoice != 's' || userChoice != 'S'|| userChoice != 'r' || userChoice != 'R');

            switch (userChoice)
            {
                case 's':
                case 'S':
                    int number1, number2;
                    
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Insert the first number ");
                    } while (!int.TryParse(Console.ReadLine(), out number1));

                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Insert the second number ");
                    } while (!int.TryParse(Console.ReadLine(), out number2));

                    if (number1 > number2)
                    {
                        (number1, number2) = (number2, number1);
                    }
                    number2++;
                    Console.WriteLine($"The generated number is {rnd.Next(number1, number2)}");
                    break;
                case 'r':
                case 'R':
                    Console.WriteLine($"The generated number is {rnd.Next()}");
                    break;
            }
            
            Console.ReadKey();
        }
    }
}
