using System;


namespace AgeAfter10Years
{
    class Program
    {
        static void Main(string[] args)
        {
            int Age;
            Console.Write("Enter your current age:");
            Age = int.Parse(Console.ReadLine());
            int AgeAfter10Years = Age + 10;
            Console.WriteLine("After 10 years you will be {0} years old.",AgeAfter10Years);
        }
    }
}
