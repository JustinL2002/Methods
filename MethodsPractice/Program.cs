using System;

namespace MethodsConsole
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
               
            Console.WriteLine(Sum(2, 6));

            Console.WriteLine(Multiply(10, 6));

            Console.WriteLine(Subtract(25, 11));

            Console.WriteLine(Divide(12, 6));

            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("How old are you?");
            string userAge = Console.ReadLine();
            Console.WriteLine("What pet do you have?");
            string petType = Console.ReadLine();
            Console.WriteLine("what is your pet's name?");
            string petName = Console.ReadLine();
            Console.WriteLine("What is your favorite color");
            string color = Console.ReadLine();

            Console.WriteLine($"A man named {userName} who was {userAge} years old walked into a pet store");
            Console.WriteLine($"He decided to buy a {color} {petType} and named it {petName}");

            
        }

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}