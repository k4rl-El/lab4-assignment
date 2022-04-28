using System;

namespace lab4_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //  lab4 question: given two numbers, return true if the sum of both numbers is less than 100, otherwise return false
            Console.WriteLine("input the first number");
            int first_num = int.Parse(Console.ReadLine());
            Console.WriteLine("input the second number");
            int second_num  = int.Parse(Console.ReadLine());

            bool x = first_num + second_num < 100;
            Console.WriteLine(x);
        }
    }
}
